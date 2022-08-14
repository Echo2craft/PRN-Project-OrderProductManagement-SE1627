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
    public partial class FormAddPayment : Form
    {
        public FormAddPayment()
        {
            InitializeComponent();
            LoadOrderID();
            LoadPayType();
        }
        private void LoadOrderID()
        {
            OrderRepository ordrepo = new();
            ddlPaymentOrderID.DataSource = new BindingSource(ordrepo.Get(), null);
            ddlPaymentOrderID.DisplayMember = "ID";
            ddlPaymentOrderID.ValueMember = "ID";
            ddlPaymentOrderID.SelectedValue = ordrepo.Get().First().Id;
        }
        private void LoadPayType()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>() {
                {0,"By Cashes" },{1,"By Bank Transfer" }, {2,"By MoMo" }
            };
            ddlPaymentPayType.DataSource = new BindingSource(comboSource, null);
            ddlPaymentPayType.DisplayMember = "Value";
            ddlPaymentPayType.ValueMember = "Key";
            ddlPaymentPayType.SelectedValue = 0;
        }
        /*private bool CheckValid()
        {
            if (dtpPaymentPayTime. == "")
                return false;
            return true;
        }*/

        private void btnAddNewPayment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Create this Payment?",
                    "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                PaymentRepository repo = new();
                var pay = new Payment()
                {
                    PayTime = Convert.ToDateTime(dtpPaymentPayTime.Value),
                    Amount = Convert.ToDouble(numboxPaymentAmount.Value),
                    OrderId = Convert.ToInt32(ddlPaymentOrderID.SelectedValue.ToString()),
                    PayType = Convert.ToInt32(ddlPaymentPayType.SelectedValue.ToString())
                };
                if (MessageBox.Show("Successfully Create Payment "+ repo.Create(pay)+" !", "Done", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Cancel Create New Payment!");
            }
        }
    }
}
