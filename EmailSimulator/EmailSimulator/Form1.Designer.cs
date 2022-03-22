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
            this.tEmail = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BotaoEnviar = new System.Windows.Forms.Button();
            this.ErroEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErroEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(29, 29);
            this.tEmail.Margin = new System.Windows.Forms.Padding(20, 20, 20, 15);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(300, 23);
            this.tEmail.TabIndex = 0;
            this.tEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tEmail_Validating);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 87);
            this.textBox2.Margin = new System.Windows.Forms.Padding(20, 20, 20, 15);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 77);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 199);
            this.textBox3.Margin = new System.Windows.Forms.Padding(20, 20, 20, 60);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 243);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(755, 67);
            this.textBox4.Margin = new System.Windows.Forms.Padding(20);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(300, 415);
            this.textBox4.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(419, 99);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(70, 90, 70, 90);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(246, 313);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
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
            // ErroEmail
            // 
            this.ErroEmail.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Assunto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mensagem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoEnviar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ErroEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tEmail;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private RichTextBox richTextBox1;
        private Button BotaoEnviar;
        private ErrorProvider ErroEmail;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}