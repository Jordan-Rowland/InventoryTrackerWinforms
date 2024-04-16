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
    public partial class AddEditPart : Form
    {
        readonly bool isEditMode = false;
        Inventory Inventory { get; set; }

        public AddEditPart(Inventory inventory)
        {
            InitializeComponent();
            Inventory = inventory;
            if (!Inventory.AllParts.Any()) txt_PartId.Text = "1";
            else txt_PartId.Text = (Inventory.AllParts.Last().PartId + 1).ToString();
            rdo_Inhouse.Checked = true;
        }

        public AddEditPart(Inventory inventory, Part part)
        {
            InitializeComponent();
            Inventory = inventory;
            isEditMode = true;
            PopulateFields(part);
        }

        private void PopulateFields(Part part)
        {
            txt_PartId.Text = part.PartId.ToString();
            txt_PartName.Text = part.Name;
            txt_PartInventory.Text = part.InStock.ToString();
            txt_PartPrice.Text = part.Price.ToString();
            txt_PartMin.Text = part.Min.ToString();
            txt_PartMax.Text = part.Max.ToString();
            
            // Set the correct machine ID or Company Name
            try
            {
                txt_PartMachineOrCompany.Text = ((Inhouse)part).MachineId.ToString();
                rdo_Inhouse.Checked = true;
            }
            catch
            {
                txt_PartMachineOrCompany.Text = ((Outsourced)part).CompanyName.ToString();
                rdo_Outsourced.Checked = true;

            }
        }

        private void Part_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // TODO: NEEDS VALIDATION AND STUFF
            int id = int.Parse(txt_PartId.Text);
            string name = txt_PartName.Text;
            int inventory = int.Parse(txt_PartInventory.Text);
            decimal price = decimal.Parse(txt_PartPrice.Text);
            int min = int.Parse(txt_PartMin.Text);
            int max = int.Parse(txt_PartMax.Text);

            dynamic part;
            if (rdo_Outsourced.Checked)
            {
                string machineOrCompany = txt_PartMachineOrCompany.Text;
                part = new Outsourced()
                {
                    PartId = id,
                    Name = name,
                    InStock = inventory,
                    Price = price,
                    Min = min,
                    Max = max,
                    CompanyName = machineOrCompany
                };
            }
            else
            {
                int machineOrCompany = int.Parse(txt_PartMachineOrCompany.Text);
                part = new Inhouse()
                {
                    PartId = id,
                    Name = name,
                    InStock = inventory,
                    Price = price,
                    Min = min,
                    Max = max,
                    MachineId = machineOrCompany,
                };
            }
            if (isEditMode) Inventory.UpdatePart(id, part);
            else Inventory.AddPart(part);
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
