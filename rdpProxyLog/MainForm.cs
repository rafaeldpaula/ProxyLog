using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcpUtil;

namespace rdpProxyLog
{
    public partial class MainForm : Form
    {
        private ClientService service { get; set; }

        public MainForm()
        {
            InitializeComponent();

            service                 = new ClientService();
            service.IpAddress       = "127.0.0.1";
            service.IpPort          = 8080;
            service.TraceHTML       = true;
            service.VerboHTML       = "POST";
            service.UrlDestino      = "https://www.fazenda.sp.gov.br/CODIF/codigo/login.aspx";
            service.OnReceivedData += ServiceOnOnReceivedData;
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            // Seta o serviço como ligado
            situacaoInfoToolStripStatusLabel.Text = "Ligado";
            situacaoInfoToolStripStatusLabel.ForeColor = Color.Green;

            // Inicia o objeto que vai tratar os recebimentos dos dados
            service.Start();

            IniciarButton.Enabled = false;
            PararButton.Enabled   = true;
        }

        private delegate void RichTextBoxUpdateEventHandler(string message);

        private void UpdateTxRichTextBox(string mensagem)
        {
            txMessagesRichTextBox.AppendText(mensagem);
        }

        private void UpdateRxRichTextBox(string mensagem)
        {
            rxMessagesRichTextBox.AppendText(mensagem);
        }

        private void ServiceOnOnReceivedData(string mensagem, bool? Tx)
        {
            if (Tx.HasValue && Tx.Value)
            {
                if (txMessagesRichTextBox.InvokeRequired)
                {
                    txMessagesRichTextBox.Invoke(new RichTextBoxUpdateEventHandler(UpdateTxRichTextBox),
                        new object[] {mensagem});
                }
                else
                {
                    txMessagesRichTextBox.AppendText(mensagem);
                }
            }
            else if (Tx.HasValue && !Tx.Value)
            {
                if (rxMessagesRichTextBox.InvokeRequired)
                {
                    rxMessagesRichTextBox.Invoke(new RichTextBoxUpdateEventHandler(UpdateRxRichTextBox), new object[] { mensagem });
                }
                else
                {
                    rxMessagesRichTextBox.AppendText(mensagem);
                }
            }
            else
            {
                // Loga alguma excessão se ocorrer
                if (txMessagesRichTextBox.InvokeRequired)
                {
                    txMessagesRichTextBox.Invoke(new RichTextBoxUpdateEventHandler(UpdateTxRichTextBox), new object[] { mensagem });
                }
                else
                {
                    txMessagesRichTextBox.AppendText(mensagem);
                }
            }
        }

        private void PararButton_Click(object sender, EventArgs e)
        {
            // Seta o serviço como desligado
            situacaoInfoToolStripStatusLabel.Text = "Desligado";
            situacaoInfoToolStripStatusLabel.ForeColor = Color.Red;

            // Destroi todos os objetos e para recebimento de dados
            service.Stop();

            IniciarButton.Enabled = true;
            PararButton.Enabled   = false;
        }

        private void clearTxButton_Click(object sender, EventArgs e)
        {
            txMessagesRichTextBox.Clear();
        }

        private void clearRxButton_Click(object sender, EventArgs e)
        {
            rxMessagesRichTextBox.Clear();
        }
    }
}
