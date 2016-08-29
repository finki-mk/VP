using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Orders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder order = new AddOrder();
            if (order.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbOrders.Items.Add(order.Item);
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (lbOrders.Items.Count == 0) return;
            Bill bill = new Bill();
            foreach (object item in lbOrders.Items)
            {
                ProductItem productItem = item as ProductItem;
                bill.Total += productItem.Total;
            }
            bill.Time = DateTime.Now;
            lbBills.Items.Add(bill);
            calculateTotal();
            lbOrders.Items.Clear();
        }

        void calculateTotal()
        {
            decimal total = 0;
            foreach (object item in lbBills.Items)
            {
                Bill bill = item as Bill;
                total += bill.Total;
            }
            tbTotal.Text = string.Format("{0:0.00} ден", total);
        }
    }
}
