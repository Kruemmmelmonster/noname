using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kruemmel_monsters
{
    public partial class GuiCheckout : Form
    {
        public GuiCheckout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // read type burger
            foreach (object burger in selection_burger.CheckedItems)
            {
               
            }

            // read type additional
            foreach (object addition in selection_addition.CheckedItems)
            {

            }

            // read type drink
            foreach (object drink in selection_drink.CheckedItems)
            {

            }

            // calculate price and display it

            this.output_price.Text = "test";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
