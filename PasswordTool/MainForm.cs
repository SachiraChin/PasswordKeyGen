using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Occulem.Core.Auth.Providers;

namespace Occulem.Core.Auth.PasswordTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GeneratePasswordHashButton_Click(object sender, EventArgs e)
        {
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
