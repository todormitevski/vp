using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StringBuilder sb = new StringBuilder();

        private void calculatePrice()
        {
            //sizes
            int total = 0;
            if (rbSmallSize.Checked)
            {
                int.TryParse(tbSmallSize.Text, out total);
                sb.AppendLine("Size: " + rbSmallSize.Text);
            }
            if (rbMediumSize.Checked)
            {
                int.TryParse(tbMediumSize.Text, out total);
                sb.AppendLine("Size: " + rbMediumSize.Text);
            }
            if (rbLargeSize.Checked)
            {
                int.TryParse(tbLargeSize.Text, out total);
                sb.AppendLine("Size: " + rbLargeSize.Text);
            }

            //condiments
            int condimentPrice = 0;
            int condimentPriceTotal = 0;
            string condimentString = "Condiments:\n";
            if (cbHotPeppers.Checked)
            {
                int.TryParse(tbHotPeppers.Text, out condimentPrice);
                condimentPriceTotal += condimentPrice;
                condimentString += " - Hot peppers\n";
            }
            if (cbExtraCheese.Checked)
            {
                int.TryParse(tbExtraCheese.Text, out condimentPrice);
                condimentPriceTotal += condimentPrice;
                condimentString += " - Extra cheese\n";
            }
            if (cbKetchup.Checked)
            {
                int.TryParse(tbKetchup.Text, out condimentPrice);
                condimentPriceTotal += condimentPrice;
                condimentString += " - Ketchup\n";
            }
            total += condimentPriceTotal;
            if (condimentString.Equals("Condiments:\n"))
                condimentString += " - none";
            sb.AppendLine(condimentString);

            //drinks
            int drinkTotal = 0;
            int quantity = 0;
            int drinkPrice = 0;
            string drinksString = "";
            drinksString += "Drinks:\n";
            int.TryParse(tbQtyCoke.Text, out quantity);
            int.TryParse(tbCokePrice.Text, out drinkPrice);
            if (quantity > 0)
                drinksString += " - Coke\n";
            drinkPrice *= quantity;
            drinkTotal += drinkPrice;
            tbTotalCoke.Text = drinkPrice.ToString();
            int.TryParse(tbQtyJuice.Text, out quantity);
            int.TryParse(tbJuicePrice.Text, out drinkPrice);
            if (quantity > 0)
                drinksString += " - Juice\n";
            drinkPrice *= quantity;
            drinkTotal += drinkPrice;
            tbTotalJuice.Text = drinkPrice.ToString();
            int.TryParse(tbQtyBeer.Text, out quantity);
            int.TryParse(tbBeerPrice.Text, out drinkPrice);
            if (quantity > 0)
                drinksString += " - Beer\n";
            drinkPrice *= quantity;
            drinkTotal += drinkPrice;
            tbTotalBeer.Text = drinkPrice.ToString();
            total += drinkTotal;
            if (drinksString.Equals("Drinks:\n"))
                drinksString += " - none";
            sb.AppendLine(drinksString);

            //desserts 80 120 160
            if (lbDessert.SelectedIndex == 0)
            {
                tbDessertPrice.Text = "80";
                total += 80;
                sb.AppendLine("Dessert:\n - Fruit pie");
            }
            else if (lbDessert.SelectedIndex == 1)
            {
                tbDessertPrice.Text = "120";
                total += 120;
                sb.AppendLine("Dessert:\n - Ice cream");
            }
            else if (lbDessert.SelectedIndex == 2)
            {
                tbDessertPrice.Text = "160";
                total += 160;
                sb.AppendLine("Dessert:\n - Cake");
            }
            else
            {
                sb.AppendLine("Dessert:\n - none");
            }

            tbTotalToPay.Text = total.ToString();
        }

        private void calcPayment()
        {
            int total = 0;
            int payment = 0;
            int.TryParse(tbTotalToPay.Text, out total);
            int.TryParse(tbTotalPaid.Text, out payment);
            int afterPayment = payment - total;
            tbTotalToReturn.Text = afterPayment.ToString();
        }

        private void btnOrderDessert_Click(object sender, EventArgs e)
        {
            //TODO: this, tbPaid and tbReturn
            DialogResult dialog = MessageBox.Show(sb.ToString(), "Your order", MessageBoxButtons.OK);
        }

        private void btnCancelDessert_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close this application?", "Exit?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void rbSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void rbMediumSize_CheckedChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void rbLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }
        private void tbSmallSize_TextChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void tbMediumSize_TextChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void tbLargeSize_TextChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void cbHotPeppers_CheckedChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void cbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void cbKetchup_CheckedChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void tbHotPeppers_TextChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void tbExtraCheese_TextChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void tbKetchup_TextChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void tbQtyCoke_TextChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void tbQtyJuice_TextChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void tbQtyBeer_TextChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void tbCokePrice_TextChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void tbJuicePrice_TextChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void tbBeerPrice_TextChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void lbDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            sb.Clear();
            calculatePrice();
        }

        private void tbTotalPaid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
