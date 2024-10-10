﻿namespace InventoryElijahSantos
{
    partial class frmAddProduct
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtProductName = new TextBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            richTxtDescription = new RichTextBox();
            gridViewProductList = new DataGridView();
            cbCategory = new ComboBox();
            btnAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 46);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 87);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 129);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Mfg. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 174);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 4;
            label5.Text = "Exp. Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 219);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 5;
            label6.Text = "Qty.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 265);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 6;
            label7.Text = "Sell Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(510, 11);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 7;
            label8.Text = "Description";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(112, 46);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(208, 23);
            txtProductName.TabIndex = 10;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(112, 129);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(208, 23);
            dtPickerMfgDate.TabIndex = 11;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(112, 166);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(208, 23);
            dtPickerExpDate.TabIndex = 12;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(112, 211);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(208, 23);
            txtQuantity.TabIndex = 13;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(112, 257);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(208, 23);
            txtSellPrice.TabIndex = 14;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(451, 43);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(285, 171);
            richTxtDescription.TabIndex = 15;
            richTxtDescription.Text = "";
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(27, 298);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(727, 150);
            gridViewProductList.TabIndex = 16;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(140, 87);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(180, 23);
            cbCategory.TabIndex = 17;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(569, 240);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 23);
            btnAddProduct.TabIndex = 18;
            btnAddProduct.Text = "button1";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddProduct);
            Controls.Add(cbCategory);
            Controls.Add(gridViewProductList);
            Controls.Add(richTxtDescription);
            Controls.Add(txtSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(txtProductName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddProduct";
            Text = "Inventory";
            Load += frmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtProductName;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private RichTextBox richTxtDescription;
        private DataGridView gridViewProductList;
        private ComboBox cbCategory;
        private Button btnAddProduct;
    }
}
