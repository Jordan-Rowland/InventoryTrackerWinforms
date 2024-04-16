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
                Part part = Inventory.AllParts.FirstOrDefault(q => q.PartId == id);
                Inventory.DeletePart(part);
            }            
            catch
            {
                MessageBox.Show("No Part selected");
            }
        }

        //!! TODO: Need to delete Products as well

        private void btn_PartsSearch_Click(object sender, EventArgs e)
        {
            BindingList<Part> results;
            if (int.TryParse(txt_PartsSearch.Text, out int result)) results = new BindingList<Part>() { Inventory.AllParts.Where(p => p.PartId == result).First() };
            else results = new BindingList<Part>(Inventory.AllParts.Where(p => p.Name.Contains(txt_PartsSearch.Text)).ToList());
            dg_Parts.DataSource = results;
        }

        private void btn_ProductsSearch_Click(object sender, EventArgs e)
        {
            BindingList<Product> results;
            if (int.TryParse(txt_ProductSearch.Text, out int result)) results = new BindingList<Product>() { Inventory.Products.Where(p => p.ProductId == result).First() };
            else results = new BindingList<Product>(Inventory.Products.Where(p => p.Name.Contains(txt_ProductSearch.Text)).ToList());
            dg_Products.DataSource = results;
        }

        private void btn_ProductsEdit_Click(object sender, EventArgs e)
        {
            //try
            //{
                int id = (int)dg_Products.SelectedRows[0].Cells["ProductId"].Value;
                Product product = Inventory.LookupProduct(id);
                AddEditProduct addEditProduct = new AddEditProduct(Inventory, product);
                addEditProduct.ShowDialog();
                dg_Products.Refresh();
            //}
            //catch
            //{
            //    MessageBox.Show("No Product selected");
            //}
        }
    }
}
