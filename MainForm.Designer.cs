namespace jordan_rowland_inventoryC968
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PartsSearch = new System.Windows.Forms.TextBox();
            this.btn_PartsSearch = new System.Windows.Forms.Button();
            this.dg_Parts = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_PartsDelete = new System.Windows.Forms.Button();
            this.btn_PartsEdit = new System.Windows.Forms.Button();
            this.btn_PartsAdd = new System.Windows.Forms.Button();
            this.btn_ProductsAdd = new System.Windows.Forms.Button();
            this.btn_ProductsEdit = new System.Windows.Forms.Button();
            this.btn_ProductsDelete = new System.Windows.Forms.Button();
            this.dg_Products = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ProductsSearch = new System.Windows.Forms.Button();
            this.txt_ProductSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Parts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parts";
            // 
            // txt_PartsSearch
            // 
            this.txt_PartsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PartsSearch.Location = new System.Drawing.Point(341, 105);
            this.txt_PartsSearch.Name = "txt_PartsSearch";
            this.txt_PartsSearch.Size = new System.Drawing.Size(232, 30);
            this.txt_PartsSearch.TabIndex = 2;
            // 
            // btn_PartsSearch
            // 
            this.btn_PartsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PartsSearch.Location = new System.Drawing.Point(235, 105);
            this.btn_PartsSearch.Name = "btn_PartsSearch";
            this.btn_PartsSearch.Size = new System.Drawing.Size(88, 30);
            this.btn_PartsSearch.TabIndex = 3;
            this.btn_PartsSearch.Text = "Search";
            this.btn_PartsSearch.UseVisualStyleBackColor = true;
            // 
            // dg_Parts
            // 
            this.dg_Parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Parts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.PartName,
            this.PartInventory,
            this.PartPrice,
            this.PartMin,
            this.PartMax});
            this.dg_Parts.Location = new System.Drawing.Point(18, 141);
            this.dg_Parts.Name = "dg_Parts";
            this.dg_Parts.RowHeadersWidth = 51;
            this.dg_Parts.RowTemplate.Height = 24;
            this.dg_Parts.Size = new System.Drawing.Size(555, 222);
            this.dg_Parts.TabIndex = 4;
            // 
            // PartID
            // 
            this.PartID.HeaderText = "Part ID";
            this.PartID.MinimumWidth = 6;
            this.PartID.Name = "PartID";
            this.PartID.Width = 50;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "Name";
            this.PartName.MinimumWidth = 6;
            this.PartName.Name = "PartName";
            this.PartName.Width = 125;
            // 
            // PartInventory
            // 
            this.PartInventory.HeaderText = "Inventory";
            this.PartInventory.MinimumWidth = 6;
            this.PartInventory.Name = "PartInventory";
            this.PartInventory.Width = 50;
            // 
            // PartPrice
            // 
            this.PartPrice.HeaderText = "Price";
            this.PartPrice.MinimumWidth = 6;
            this.PartPrice.Name = "PartPrice";
            this.PartPrice.Width = 50;
            // 
            // PartMin
            // 
            this.PartMin.HeaderText = "Min";
            this.PartMin.MinimumWidth = 6;
            this.PartMin.Name = "PartMin";
            this.PartMin.Width = 50;
            // 
            // PartMax
            // 
            this.PartMax.HeaderText = "Max";
            this.PartMax.MinimumWidth = 6;
            this.PartMax.Name = "PartMax";
            this.PartMax.Width = 50;
            // 
            // btn_PartsDelete
            // 
            this.btn_PartsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PartsDelete.Location = new System.Drawing.Point(485, 369);
            this.btn_PartsDelete.Name = "btn_PartsDelete";
            this.btn_PartsDelete.Size = new System.Drawing.Size(88, 30);
            this.btn_PartsDelete.TabIndex = 5;
            this.btn_PartsDelete.Text = "Delete";
            this.btn_PartsDelete.UseVisualStyleBackColor = true;
            // 
            // btn_PartsEdit
            // 
            this.btn_PartsEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PartsEdit.Location = new System.Drawing.Point(391, 369);
            this.btn_PartsEdit.Name = "btn_PartsEdit";
            this.btn_PartsEdit.Size = new System.Drawing.Size(88, 30);
            this.btn_PartsEdit.TabIndex = 6;
            this.btn_PartsEdit.Text = "Modify";
            this.btn_PartsEdit.UseVisualStyleBackColor = true;
            // 
            // btn_PartsAdd
            // 
            this.btn_PartsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PartsAdd.Location = new System.Drawing.Point(297, 369);
            this.btn_PartsAdd.Name = "btn_PartsAdd";
            this.btn_PartsAdd.Size = new System.Drawing.Size(88, 30);
            this.btn_PartsAdd.TabIndex = 7;
            this.btn_PartsAdd.Text = "Add";
            this.btn_PartsAdd.UseVisualStyleBackColor = true;
            this.btn_PartsAdd.Click += new System.EventHandler(this.btn_PartsAdd_Click);
            // 
            // btn_ProductsAdd
            // 
            this.btn_ProductsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductsAdd.Location = new System.Drawing.Point(906, 369);
            this.btn_ProductsAdd.Name = "btn_ProductsAdd";
            this.btn_ProductsAdd.Size = new System.Drawing.Size(88, 30);
            this.btn_ProductsAdd.TabIndex = 14;
            this.btn_ProductsAdd.Text = "Add";
            this.btn_ProductsAdd.UseVisualStyleBackColor = true;
            this.btn_ProductsAdd.Click += new System.EventHandler(this.btn_ProductsAdd_Click);
            // 
            // btn_ProductsEdit
            // 
            this.btn_ProductsEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductsEdit.Location = new System.Drawing.Point(1000, 369);
            this.btn_ProductsEdit.Name = "btn_ProductsEdit";
            this.btn_ProductsEdit.Size = new System.Drawing.Size(88, 30);
            this.btn_ProductsEdit.TabIndex = 13;
            this.btn_ProductsEdit.Text = "Modify";
            this.btn_ProductsEdit.UseVisualStyleBackColor = true;
            // 
            // btn_ProductsDelete
            // 
            this.btn_ProductsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductsDelete.Location = new System.Drawing.Point(1094, 369);
            this.btn_ProductsDelete.Name = "btn_ProductsDelete";
            this.btn_ProductsDelete.Size = new System.Drawing.Size(88, 30);
            this.btn_ProductsDelete.TabIndex = 12;
            this.btn_ProductsDelete.Text = "Delete";
            this.btn_ProductsDelete.UseVisualStyleBackColor = true;
            // 
            // dg_Products
            // 
            this.dg_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductInventory,
            this.ProductPrice,
            this.ProductMin,
            this.ProductMax});
            this.dg_Products.Location = new System.Drawing.Point(627, 141);
            this.dg_Products.Name = "dg_Products";
            this.dg_Products.RowHeadersWidth = 51;
            this.dg_Products.RowTemplate.Height = 24;
            this.dg_Products.Size = new System.Drawing.Size(555, 222);
            this.dg_Products.TabIndex = 11;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Part ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 50;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // ProductInventory
            // 
            this.ProductInventory.HeaderText = "Inventory";
            this.ProductInventory.MinimumWidth = 6;
            this.ProductInventory.Name = "ProductInventory";
            this.ProductInventory.Width = 50;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Width = 50;
            // 
            // ProductMin
            // 
            this.ProductMin.HeaderText = "Min";
            this.ProductMin.MinimumWidth = 6;
            this.ProductMin.Name = "ProductMin";
            this.ProductMin.Width = 50;
            // 
            // ProductMax
            // 
            this.ProductMax.HeaderText = "Max";
            this.ProductMax.MinimumWidth = 6;
            this.ProductMax.Name = "ProductMax";
            this.ProductMax.Width = 50;
            // 
            // btn_ProductsSearch
            // 
            this.btn_ProductsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductsSearch.Location = new System.Drawing.Point(844, 105);
            this.btn_ProductsSearch.Name = "btn_ProductsSearch";
            this.btn_ProductsSearch.Size = new System.Drawing.Size(88, 30);
            this.btn_ProductsSearch.TabIndex = 10;
            this.btn_ProductsSearch.Text = "Search";
            this.btn_ProductsSearch.UseVisualStyleBackColor = true;
            // 
            // txt_ProductSearch
            // 
            this.txt_ProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductSearch.Location = new System.Drawing.Point(950, 105);
            this.txt_ProductSearch.Name = "txt_ProductSearch";
            this.txt_ProductSearch.Size = new System.Drawing.Size(232, 30);
            this.txt_ProductSearch.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(639, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Products";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(1094, 453);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(88, 30);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 495);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ProductsAdd);
            this.Controls.Add(this.btn_ProductsEdit);
            this.Controls.Add(this.btn_ProductsDelete);
            this.Controls.Add(this.dg_Products);
            this.Controls.Add(this.btn_ProductsSearch);
            this.Controls.Add(this.txt_ProductSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_PartsAdd);
            this.Controls.Add(this.btn_PartsEdit);
            this.Controls.Add(this.btn_PartsDelete);
            this.Controls.Add(this.dg_Parts);
            this.Controls.Add(this.btn_PartsSearch);
            this.Controls.Add(this.txt_PartsSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Parts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PartsSearch;
        private System.Windows.Forms.Button btn_PartsSearch;
        private System.Windows.Forms.DataGridView dg_Parts;
        private System.Windows.Forms.Button btn_PartsDelete;
        private System.Windows.Forms.Button btn_PartsEdit;
        private System.Windows.Forms.Button btn_PartsAdd;
        private System.Windows.Forms.Button btn_ProductsAdd;
        private System.Windows.Forms.Button btn_ProductsEdit;
        private System.Windows.Forms.Button btn_ProductsDelete;
        private System.Windows.Forms.DataGridView dg_Products;
        private System.Windows.Forms.Button btn_ProductsSearch;
        private System.Windows.Forms.TextBox txt_ProductSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMax;
    }
}

