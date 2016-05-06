using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TcpUtil
{
    public delegate void EventHandler(string mensagem, bool? Tx);

    public class ClientService
    {
        public event EventHandler OnReceivedData;

        #region Atributos
        public string IpAddress { get; set; }
        public int IpPort { get; set; }
        public string UrlDestino { get; set; }
        public string VerboHTML { get; set; }
        public bool TraceHTML { get; set; }
        #endregion

        #region Variáveis Privadas
        /// <summary>
        /// Propriedade utilizada para receber e enviar conexões via TCP/IP
        /// </summary>
        private TcpListener tcpListener { get; set; }
        /// <summary>
        /// Propriedade utilizada para indicar se o serviço foi parado
        /// </summary>
        private bool Parando { get; set; }
        #endregion

        #region Construtores
        public ClientService()
        {
        }
        #endregion

        #region Tratamento da mensagens
        public async void ThreadRun()
        {
            Socket socket = null;

            if (Parando)
                return;

            try
            {
                socket = await tcpListener.AcceptSocketAsync();
                if (socket != null)
                {
                    int size = socket.ReceiveBufferSize;
                    byte[] buffer = new byte[size];

                    int nb = socket.Receive(buffer);
                    if (nb > 0) // Verifica a quantidade de bytes recebidos
                    {
                        Logar("===================================================================", true);
                        Logar(Encoding.ASCII.GetString(buffer), true);

                        if (TraceHTML)
                        {
                            // Conexão por HTML
                            HttpWebRequest webRequest = WebRequest.Create(new Uri(UrlDestino)) as HttpWebRequest;
                            webRequest.Method         = VerboHTML;
                            if (VerboHTML == "POST")
                            {
                                StreamWriter requestWriter = new StreamWriter(webRequest.GetRequestStream());
                                requestWriter.Write(buffer);
                                requestWriter.Close();
                            }

                            var response  = webRequest.GetResponse();
                            var reader    = new StreamReader(response.GetResponseStream());
                            var fmtString = reader.ReadToEnd();
                            response.Close();

                            Logar("===================================================================", false);
                            Logar(fmtString, false);

                            // Retorna os dados para a aplicação que está na ponta
                            socket.SendBufferSize = fmtString.Length;
                            socket.Send(Encoding.ASCII.GetBytes(fmtString));
                            socket.Close();
                        }
                        else
                        {
                            // Conexão por IP
                            //var fmtString = ;

                            //LogarTxRx(fmtString, false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (Parando) // Não logo que houve problemas de desconexão
                    return;

                Logar(ex.Message, true); // Tx
                Logar("===================================================================", false); // Rx
            }
            finally
            {
                if (socket != null)
                    socket.Close();
            }

            // Coloca em background novamente
            Task trataConexao = new Task(ThreadRun);
            trataConexao.Start();
            trataConexao.Wait();
        }
        #endregion

        public void Start()
        {
            // Logar Tx
            Logar("===================================================================", true);
            Logar("Iniciando a escuta na porta.", true);
            Logar(string.Format("IP Address......: {0}", IpAddress) , true);
            Logar(string.Format("IP Port.........: {0}", IpPort)    , true);
            Logar(string.Format("Url de Destino..: {0}", UrlDestino), true);
            Logar(string.Format("VerboHTML.......: {0}", VerboHTML) , true);
            Logar(string.Format("TraceHTML.......: {0}", TraceHTML) , true);

            // Logar Rx
            Logar("===================================================================", false);
            Logar("Iniciando a escuta na porta.", false);
            Logar(string.Format("IP Address......: {0}", IpAddress), false);
            Logar(string.Format("IP Port.........: {0}", IpPort), false);
            Logar(string.Format("Url de Destino..: {0}", UrlDestino), false);
            Logar(string.Format("VerboHTML.......: {0}", VerboHTML), false);
            Logar(string.Format("TraceHTML.......: {0}", TraceHTML), false);

            var ipAddress  = IpAddress.Split('.');
            var bIpAddress = Array.ConvertAll(ipAddress, input => Convert.ToByte(input));

            Parando = false;

            tcpListener = new TcpListener(new IPAddress(bIpAddress), IpPort);
            tcpListener.Start();

            // Aguarda receber dados
            Task trataConexao = new Task(ThreadRun);
            trataConexao.Start();
            trataConexao.Wait();
        }

        public void Stop()
        {
            Logar("Fechando canais de comunicação.", true); // Tx
            Logar("Fechando canais de comunicação.", false); // Rx

            Parando = true;
            tcpListener.Server.Close();
            tcpListener.Stop();

            Logar("Finalizado com sucesso.", true); // Tx
            Logar("Finalizado com sucesso.", false); // Rx
        }

        protected virtual void Logar(string mensagem, bool? Tx)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("{0}: {1}\n", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), mensagem);

            if (OnReceivedData != null)
                OnReceivedData.Invoke(retorno.ToString(), Tx);
        }
    }
}
