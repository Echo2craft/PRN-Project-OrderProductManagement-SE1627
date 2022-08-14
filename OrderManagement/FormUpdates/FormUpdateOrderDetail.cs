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
    public partial class FormUpdateOrderDetail : Form
    {
        public FormUpdateOrderDetail(OrderDetail ordde)
        {
            InitializeComponent();
            LoadData(ordde);
            LoadProductID(ordde);
            LoadOrderID(ordde);
        }
        private void LoadData(OrderDetail ordde)
        {
            txtOderDetailId.Text = ordde.Id.ToString();
            numboxODQuantity.Value = ordde.Quantity;
            numboxODPrice.Value = Convert.ToInt32(ordde.Price);
        }
        private void LoadProductID(OrderDetail ordde)
        {
            ProductRepository prorepo = new();
            ddlODProductID.DataSource = new BindingSource(prorepo.Get(), null);
            ddlODProductID.DisplayMember = "ID";
            ddlODProductID.ValueMember = "ID";
            ddlODProductID.SelectedValue = ordde.ProductId;
        }
        private void LoadOrderID(OrderDetail ordde)
        {
            OrderRepository ordrepo = new();
            ddlODOrderID.DataSource = new BindingSource(ordrepo.Get(), null);
            ddlODOrderID.DisplayMember = "ID";
            ddlODOrderID.ValueMember = "ID";
            ddlODOrderID.SelectedValue = ordde.OrderId;
        }

        private void btnUpdateExistingOrderDetail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Update this Order Detail",
                "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                /*CategoryRepository repo = new();
                var cat = new Category()
                {
                    Name = txtName.Text,
                    Status = StatusNameList.SelectedIndex
                };
                repo.Update(cat);*/
                OrderDetailRepository repo = new();
                var ordde = new OrderDetail()
                {
                    Id = Convert.ToInt32(txtOderDetailId.Text),
                    ProductId = Convert.ToInt32(ddlODProductID.SelectedValue.ToString()),
                    OrderId = Convert.ToInt32(ddlODOrderID.SelectedValue.ToString()),
                    Quantity = Convert.ToInt32(numboxODQuantity.Value),
                    Price = Convert.ToDouble(numboxODPrice.Value)
                };
                repo.Update(ordde);
                if (MessageBox.Show("Successfully Update Order Detail: " + ordde.Id + " !", "Done", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Cancel Update Order Detail !");
            }
        }
    }
}
