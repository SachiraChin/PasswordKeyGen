namespace PasswordTool
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
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.GeneratePasswordHashButton = new System.Windows.Forms.Button();
            this.PasswordHashTextBox = new System.Windows.Forms.TextBox();
            this.PasswordSaltTextBox = new System.Windows.Forms.TextBox();
            this.ClientSecretTextBox = new System.Windows.Forms.TextBox();
            this.GenerateClientSecretButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientSecretHashTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientSecretSaltTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ClientIdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 34);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(167, 20);
            this.PasswordTextBox.TabIndex = 0;
            // 
            // GeneratePasswordHashButton
            // 
            this.GeneratePasswordHashButton.Location = new System.Drawing.Point(195, 32);
            this.GeneratePasswordHashButton.Name = "GeneratePasswordHashButton";
            this.GeneratePasswordHashButton.Size = new System.Drawing.Size(184, 23);
            this.GeneratePasswordHashButton.TabIndex = 1;
            this.GeneratePasswordHashButton.Text = "Generate Password Hash";
            this.GeneratePasswordHashButton.UseVisualStyleBackColor = true;
            this.GeneratePasswordHashButton.Click += new System.EventHandler(this.GeneratePasswordHashButton_Click);
            // 
            // PasswordHashTextBox
            // 
            this.PasswordHashTextBox.Location = new System.Drawing.Point(12, 83);
            this.PasswordHashTextBox.Name = "PasswordHashTextBox";
            this.PasswordHashTextBox.Size = new System.Drawing.Size(480, 20);
            this.PasswordHashTextBox.TabIndex = 2;
            // 
            // PasswordSaltTextBox
            // 
            this.PasswordSaltTextBox.Location = new System.Drawing.Point(12, 127);
            this.PasswordSaltTextBox.Name = "PasswordSaltTextBox";
            this.PasswordSaltTextBox.Size = new System.Drawing.Size(480, 20);
            this.PasswordSaltTextBox.TabIndex = 3;
            // 
            // ClientSecretTextBox
            // 
            this.ClientSecretTextBox.Location = new System.Drawing.Point(12, 266);
            this.ClientSecretTextBox.Name = "ClientSecretTextBox";
            this.ClientSecretTextBox.Size = new System.Drawing.Size(480, 20);
            this.ClientSecretTextBox.TabIndex = 4;
            // 
            // GenerateClientSecretButton
            // 
            this.GenerateClientSecretButton.Location = new System.Drawing.Point(12, 173);
            this.GenerateClientSecretButton.Name = "GenerateClientSecretButton";
            this.GenerateClientSecretButton.Size = new System.Drawing.Size(178, 23);
            this.GenerateClientSecretButton.TabIndex = 5;
            this.GenerateClientSecretButton.Text = "Generate Client Secret";
            this.GenerateClientSecretButton.UseVisualStyleBackColor = true;
            this.GenerateClientSecretButton.Click += new System.EventHandler(this.GenerateClientSecretButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hash";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salt";
            // 
            // ClientSecretHashTextBox
            // 
            this.ClientSecretHashTextBox.Location = new System.Drawing.Point(12, 310);
            this.ClientSecretHashTextBox.Name = "ClientSecretHashTextBox";
            this.ClientSecretHashTextBox.Size = new System.Drawing.Size(480, 20);
            this.ClientSecretHashTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client Secret";
            // 
            // ClientSecretSaltTextBox
            // 
            this.ClientSecretSaltTextBox.Location = new System.Drawing.Point(12, 354);
            this.ClientSecretSaltTextBox.Name = "ClientSecretSaltTextBox";
            this.ClientSecretSaltTextBox.Size = new System.Drawing.Size(480, 20);
            this.ClientSecretSaltTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hash";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Salt";
            // 
            // ClientIdTextBox
            // 
            this.ClientIdTextBox.Location = new System.Drawing.Point(12, 227);
            this.ClientIdTextBox.Name = "ClientIdTextBox";
            this.ClientIdTextBox.Size = new System.Drawing.Size(480, 20);
            this.ClientIdTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Client Id";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 394);
            this.Controls.Add(this.ClientIdTextBox);
            this.Controls.Add(this.ClientSecretSaltTextBox);
            this.Controls.Add(this.ClientSecretHashTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateClientSecretButton);
            this.Controls.Add(this.ClientSecretTextBox);
            this.Controls.Add(this.PasswordSaltTextBox);
            this.Controls.Add(this.PasswordHashTextBox);
            this.Controls.Add(this.GeneratePasswordHashButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Name = "MainForm";
            this.Text = "Password Genration Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button GeneratePasswordHashButton;
        private System.Windows.Forms.TextBox PasswordHashTextBox;
        private System.Windows.Forms.TextBox PasswordSaltTextBox;
        private System.Windows.Forms.TextBox ClientSecretTextBox;
        private System.Windows.Forms.Button GenerateClientSecretButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientSecretHashTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClientSecretSaltTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ClientIdTextBox;
        private System.Windows.Forms.Label label7;
    }
}

