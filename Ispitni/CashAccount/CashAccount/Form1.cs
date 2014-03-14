using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zadaca1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            NewProduct np = new NewProduct();
            if (np.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (object obj in lbProducts.Items)
                {
                    Product product = (Product)obj;
                    if (product.Code == np.Product.Code)
                    {
                        MessageBox.Show("Производ со овој код веќе постои!");
                        return;
                    }
                }
                lbProducts.Items.Add(np.Product);
            }
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddToAccount.Enabled = lbProducts.SelectedIndex != -1;
            nudQuantity.Enabled = lbProducts.SelectedIndex != -1;
        }

        private void btnAddToAccount_Click(object sender, EventArgs e)
        {
            Product selected = (Product)lbProducts.SelectedItem;
            Item item = new Item(selected, (int)nudQuantity.Value);            
            lbItems.Items.Add(item);
            calculateTotal();
        }

        private void nudTax_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void calculateTotal()
        {
            float total = 0;
            foreach (object obj in lbItems.Items)
            {
                Item item = (Item)obj;
                total += item.Price();
            }
            tbTotal.Text = string.Format("{0:0.00} ден", total);
            tbTotalPayment.Text = string.Format("{0:0.00} ден", total * (float)(1 + nudTax.Value / 100));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Избриши ставка?", "Дали сте сигруни дека сакате да ја избришете ставката?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                lbItems.Items.RemoveAt(lbItems.SelectedIndex);
                calculateTotal();
            }
            
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = lbItems.SelectedIndex != -1;
        }
    }
}
