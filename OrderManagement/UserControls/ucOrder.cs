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
    public partial class ucOrder : UserControl
    {
        public ucOrder()
        {
            InitializeComponent();
            Dictionary<int, string> comboSource = new Dictionary<int, string>() {
                {0,"By Id" },{1,"By Customer Name" }
            };
            searchByIdOrName.DataSource = new BindingSource(comboSource, null);
            searchByIdOrName.DisplayMember = "Value";
            searchByIdOrName.ValueMember = "Key";
            searchByIdOrName.SelectedValue = 0;
            LoadData();
        }

        private void LoadData()
        {
            OrderRepository repo = new();
            var order = repo.Get();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = order;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                OrderRepository repo = new();
                var updatePro = repo.GetById((int)(dataGridView1.SelectedRows[0].Cells[0].Value));
                if (updatePro != null)
                {
                    DialogResult result = MessageBox.Show("Would You Like to Permanently Delete this Order? " +
                        "\nWe recommend you to change Order ID of all Order Details and all Payment \nAssociated with this Order's ID before Permanently Deleting it!" +
                        "\n- Yes: Permanently Delete it and it's Associated Items in the Database" +
                        "\n- No: Status Change" +
                        "\n- Cancel: Cancel Changes",
                "Delete", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        int id = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);
                        repo.PermanentDelete(id);
                        MessageBox.Show("Order and it's associated Order Details are Permanently Deleted !");
                    }
                    else if (result == DialogResult.No)
                    {
                        int id = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);
                        repo.Delete(id);
                        MessageBox.Show("Order Status Changed!");
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a Order to Delete!");
            }
        }

        private void btnSearchPayment_Click(object sender, EventArgs e)
        {
            if (txtOrderSearchName.Text == "")
            {
                MessageBox.Show("Show All Orders!\n You can search a Order By fill in the Id or Customer Name in the Empty Box next to Search Button!");
                LoadData();
            }
            else if (txtOrderSearchName.Text != "" && searchByIdOrName.SelectedValue.Equals(0))
            {
                try
                {
                    List<Order> pldh = new List<Order>();
                    OrderRepository repo = new();
                    var order = repo.GetById(Convert.ToInt32(txtOrderSearchName.Text));
                    if (order != null)
                    {
                        pldh = new()
                        {
                            order
                        };
                    }
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = pldh;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Your Input Data is not Valid!");
                }
            }
            else if (txtOrderSearchName.Text != "" && searchByIdOrName.SelectedValue.Equals(1))
            {
                OrderRepository repo = new();
                var order = repo.GetByCustomerName(txtOrderSearchName.Text);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = order;
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FormAddOrder formAddOrder = new FormAddOrder();
            formAddOrder.ShowDialog();
            LoadData();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                OrderRepository repo = new();
                var updateOrd = repo.GetById((int)(dataGridView1.SelectedRows[0].Cells[0].Value));
                if (updateOrd != null)
                {
                    FormUpdateOrder formUpdateOrder = new FormUpdateOrder(updateOrd);
                    formUpdateOrder.ShowDialog();
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
                MessageBox.Show("Please select an Order to Update!");
            }
        }
    }
}
