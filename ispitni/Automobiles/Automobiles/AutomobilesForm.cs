using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobiles
{
    public partial class AutomobilesForm : Form
    {
        public AutomobilesForm()
        {
            InitializeComponent();
        }

        private void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            ManufacturerForm manuForm = new ManufacturerForm();
            DialogResult dr = manuForm.ShowDialog();
            if(dr == DialogResult.OK)
            {
                lbManufacturers.Items.Add(manuForm.manufacturer);
                cbManufacturer.Items.Add(manuForm.manufacturer);
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            if(cbManufacturer.SelectedIndex != -1)
            {
                Manufacturer manufacturer = new Manufacturer();
                Automobile automobile = new Automobile(manufacturer, tbModel.Text, nudConsumption.Value, nudPrice.Value);
                List<Automobile> automobiles = new List<Automobile> ();
                manufacturer.automobiles.Add(automobile);
                LoadVehicles("add");
                //finish tmrw
            }
        }

        private void btnRemoveVehicle_Click(object sender, EventArgs e)
        {
            if(lbVehicles.SelectedIndex != -1)
            {
                lbVehicles.Items.Remove(lbVehicles.SelectedItem);
                LoadVehicles("remove");
            }
        }

        private void LoadVehicles(string action)
        {
            if(action.Equals("add"))
            {

            }
            else if (action.Equals("remove"))
            {

            }
        }
    }
}
