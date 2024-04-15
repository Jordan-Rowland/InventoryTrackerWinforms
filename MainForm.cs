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
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_PartsAdd_Click(object sender, EventArgs e)
        {
            AddEditPart addEditPart = new AddEditPart();
            addEditPart.ShowDialog();
        }

        private void btn_ProductsAdd_Click(object sender, EventArgs e)
        {
            AddEditProduct addEditProduct = new AddEditProduct();
            addEditProduct.ShowDialog();

        }
    }
}
