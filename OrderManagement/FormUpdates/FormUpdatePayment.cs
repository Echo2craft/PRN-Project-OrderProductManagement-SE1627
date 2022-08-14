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
    public partial class FormUpdatePayment : Form
    {
        public FormUpdatePayment(Payment pay)
        {
            InitializeComponent();
            LoadOrderID(pay);
            LoadPayType(pay);
            LoadData(pay);
        }
        private void LoadData(Payment pay)
        {
            txtPaymentID.Text = pay.Id.ToString();
            dtpPaymentPayTime.Value = Convert.ToDateTime(pay.PayTime.Value);
            numboxPaymentAmount.Value = Convert.ToInt32(pay.Amount.ToString());
        }
        private void LoadOrderID(Payment pay)
        {
            OrderRepository ordrepo = new();
            ddlPaymentOrderID.DataSource = new BindingSource(ordrepo.Get(), null);
            ddlPaymentOrderID.DisplayMember = "ID";
            ddlPaymentOrderID.ValueMember = "ID";
            ddlPaymentOrderID.SelectedValue = pay.OrderId;
        }
        private void LoadPayType(Payment pay)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>() {
                {0,"By Cashes" },{1,"By Bank Transfer" }, {2,"By MoMo" }
            };
            ddlPaymentPayType.DataSource = new BindingSource(comboSource, null);
            ddlPaymentPayType.DisplayMember = "Value";
            ddlPaymentPayType.ValueMember = "Key";
            ddlPaymentPayType.SelectedValue = pay.PayType;
        }

        private void btnUpdateExistingPayment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Update this Payment?",
                "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                /*CategoryRepository repo = new();
                var cat = new Category()
                {
                    Name = txtName.Text,
                    Status = StatusNameList.SelectedIndex
                };
                repo.Update(cat);*/
                PaymentRepository repo = new();
                var pay = new Payment()
                {
                    Id = Convert.ToInt32(txtPaymentID.Text),
                    Amount = Convert.ToDouble(numboxPaymentAmount.Value),
                    PayTime = Convert.ToDateTime(dtpPaymentPayTime.Value),
                    OrderId = Convert.ToInt32(ddlPaymentOrderID.SelectedValue.ToString()),
                    PayType = Convert.ToInt32(ddlPaymentPayType.SelectedValue.ToString())
                };
                repo.Update(pay);
                if (MessageBox.Show("Successfully Update Payment: " + pay.Id + " !", "Done", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Cancel Update Payment !");
            }
        }
    }
}
