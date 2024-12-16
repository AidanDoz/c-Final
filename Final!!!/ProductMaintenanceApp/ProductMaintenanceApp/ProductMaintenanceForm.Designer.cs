namespace ProductMaintenanceApp
{
    partial class ProductMaintenanceForm
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
            btnAdd = new Button();
            btnModify = new Button();
            btnRemove = new Button();
            btnExit = new Button();
            lstProduct = new ListBox();
            lblHdrProductCode = new Label();
            lblHdrName = new Label();
            lblHdrVersion = new Label();
            lblHdrReleaseDate = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlDark;
            btnAdd.Location = new Point(40, 320);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 32);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = SystemColors.ControlDark;
            btnModify.Location = new Point(185, 320);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(124, 32);
            btnModify.TabIndex = 1;
            btnModify.Text = "&Modify";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.ControlDark;
            btnRemove.Location = new Point(330, 320);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(124, 32);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "&Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ControlDark;
            btnExit.Location = new Point(614, 320);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(124, 32);
            btnExit.TabIndex = 3;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lstProduct
            // 
            lstProduct.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstProduct.FormattingEnabled = true;
            lstProduct.ItemHeight = 15;
            lstProduct.Location = new Point(40, 45);
            lstProduct.Name = "lstProduct";
            lstProduct.Size = new Size(698, 259);
            lstProduct.TabIndex = 4;
            lstProduct.SelectedIndexChanged += lstProduct_SelectedIndexChanged;
            // 
            // lblHdrProductCode
            // 
            lblHdrProductCode.AutoSize = true;
            lblHdrProductCode.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHdrProductCode.Location = new Point(40, 27);
            lblHdrProductCode.Name = "lblHdrProductCode";
            lblHdrProductCode.Size = new Size(91, 15);
            lblHdrProductCode.TabIndex = 9;
            lblHdrProductCode.Text = "Product Code";
            // 
            // lblHdrName
            // 
            lblHdrName.AutoSize = true;
            lblHdrName.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHdrName.Location = new Point(152, 27);
            lblHdrName.Name = "lblHdrName";
            lblHdrName.Size = new Size(35, 15);
            lblHdrName.TabIndex = 10;
            lblHdrName.Text = "Name";
            // 
            // lblHdrVersion
            // 
            lblHdrVersion.AutoSize = true;
            lblHdrVersion.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHdrVersion.Location = new Point(485, 27);
            lblHdrVersion.Name = "lblHdrVersion";
            lblHdrVersion.Size = new Size(56, 15);
            lblHdrVersion.TabIndex = 11;
            lblHdrVersion.Text = "Version";
            // 
            // lblHdrReleaseDate
            // 
            lblHdrReleaseDate.AutoSize = true;
            lblHdrReleaseDate.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHdrReleaseDate.Location = new Point(598, 27);
            lblHdrReleaseDate.Name = "lblHdrReleaseDate";
            lblHdrReleaseDate.Size = new Size(91, 15);
            lblHdrReleaseDate.TabIndex = 12;
            lblHdrReleaseDate.Text = "Release Date";
            // 
            // ProductMaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 382);
            Controls.Add(lblHdrReleaseDate);
            Controls.Add(lblHdrVersion);
            Controls.Add(lblHdrName);
            Controls.Add(lblHdrProductCode);
            Controls.Add(lstProduct);
            Controls.Add(btnExit);
            Controls.Add(btnRemove);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Name = "ProductMaintenanceForm";
            Text = "Product Maintenance";
            Load += ProductMaintenanceFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnModify;
        private Button btnRemove;
        private Button btnExit;
        private ListBox lstProduct;
        private Label lblHdrProductCode;
        private Label lblHdrName;
        private Label lblHdrVersion;
        private Label lblHdrReleaseDate;
    }
}
