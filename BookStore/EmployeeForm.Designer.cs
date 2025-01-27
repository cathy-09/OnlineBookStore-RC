namespace BookStore
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            picBoxUIDesign = new PictureBox();
            btnWarehouse = new Button();
            gBEmployeesBoard = new GroupBox();
            lblInformationText = new Label();
            btnShopping = new Button();
            linkLabelUserInfo = new LinkLabel();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxUIDesign).BeginInit();
            gBEmployeesBoard.SuspendLayout();
            SuspendLayout();
            // 
            // picBoxUIDesign
            // 
            picBoxUIDesign.Image = (Image)resources.GetObject("picBoxUIDesign.Image");
            picBoxUIDesign.Location = new Point(-119, -4);
            picBoxUIDesign.Name = "picBoxUIDesign";
            picBoxUIDesign.Size = new Size(967, 522);
            picBoxUIDesign.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxUIDesign.TabIndex = 14;
            picBoxUIDesign.TabStop = false;
            // 
            // btnWarehouse
            // 
            btnWarehouse.BackColor = Color.White;
            btnWarehouse.FlatStyle = FlatStyle.Popup;
            btnWarehouse.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnWarehouse.ForeColor = Color.FromArgb(255, 128, 0);
            btnWarehouse.Location = new Point(17, 66);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(212, 31);
            btnWarehouse.TabIndex = 44;
            btnWarehouse.Text = "Go To Warehouse";
            btnWarehouse.UseVisualStyleBackColor = false;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // gBEmployeesBoard
            // 
            gBEmployeesBoard.Controls.Add(lblInformationText);
            gBEmployeesBoard.Controls.Add(btnShopping);
            gBEmployeesBoard.Controls.Add(linkLabelUserInfo);
            gBEmployeesBoard.Controls.Add(btnExit);
            gBEmployeesBoard.Controls.Add(btnWarehouse);
            gBEmployeesBoard.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            gBEmployeesBoard.ForeColor = Color.FromArgb(255, 128, 0);
            gBEmployeesBoard.Location = new Point(12, 207);
            gBEmployeesBoard.Name = "gBEmployeesBoard";
            gBEmployeesBoard.Size = new Size(683, 110);
            gBEmployeesBoard.TabIndex = 45;
            gBEmployeesBoard.TabStop = false;
            gBEmployeesBoard.Text = "Employees Board";
            // 
            // lblInformationText
            // 
            lblInformationText.AutoSize = true;
            lblInformationText.Location = new Point(414, 29);
            lblInformationText.Name = "lblInformationText";
            lblInformationText.Size = new Size(251, 25);
            lblInformationText.TabIndex = 47;
            lblInformationText.Text = "You can also shop here";
            // 
            // btnShopping
            // 
            btnShopping.BackColor = Color.White;
            btnShopping.FlatStyle = FlatStyle.Popup;
            btnShopping.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnShopping.ForeColor = Color.FromArgb(255, 128, 0);
            btnShopping.Location = new Point(235, 66);
            btnShopping.Name = "btnShopping";
            btnShopping.Size = new Size(212, 31);
            btnShopping.TabIndex = 46;
            btnShopping.Text = "Shopping";
            btnShopping.UseVisualStyleBackColor = false;
            btnShopping.Click += btnShopping_Click;
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
            btnExit.Location = new Point(453, 66);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(212, 31);
            btnExit.TabIndex = 45;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 353);
            Controls.Add(gBEmployeesBoard);
            Controls.Add(picBoxUIDesign);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)picBoxUIDesign).EndInit();
            gBEmployeesBoard.ResumeLayout(false);
            gBEmployeesBoard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBoxUIDesign;
        private Button btnWarehouse;
        private GroupBox gBEmployeesBoard;
        private Button btnExit;
        private Button btnShopping;
        private Label lblInformationText;
        private LinkLabel linkLabelUserInfo;
    }
}