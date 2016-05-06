namespace rdpProxyLog
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IniciarButton = new System.Windows.Forms.Button();
            this.PararButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.situacaoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.situacaoInfoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.clearTxButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txMessagesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.clearRxButton = new System.Windows.Forms.Button();
            this.rxMessagesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // IniciarButton
            // 
            this.IniciarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarButton.Location = new System.Drawing.Point(12, 12);
            this.IniciarButton.Name = "IniciarButton";
            this.IniciarButton.Size = new System.Drawing.Size(99, 38);
            this.IniciarButton.TabIndex = 1;
            this.IniciarButton.Text = "Iniciar";
            this.IniciarButton.UseVisualStyleBackColor = true;
            this.IniciarButton.Click += new System.EventHandler(this.IniciarButton_Click);
            // 
            // PararButton
            // 
            this.PararButton.Enabled = false;
            this.PararButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PararButton.Location = new System.Drawing.Point(117, 12);
            this.PararButton.Name = "PararButton";
            this.PararButton.Size = new System.Drawing.Size(99, 38);
            this.PararButton.TabIndex = 2;
            this.PararButton.Text = "Parar";
            this.PararButton.UseVisualStyleBackColor = true;
            this.PararButton.Click += new System.EventHandler(this.PararButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mensagens Recebidas";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.situacaoToolStripStatusLabel,
            this.situacaoInfoToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 655);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1203, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // situacaoToolStripStatusLabel
            // 
            this.situacaoToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacaoToolStripStatusLabel.Name = "situacaoToolStripStatusLabel";
            this.situacaoToolStripStatusLabel.Size = new System.Drawing.Size(119, 17);
            this.situacaoToolStripStatusLabel.Text = "Situação do Serviço:";
            // 
            // situacaoInfoToolStripStatusLabel
            // 
            this.situacaoInfoToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacaoInfoToolStripStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.situacaoInfoToolStripStatusLabel.Name = "situacaoInfoToolStripStatusLabel";
            this.situacaoInfoToolStripStatusLabel.Size = new System.Drawing.Size(61, 17);
            this.situacaoInfoToolStripStatusLabel.Text = "Desligado";
            // 
            // SplitContainer
            // 
            this.SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer.Location = new System.Drawing.Point(12, 56);
            this.SplitContainer.Name = "SplitContainer";
            this.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.clearTxButton);
            this.SplitContainer.Panel1.Controls.Add(this.label1);
            this.SplitContainer.Panel1.Controls.Add(this.txMessagesRichTextBox);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.clearRxButton);
            this.SplitContainer.Panel2.Controls.Add(this.rxMessagesRichTextBox);
            this.SplitContainer.Panel2.Controls.Add(this.label2);
            this.SplitContainer.Size = new System.Drawing.Size(1179, 589);
            this.SplitContainer.SplitterDistance = 294;
            this.SplitContainer.TabIndex = 8;
            // 
            // clearTxButton
            // 
            this.clearTxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearTxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTxButton.Location = new System.Drawing.Point(1126, 0);
            this.clearTxButton.Name = "clearTxButton";
            this.clearTxButton.Size = new System.Drawing.Size(53, 20);
            this.clearTxButton.TabIndex = 8;
            this.clearTxButton.Text = "CLEAR";
            this.clearTxButton.UseVisualStyleBackColor = true;
            this.clearTxButton.Click += new System.EventHandler(this.clearTxButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mensagens Transferidas";
            // 
            // txMessagesRichTextBox
            // 
            this.txMessagesRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txMessagesRichTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMessagesRichTextBox.Location = new System.Drawing.Point(0, 23);
            this.txMessagesRichTextBox.Name = "txMessagesRichTextBox";
            this.txMessagesRichTextBox.Size = new System.Drawing.Size(1179, 266);
            this.txMessagesRichTextBox.TabIndex = 6;
            this.txMessagesRichTextBox.Text = "";
            // 
            // clearRxButton
            // 
            this.clearRxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearRxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearRxButton.Location = new System.Drawing.Point(1126, 0);
            this.clearRxButton.Name = "clearRxButton";
            this.clearRxButton.Size = new System.Drawing.Size(53, 20);
            this.clearRxButton.TabIndex = 9;
            this.clearRxButton.Text = "CLEAR";
            this.clearRxButton.UseVisualStyleBackColor = true;
            this.clearRxButton.Click += new System.EventHandler(this.clearRxButton_Click);
            // 
            // rxMessagesRichTextBox
            // 
            this.rxMessagesRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rxMessagesRichTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rxMessagesRichTextBox.Location = new System.Drawing.Point(0, 23);
            this.rxMessagesRichTextBox.Name = "rxMessagesRichTextBox";
            this.rxMessagesRichTextBox.Size = new System.Drawing.Size(1179, 274);
            this.rxMessagesRichTextBox.TabIndex = 7;
            this.rxMessagesRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 677);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PararButton);
            this.Controls.Add(this.IniciarButton);
            this.MinimumSize = new System.Drawing.Size(1219, 716);
            this.Name = "MainForm";
            this.Text = "Rafael de Paula - Proxy Log";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button IniciarButton;
        private System.Windows.Forms.Button PararButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel situacaoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel situacaoInfoToolStripStatusLabel;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txMessagesRichTextBox;
        private System.Windows.Forms.RichTextBox rxMessagesRichTextBox;
        private System.Windows.Forms.Button clearTxButton;
        private System.Windows.Forms.Button clearRxButton;
    }
}

