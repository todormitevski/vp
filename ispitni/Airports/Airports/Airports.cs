using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
    public partial class Airports : Form
    {
        public Airports()
        {
            InitializeComponent();
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            AddAirport addAirport = new AddAirport();
            if(addAirport.ShowDialog() == DialogResult.OK)
            {
                lbAirports.Items.Add(addAirport.airport);
            }
        }

        private void btnRemoveAirport_Click(object sender, EventArgs e)
        {
            if(lbAirports.SelectedIndex == -1)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Are you sure you want to remove this airport?", "Are you sure?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                int selectIndex = lbAirports.SelectedIndex;
                lbAirports.Items.RemoveAt(selectIndex);
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if(lbAirports.SelectedIndex == -1)
            {
                return;
            }
            AddDestination addDestination = new AddDestination();
            if(addDestination.ShowDialog() == DialogResult.OK)
            {
                Airport selectedAirport = lbAirports.SelectedItem as Airport;
                selectedAirport.Destinations.Add(addDestination.CreatedDestination);
                LoadDestinations();
            }
        }

        private void LoadDestinations()
        {
            lbDestinations.Items.Clear();
            tbAvgDistance.Clear();
            tbMostExpensive.Clear();
            if(lbAirports.SelectedIndex != -1)
            {
                Airport SelectedAirport = lbAirports.SelectedItem as Airport;
                foreach (Destination destination in SelectedAirport.Destinations)
                {
                    lbDestinations.Items.Add(destination);
                }

                //avg
                double sum = 0.0;
                foreach (Destination destination in SelectedAirport.Destinations)
                {
                    sum += destination.Distance;
                }

                if (SelectedAirport.Destinations.Count != 0)
                {
                    double average = sum / SelectedAirport.Destinations.Count;
                    tbAvgDistance.Text = $"{average}";
                }
                else
                {
                    tbAvgDistance.Text = "No destinations present.";
                }

                //most exp
                if (SelectedAirport.Destinations.Count == 0)
                {
                    tbMostExpensive.Text = "No destinations present.";
                }
                else
                {
                    Destination max = SelectedAirport.Destinations[0];
                    for (int i = 1; i < SelectedAirport.Destinations.Count; i++)
                    {
                        if (SelectedAirport.Destinations[i].Price > max.Price)
                        {
                            max = SelectedAirport.Destinations[i];
                        }
                    }
                    tbMostExpensive.Text = max.ToString();
                }
            }
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDestinations();
        }

        private void lbAirports_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDestinations();
        }
    }
}
