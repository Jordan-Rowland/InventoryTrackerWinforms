using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jordan_rowland_inventoryC968
{
    public partial class MainForm : Form
    {

        Inventory Inventory = new Inventory();

        public MainForm()
        {
            InitializeComponent();
            dg_Parts.DataSource = new BindingSource(Inventory.AllParts, null);
            dg_Products.DataSource = new BindingSource(Inventory.Products, null);
            dg_Parts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_Parts.AllowUserToAddRows = false;
            dg_Products.AllowUserToAddRows = false;
            dg_Parts.ReadOnly = true;
            dg_Products.ReadOnly = true;

            dg_Parts.Columns[0].HeaderText = "Part ID";
            dg_Parts.Columns[2].HeaderText = "Inventory";

            dg_Products.Columns[0].HeaderText = "Product ID";
            dg_Products.Columns[2].HeaderText = "Inventory";

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_PartsAdd_Click(object sender, EventArgs e)
        {
            AddEditPart addEditPart = new AddEditPart(Inventory);
            addEditPart.ShowDialog();
        }

        private void btn_ProductsAdd_Click(object sender, EventArgs e)
        {
            AddEditProduct addEditProduct = new AddEditProduct(Inventory);
            addEditProduct.ShowDialog();
            dg_Parts.Refresh();
        }

        private void btn_PartsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dg_Parts.SelectedRows[0].Cells["PartId"].Value;
                Part part = Inventory.AllParts.FirstOrDefault(q => q.PartId == id);
                AddEditPart addEditPart = new AddEditPart(Inventory, part);
                addEditPart.ShowDialog();
                dg_Parts.Refresh();
            }
            catch
            {
                MessageBox.Show("No Part selected");
            }
        }

        private void btn_PartsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dg_Parts.SelectedRows[0].Cells["PartId"].Value;
                string message = "Delete this part?";
                string caption = "Click Yes or No to confirm";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                    Inventory.DeletePart(Inventory.AllParts.FirstOrDefault(q => q.PartId == id));
            }
            catch
            {
                MessageBox.Show("No part selected");
            }
        }

        private void btn_PartsSearch_Click(object sender, EventArgs e)
        {
            bool partFound = false;
            if (int.TryParse(txt_PartsSearch.Text, out int result))
            {
                foreach (DataGridViewRow row in dg_Parts.Rows)
                {
                    Part part = (Part)row.DataBoundItem;
                    if (result == part.PartId) row.Selected = partFound = true;
                    else row.Selected = false;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dg_Parts.Rows)
                {
                    Part part = (Part)row.DataBoundItem;
                    if (txt_PartsSearch.Text == "") row.Selected = false;
                    else if (part.Name.Contains(txt_PartsSearch.Text)) row.Selected = partFound = true;
                    else row.Selected = false;
                }
            }
            if (txt_PartsSearch.Text != "" && !partFound) MessageBox.Show("Part could not be found.");
        }

        private void btn_ProductsSearch_Click(object sender, EventArgs e)
        {
            bool productFound = false;
            if (int.TryParse(txt_ProductSearch.Text, out int result))
            {
                foreach (DataGridViewRow row in dg_Products.Rows)
                {
                    Product product = (Product)row.DataBoundItem;
                    if (txt_ProductSearch.Text == "") row.Selected = false;
                    else if (result == product.ProductId) row.Selected = productFound = true;
                    else row.Selected = false;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dg_Products.Rows)
                {
                    Product product = (Product)row.DataBoundItem;
                    if (txt_ProductSearch.Text == "") row.Selected = false;
                    else if (product.Name.Contains(txt_ProductSearch.Text)) row.Selected = productFound = true;
                    else row.Selected = false;
                }
            }
            if (txt_ProductSearch.Text != "" && !productFound) MessageBox.Show("Product could not be found.");

        }

        private void btn_ProductsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // BETTER ERRORS
                int id = (int)dg_Products.SelectedRows[0].Cells["ProductId"].Value;
                Product product = Inventory.LookupProduct(id);
                AddEditProduct addEditProduct = new AddEditProduct(Inventory, product);
                addEditProduct.ShowDialog();
                dg_Products.Refresh();
            }
            catch
            {
                MessageBox.Show("No Product selected");
            }
}

        private void btn_ProductsDelete_Click(object sender, EventArgs e)
        {
            // Still need to account for missing or unselected rows
            try
            {
                int id = (int)dg_Products.SelectedRows[0].Cells["ProductId"].Value;
                Product product = Inventory.LookupProduct(id);

                if (product.AssociatedParts.Any())
                {
                    MessageBox.Show(
                        "You cannot delete a product with parts associated with it.\nPlease remove the parts and try again."
                    );
                    return;
                }

                string message = "Delete this product?";
                string caption = "Click Yes or No to confirm";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes) Inventory.RemoveProduct(product);
            }
            catch
            {
                MessageBox.Show("No product selected");
            }
}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
