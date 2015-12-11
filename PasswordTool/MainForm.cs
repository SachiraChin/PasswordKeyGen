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

        private void GeneratePasswordHashButton_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = System.Web.Security.Membership.GeneratePassword(16, 6);
            var hash = PasswordHashProvider.CreateHash(PasswordTextBox.Text);
            PasswordHashTextBox.Text = hash.Hash;
            PasswordSaltTextBox.Text = hash.Salt;
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
    }
}
