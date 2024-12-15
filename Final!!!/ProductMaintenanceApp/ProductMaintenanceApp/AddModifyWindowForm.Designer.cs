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
            tbReleseDate = new TextBox();
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
            tbProductCode.Location = new Point(189, 63);
            tbProductCode.Name = "tbProductCode";
            tbProductCode.Size = new Size(168, 23);
            tbProductCode.TabIndex = 0;
            tbProductCode.TextChanged += textBox1_TextChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(189, 114);
            tbName.Name = "tbName";
            tbName.Size = new Size(252, 23);
            tbName.TabIndex = 1;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // tbVersion
            // 
            tbVersion.Location = new Point(189, 162);
            tbVersion.Name = "tbVersion";
            tbVersion.Size = new Size(168, 23);
            tbVersion.TabIndex = 2;
            tbVersion.TextChanged += tbVersion_TextChanged;
            // 
            // tbReleseDate
            // 
            tbReleseDate.Location = new Point(189, 206);
            tbReleseDate.Name = "tbReleseDate";
            tbReleseDate.Size = new Size(168, 23);
            tbReleseDate.TabIndex = 3;
            tbReleseDate.TextChanged += tbReleseDate_TextChanged;
            // 
            // lbProductCode
            // 
            lbProductCode.AutoSize = true;
            lbProductCode.Location = new Point(42, 66);
            lbProductCode.Name = "lbProductCode";
            lbProductCode.Size = new Size(83, 15);
            lbProductCode.TabIndex = 4;
            lbProductCode.Text = "Product Code:";
            lbProductCode.Click += lbProductCode_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(42, 117);
            lbName.Name = "lbName";
            lbName.Size = new Size(42, 15);
            lbName.TabIndex = 5;
            lbName.Text = "Name:";
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Location = new Point(42, 165);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(48, 15);
            lbVersion.TabIndex = 6;
            lbVersion.Text = "Version:";
            // 
            // lbReleaseDate
            // 
            lbReleaseDate.AutoSize = true;
            lbReleaseDate.Location = new Point(42, 209);
            lbReleaseDate.Name = "lbReleaseDate";
            lbReleaseDate.Size = new Size(75, 15);
            lbReleaseDate.TabIndex = 7;
            lbReleaseDate.Text = "Release date:";
            // 
            // btOK
            // 
            btOK.BackColor = SystemColors.ButtonShadow;
            btOK.Location = new Point(188, 264);
            btOK.Name = "btOK";
            btOK.Size = new Size(93, 30);
            btOK.TabIndex = 8;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = false;
            btOK.Click += btOK_Click;
            // 
            // btCancel
            // 
            btCancel.BackColor = SystemColors.ButtonShadow;
            btCancel.Location = new Point(310, 264);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(93, 30);
            btCancel.TabIndex = 9;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // AddModifyWindowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 335);
            Controls.Add(btCancel);
            Controls.Add(btOK);
            Controls.Add(lbReleaseDate);
            Controls.Add(lbVersion);
            Controls.Add(lbName);
            Controls.Add(lbProductCode);
            Controls.Add(tbReleseDate);
            Controls.Add(tbVersion);
            Controls.Add(tbName);
            Controls.Add(tbProductCode);
            Name = "AddModifyWindowForm";
            Text = "Add or Modify Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbProductCode;
        private TextBox tbName;
        private TextBox tbVersion;
        private TextBox tbReleseDate;
        private Label lbProductCode;
        private Label lbName;
        private Label lbVersion;
        private Label lbReleaseDate;
        private Button btOK;
        private Button btCancel;
    }
}