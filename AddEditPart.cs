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
        Inventory Inventory { get; set; }

        public AddEditPart(Inventory inventory)
        {
            InitializeComponent();
            Inventory = inventory;
            if (!Inventory.AllParts.Any())
            {
                txt_PartId.Text = "1";
            }
            txt_PartId.Text = (Inventory.AllParts.Last().PartId + 1).ToString();
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // NEEDS VALIDATION AND STUFF
            int id = int.Parse(txt_PartId.Text);
            string name = txt_PartName.Text;
            int inventory = int.Parse(txt_PartInventory.Text);
            decimal price = decimal.Parse(txt_PartPrice.Text);
            int min = int.Parse(txt_PartMin.Text);
            int max = int.Parse(txt_PartMax.Text);

            if (rdo_OutSourced.Checked)
            {
                string machineOrCompany = txt_PartMachineOrCompany.Text;
                Inventory.addPart(new Outsourced() { PartId = id, Name = name, InStock = inventory, Price = price, Min = min, Max = max, CompanyName = machineOrCompany });
            }
            else
            {
                int machineOrCompany = int.Parse(txt_PartMachineOrCompany.Text);
                Inventory.addPart(new Inhouse() { PartId = id, Name = name, InStock = inventory, Price = price, Min = min, Max = max, MachineID = machineOrCompany });
            }
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdo_InHouse_CheckedChanged(object sender, EventArgs e)
        {
            lbl_CompanyOrMachineLabel.Text = "Machine ID";
        }

        private void rdo_OutSourced_CheckedChanged(object sender, EventArgs e)
        {
            lbl_CompanyOrMachineLabel.Text = "Company Name";
        }
    }
}
