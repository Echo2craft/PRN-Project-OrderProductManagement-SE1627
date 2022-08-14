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
    public partial class FormUpdateOrder : Form
    {
        public FormUpdateOrder(Order ord)
        {
            InitializeComponent();
            LoadData(ord);
        }
        private void LoadData(Order ord)
        {
            txtOrderId.Text = ord.Id.ToString();
            txtOrderCustomerName.Text = ord.CustomerName;
            txtOrderAddress.Text = ord.Address;
            numboxOrderPrice.Value = Convert.ToInt32(ord.Price);
            dtpOrderOrderedDate.Value = Convert.ToDateTime(ord.OrderDate);

            Dictionary<int, string> comboSource = new Dictionary<int, string>() {
                {0,"InActive" },{1,"Active" }
            };
            ddlOrderStatus.DataSource = new BindingSource(comboSource, null);
            ddlOrderStatus.DisplayMember = "Value";
            ddlOrderStatus.ValueMember = "Key";
            ddlOrderStatus.SelectedValue = ord.Status;
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                if (MessageBox.Show("Are you sure to Update this Product?",
                "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    /*CategoryRepository repo = new();
                    var cat = new Category()
                    {
                        Name = txtName.Text,
                        Status = StatusNameList.SelectedIndex
                    };
                    repo.Update(cat);*/
                    OrderRepository repo = new();
                    var ord = new Order()
                    {
                        Id = Convert.ToInt32(txtOrderId.Text),
                        CustomerName = txtOrderCustomerName.Text,
                        Address = txtOrderAddress.Text,
                        Price = Convert.ToDouble(numboxOrderPrice.Value),
                        OrderDate = Convert.ToDateTime(dtpOrderOrderedDate.Value),
                        Status = Convert.ToInt32(ddlOrderStatus.SelectedValue.ToString()),
                    };
                    repo.Update(ord);
                    if (MessageBox.Show("Successfully Update Order: " + ord.Id + " !", "Done", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancel Update Order !");
                }
            }
            else
            {
                MessageBox.Show("Your Input Data is not Valid!");
            }
        }
        private bool CheckValid()
        {
            if (txtOrderCustomerName.Text == "" || txtOrderAddress.Text == "")
                return false;
            if (txtOrderCustomerName.Text.Length < 2 || txtOrderAddress.Text.Length < 16)
                return false;
            return true;
        }
    }
}
