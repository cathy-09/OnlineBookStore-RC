namespace BookStore
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            picBoxLogInIcon = new PictureBox();
            lblText = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            checkBoxForgot = new CheckBox();
            button1 = new Button();
            lblAccountText = new Label();
            picBoxUIDesign = new PictureBox();
            btnSignUp = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxLogInIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxUIDesign).BeginInit();
            SuspendLayout();
            // 
            // picBoxLogInIcon
            // 
            picBoxLogInIcon.Image = (Image)resources.GetObject("picBoxLogInIcon.Image");
            picBoxLogInIcon.Location = new Point(416, 52);
            picBoxLogInIcon.Name = "picBoxLogInIcon";
            picBoxLogInIcon.Size = new Size(173, 103);
            picBoxLogInIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLogInIcon.TabIndex = 1;
            picBoxLogInIcon.TabStop = false;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblText.Location = new Point(452, 158);
            lblText.Name = "lblText";
            lblText.Size = new Size(104, 21);
            lblText.TabIndex = 2;
            lblText.Text = "Get Started";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(416, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(173, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(416, 271);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(173, 23);
            txtPassword.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(416, 188);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 21);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(416, 247);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 21);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // checkBoxForgot
            // 
            checkBoxForgot.AutoSize = true;
            checkBoxForgot.Location = new Point(416, 300);
            checkBoxForgot.Name = "checkBoxForgot";
            checkBoxForgot.Size = new Size(146, 19);
            checkBoxForgot.TabIndex = 7;
            checkBoxForgot.Text = "Forgot your password?";
            checkBoxForgot.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(416, 325);
            button1.Name = "button1";
            button1.Size = new Size(173, 36);
            button1.TabIndex = 8;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblAccountText
            // 
            lblAccountText.AutoSize = true;
            lblAccountText.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccountText.Location = new Point(416, 373);
            lblAccountText.Name = "lblAccountText";
            lblAccountText.Size = new Size(89, 32);
            lblAccountText.TabIndex = 9;
            lblAccountText.Text = "Don't have an \r\naccount yet? ";
            // 
            // picBoxUIDesign
            // 
            picBoxUIDesign.Image = (Image)resources.GetObject("picBoxUIDesign.Image");
            picBoxUIDesign.Location = new Point(-1, -228);
            picBoxUIDesign.Name = "picBoxUIDesign";
            picBoxUIDesign.Size = new Size(648, 909);
            picBoxUIDesign.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxUIDesign.TabIndex = 0;
            picBoxUIDesign.TabStop = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.White;
            btnSignUp.FlatStyle = FlatStyle.Popup;
            btnSignUp.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignUp.Location = new Point(511, 373);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(78, 32);
            btnSignUp.TabIndex = 10;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(646, 452);
            Controls.Add(btnSignUp);
            Controls.Add(lblAccountText);
            Controls.Add(button1);
            Controls.Add(checkBoxForgot);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblText);
            Controls.Add(picBoxLogInIcon);
            Controls.Add(picBoxUIDesign);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxLogInIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxUIDesign).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picBoxLogInIcon;
        private Label lblText;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private CheckBox checkBoxForgot;
        private Button button1;
        private Label lblAccountText;
        private PictureBox picBoxUIDesign;
        private Button btnSignUp;
    }
}
