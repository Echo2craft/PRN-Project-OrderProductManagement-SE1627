using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement
{
    public partial class OrderProductManagement : Form
    {
        public OrderProductManagement()
        {
            InitializeComponent();
        }

        private ucCategory ucCate;
        private ucProduct ucPro;
        private ucOrder ucOrd;
        private ucPayment ucPay;
        private ucOrderDetail ucOrdde;

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucCate = new ucCategory();
            //ucCate Changes detect???
            panel1.Controls.Clear();
            panel1.Controls.Add(ucCate);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucPro = new ucProduct();
            panel1.Controls.Clear();
            panel1.Controls.Add(ucPro);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            e.ClickedItem.BackColor = Color.FromArgb(153, 180, 209);
            for (int i  = 0; i < menuStrip1.Items.Count; i++)
            {
                if(menuStrip1.Items[i].Text != e.ClickedItem.Text)
                {
                    menuStrip1.Items[i].BackColor = Color.Transparent;
                }
            };
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucPay = new ucPayment();
            panel1.Controls.Clear();
            panel1.Controls.Add(ucPay);
        }

        private void orderDetailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ucOrdde = new ucOrderDetail();
            panel1.Controls.Clear();
            panel1.Controls.Add(ucOrdde);
        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ucOrd = new ucOrder();
            panel1.Controls.Clear();
            panel1.Controls.Add(ucOrd);
        }
    }
}
