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
            this.GeneratePasswordWithHashButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SymmetricSecurityKeyTextBox = new System.Windows.Forms.TextBox();
            this.GenerateSymmetricSecurityKeyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(19, 53);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(167, 20);
            this.PasswordTextBox.TabIndex = 0;
            // 
            // GeneratePasswordHashButton
            // 
            this.GeneratePasswordHashButton.Location = new System.Drawing.Point(403, 50);
            this.GeneratePasswordHashButton.Name = "GeneratePasswordHashButton";
            this.GeneratePasswordHashButton.Size = new System.Drawing.Size(184, 23);
            this.GeneratePasswordHashButton.TabIndex = 1;
            this.GeneratePasswordHashButton.Text = "Generate Password Hash";
            this.GeneratePasswordHashButton.UseVisualStyleBackColor = true;
            this.GeneratePasswordHashButton.Click += new System.EventHandler(this.GeneratePasswordHashButton_Click);
            // 
            // PasswordHashTextBox
            // 
            this.PasswordHashTextBox.Location = new System.Drawing.Point(19, 102);
            this.PasswordHashTextBox.Name = "PasswordHashTextBox";
            this.PasswordHashTextBox.ReadOnly = true;
            this.PasswordHashTextBox.Size = new System.Drawing.Size(480, 20);
            this.PasswordHashTextBox.TabIndex = 2;
            // 
            // PasswordSaltTextBox
            // 
            this.PasswordSaltTextBox.Location = new System.Drawing.Point(19, 146);
            this.PasswordSaltTextBox.Name = "PasswordSaltTextBox";
            this.PasswordSaltTextBox.ReadOnly = true;
            this.PasswordSaltTextBox.Size = new System.Drawing.Size(480, 20);
            this.PasswordSaltTextBox.TabIndex = 3;
            // 
            // ClientSecretTextBox
            // 
            this.ClientSecretTextBox.Location = new System.Drawing.Point(19, 121);
            this.ClientSecretTextBox.Name = "ClientSecretTextBox";
            this.ClientSecretTextBox.ReadOnly = true;
            this.ClientSecretTextBox.Size = new System.Drawing.Size(480, 20);
            this.ClientSecretTextBox.TabIndex = 4;
            // 
            // GenerateClientSecretButton
            // 
            this.GenerateClientSecretButton.Location = new System.Drawing.Point(19, 28);
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
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hash";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salt";
            // 
            // ClientSecretHashTextBox
            // 
            this.ClientSecretHashTextBox.Location = new System.Drawing.Point(19, 165);
            this.ClientSecretHashTextBox.Name = "ClientSecretHashTextBox";
            this.ClientSecretHashTextBox.ReadOnly = true;
            this.ClientSecretHashTextBox.Size = new System.Drawing.Size(480, 20);
            this.ClientSecretHashTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client Secret";
            // 
            // ClientSecretSaltTextBox
            // 
            this.ClientSecretSaltTextBox.Location = new System.Drawing.Point(19, 209);
            this.ClientSecretSaltTextBox.Name = "ClientSecretSaltTextBox";
            this.ClientSecretSaltTextBox.ReadOnly = true;
            this.ClientSecretSaltTextBox.Size = new System.Drawing.Size(480, 20);
            this.ClientSecretSaltTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hash";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Salt";
            // 
            // ClientIdTextBox
            // 
            this.ClientIdTextBox.Location = new System.Drawing.Point(19, 82);
            this.ClientIdTextBox.Name = "ClientIdTextBox";
            this.ClientIdTextBox.ReadOnly = true;
            this.ClientIdTextBox.Size = new System.Drawing.Size(480, 20);
            this.ClientIdTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Client Id";
            // 
            // GeneratePasswordWithHashButton
            // 
            this.GeneratePasswordWithHashButton.Location = new System.Drawing.Point(200, 50);
            this.GeneratePasswordWithHashButton.Name = "GeneratePasswordWithHashButton";
            this.GeneratePasswordWithHashButton.Size = new System.Drawing.Size(184, 23);
            this.GeneratePasswordWithHashButton.TabIndex = 10;
            this.GeneratePasswordWithHashButton.Text = "Generate Password with Hash";
            this.GeneratePasswordWithHashButton.UseVisualStyleBackColor = true;
            this.GeneratePasswordWithHashButton.Click += new System.EventHandler(this.GeneratePasswordWithHashButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GeneratePasswordWithHashButton);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Controls.Add(this.GeneratePasswordHashButton);
            this.groupBox1.Controls.Add(this.PasswordHashTextBox);
            this.groupBox1.Controls.Add(this.PasswordSaltTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 196);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Generation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GenerateClientSecretButton);
            this.groupBox2.Controls.Add(this.ClientSecretTextBox);
            this.groupBox2.Controls.Add(this.ClientIdTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ClientSecretSaltTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ClientSecretHashTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 253);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Secret Generation";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GenerateSymmetricSecurityKeyButton);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.SymmetricSecurityKeyTextBox);
            this.groupBox3.Location = new System.Drawing.Point(13, 474);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 121);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Symmetric Security Key Generation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Symmetric Security Key (Base64Url)";
            // 
            // SymmetricSecurityKeyTextBox
            // 
            this.SymmetricSecurityKeyTextBox.Location = new System.Drawing.Point(18, 73);
            this.SymmetricSecurityKeyTextBox.Name = "SymmetricSecurityKeyTextBox";
            this.SymmetricSecurityKeyTextBox.ReadOnly = true;
            this.SymmetricSecurityKeyTextBox.Size = new System.Drawing.Size(605, 20);
            this.SymmetricSecurityKeyTextBox.TabIndex = 9;
            // 
            // GenerateSymmetricSecurityKeyButton
            // 
            this.GenerateSymmetricSecurityKeyButton.Location = new System.Drawing.Point(18, 19);
            this.GenerateSymmetricSecurityKeyButton.Name = "GenerateSymmetricSecurityKeyButton";
            this.GenerateSymmetricSecurityKeyButton.Size = new System.Drawing.Size(178, 23);
            this.GenerateSymmetricSecurityKeyButton.TabIndex = 5;
            this.GenerateSymmetricSecurityKeyButton.Text = "Generate Symmetric Security Key";
            this.GenerateSymmetricSecurityKeyButton.UseVisualStyleBackColor = true;
            this.GenerateSymmetricSecurityKeyButton.Click += new System.EventHandler(this.GenerateSymmetricSecurityKeyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 607);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Generation Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button GeneratePasswordWithHashButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button GenerateSymmetricSecurityKeyButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SymmetricSecurityKeyTextBox;
    }
}

