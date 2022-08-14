using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductRepo1.Models;
using ProductRepo1.Repository;

namespace OrderManagement
{
    public partial class FormAddOrderDetail : Form
    {
        public FormAddOrderDetail()
        {
            InitializeComponent();
            LoadProductID();
            LoadOrderID();
        }
        private void LoadProductID()
        {
            ProductRepository prorepo = new();
            ddlODProductID.DataSource = new BindingSource(prorepo.Get(), null);
            ddlODProductID.DisplayMember = "ID";
            ddlODProductID.ValueMember = "ID";
            ddlODProductID.SelectedValue = prorepo.Get().First().Id;
        }
        private void LoadOrderID()
        {
            OrderRepository ordrepo = new();
            ddlODOrderID.DataSource = new BindingSource(ordrepo.Get(), null);
            ddlODOrderID.DisplayMember = "ID";
            ddlODOrderID.ValueMember = "ID";
            ddlODOrderID.SelectedValue = ordrepo.Get().First().Id;
        }

        private void btnAddNewOrderDetail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Create this Order Detail?",
                    "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                OrderDetailRepository repo = new();
                var pay = new OrderDetail()
                {
                    ProductId = Convert.ToInt32(ddlODProductID.SelectedValue.ToString()),
                    OrderId = Convert.ToInt32(ddlODOrderID.SelectedValue.ToString()),
                    Quantity = Convert.ToInt32(numboxODQuantity.Value),
                    Price = Convert.ToInt32(numboxODPrice.Value)
                };
                if (MessageBox.Show("Successfully Create Order Detail: "+ repo.Create(pay) + "!", "Done", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Cancel Create New Order Detail!");
            }
        }
    }
}
