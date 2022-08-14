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
    public partial class ucPayment : UserControl
    {
        public ucPayment()
        {
            InitializeComponent();
            Dictionary<int, string> comboSource = new Dictionary<int, string>() {
                {0,"By Id" },{1,"By Order Id" }
            };
            searchByIdOrName.DataSource = new BindingSource(comboSource, null);
            searchByIdOrName.DisplayMember = "Value";
            searchByIdOrName.ValueMember = "Key";
            searchByIdOrName.SelectedValue = 0;
            LoadData();
        }
        private void LoadData()
        {
            PaymentRepository repo = new();
            var payment = repo.Get();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = payment;
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                PaymentRepository repo = new();
                var updatePro = repo.GetById((int)(dataGridView1.SelectedRows[0].Cells[0].Value));
                if (updatePro != null)
                {
                    DialogResult result = MessageBox.Show("Would You Like to Permanently Delete this Payment? \n" +
                        "\n- Ok: Permanently Delete it" +
                        "\n- Cancel: Cancel Changes",
                "Delete", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        int id = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);
                        repo.Delete(id);
                        MessageBox.Show("Payment Permanently Deleted !");
                    }
                    LoadData();
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a Payment to Delete!");
            }
        }

        private void btnSearchPayment_Click(object sender, EventArgs e)
        {
            if (txtPaymentSearchName.Text == "")
            {
                MessageBox.Show("Show All Payments!\n You can search a Payment By fill in the Id or Order Id in the Empty Box next to Search Button!");
                LoadData();
            }
            else if (txtPaymentSearchName.Text != "" && searchByIdOrName.SelectedValue.Equals(0))
            {
                try
                {
                    List<Payment> pldh = new List<Payment>();
                    PaymentRepository repo = new();
                    var payment = repo.GetById(Convert.ToInt32(txtPaymentSearchName.Text));
                    if (payment != null)
                    {
                        pldh = new()
                        {
                            payment
                        };
                    }
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = pldh;
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Your Input Data is not Valid!");
                }
            }
            else if (txtPaymentSearchName.Text != "" && searchByIdOrName.SelectedValue.Equals(1))
            {
                try
                {
                    PaymentRepository repo = new();
                    var payment = repo.GetByOrderId(Convert.ToInt32(txtPaymentSearchName.Text));
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = payment;
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Your Input Data is not Valid!");
                }
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            FormAddPayment formAddPayment = new FormAddPayment();
            formAddPayment.ShowDialog();
            LoadData();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                PaymentRepository repo = new();
                var updatePay = repo.GetById((int)(dataGridView1.SelectedRows[0].Cells[0].Value));
                if (updatePay != null)
                {
                    FormUpdatePayment formUpdatePayment = new FormUpdatePayment(updatePay);
                    formUpdatePayment.ShowDialog();
                }
                /*FormUpdateCategory fuc = new();
                fuc.ShowDialog();
                var cate = new Category()
                {
                    Id = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                    Name = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                    Status = (int)dataGridView1.SelectedRows[0].Cells[2].Value
                };
                fuc.LoadCategory(cate);*/
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select an Payment to Update!");
            }
        }
    }
}
