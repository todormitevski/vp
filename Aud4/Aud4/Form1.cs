using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aud4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStr_Click(object sender, EventArgs e)
        {
            if(tbStrToAdd.Text != "")
            {
                Boolean flag = false;
                foreach(string item in lbStrings.Items)
                {
                    if (item.Equals(tbStrToAdd.Text))
                    {
                        flag = true;
                        break;
                    }
                }
                if(!flag)
                {
                    lbStrings.Items.Add(tbStrToAdd.Text);
                    tbStrToAdd.Clear();
                }
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if(lbStrings.SelectedItems.Count > 0) //.SelectedIndex != -1 also works
            {
                String value = lbStrings.SelectedItems[0].ToString();
                clbStrings.Items.Add (value);
                lbStrings.Items.Remove(value);
            }
        }
    }
}
