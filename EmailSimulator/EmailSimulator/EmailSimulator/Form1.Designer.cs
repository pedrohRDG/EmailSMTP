namespace EmailSimulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tEmailRemetente = new System.Windows.Forms.TextBox();
            this.tAssunto = new System.Windows.Forms.TextBox();
            this.tMensagem = new System.Windows.Forms.TextBox();
            this.tMensagemCliente = new System.Windows.Forms.TextBox();
            this.tServerBox = new System.Windows.Forms.RichTextBox();
            this.BotaoEnviar = new System.Windows.Forms.Button();
            this.Erro = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tEmailCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Erro)).BeginInit();
            this.SuspendLayout();
            // 
            // tEmailRemetente
            // 
            this.tEmailRemetente.Location = new System.Drawing.Point(29, 29);
            this.tEmailRemetente.Margin = new System.Windows.Forms.Padding(20, 20, 20, 15);
            this.tEmailRemetente.Name = "tEmailRemetente";
            this.tEmailRemetente.Size = new System.Drawing.Size(300, 23);
            this.tEmailRemetente.TabIndex = 0;
            // 
            // tAssunto
            // 
            this.tAssunto.Location = new System.Drawing.Point(29, 87);
            this.tAssunto.Margin = new System.Windows.Forms.Padding(20, 20, 20, 15);
            this.tAssunto.Multiline = true;
            this.tAssunto.Name = "tAssunto";
            this.tAssunto.Size = new System.Drawing.Size(300, 77);
            this.tAssunto.TabIndex = 1;
            // 
            // tMensagem
            // 
            this.tMensagem.Location = new System.Drawing.Point(29, 199);
            this.tMensagem.Margin = new System.Windows.Forms.Padding(20, 20, 20, 60);
            this.tMensagem.Multiline = true;
            this.tMensagem.Name = "tMensagem";
            this.tMensagem.Size = new System.Drawing.Size(300, 243);
            this.tMensagem.TabIndex = 2;
            // 
            // tMensagemCliente
            // 
            this.tMensagemCliente.Location = new System.Drawing.Point(755, 87);
            this.tMensagemCliente.Margin = new System.Windows.Forms.Padding(20);
            this.tMensagemCliente.Multiline = true;
            this.tMensagemCliente.Name = "tMensagemCliente";
            this.tMensagemCliente.Size = new System.Drawing.Size(300, 395);
            this.tMensagemCliente.TabIndex = 3;
            // 
            // tServerBox
            // 
            this.tServerBox.Location = new System.Drawing.Point(419, 99);
            this.tServerBox.Margin = new System.Windows.Forms.Padding(70, 90, 70, 90);
            this.tServerBox.Name = "tServerBox";
            this.tServerBox.Size = new System.Drawing.Size(246, 313);
            this.tServerBox.TabIndex = 4;
            this.tServerBox.Text = "";
            // 
            // BotaoEnviar
            // 
            this.BotaoEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoEnviar.Location = new System.Drawing.Point(254, 459);
            this.BotaoEnviar.Name = "BotaoEnviar";
            this.BotaoEnviar.Size = new System.Drawing.Size(75, 23);
            this.BotaoEnviar.TabIndex = 5;
            this.BotaoEnviar.Text = "Enviar";
            this.BotaoEnviar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotaoEnviar.UseVisualStyleBackColor = true;
            this.BotaoEnviar.Click += new System.EventHandler(this.bEnviarEmail);
            // 
            // Erro
            // 
            this.Erro.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email Remetente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Assunto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(29, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mensagem";
            // 
            // tEmailCliente
            // 
            this.tEmailCliente.Location = new System.Drawing.Point(755, 29);
            this.tEmailCliente.Margin = new System.Windows.Forms.Padding(20, 20, 20, 15);
            this.tEmailCliente.Name = "tEmailCliente";
            this.tEmailCliente.Size = new System.Drawing.Size(300, 23);
            this.tEmailCliente.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(755, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email Cliente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tEmailCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoEnviar);
            this.Controls.Add(this.tServerBox);
            this.Controls.Add(this.tMensagemCliente);
            this.Controls.Add(this.tMensagem);
            this.Controls.Add(this.tAssunto);
            this.Controls.Add(this.tEmailRemetente);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Erro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tEmailRemetente;
        private TextBox tAssunto;
        private TextBox tMensagem;
        private TextBox tMensagemCliente;
        private RichTextBox tServerBox;
        private Button BotaoEnviar;
        private ErrorProvider Erro;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox tEmailCliente;
    }
}