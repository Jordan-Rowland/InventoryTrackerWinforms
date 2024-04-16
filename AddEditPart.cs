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
            checkAndDisableSave();
        }

        public AddEditPart(Inventory inventory, Part part)
        {
            InitializeComponent();
            Inventory = inventory;
            isEditMode = true;
            lbl_MainLabel.Text = "Modify Part";
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
            string errors = "";

            if (!int.TryParse(txt_PartInventory.Text, out int inventory)) errors += "* Inventory must be a valid number\n";
            if (!decimal.TryParse(txt_PartPrice.Text, out decimal price)) errors += "* Price must be a valid Decimal\n";
            if (!int.TryParse(txt_PartMin.Text, out int min)) errors += "* Min must be a valid number\n";
            if (!int.TryParse(txt_PartMax.Text, out int max)) errors += "* Max must be a valid number\n";
            if (min > max) errors += "* Min must be less than Max\n";
            if (inventory < min || inventory > max) errors += "* Inventory must be between Min and Max\n";

            int machineId = 0;
            if (rdo_Inhouse.Checked && !int.TryParse(txt_PartMachineOrCompany.Text, out machineId))
                errors += "* Machine ID valid number\n";


            if (errors.Any())
            {
                MessageBox.Show($"The Following Errors must be fxed:\n{errors}");
                return;
            }

            int id = int.Parse(txt_PartId.Text);
            string name = txt_PartName.Text;

            dynamic part;

            if (rdo_Outsourced.Checked)
            {
                string companyName = txt_PartMachineOrCompany.Text;
                part = new Outsourced()
                {
                    PartId = id,
                    Name = name,
                    InStock = inventory,
                    Price = price,
                    Min = min,
                    Max = max,
                    CompanyName = companyName
                };
            }
            else
            {
                part = new Inhouse()
                {
                    PartId = id,
                    Name = name,
                    InStock = inventory,
                    Price = price,
                    Min = min,
                    Max = max,
                    MachineId = machineId,
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

        private void checkAndDisableSave()
        {
            List<string> fields = new List<string>()
            { 
                txt_PartId.Text,
                txt_PartName.Text,
                txt_PartInventory.Text,
                txt_PartPrice.Text,
                txt_PartMin.Text,
                txt_PartMax.Text,
            };
            foreach (string field in fields)
            {
                if (field == "")
                {
                    btn_Save.Enabled = false;
                    break;
                }
                else btn_Save.Enabled = true;
            }
        }
        private void txt_PartId_TextChanged(object sender, EventArgs e) => checkAndDisableSave();
        private void txt_PartName_TextChanged(object sender, EventArgs e) => checkAndDisableSave();
        private void txt_PartInventory_TextChanged(object sender, EventArgs e) => checkAndDisableSave();
        private void txt_PartPrice_TextChanged(object sender, EventArgs e) => checkAndDisableSave();
        private void txt_PartMin_TextChanged(object sender, EventArgs e) => checkAndDisableSave();
        private void txt_PartMax_TextChanged(object sender, EventArgs e) => checkAndDisableSave();
        private void txt_PartMachineOrCompany_TextChanged(object sender, EventArgs e) => checkAndDisableSave();
    }
}
