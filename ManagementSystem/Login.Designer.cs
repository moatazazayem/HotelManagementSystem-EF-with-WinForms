namespace ManagementSystem
{
    partial class Login
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
            usernameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            passwordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            signinButton = new MaterialSkin.Controls.MaterialButton();
            WrongUser = new Label();
            pictureBox1 = new PictureBox();
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.AnimateReadOnly = false;
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Depth = 0;
            usernameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernameTextBox.LeadingIcon = null;
            usernameTextBox.Location = new Point(250, 54);
            usernameTextBox.MaxLength = 50;
            usernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            usernameTextBox.Multiline = false;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(285, 50);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.Text = "";
            usernameTextBox.TrailingIcon = null;
            usernameTextBox.Click += usernameTextBox_Click;
            usernameTextBox.Leave += usernameTextBox_Leave;
            // 
            // passwordTextBox
            // 
            passwordTextBox.AnimateReadOnly = false;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Depth = 0;
            passwordTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordTextBox.LeadingIcon = null;
            passwordTextBox.Location = new Point(250, 134);
            passwordTextBox.MaxLength = 50;
            passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            passwordTextBox.Multiline = false;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Password = true;
            passwordTextBox.Size = new Size(285, 50);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.Text = "";
            passwordTextBox.TrailingIcon = null;
            passwordTextBox.Click += passwordTextBox_Click;
            passwordTextBox.Leave += passwordTextBox_Leave;
            // 
            // signinButton
            // 
            signinButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            signinButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            signinButton.Depth = 0;
            signinButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signinButton.HighEmphasis = true;
            signinButton.Icon = null;
            signinButton.Location = new Point(346, 197);
            signinButton.Margin = new Padding(4, 6, 4, 6);
            signinButton.MouseState = MaterialSkin.MouseState.HOVER;
            signinButton.Name = "signinButton";
            signinButton.NoAccentTextColor = Color.Empty;
            signinButton.Size = new Size(93, 36);
            signinButton.TabIndex = 4;
            signinButton.Text = "        Login          ";
            signinButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            signinButton.UseAccentColor = false;
            signinButton.UseVisualStyleBackColor = true;
            signinButton.Click += signinButton_Click;
            // 
            // WrongUser
            // 
            WrongUser.AutoSize = true;
            WrongUser.BackColor = Color.LavenderBlush;
            WrongUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WrongUser.ForeColor = Color.Red;
            WrongUser.Location = new Point(250, 245);
            WrongUser.Name = "WrongUser";
            WrongUser.Size = new Size(0, 17);
            WrongUser.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hotel_da_vinci;
            pictureBox1.Location = new Point(-213, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1211, 471);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Oswald", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(250, 27);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(80, 24);
            UserNameLabel.TabIndex = 7;
            UserNameLabel.Text = "User Name:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Oswald", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(250, 107);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(72, 24);
            PasswordLabel.TabIndex = 8;
            PasswordLabel.Text = "Password:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(WrongUser);
            Controls.Add(signinButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(800, 500);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox usernameTextBox;
        private MaterialSkin.Controls.MaterialTextBox passwordTextBox;
        private MaterialSkin.Controls.MaterialButton signinButton;
        private Label WrongUser;
        private PictureBox pictureBox1;
        private Label UserNameLabel;
        private Label PasswordLabel;
    }
}