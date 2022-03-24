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

        public void MontaRespostaServidor()
        {
        
        }

        public void ValidaCampoEmail(TextBox prEmail) 
       {
            if (!IsValidEmail(prEmail.Text))
            {
                Erro.SetError(prEmail, "Email Invalido");
                MessageBox.Show(prEmail.Text + " Não é um email valido", "Email invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                prEmail.Clear();
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


        private void bEnviarEmail(object sender, EventArgs e)
        {
            //CamposObrigatorios
            VerificaCampoObrigatorio(tAssunto);
            VerificaCampoObrigatorio(tMensagem);
            VerificaCampoObrigatorio(tEmailCliente);
            VerificaCampoObrigatorio(tEmailRemetente);

            //ValidaEmails
            ValidaCampoEmail(tEmailRemetente);
            ValidaCampoEmail(tEmailCliente);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}