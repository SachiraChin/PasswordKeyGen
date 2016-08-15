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
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(18, 52);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(248, 26);
            this.PasswordTextBox.TabIndex = 0;
            // 
            // GeneratePasswordHashButton
            // 
            this.GeneratePasswordHashButton.Location = new System.Drawing.Point(594, 48);
            this.GeneratePasswordHashButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GeneratePasswordHashButton.Name = "GeneratePasswordHashButton";
            this.GeneratePasswordHashButton.Size = new System.Drawing.Size(276, 35);
            this.GeneratePasswordHashButton.TabIndex = 1;
            this.GeneratePasswordHashButton.Text = "Generate Password Hash";
            this.GeneratePasswordHashButton.UseVisualStyleBackColor = true;
            this.GeneratePasswordHashButton.Click += new System.EventHandler(this.GeneratePasswordHashButton_Click);
            // 
            // PasswordHashTextBox
            // 
            this.PasswordHashTextBox.Location = new System.Drawing.Point(18, 128);
            this.PasswordHashTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordHashTextBox.Name = "PasswordHashTextBox";
            this.PasswordHashTextBox.Size = new System.Drawing.Size(718, 26);
            this.PasswordHashTextBox.TabIndex = 2;
            // 
            // PasswordSaltTextBox
            // 
            this.PasswordSaltTextBox.Location = new System.Drawing.Point(18, 195);
            this.PasswordSaltTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordSaltTextBox.Name = "PasswordSaltTextBox";
            this.PasswordSaltTextBox.Size = new System.Drawing.Size(718, 26);
            this.PasswordSaltTextBox.TabIndex = 3;
            // 
            // ClientSecretTextBox
            // 
            this.ClientSecretTextBox.Location = new System.Drawing.Point(18, 409);
            this.ClientSecretTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientSecretTextBox.Name = "ClientSecretTextBox";
            this.ClientSecretTextBox.Size = new System.Drawing.Size(718, 26);
            this.ClientSecretTextBox.TabIndex = 4;
            // 
            // GenerateClientSecretButton
            // 
            this.GenerateClientSecretButton.Location = new System.Drawing.Point(18, 266);
            this.GenerateClientSecretButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenerateClientSecretButton.Name = "GenerateClientSecretButton";
            this.GenerateClientSecretButton.Size = new System.Drawing.Size(267, 35);
            this.GenerateClientSecretButton.TabIndex = 5;
            this.GenerateClientSecretButton.Text = "Generate Client Secret";
            this.GenerateClientSecretButton.UseVisualStyleBackColor = true;
            this.GenerateClientSecretButton.Click += new System.EventHandler(this.GenerateClientSecretButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hash";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salt";
            // 
            // ClientSecretHashTextBox
            // 
            this.ClientSecretHashTextBox.Location = new System.Drawing.Point(18, 477);
            this.ClientSecretHashTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientSecretHashTextBox.Name = "ClientSecretHashTextBox";
            this.ClientSecretHashTextBox.Size = new System.Drawing.Size(718, 26);
            this.ClientSecretHashTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 385);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client Secret";
            // 
            // ClientSecretSaltTextBox
            // 
            this.ClientSecretSaltTextBox.Location = new System.Drawing.Point(18, 545);
            this.ClientSecretSaltTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientSecretSaltTextBox.Name = "ClientSecretSaltTextBox";
            this.ClientSecretSaltTextBox.Size = new System.Drawing.Size(718, 26);
            this.ClientSecretSaltTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 452);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hash";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 520);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Salt";
            // 
            // ClientIdTextBox
            // 
            this.ClientIdTextBox.Location = new System.Drawing.Point(18, 349);
            this.ClientIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientIdTextBox.Name = "ClientIdTextBox";
            this.ClientIdTextBox.Size = new System.Drawing.Size(718, 26);
            this.ClientIdTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 325);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Client Id";
            // 
            // GeneratePasswordWithHashButton
            // 
            this.GeneratePasswordWithHashButton.Location = new System.Drawing.Point(289, 48);
            this.GeneratePasswordWithHashButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GeneratePasswordWithHashButton.Name = "GeneratePasswordWithHashButton";
            this.GeneratePasswordWithHashButton.Size = new System.Drawing.Size(276, 35);
            this.GeneratePasswordWithHashButton.TabIndex = 10;
            this.GeneratePasswordWithHashButton.Text = "Generate Password with Hash";
            this.GeneratePasswordWithHashButton.UseVisualStyleBackColor = true;
            this.GeneratePasswordWithHashButton.Click += new System.EventHandler(this.GeneratePasswordWithHashButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 606);
            this.Controls.Add(this.GeneratePasswordWithHashButton);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button GeneratePasswordWithHashButton;
    }
}

