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
    public partial class AddEditPart : Form
    {
        bool isEditMode = false;
        public AddEditPart()
        {
            InitializeComponent();
        }

        public AddEditPart(Part part)
        {
            InitializeComponent();
            isEditMode = true;
            PopulateFields(part);
        }

        private void PopulateFields(Part part)
        {
            // Populate fields
        }

        private void Part_Load(object sender, EventArgs e)
        {

        }
    }
}
