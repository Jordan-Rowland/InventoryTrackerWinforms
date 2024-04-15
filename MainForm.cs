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
            AddEditProduct addEditProduct = new AddEditProduct();
            addEditProduct.ShowDialog();

        }

        private void btn_PartsEdit_Click(object sender, EventArgs e)
        {
            int id = (int)dg_Parts.SelectedRows[0].Cells["PartId"].Value;
            Part part = Inventory.AllParts.FirstOrDefault(q => q.PartId == id);
            AddEditPart addEditPart = new AddEditPart(Inventory, part);
            addEditPart.ShowDialog();
        }

        private void btn_PartsDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dg_Parts.SelectedRows[0].Cells["PartId"].Value;
            Part part = Inventory.AllParts.FirstOrDefault(q => q.PartId == id);
            Inventory.deletePart(part);
        }
    }
}
