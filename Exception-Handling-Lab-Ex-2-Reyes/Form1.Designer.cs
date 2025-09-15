namespace Exception_Handling_Lab_Ex_2_Reyes
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblMfgDate = new System.Windows.Forms.Label();
            this.dtPickerMfgDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.dtPickerExpDate = new System.Windows.Forms.DateTimePicker();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.lblDiscription = new System.Windows.Forms.Label();
            this.richTxtDiscription = new System.Windows.Forms.RichTextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gridViewProductList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblAddProduct.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.ForeColor = System.Drawing.Color.Indigo;
            this.lblAddProduct.Location = new System.Drawing.Point(13, 13);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(162, 31);
            this.lblAddProduct.TabIndex = 0;
            this.lblAddProduct.Text = "Add Product";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Indigo;
            this.lblProduct.Location = new System.Drawing.Point(13, 59);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(75, 21);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product:";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.Thistle;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(115, 58);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(258, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Indigo;
            this.lblCategory.Location = new System.Drawing.Point(13, 90);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 21);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Thistle;
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCategory.Font = new System.Drawing.Font("Book Antiqua", 9F);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(115, 91);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(258, 24);
            this.cbCategory.TabIndex = 4;
            // 
            // lblMfgDate
            // 
            this.lblMfgDate.AutoSize = true;
            this.lblMfgDate.BackColor = System.Drawing.Color.Transparent;
            this.lblMfgDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMfgDate.ForeColor = System.Drawing.Color.Indigo;
            this.lblMfgDate.Location = new System.Drawing.Point(13, 122);
            this.lblMfgDate.Name = "lblMfgDate";
            this.lblMfgDate.Size = new System.Drawing.Size(97, 21);
            this.lblMfgDate.TabIndex = 5;
            this.lblMfgDate.Text = "MFG Date:";
            // 
            // dtPickerMfgDate
            // 
            this.dtPickerMfgDate.CalendarFont = new System.Drawing.Font("Book Antiqua", 9F);
            this.dtPickerMfgDate.CalendarForeColor = System.Drawing.Color.Indigo;
            this.dtPickerMfgDate.CalendarMonthBackground = System.Drawing.Color.Thistle;
            this.dtPickerMfgDate.CalendarTitleBackColor = System.Drawing.Color.Thistle;
            this.dtPickerMfgDate.CalendarTitleForeColor = System.Drawing.Color.Thistle;
            this.dtPickerMfgDate.CalendarTrailingForeColor = System.Drawing.Color.Indigo;
            this.dtPickerMfgDate.Font = new System.Drawing.Font("Book Antiqua", 9F);
            this.dtPickerMfgDate.Location = new System.Drawing.Point(115, 122);
            this.dtPickerMfgDate.Name = "dtPickerMfgDate";
            this.dtPickerMfgDate.Size = new System.Drawing.Size(258, 22);
            this.dtPickerMfgDate.TabIndex = 6;
            this.dtPickerMfgDate.Value = new System.DateTime(2025, 9, 15, 0, 0, 0, 0);
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.BackColor = System.Drawing.Color.Transparent;
            this.lblExpDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDate.ForeColor = System.Drawing.Color.Indigo;
            this.lblExpDate.Location = new System.Drawing.Point(15, 152);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(95, 21);
            this.lblExpDate.TabIndex = 7;
            this.lblExpDate.Text = "EXP Date:";
            // 
            // dtPickerExpDate
            // 
            this.dtPickerExpDate.CalendarFont = new System.Drawing.Font("Book Antiqua", 9F);
            this.dtPickerExpDate.CalendarForeColor = System.Drawing.Color.Indigo;
            this.dtPickerExpDate.CalendarMonthBackground = System.Drawing.Color.Thistle;
            this.dtPickerExpDate.CalendarTitleBackColor = System.Drawing.Color.Thistle;
            this.dtPickerExpDate.CalendarTitleForeColor = System.Drawing.Color.Thistle;
            this.dtPickerExpDate.CalendarTrailingForeColor = System.Drawing.Color.Indigo;
            this.dtPickerExpDate.Font = new System.Drawing.Font("Book Antiqua", 9F);
            this.dtPickerExpDate.Location = new System.Drawing.Point(115, 152);
            this.dtPickerExpDate.Name = "dtPickerExpDate";
            this.dtPickerExpDate.Size = new System.Drawing.Size(258, 22);
            this.dtPickerExpDate.TabIndex = 8;
            this.dtPickerExpDate.Value = new System.DateTime(2025, 9, 15, 0, 0, 0, 0);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Indigo;
            this.lblQuantity.Location = new System.Drawing.Point(15, 182);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(82, 21);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Thistle;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(115, 184);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(258, 22);
            this.txtQuantity.TabIndex = 10;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Indigo;
            this.lblPrice.Location = new System.Drawing.Point(15, 214);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(90, 21);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Sell Price:";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.BackColor = System.Drawing.Color.Thistle;
            this.txtSellPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSellPrice.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellPrice.Location = new System.Drawing.Point(115, 214);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(258, 22);
            this.txtSellPrice.TabIndex = 12;
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscription.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscription.ForeColor = System.Drawing.Color.Indigo;
            this.lblDiscription.Location = new System.Drawing.Point(424, 59);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(102, 21);
            this.lblDiscription.TabIndex = 13;
            this.lblDiscription.Text = "Discription:";
            // 
            // richTxtDiscription
            // 
            this.richTxtDiscription.BackColor = System.Drawing.Color.Thistle;
            this.richTxtDiscription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTxtDiscription.Font = new System.Drawing.Font("Book Antiqua", 9F);
            this.richTxtDiscription.Location = new System.Drawing.Point(438, 84);
            this.richTxtDiscription.Name = "richTxtDiscription";
            this.richTxtDiscription.Size = new System.Drawing.Size(313, 151);
            this.richTxtDiscription.TabIndex = 14;
            this.richTxtDiscription.Text = "";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Thistle;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProduct.Font = new System.Drawing.Font("Book Antiqua", 9F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.Indigo;
            this.btnAddProduct.Location = new System.Drawing.Point(652, 241);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(99, 25);
            this.btnAddProduct.TabIndex = 15;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // gridViewProductList
            // 
            this.gridViewProductList.AllowUserToOrderColumns = true;
            this.gridViewProductList.BackgroundColor = System.Drawing.Color.Thistle;
            this.gridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProductList.GridColor = System.Drawing.Color.Lavender;
            this.gridViewProductList.Location = new System.Drawing.Point(17, 273);
            this.gridViewProductList.Name = "gridViewProductList";
            this.gridViewProductList.Size = new System.Drawing.Size(734, 165);
            this.gridViewProductList.TabIndex = 16;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.gridViewProductList);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.richTxtDiscription);
            this.Controls.Add(this.lblDiscription);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.dtPickerExpDate);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.dtPickerMfgDate);
            this.Controls.Add(this.lblMfgDate);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblAddProduct);
            this.Name = "frmAddProduct";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblMfgDate;
        private System.Windows.Forms.DateTimePicker dtPickerMfgDate;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.DateTimePicker dtPickerExpDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label lblDiscription;
        private System.Windows.Forms.RichTextBox richTxtDiscription;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView gridViewProductList;
    }
}

