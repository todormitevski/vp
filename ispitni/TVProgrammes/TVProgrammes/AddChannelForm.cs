using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVProgrammes
{
    public partial class AddChannelForm : Form
    {
        public Channel channel;
        public TVProgrammesForm MainForm { get; set; } = new TVProgrammesForm();
        public AddChannelForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbChannelNumber.Text != "" && tbChannelName.Text != "")
            {
                this.channel = new Channel(tbChannelName.Text, tbChannelNumber.Text);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbChannelName_Validating(object sender, CancelEventArgs e)
        {
            if(tbChannelName.Text == "")
            {
                errorProvider1.SetError(tbChannelName,"Name field must be filled");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbChannelName, null);
                e.Cancel = false;
            }
        }

        private void tbChannelNumber_Validating(object sender, CancelEventArgs e)
        {
            if(tbChannelNumber.Text == "")
            {
                errorProvider1.SetError(tbChannelNumber, "Number field must be filled");
                e.Cancel = true;
            }
            else
            {
                //somehow not working
                if (MainForm.checkNumber(tbChannelNumber.Text))
                {
                    errorProvider1.SetError(tbChannelNumber, null);
                    e.Cancel = false;
                }
                else
                {
                    errorProvider1.SetError(tbChannelNumber, "Channel with that number already exists");
                    e.Cancel = true;
                }
            }
        }
    }
}
