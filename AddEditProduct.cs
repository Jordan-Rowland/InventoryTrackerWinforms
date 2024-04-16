using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jordan_rowland_inventoryC968
{
    public partial class AddEditProduct : Form
    {
        readonly bool isEditMode = false;
        Inventory Inventory;
        BindingList<Part> AssociatedParts = new BindingList<Part>();

        public AddEditProduct(Inventory inventory)
        {
            InitializeComponent();
            Inventory = inventory;

            if (!Inventory.Products.Any()) txt_ProductId.Text = "1";
            else txt_ProductId.Text = (Inventory.Products.Last().ProductId + 1).ToString();

            dg_AllParts.DataSource = new BindingSource(Inventory.AllParts, null);
            dg_ProductParts.DataSource = new BindingSource(AssociatedParts, null);
            DataGridsConfig();
        }

        public AddEditProduct(Inventory inventory, Product product)
        {
            InitializeComponent();
            Inventory = inventory;
            isEditMode = true;
            lbl_MainLabel.Text = "Modify Product";
            AssociatedParts = new BindingList<Part>(product.AssociatedParts.ToList());
            dg_AllParts.DataSource = new BindingSource(Inventory.AllParts, null);
            dg_ProductParts.DataSource = new BindingSource(AssociatedParts, null);
            DataGridsConfig();
            PopulateFields(product);
        }

        private void DataGridsConfig()
        {
            dg_AllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_ProductParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_AllParts.AllowUserToAddRows = false;
            dg_ProductParts.AllowUserToAddRows = false;
            dg_AllParts.ReadOnly = true;
            dg_ProductParts.ReadOnly = true;
        }

        private void PopulateFields(Product product)
        {
            txt_ProductId.Text = product.ProductId.ToString();
            txt_ProductName.Text = product.Name;
            txt_ProductInventory.Text = product.InStock.ToString();
            txt_ProductPrice.Text = product.Price.ToString();
            txt_ProductMin.Text = product.Min.ToString();
            txt_ProductMax.Text = product.Max.ToString();
        }

        private void AddEditProduct_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // TODO: NEEDS VALIDATION AND STUFF
            int id = int.Parse(txt_ProductId.Text);
            string name = txt_ProductName.Text;
            int inventory = int.Parse(txt_ProductInventory.Text);
            decimal price = decimal.Parse(txt_ProductPrice.Text);
            int min = int.Parse(txt_ProductMin.Text);
            int max = int.Parse(txt_ProductMax.Text);
            //BindingList<Part> partList = (BindingList<Part>)dg_ProductParts.DataSource;

            Debug.Write($"\nCount: {AssociatedParts.Count()}");
            Product product = new Product()
            {
                ProductId = id,
                Name = name,
                InStock = inventory,
                Price = price,
                Min = min,
                Max = max,
                AssociatedParts = AssociatedParts,
            };
          
            if (isEditMode) Inventory.UpdateProduct(id, product);
            else Inventory.AddProduct(product);
            Close();
        }

        private void btn_ProductPartDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dg_ProductParts.SelectedRows[0].Cells["PartId"].Value;
                AssociatedParts.Remove(AssociatedParts.FirstOrDefault(q => q.PartId == id));
            }
            catch
            {
                MessageBox.Show("No Product selected");
            }
}

        private void btn_PartAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dg_AllParts.SelectedRows[0].Cells["PartId"].Value;
                AssociatedParts.Add(Inventory.AllParts.FirstOrDefault(q => q.PartId == id));
                dg_ProductParts.Refresh();
        }
            catch
            {
                // EDIT THIS TO HAVE BETTER ERRORS
                MessageBox.Show("No Product selected");
            }
}
    }
}
