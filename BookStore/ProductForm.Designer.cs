namespace BookStore
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            picBoxUIDesign = new PictureBox();
            lBOrder = new ListBox();
            lBProducts = new ListBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            lblGenre = new Label();
            txtGenre = new TextBox();
            lblYear = new Label();
            txtYear = new TextBox();
            lblPublisher = new Label();
            txtPublisher = new TextBox();
            lblISBN = new Label();
            txtISBN = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblPageCount = new Label();
            txtPageCount = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnFulfill = new Button();
            btnLoad = new Button();
            btnExit = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxUIDesign).BeginInit();
            SuspendLayout();
            // 
            // picBoxUIDesign
            // 
            picBoxUIDesign.Image = (Image)resources.GetObject("picBoxUIDesign.Image");
            picBoxUIDesign.Location = new Point(-204, -4);
            picBoxUIDesign.Name = "picBoxUIDesign";
            picBoxUIDesign.Size = new Size(1435, 725);
            picBoxUIDesign.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxUIDesign.TabIndex = 13;
            picBoxUIDesign.TabStop = false;
            // 
            // lBOrder
            // 
            lBOrder.FormattingEnabled = true;
            lBOrder.ItemHeight = 15;
            lBOrder.Location = new Point(12, 727);
            lBOrder.Name = "lBOrder";
            lBOrder.Size = new Size(1001, 154);
            lBOrder.TabIndex = 15;
            // 
            // lBProducts
            // 
            lBProducts.FormattingEnabled = true;
            lBProducts.ItemHeight = 15;
            lBProducts.Location = new Point(12, 287);
            lBProducts.Name = "lBProducts";
            lBProducts.Size = new Size(1001, 289);
            lBProducts.TabIndex = 16;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 587);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(45, 21);
            lblTitle.TabIndex = 26;
            lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 611);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(173, 23);
            txtTitle.TabIndex = 25;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor.Location = new Point(12, 649);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(69, 21);
            lblAuthor.TabIndex = 28;
            lblAuthor.Text = "Author:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(12, 673);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(173, 23);
            txtAuthor.TabIndex = 27;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenre.Location = new Point(211, 649);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(63, 21);
            lblGenre.TabIndex = 32;
            lblGenre.Text = "Genre:";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(211, 673);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(173, 23);
            txtGenre.TabIndex = 31;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblYear.Location = new Point(211, 587);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(51, 21);
            lblYear.TabIndex = 30;
            lblYear.Text = "Year:";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(211, 611);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(173, 23);
            txtYear.TabIndex = 29;
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPublisher.Location = new Point(413, 649);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(81, 21);
            lblPublisher.TabIndex = 36;
            lblPublisher.Text = "Publisher:";
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(413, 673);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(173, 23);
            txtPublisher.TabIndex = 35;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblISBN.Location = new Point(413, 587);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(48, 21);
            lblISBN.TabIndex = 34;
            lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(413, 611);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(173, 23);
            txtISBN.TabIndex = 33;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(606, 649);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(51, 21);
            lblPrice.TabIndex = 40;
            lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(606, 673);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(173, 23);
            txtPrice.TabIndex = 39;
            // 
            // lblPageCount
            // 
            lblPageCount.AutoSize = true;
            lblPageCount.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPageCount.Location = new Point(606, 587);
            lblPageCount.Name = "lblPageCount";
            lblPageCount.Size = new Size(109, 21);
            lblPageCount.TabIndex = 38;
            lblPageCount.Text = "Page Count:";
            // 
            // txtPageCount
            // 
            txtPageCount.Location = new Point(606, 611);
            txtPageCount.Name = "txtPageCount";
            txtPageCount.Size = new Size(173, 23);
            txtPageCount.TabIndex = 37;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(255, 128, 0);
            btnAdd.Location = new Point(801, 587);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(212, 31);
            btnAdd.TabIndex = 41;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.FromArgb(255, 128, 0);
            btnUpdate.Location = new Point(801, 629);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 31);
            btnUpdate.TabIndex = 42;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(255, 128, 0);
            btnDelete.Location = new Point(801, 673);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(212, 31);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFulfill
            // 
            btnFulfill.BackColor = Color.White;
            btnFulfill.FlatStyle = FlatStyle.Popup;
            btnFulfill.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFulfill.ForeColor = Color.FromArgb(255, 128, 0);
            btnFulfill.Location = new Point(354, 887);
            btnFulfill.Name = "btnFulfill";
            btnFulfill.Size = new Size(315, 31);
            btnFulfill.TabIndex = 44;
            btnFulfill.Text = "FulFill the Order";
            btnFulfill.UseVisualStyleBackColor = false;
            btnFulfill.Click += btnFulfill_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.White;
            btnLoad.FlatStyle = FlatStyle.Popup;
            btnLoad.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.ForeColor = Color.FromArgb(255, 128, 0);
            btnLoad.Location = new Point(12, 887);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(313, 31);
            btnLoad.TabIndex = 45;
            btnLoad.Text = "Load Orders";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(255, 128, 0);
            btnExit.Location = new Point(698, 887);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(315, 31);
            btnExit.TabIndex = 46;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(255, 128, 0);
            btnSave.Location = new Point(913, 629);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 31);
            btnSave.TabIndex = 47;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 928);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            Controls.Add(btnLoad);
            Controls.Add(btnFulfill);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblPageCount);
            Controls.Add(txtPageCount);
            Controls.Add(lblPublisher);
            Controls.Add(txtPublisher);
            Controls.Add(lblISBN);
            Controls.Add(txtISBN);
            Controls.Add(lblGenre);
            Controls.Add(txtGenre);
            Controls.Add(lblYear);
            Controls.Add(txtYear);
            Controls.Add(lblAuthor);
            Controls.Add(txtAuthor);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lBProducts);
            Controls.Add(lBOrder);
            Controls.Add(picBoxUIDesign);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxUIDesign).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxUIDesign;
        private ListBox lBOrder;
        private ListBox lBProducts;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private Label lblGenre;
        private TextBox txtGenre;
        private Label lblYear;
        private TextBox txtYear;
        private Label lblPublisher;
        private TextBox txtPublisher;
        private Label lblISBN;
        private TextBox txtISBN;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblPageCount;
        private TextBox txtPageCount;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnFulfill;
        private Button btnLoad;
        private Button btnExit;
        private Button btnSave;
    }
}