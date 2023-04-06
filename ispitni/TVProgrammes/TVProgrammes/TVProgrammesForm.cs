using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVProgrammes
{
    public partial class TVProgrammesForm : Form
    {
        public List<Channel> channels {  get; set; } = new List<Channel>();
        public TVProgrammesForm()
        {
            InitializeComponent();
        }

        public bool checkNumber(string number)
        {
            foreach(Channel channel in channels)
            {
                if (channel.Number.Equals(number))
                    return false;
            }
            return true;
        }

        private void btnAddChannel_Click(object sender, EventArgs e)
        {
            AddChannelForm addChannelForm = new AddChannelForm();
            addChannelForm.ShowDialog();
            if (addChannelForm.DialogResult == DialogResult.OK)
            {
                cbChannel.Items.Add(addChannelForm.channel);
                channels.Add(addChannelForm.channel);
            }
        }

        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            Programme progoramme = new Programme(tbProgramName.Text,nudDuration.Value);
            Channel selectedChannel = cbChannel.SelectedItem as Channel;
            selectedChannel.programmes.Add(progoramme);
            LoadProgrammes();
        }

        private void btnDeleteProgram_Click(object sender, EventArgs e)
        {
            if(lbProgrammes.SelectedIndex != -1 && cbChannel.SelectedIndex != -1)
            {
                Channel selectedChannel = cbChannel.SelectedItem as Channel;
                selectedChannel.programmes.Remove(lbProgrammes.SelectedItem as Programme);
                lbProgrammes.Items.RemoveAt(lbProgrammes.SelectedIndex);
                LoadProgrammes();
            }
        }

        public void LoadProgrammes()
        {
            Channel selectedChannel = cbChannel.SelectedItem as Channel;
            lbProgrammes.Items.Clear();
            decimal avgTime = 0;
            foreach (Programme programme in selectedChannel.programmes)
            {
                lbProgrammes.Items.Add(programme);
                avgTime += programme.Time;
            }
            if(selectedChannel.programmes.Count == 0)
            {
                avgTime = 0;
            } else avgTime /= selectedChannel.programmes.Count;
            tbAverageDuration.Text = avgTime.ToString();
        }

        public void enableButton()
        {
            if(cbChannel.SelectedIndex != -1 && tbProgramName.Text != "" && nudDuration.Value > 0)
            {
                btnAddProgram.Enabled = true;
            }
            else
            {
                btnAddProgram.Enabled = false;
            }
        }

        private void cbChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableButton();
            Channel channel = cbChannel.SelectedItem as Channel;
            lblProgramToShow.Text = channel.Name;
            LoadProgrammes();
        }

        private void cbChannel_SelectedValueChanged(object sender, EventArgs e)
        {
            enableButton();
            Channel channel = cbChannel.SelectedItem as Channel;
            lblProgramToShow.Text = channel.Name;
            LoadProgrammes();
        }

        private void tbProgramName_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void nudDuration_ValueChanged(object sender, EventArgs e)
        {
            enableButton();
        }
    }
}
