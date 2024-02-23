namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            lbManuafacturer = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            lbReleaseYear = new System.Windows.Forms.Label();
            txtCarID = new System.Windows.Forms.TextBox();
            txtCarName = new System.Windows.Forms.TextBox();
            txtManufacturer = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtReleaseYear = new System.Windows.Forms.TextBox();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            dgvCarList = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(39, 28);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(50, 20);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(39, 75);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(75, 20);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManuafacturer
            // 
            lbManuafacturer.AutoSize = true;
            lbManuafacturer.Location = new System.Drawing.Point(39, 132);
            lbManuafacturer.Name = "lbManuafacturer";
            lbManuafacturer.Size = new System.Drawing.Size(97, 20);
            lbManuafacturer.TabIndex = 2;
            lbManuafacturer.Text = "Manufacturer";
            lbManuafacturer.Click += lbManuafacturer_Click;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(433, 24);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(41, 20);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new System.Drawing.Point(433, 71);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new System.Drawing.Size(92, 20);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Release Year";
            lbReleaseYear.Click += label5_Click;
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(150, 24);
            txtCarID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(240, 27);
            txtCarID.TabIndex = 5;
            txtCarID.Click += txtCarID_Click;
            txtCarID.TextChanged += textBox1_TextChanged;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(150, 71);
            txtCarName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(240, 27);
            txtCarName.TabIndex = 6;
            txtCarName.Click += txtCarName_Click;
            txtCarName.TextChanged += txtCarName_TextChanged;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new System.Drawing.Point(150, 128);
            txtManufacturer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new System.Drawing.Size(240, 27);
            txtManufacturer.TabIndex = 7;
            txtManufacturer.Click += txtManufacturer_Click;
            txtManufacturer.TextChanged += txtManufacturer_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(541, 28);
            txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(240, 27);
            txtPrice.TabIndex = 8;
            txtPrice.Click += txtPrice_Click;
            txtPrice.TextChanged += textBox4_TextChanged;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(541, 75);
            txtReleaseYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(240, 27);
            txtReleaseYear.TabIndex = 9;
            txtReleaseYear.Click += txtReleaseYear_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(150, 183);
            btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(108, 31);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(366, 183);
            btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(108, 31);
            btnNew.TabIndex = 11;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(563, 183);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(108, 31);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new System.Drawing.Point(9, 252);
            dgvCarList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 25;
            dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new System.Drawing.Size(828, 280);
            dgvCarList.TabIndex = 13;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(366, 556);
            btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(108, 31);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(849, 600);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManuafacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmCarManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbManuafacturer;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Button btnClose;
    }
}