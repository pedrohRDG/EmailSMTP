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

        private void bEnviarEmail(object sender, EventArgs e)
        {

        }

        private void tEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsValidEmail(tEmail.Text))
            {
                ErroEmail.SetError(tEmail, "O email é invalido");
                MessageBox.Show(tEmail.Text + " não é um email valido", "Email invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tEmail.Clear();
            }
        }
    }
}