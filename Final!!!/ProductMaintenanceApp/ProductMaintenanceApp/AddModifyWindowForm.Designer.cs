namespace ProductMaintenanceApp
{
    partial class AddModifyWindowForm
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
            tbProductCode = new TextBox();
            tbName = new TextBox();
            tbVersion = new TextBox();
            tbReleaseDate = new TextBox();
            lbProductCode = new Label();
            lbName = new Label();
            lbVersion = new Label();
            lbReleaseDate = new Label();
            btOK = new Button();
            btCancel = new Button();
            SuspendLayout();
            // 
            // tbProductCode
            // 
            tbProductCode.Location = new Point(189, 71);
            tbProductCode.Name = "tbProductCode";
            tbProductCode.Size = new Size(168, 25);
            tbProductCode.TabIndex = 0;
            tbProductCode.TextChanged += textBox1_TextChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(189, 130);
            tbName.Name = "tbName";
            tbName.Size = new Size(252, 25);
            tbName.TabIndex = 1;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // tbVersion
            // 
            tbVersion.Location = new Point(189, 184);
            tbVersion.Name = "tbVersion";
            tbVersion.Size = new Size(168, 25);
            tbVersion.TabIndex = 2;
            tbVersion.TextChanged += tbVersion_TextChanged;
            // 
            // tbReleaseDate
            // 
            tbReleaseDate.Location = new Point(189, 233);
            tbReleaseDate.Name = "tbReleaseDate";
            tbReleaseDate.Size = new Size(168, 25);
            tbReleaseDate.TabIndex = 3;
            tbReleaseDate.TextChanged += tbReleaseDate_TextChanged;
            // 
            // lbProductCode
            // 
            lbProductCode.AutoSize = true;
            lbProductCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProductCode.Location = new Point(42, 74);
            lbProductCode.Name = "lbProductCode";
            lbProductCode.Size = new Size(91, 17);
            lbProductCode.TabIndex = 4;
            lbProductCode.Text = "Product Code:";
            lbProductCode.Click += lbProductCode_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.Location = new Point(42, 133);
            lbName.Name = "lbName";
            lbName.Size = new Size(46, 17);
            lbName.TabIndex = 5;
            lbName.Text = "Name:";
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVersion.Location = new Point(42, 187);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(54, 17);
            lbVersion.TabIndex = 6;
            lbVersion.Text = "Version:";
            // 
            // lbReleaseDate
            // 
            lbReleaseDate.AutoSize = true;
            lbReleaseDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbReleaseDate.Location = new Point(42, 237);
            lbReleaseDate.Name = "lbReleaseDate";
            lbReleaseDate.Size = new Size(86, 17);
            lbReleaseDate.TabIndex = 7;
            lbReleaseDate.Text = "Release date:";
            // 
            // btOK
            // 
            btOK.BackColor = SystemColors.ButtonShadow;
            btOK.Location = new Point(188, 300);
            btOK.Name = "btOK";
            btOK.Size = new Size(93, 34);
            btOK.TabIndex = 8;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = false;
            btOK.Click += btOK_Click;
            // 
            // btCancel
            // 
            btCancel.BackColor = SystemColors.ButtonShadow;
            btCancel.Location = new Point(310, 300);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(93, 34);
            btCancel.TabIndex = 9;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // AddModifyWindowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 380);
            Controls.Add(btCancel);
            Controls.Add(btOK);
            Controls.Add(lbReleaseDate);
            Controls.Add(lbVersion);
            Controls.Add(lbName);
            Controls.Add(lbProductCode);
            Controls.Add(tbReleaseDate);
            Controls.Add(tbVersion);
            Controls.Add(tbName);
            Controls.Add(tbProductCode);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AddModifyWindowForm";
            Text = "Add or Modify Product";
            Load += AddModifyFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbProductCode;
        private TextBox tbName;
        private TextBox tbVersion;
        private TextBox tbReleaseDate;
        private Label lbProductCode;
        private Label lbName;
        private Label lbVersion;
        private Label lbReleaseDate;
        private Button btOK;
        private Button btCancel;
    }
}