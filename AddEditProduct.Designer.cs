namespace jordan_rowland_inventoryC968
{
    partial class AddEditProduct
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
            this.btn_PartAdd = new System.Windows.Forms.Button();
            this.dg_AllParts = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AllPartsSearch = new System.Windows.Forms.Button();
            this.txt_AllPartsSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_PartDelete = new System.Windows.Forms.Button();
            this.btn_ProductPartsSearch = new System.Windows.Forms.Button();
            this.txt_ProductPartsSearch = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_ProductInventory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ProductPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ProductMax = new System.Windows.Forms.TextBox();
            this.txt_ProductMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ProductId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dg_ProductParts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_AllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ProductParts)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_PartAdd
            // 
            this.btn_PartAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PartAdd.Location = new System.Drawing.Point(873, 320);
            this.btn_PartAdd.Name = "btn_PartAdd";
            this.btn_PartAdd.Size = new System.Drawing.Size(88, 30);
            this.btn_PartAdd.TabIndex = 14;
            this.btn_PartAdd.Text = "Add";
            this.btn_PartAdd.UseVisualStyleBackColor = true;
            // 
            // dg_AllParts
            // 
            this.dg_AllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_AllParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.PartName,
            this.PartInventory,
            this.PartPrice,
            this.PartMin,
            this.PartMax});
            this.dg_AllParts.Location = new System.Drawing.Point(406, 92);
            this.dg_AllParts.Name = "dg_AllParts";
            this.dg_AllParts.RowHeadersWidth = 51;
            this.dg_AllParts.RowTemplate.Height = 24;
            this.dg_AllParts.Size = new System.Drawing.Size(555, 222);
            this.dg_AllParts.TabIndex = 11;
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
            // btn_AllPartsSearch
            // 
            this.btn_AllPartsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AllPartsSearch.Location = new System.Drawing.Point(623, 56);
            this.btn_AllPartsSearch.Name = "btn_AllPartsSearch";
            this.btn_AllPartsSearch.Size = new System.Drawing.Size(88, 30);
            this.btn_AllPartsSearch.TabIndex = 10;
            this.btn_AllPartsSearch.Text = "Search";
            this.btn_AllPartsSearch.UseVisualStyleBackColor = true;
            // 
            // txt_AllPartsSearch
            // 
            this.txt_AllPartsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AllPartsSearch.Location = new System.Drawing.Point(729, 56);
            this.txt_AllPartsSearch.Name = "txt_AllPartsSearch";
            this.txt_AllPartsSearch.Size = new System.Drawing.Size(232, 30);
            this.txt_AllPartsSearch.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parts assoicated with product";
            // 
            // btn_PartDelete
            // 
            this.btn_PartDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PartDelete.Location = new System.Drawing.Point(873, 649);
            this.btn_PartDelete.Name = "btn_PartDelete";
            this.btn_PartDelete.Size = new System.Drawing.Size(88, 30);
            this.btn_PartDelete.TabIndex = 19;
            this.btn_PartDelete.Text = "Delete";
            this.btn_PartDelete.UseVisualStyleBackColor = true;
            // 
            // btn_ProductPartsSearch
            // 
            this.btn_ProductPartsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductPartsSearch.Location = new System.Drawing.Point(623, 385);
            this.btn_ProductPartsSearch.Name = "btn_ProductPartsSearch";
            this.btn_ProductPartsSearch.Size = new System.Drawing.Size(88, 30);
            this.btn_ProductPartsSearch.TabIndex = 17;
            this.btn_ProductPartsSearch.Text = "Search";
            this.btn_ProductPartsSearch.UseVisualStyleBackColor = true;
            // 
            // txt_ProductPartsSearch
            // 
            this.txt_ProductPartsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductPartsSearch.Location = new System.Drawing.Point(729, 385);
            this.txt_ProductPartsSearch.Name = "txt_ProductPartsSearch";
            this.txt_ProductPartsSearch.Size = new System.Drawing.Size(232, 30);
            this.txt_ProductPartsSearch.TabIndex = 16;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(877, 724);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(88, 36);
            this.btn_Cancel.TabIndex = 39;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(779, 724);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(88, 36);
            this.btn_Save.TabIndex = 38;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // txt_ProductInventory
            // 
            this.txt_ProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductInventory.Location = new System.Drawing.Point(143, 345);
            this.txt_ProductInventory.Name = "txt_ProductInventory";
            this.txt_ProductInventory.Size = new System.Drawing.Size(159, 28);
            this.txt_ProductInventory.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "Name";
            // 
            // txt_ProductPrice
            // 
            this.txt_ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductPrice.Location = new System.Drawing.Point(143, 379);
            this.txt_ProductPrice.Name = "txt_ProductPrice";
            this.txt_ProductPrice.Size = new System.Drawing.Size(159, 28);
            this.txt_ProductPrice.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Price";
            // 
            // txt_ProductMax
            // 
            this.txt_ProductMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductMax.Location = new System.Drawing.Point(278, 412);
            this.txt_ProductMax.Name = "txt_ProductMax";
            this.txt_ProductMax.Size = new System.Drawing.Size(63, 28);
            this.txt_ProductMax.TabIndex = 31;
            // 
            // txt_ProductMin
            // 
            this.txt_ProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductMin.Location = new System.Drawing.Point(143, 413);
            this.txt_ProductMin.Name = "txt_ProductMin";
            this.txt_ProductMin.Size = new System.Drawing.Size(63, 28);
            this.txt_ProductMin.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Max";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductName.Location = new System.Drawing.Point(143, 311);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(159, 28);
            this.txt_ProductName.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 415);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(41, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "Min";
            // 
            // txt_ProductId
            // 
            this.txt_ProductId.Enabled = false;
            this.txt_ProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductId.Location = new System.Drawing.Point(143, 277);
            this.txt_ProductId.Name = "txt_ProductId";
            this.txt_ProductId.Size = new System.Drawing.Size(159, 28);
            this.txt_ProductId.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "Add Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "All candidate parts";
            // 
            // dg_ProductParts
            // 
            this.dg_ProductParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ProductParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dg_ProductParts.Location = new System.Drawing.Point(406, 421);
            this.dg_ProductParts.Name = "dg_ProductParts";
            this.dg_ProductParts.RowHeadersWidth = 51;
            this.dg_ProductParts.RowTemplate.Height = 24;
            this.dg_ProductParts.Size = new System.Drawing.Size(555, 222);
            this.dg_ProductParts.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Min";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Max";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // AddEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 772);
            this.Controls.Add(this.dg_ProductParts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_ProductInventory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ProductPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ProductMax);
            this.Controls.Add(this.txt_ProductMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ProductId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_PartDelete);
            this.Controls.Add(this.btn_ProductPartsSearch);
            this.Controls.Add(this.txt_ProductPartsSearch);
            this.Controls.Add(this.btn_PartAdd);
            this.Controls.Add(this.dg_AllParts);
            this.Controls.Add(this.btn_AllPartsSearch);
            this.Controls.Add(this.txt_AllPartsSearch);
            this.Controls.Add(this.label2);
            this.Name = "AddEditProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.AddEditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_AllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ProductParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PartAdd;
        private System.Windows.Forms.DataGridView dg_AllParts;
        private System.Windows.Forms.Button btn_AllPartsSearch;
        private System.Windows.Forms.TextBox txt_AllPartsSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_PartDelete;
        private System.Windows.Forms.Button btn_ProductPartsSearch;
        private System.Windows.Forms.TextBox txt_ProductPartsSearch;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_ProductInventory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ProductPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ProductMax;
        private System.Windows.Forms.TextBox txt_ProductMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ProductId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartMax;
        private System.Windows.Forms.DataGridView dg_ProductParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}