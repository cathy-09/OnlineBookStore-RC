namespace BookStore
{
    partial class CartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            picBoxUIDesign = new PictureBox();
            lBOrder = new ListBox();
            lblConfirm = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            lblUserDetails = new Label();
            lBDetailsUser = new ListBox();
            btnOrderNow = new Button();
            btnGoBack = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxUIDesign).BeginInit();
            SuspendLayout();
            // 
            // picBoxUIDesign
            // 
            picBoxUIDesign.Image = (Image)resources.GetObject("picBoxUIDesign.Image");
            picBoxUIDesign.Location = new Point(-90, -10);
            picBoxUIDesign.Name = "picBoxUIDesign";
            picBoxUIDesign.Size = new Size(843, 469);
            picBoxUIDesign.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxUIDesign.TabIndex = 13;
            picBoxUIDesign.TabStop = false;
            // 
            // lBOrder
            // 
            lBOrder.FormattingEnabled = true;
            lBOrder.ItemHeight = 15;
            lBOrder.Location = new Point(12, 188);
            lBOrder.Name = "lBOrder";
            lBOrder.Size = new Size(617, 154);
            lBOrder.TabIndex = 14;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirm.ForeColor = Color.FromArgb(255, 128, 0);
            lblConfirm.Location = new Point(12, 160);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(215, 25);
            lblConfirm.TabIndex = 15;
            lblConfirm.Text = "Confirm Your Order:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(529, 362);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 25);
            txtPrice.TabIndex = 16;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.FromArgb(255, 128, 0);
            lblPrice.Location = new Point(393, 362);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(121, 25);
            lblPrice.TabIndex = 17;
            lblPrice.Text = "Total Price:";
            // 
            // lblUserDetails
            // 
            lblUserDetails.AutoSize = true;
            lblUserDetails.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserDetails.ForeColor = Color.FromArgb(255, 128, 0);
            lblUserDetails.Location = new Point(12, 387);
            lblUserDetails.Name = "lblUserDetails";
            lblUserDetails.Size = new Size(148, 25);
            lblUserDetails.TabIndex = 18;
            lblUserDetails.Text = "Buyer Details:";
            // 
            // lBDetailsUser
            // 
            lBDetailsUser.FormattingEnabled = true;
            lBDetailsUser.ItemHeight = 15;
            lBDetailsUser.Location = new Point(12, 424);
            lBDetailsUser.Name = "lBDetailsUser";
            lBDetailsUser.Size = new Size(617, 34);
            lBDetailsUser.TabIndex = 19;
            // 
            // btnOrderNow
            // 
            btnOrderNow.BackColor = Color.White;
            btnOrderNow.FlatStyle = FlatStyle.Popup;
            btnOrderNow.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrderNow.ForeColor = Color.FromArgb(255, 128, 0);
            btnOrderNow.Location = new Point(12, 464);
            btnOrderNow.Name = "btnOrderNow";
            btnOrderNow.Size = new Size(617, 36);
            btnOrderNow.TabIndex = 20;
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
            btnGoBack.Location = new Point(12, 506);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(617, 36);
            btnGoBack.TabIndex = 21;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 552);
            Controls.Add(btnGoBack);
            Controls.Add(btnOrderNow);
            Controls.Add(lBDetailsUser);
            Controls.Add(lblUserDetails);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblConfirm);
            Controls.Add(lBOrder);
            Controls.Add(picBoxUIDesign);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CartForm";
            Load += CartForm_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxUIDesign).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxUIDesign;
        private ListBox lBOrder;
        private Label lblConfirm;
        private TextBox txtPrice;
        private Label lblPrice;
        private Label lblUserDetails;
        private ListBox lBDetailsUser;
        private Button btnOrderNow;
        private Button btnGoBack;
    }
}