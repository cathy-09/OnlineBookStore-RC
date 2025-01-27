namespace BookStore
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            picBoxUIDesign = new PictureBox();
            gBEmployeesBoard = new GroupBox();
            lblInformationText = new Label();
            linkLabelUserInfo = new LinkLabel();
            btnExit = new Button();
            btnWarehouse = new Button();
            btnShopping = new Button();
            lBUsers = new ListBox();
            lBEmployees = new ListBox();
            lBAdmins = new ListBox();
            btnSaveUser = new Button();
            btnFired = new Button();
            btnUpdateUser = new Button();
            btnAppoint = new Button();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblEGN = new Label();
            label1 = new Label();
            txtEGN = new TextBox();
            txtLastName = new TextBox();
            lblSurname = new Label();
            lblFirstName = new Label();
            txtSurname = new TextBox();
            txtFirstName = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnSaveEmployee = new Button();
            btnUpdateEmployee = new Button();
            btnRest = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxUIDesign).BeginInit();
            gBEmployeesBoard.SuspendLayout();
            SuspendLayout();
            // 
            // picBoxUIDesign
            // 
            picBoxUIDesign.Image = (Image)resources.GetObject("picBoxUIDesign.Image");
            picBoxUIDesign.Location = new Point(-75, -2);
            picBoxUIDesign.Name = "picBoxUIDesign";
            picBoxUIDesign.Size = new Size(1151, 711);
            picBoxUIDesign.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxUIDesign.TabIndex = 14;
            picBoxUIDesign.TabStop = false;
            // 
            // gBEmployeesBoard
            // 
            gBEmployeesBoard.Controls.Add(lblInformationText);
            gBEmployeesBoard.Controls.Add(linkLabelUserInfo);
            gBEmployeesBoard.Controls.Add(btnExit);
            gBEmployeesBoard.Controls.Add(btnWarehouse);
            gBEmployeesBoard.Controls.Add(btnShopping);
            gBEmployeesBoard.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            gBEmployeesBoard.ForeColor = Color.FromArgb(255, 128, 0);
            gBEmployeesBoard.Location = new Point(24, 260);
            gBEmployeesBoard.Name = "gBEmployeesBoard";
            gBEmployeesBoard.Size = new Size(965, 110);
            gBEmployeesBoard.TabIndex = 46;
            gBEmployeesBoard.TabStop = false;
            gBEmployeesBoard.Text = "Employees Board";
            // 
            // lblInformationText
            // 
            lblInformationText.AutoSize = true;
            lblInformationText.Location = new Point(708, 29);
            lblInformationText.Name = "lblInformationText";
            lblInformationText.Size = new Size(251, 25);
            lblInformationText.TabIndex = 47;
            lblInformationText.Text = "You can also shop here";
            // 
            // linkLabelUserInfo
            // 
            linkLabelUserInfo.ActiveLinkColor = Color.RosyBrown;
            linkLabelUserInfo.AutoSize = true;
            linkLabelUserInfo.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabelUserInfo.LinkColor = Color.FromArgb(255, 128, 0);
            linkLabelUserInfo.Location = new Point(17, 29);
            linkLabelUserInfo.Name = "linkLabelUserInfo";
            linkLabelUserInfo.Size = new Size(71, 25);
            linkLabelUserInfo.TabIndex = 46;
            linkLabelUserInfo.TabStop = true;
            linkLabelUserInfo.Text = "@User";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(255, 128, 0);
            btnExit.Location = new Point(651, 66);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(308, 31);
            btnExit.TabIndex = 45;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnWarehouse
            // 
            btnWarehouse.BackColor = Color.White;
            btnWarehouse.FlatStyle = FlatStyle.Popup;
            btnWarehouse.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnWarehouse.ForeColor = Color.FromArgb(255, 128, 0);
            btnWarehouse.Location = new Point(17, 66);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(303, 31);
            btnWarehouse.TabIndex = 44;
            btnWarehouse.Text = "Go To Warehouse";
            btnWarehouse.UseVisualStyleBackColor = false;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // btnShopping
            // 
            btnShopping.BackColor = Color.White;
            btnShopping.FlatStyle = FlatStyle.Popup;
            btnShopping.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnShopping.ForeColor = Color.FromArgb(255, 128, 0);
            btnShopping.Location = new Point(334, 66);
            btnShopping.Name = "btnShopping";
            btnShopping.Size = new Size(303, 31);
            btnShopping.TabIndex = 46;
            btnShopping.Text = "Shopping";
            btnShopping.UseVisualStyleBackColor = false;
            btnShopping.Click += btnShopping_Click;
            // 
            // lBUsers
            // 
            lBUsers.FormattingEnabled = true;
            lBUsers.ItemHeight = 15;
            lBUsers.Location = new Point(24, 385);
            lBUsers.Name = "lBUsers";
            lBUsers.Size = new Size(698, 94);
            lBUsers.TabIndex = 48;
            // 
            // lBEmployees
            // 
            lBEmployees.FormattingEnabled = true;
            lBEmployees.ItemHeight = 15;
            lBEmployees.Location = new Point(24, 488);
            lBEmployees.Name = "lBEmployees";
            lBEmployees.Size = new Size(698, 94);
            lBEmployees.TabIndex = 49;
            // 
            // lBAdmins
            // 
            lBAdmins.FormattingEnabled = true;
            lBAdmins.ItemHeight = 15;
            lBAdmins.Location = new Point(24, 588);
            lBAdmins.Name = "lBAdmins";
            lBAdmins.Size = new Size(698, 94);
            lBAdmins.TabIndex = 50;
            // 
            // btnSaveUser
            // 
            btnSaveUser.BackColor = Color.White;
            btnSaveUser.FlatStyle = FlatStyle.Popup;
            btnSaveUser.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveUser.ForeColor = Color.FromArgb(255, 128, 0);
            btnSaveUser.Location = new Point(732, 436);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(251, 31);
            btnSaveUser.TabIndex = 54;
            btnSaveUser.Text = "Save User";
            btnSaveUser.UseVisualStyleBackColor = false;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // btnFired
            // 
            btnFired.BackColor = Color.White;
            btnFired.FlatStyle = FlatStyle.Popup;
            btnFired.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFired.ForeColor = Color.FromArgb(255, 128, 0);
            btnFired.Location = new Point(732, 640);
            btnFired.Name = "btnFired";
            btnFired.Size = new Size(251, 31);
            btnFired.TabIndex = 53;
            btnFired.Text = "Fired";
            btnFired.UseVisualStyleBackColor = false;
            btnFired.Click += btnFired_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.White;
            btnUpdateUser.FlatStyle = FlatStyle.Popup;
            btnUpdateUser.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateUser.ForeColor = Color.FromArgb(255, 128, 0);
            btnUpdateUser.Location = new Point(732, 399);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(251, 31);
            btnUpdateUser.TabIndex = 52;
            btnUpdateUser.Text = "Update User";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnAppoint
            // 
            btnAppoint.BackColor = Color.White;
            btnAppoint.FlatStyle = FlatStyle.Popup;
            btnAppoint.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAppoint.ForeColor = Color.FromArgb(255, 128, 0);
            btnAppoint.Location = new Point(732, 603);
            btnAppoint.Name = "btnAppoint";
            btnAppoint.Size = new Size(251, 31);
            btnAppoint.TabIndex = 51;
            btnAppoint.Text = "Appoint ";
            btnAppoint.UseVisualStyleBackColor = false;
            btnAppoint.Click += btnAppoint_Click;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.Location = new Point(596, 714);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(130, 21);
            lblPhoneNumber.TabIndex = 68;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(596, 738);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(173, 23);
            txtPhoneNumber.TabIndex = 67;
            // 
            // lblEGN
            // 
            lblEGN.AutoSize = true;
            lblEGN.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEGN.Location = new Point(793, 715);
            lblEGN.Name = "lblEGN";
            lblEGN.Size = new Size(49, 21);
            lblEGN.TabIndex = 66;
            lblEGN.Text = "EGN:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(405, 715);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 65;
            label1.Text = "Last name:";
            // 
            // txtEGN
            // 
            txtEGN.Location = new Point(793, 739);
            txtEGN.Name = "txtEGN";
            txtEGN.Size = new Size(173, 23);
            txtEGN.TabIndex = 64;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(404, 738);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(173, 23);
            txtLastName.TabIndex = 63;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSurname.Location = new Point(209, 715);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(83, 21);
            lblSurname.TabIndex = 62;
            lblSurname.Text = "Surname:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(12, 715);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(93, 21);
            lblFirstName.TabIndex = 61;
            lblFirstName.Text = "First name:";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(209, 739);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(173, 23);
            txtSurname.TabIndex = 60;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 739);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(173, 23);
            txtFirstName.TabIndex = 59;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(209, 775);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 21);
            lblPassword.TabIndex = 58;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(12, 775);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 21);
            lblUsername.TabIndex = 57;
            lblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(209, 799);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(173, 23);
            txtPassword.TabIndex = 56;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 799);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(173, 23);
            txtUsername.TabIndex = 55;
            // 
            // btnSaveEmployee
            // 
            btnSaveEmployee.BackColor = Color.White;
            btnSaveEmployee.FlatStyle = FlatStyle.Popup;
            btnSaveEmployee.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveEmployee.ForeColor = Color.FromArgb(255, 128, 0);
            btnSaveEmployee.Location = new Point(732, 539);
            btnSaveEmployee.Name = "btnSaveEmployee";
            btnSaveEmployee.Size = new Size(251, 31);
            btnSaveEmployee.TabIndex = 70;
            btnSaveEmployee.Text = "Save Employee";
            btnSaveEmployee.UseVisualStyleBackColor = false;
            btnSaveEmployee.Click += btnSaveEmployee_Click;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.BackColor = Color.White;
            btnUpdateEmployee.FlatStyle = FlatStyle.Popup;
            btnUpdateEmployee.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateEmployee.ForeColor = Color.FromArgb(255, 128, 0);
            btnUpdateEmployee.Location = new Point(732, 502);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(251, 31);
            btnUpdateEmployee.TabIndex = 69;
            btnUpdateEmployee.Text = "Update Employee";
            btnUpdateEmployee.UseVisualStyleBackColor = false;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // btnRest
            // 
            btnRest.BackColor = Color.White;
            btnRest.FlatStyle = FlatStyle.Popup;
            btnRest.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRest.ForeColor = Color.FromArgb(255, 128, 0);
            btnRest.Location = new Point(405, 775);
            btnRest.Name = "btnRest";
            btnRest.Size = new Size(364, 47);
            btnRest.TabIndex = 48;
            btnRest.Text = "Go To Rest";
            btnRest.UseVisualStyleBackColor = false;
            btnRest.Click += btnRest_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.White;
            btnLoad.FlatStyle = FlatStyle.Popup;
            btnLoad.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.ForeColor = Color.FromArgb(255, 128, 0);
            btnLoad.Location = new Point(793, 775);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(173, 47);
            btnLoad.TabIndex = 71;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 831);
            Controls.Add(btnLoad);
            Controls.Add(btnRest);
            Controls.Add(btnSaveEmployee);
            Controls.Add(btnUpdateEmployee);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblEGN);
            Controls.Add(label1);
            Controls.Add(txtEGN);
            Controls.Add(txtLastName);
            Controls.Add(lblSurname);
            Controls.Add(lblFirstName);
            Controls.Add(txtSurname);
            Controls.Add(txtFirstName);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnSaveUser);
            Controls.Add(btnFired);
            Controls.Add(btnUpdateUser);
            Controls.Add(btnAppoint);
            Controls.Add(lBAdmins);
            Controls.Add(lBEmployees);
            Controls.Add(lBUsers);
            Controls.Add(gBEmployeesBoard);
            Controls.Add(picBoxUIDesign);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)picBoxUIDesign).EndInit();
            gBEmployeesBoard.ResumeLayout(false);
            gBEmployeesBoard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxUIDesign;
        private GroupBox gBEmployeesBoard;
        private Label lblInformationText;
        private LinkLabel linkLabelUserInfo;
        private Button btnExit;
        private Button btnWarehouse;
        private Button btnShopping;
        private ListBox lBUsers;
        private ListBox lBEmployees;
        private ListBox lBAdmins;
        private Button btnSaveUser;
        private Button btnFired;
        private Button btnUpdateUser;
        private Button btnAppoint;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblEGN;
        private Label label1;
        private TextBox txtEGN;
        private TextBox txtLastName;
        private Label lblSurname;
        private Label lblFirstName;
        private TextBox txtSurname;
        private TextBox txtFirstName;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnSaveEmployee;
        private Button btnUpdateEmployee;
        private Button btnRest;
        private Button btnLoad;
    }
}