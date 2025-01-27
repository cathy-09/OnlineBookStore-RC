namespace BookStore
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            picBoxUIDesign = new PictureBox();
            chLBListBooks = new CheckedListBox();
            linkLabelUserInfo = new LinkLabel();
            gBInfoBook = new GroupBox();
            lblInformationText = new Label();
            btnOrderNow = new Button();
            btnGoBack = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxUIDesign).BeginInit();
            gBInfoBook.SuspendLayout();
            SuspendLayout();
            // 
            // picBoxUIDesign
            // 
            picBoxUIDesign.Image = (Image)resources.GetObject("picBoxUIDesign.Image");
            picBoxUIDesign.Location = new Point(-129, 0);
            picBoxUIDesign.Name = "picBoxUIDesign";
            picBoxUIDesign.Size = new Size(1036, 550);
            picBoxUIDesign.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxUIDesign.TabIndex = 12;
            picBoxUIDesign.TabStop = false;
            // 
            // chLBListBooks
            // 
            chLBListBooks.FormattingEnabled = true;
            chLBListBooks.Location = new Point(12, 258);
            chLBListBooks.Name = "chLBListBooks";
            chLBListBooks.Size = new Size(748, 472);
            chLBListBooks.TabIndex = 13;
            // 
            // linkLabelUserInfo
            // 
            linkLabelUserInfo.ActiveLinkColor = Color.RosyBrown;
            linkLabelUserInfo.AutoSize = true;
            linkLabelUserInfo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabelUserInfo.LinkColor = Color.FromArgb(255, 128, 0);
            linkLabelUserInfo.Location = new Point(6, 23);
            linkLabelUserInfo.Name = "linkLabelUserInfo";
            linkLabelUserInfo.Size = new Size(52, 19);
            linkLabelUserInfo.TabIndex = 14;
            linkLabelUserInfo.TabStop = true;
            linkLabelUserInfo.Text = "@User";
            // 
            // gBInfoBook
            // 
            gBInfoBook.Controls.Add(lblInformationText);
            gBInfoBook.Controls.Add(linkLabelUserInfo);
            gBInfoBook.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gBInfoBook.ForeColor = Color.FromArgb(255, 128, 0);
            gBInfoBook.Location = new Point(12, 198);
            gBInfoBook.Name = "gBInfoBook";
            gBInfoBook.Size = new Size(748, 54);
            gBInfoBook.TabIndex = 15;
            gBInfoBook.TabStop = false;
            gBInfoBook.Text = "User Info";
            // 
            // lblInformationText
            // 
            lblInformationText.AutoSize = true;
            lblInformationText.Location = new Point(602, 23);
            lblInformationText.Name = "lblInformationText";
            lblInformationText.Size = new Size(140, 19);
            lblInformationText.TabIndex = 16;
            lblInformationText.Text = "Make Your Order";
            // 
            // btnOrderNow
            // 
            btnOrderNow.BackColor = Color.White;
            btnOrderNow.FlatStyle = FlatStyle.Popup;
            btnOrderNow.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrderNow.ForeColor = Color.FromArgb(255, 128, 0);
            btnOrderNow.Location = new Point(12, 740);
            btnOrderNow.Name = "btnOrderNow";
            btnOrderNow.Size = new Size(363, 36);
            btnOrderNow.TabIndex = 17;
            btnOrderNow.Text = "Order Now";
            btnOrderNow.UseVisualStyleBackColor = false;
            btnOrderNow.Click += btnOrderNow_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.White;
            btnGoBack.FlatStyle = FlatStyle.Popup;
            btnGoBack.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoBack.ForeColor = Color.FromArgb(255, 128, 0);
            btnGoBack.Location = new Point(388, 740);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(372, 36);
            btnGoBack.TabIndex = 18;
            btnGoBack.Text = "Go Back To Main";
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 788);
            Controls.Add(btnGoBack);
            Controls.Add(btnOrderNow);
            Controls.Add(gBInfoBook);
            Controls.Add(chLBListBooks);
            Controls.Add(picBoxUIDesign);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)picBoxUIDesign).EndInit();
            gBInfoBook.ResumeLayout(false);
            gBInfoBook.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBoxUIDesign;
        private CheckedListBox chLBListBooks;
        private LinkLabel linkLabelUserInfo;
        private GroupBox gBInfoBook;
        private Label lblInformationText;
        private Button btnOrderNow;
        private Button btnGoBack;
    }
}