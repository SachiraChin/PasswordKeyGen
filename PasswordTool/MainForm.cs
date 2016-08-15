using System;
using System.Windows.Forms;
using PasswordTool.Providers;

namespace PasswordTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void GenerateClientSecretButton_Click(object sender, EventArgs e)
        {
            ClientIdTextBox.Text= Guid.NewGuid().ToString("N");
            var secret= ApiKeyProvider.GenerateKey();
            var hash = PasswordHashProvider.CreateHash(secret);
            ClientSecretTextBox.Text = secret;
            ClientSecretHashTextBox.Text = hash.Hash;
            ClientSecretSaltTextBox.Text = hash.Salt;
        }
        
        private void GeneratePasswordWithHashButton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                var pass = System.Web.Security.Membership.GeneratePassword(16, 6);

                if (pass.Contains(":") || pass.Contains("&") || pass.Contains(".") || pass.Contains("%"))
                    continue;

                PasswordTextBox.Text = pass;
                break;
            }
            var hash = PasswordHashProvider.CreateHash(PasswordTextBox.Text);
            PasswordHashTextBox.Text = hash.Hash;
            PasswordSaltTextBox.Text = hash.Salt;
        }

        private void GeneratePasswordHashButton_Click(object sender, EventArgs e)
        {
            var hash = PasswordHashProvider.CreateHash(PasswordTextBox.Text);
            PasswordHashTextBox.Text = hash.Hash;
            PasswordSaltTextBox.Text = hash.Salt;
        }
    }
}
