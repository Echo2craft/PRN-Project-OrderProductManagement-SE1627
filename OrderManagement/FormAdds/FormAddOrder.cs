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
    public partial class FormAddOrder : Form
    {
        public FormAddOrder()
        {
            InitializeComponent();
            LoadStatus();
        }
        private void LoadStatus()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>() {
                {0,"InActive" },{1,"Active" }
            };
            ddlStatus.DataSource = new BindingSource(comboSource, null);
            ddlStatus.DisplayMember = "Value";
            ddlStatus.ValueMember = "Key";
            ddlStatus.SelectedValue = 1;
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                if (MessageBox.Show("Are you sure to Create this Order?",
                    "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    OrderRepository repo = new();
                    var ord = new Order()
                    {
                        CustomerName = txtOrderCustomerName.Text,
                        Price = Convert.ToDouble(numboxOrderPrice.Value),
                        OrderDate = Convert.ToDateTime(dtpOrderedDate.Value),
                        Address = txtOrderCustomerAddress.Text,
                        Status = Convert.ToInt32(ddlStatus.SelectedValue.ToString())
                    };
                    repo.Create(ord);
                    if (MessageBox.Show("Successfully Create Order: " + ord.Id + " !", "Done", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancel Create New Order!");
                }
            }
            else
            {
                MessageBox.Show("Your Input Data is not Valid!");
            }
        }
        private bool CheckValid()
        {
            if (txtOrderCustomerName.Text == "" || txtOrderCustomerAddress.Text == "")
                return false;
            if (txtOrderCustomerName.Text.Length < 2 || txtOrderCustomerAddress.Text.Length < 16)
                return false;
            return true;
        }
    }
}
