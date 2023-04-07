using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Race
{
    public partial class F1RaceForm : Form
    {
        List<Driver> drivers = new List<Driver>();
        public F1RaceForm()
        {
            InitializeComponent();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            AddDriverForm form = new AddDriverForm();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                drivers.Add(form.driver);
            }
            LoadDriver();
        }

        private void btnRemoveDriver_Click(object sender, EventArgs e)
        {
            if(lbDrivers.SelectedIndex == -1)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this driver?", "Are you sure?", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                Driver driverToRemove = lbDrivers.SelectedItem as Driver;
                drivers.Remove(driverToRemove);
                LoadDriver();
                lbLaps.Items.Clear();
            }
        }

        private void btnAddLap_Click(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedIndex != -1)
            {
                Driver driver = lbDrivers.SelectedItem as Driver;
                Lap lap = new Lap((int)nudMinutes.Value,(int)nudSeconds.Value);
                driver.Laps.Add(lap);
                lbLaps.Items.Clear();
                foreach (Lap Lap in driver.Laps)
                {
                    lbLaps.Items.Add(Lap);
                }
                LoadLaps();
            }
        }

        private void LoadDriver()
        {
            lbDrivers.Items.Clear();
            drivers.Sort();
            foreach(Driver driver in drivers)
            {
                lbDrivers.Items.Add(driver);
            }
        }

        private void LoadLaps()
        {
            if (lbDrivers.SelectedIndex != -1)
            {
                Driver driver = lbDrivers.SelectedItem as Driver;
                Lap bestLap = new Lap(99, 99);
                lbLaps.Items.Clear();
                foreach (Lap lap in driver.Laps)
                {
                    int lapTime = lap.Minute * 60 + lap.Second;
                    if(lapTime > nudTime.Value)
                    {
                        if(lap.Minute < bestLap.Minute && lap.Second < bestLap.Second)
                        {
                            bestLap = lap;
                        }
                        lbLaps.Items.Add(lap);
                    }
                }
                if(bestLap.Minute == 99 && bestLap.Second == 99)
                {
                    tbBestLap.Text = "";
                } else tbBestLap.Text = bestLap.ToString();
            }
        }

        private void nudSeconds_ValueChanged(object sender, EventArgs e)
        {
            //not working properly for the downkey from 0 value
            if (nudSeconds.Value == 0 && nudMinutes.Value > nudMinutes.Minimum)
            {
                nudMinutes.Value--;
                nudSeconds.Value = 59;
            }
            else if (nudSeconds.Value > 59)
            {
                nudSeconds.Value = 0;
                nudMinutes.Value++;
            }
        }

        private void lbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLaps();
        }

        private void lbDrivers_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadLaps();
        }

        private void nudTime_ValueChanged(object sender, EventArgs e)
        {
            LoadLaps();
        }
    }
}
