using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace EmailSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

       public void ValidaCampoEmail(TextBox prEmail) 
       {
            if (!IsValidEmail(prEmail.Text))
            {
                Erro.SetError(prEmail, "Email Invalido");
                MessageBox.Show(prEmail.Text + " Não é um email valido", "Email invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);         
                prEmail.Focus();
            }
            else
            {
                Erro.SetError(prEmail, null);
            }
        }

       public void VerificaCampoObrigatorio(TextBox prCampo)
        {
            if (string.IsNullOrEmpty(prCampo.Text))
            {
                Erro.SetError(prCampo, "Campo Obrigatorio");
                prCampo.Focus();
            }
            else
            {
                Erro.SetError(prCampo, null);
            }
        }

        public void MontaRespostaServidor()
        {
            if (IsValidEmail(tEmailRemetente.Text) && (IsValidEmail(tEmailCliente.Text)))
            {
                tServerBox.Text = "MAIL FROM: <" + tEmailRemetente.Text + ">" + "\r\n" +
                                  "250 2.1.0 Sender OK" + "\r\n" +
                                  "RCPT TO: <" + tEmailCliente.Text + "> NOTIFY=success" + "\r\n" +
                                  "250 2.1.5 Recipient OK" + "\r\n" +
                                  "DATA" + "\r\n" +
                                  "354 Enter mail, end with . on a line by itself" + "\r\n" +
                                  tAssunto.Text + "\r\n" +
                                  tMensagem.Text + "\r\n" +
                                  "." + "\r\n" +
                                  "QUIT" + "\r\n" +
                                  "221" + tEmailCliente.Text + " closing connection";
            }
            else 
            {
                tServerBox.Text = "MAIL FROM: <" + tEmailRemetente.Text + ">" + "\r\n" +
                                  "550 5.1.7 Invalid address" + "\r\n" +
                                  "RCPT TO: <" + tEmailCliente.Text + "> NOTIFY=failure" + "\r\n" +
                                  "550 5.1.1 User unknown";
            }

        }

        public void MontaRespostaCliente()
        {
            if (IsValidEmail(tEmailRemetente.Text) && (IsValidEmail(tEmailCliente.Text)))
            {
                tMensagemCliente.Text = tAssunto.Text + "\r\n" +
                                        tMensagem.Text + "\r\n" + "\r\n" + "\r\n" +
                                        "Ass. " + tEmailRemetente.Text;

            }

        }


        private void bEnviarEmail(object sender, EventArgs e)
        {
            //Campos Obrigatorios
            VerificaCampoObrigatorio(tAssunto);
            VerificaCampoObrigatorio(tMensagem);
            VerificaCampoObrigatorio(tEmailCliente);
            VerificaCampoObrigatorio(tEmailRemetente);

            //Valida Emails
            ValidaCampoEmail(tEmailRemetente);
            ValidaCampoEmail(tEmailCliente);

            //Monta Info servidor
            MontaRespostaServidor();

            //Monta Resposta Clinete
            MontaRespostaCliente();


        }

    }
}