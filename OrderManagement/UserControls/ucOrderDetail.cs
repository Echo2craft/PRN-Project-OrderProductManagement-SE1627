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
    public partial class ucOrderDetail : UserControl
    {
        public ucOrderDetail()
        {
            InitializeComponent();
            Dictionary<int, string> comboSource = new Dictionary<int, string>() {
                {0,"By Id" },{1,"By Order Id" },{2,"By Product Id"}
            };
            searchByIdOrName.DataSource = new BindingSource(comboSource, null);
            searchByIdOrName.DisplayMember = "Value";
            searchByIdOrName.ValueMember = "Key";
            searchByIdOrName.SelectedValue = 0;
            LoadData();
        }
        private void LoadData()
        {
            OrderDetailRepository repo = new();
            var orderdetail = repo.Get();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = orderdetail;
        }
        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                OrderDetailRepository repo = new();
                var updatePro = repo.GetById((int)(dataGridView1.SelectedRows[0].Cells[0].Value));
                if (updatePro != null)
                {
                    DialogResult result = MessageBox.Show("Would You Like to Permanently Delete this Order Detail? \n" +
                        "\n- Ok: Permanently Delete it" +
                        "\n- Cancel: Cancel Changes",
                "Delete", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        int id = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);
                        repo.Delete(id);
                        MessageBox.Show("Order Detail Permanently Deleted !");
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a Order Detail to Delete!");
            }
        }

        private void btnSearchOrderDetail_Click(object sender, EventArgs e)
        {
            if (txtOrderDetailSearchName.Text == "")
            {
                MessageBox.Show("Show All Order Details!\n You can search a Order Detail By fill in the Id or Order Id or Product Id in the Empty Box next to Search Button!");
                LoadData();
            }
            else if (txtOrderDetailSearchName.Text != "" && searchByIdOrName.SelectedValue.Equals(0))
            {
                try
                {
                    List<OrderDetail> pldh = new List<OrderDetail>();
                    OrderDetailRepository repo = new();
                    var order = repo.GetById(Convert.ToInt32(txtOrderDetailSearchName.Text));
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
            else if (txtOrderDetailSearchName.Text != "" && searchByIdOrName.SelectedValue.Equals(1))
            {
                try
                {
                    OrderDetailRepository repo = new();
                    var order = repo.GetByOrderId(Convert.ToInt32(txtOrderDetailSearchName.Text));
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = order;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Your Input Data is not Valid!");
                }
            }
            else if (txtOrderDetailSearchName.Text != "" && searchByIdOrName.SelectedValue.Equals(2))
            {
                try
                {
                    OrderDetailRepository repo = new();
                    var order = repo.GetByProductId(Convert.ToInt32(txtOrderDetailSearchName.Text));
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = order;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Your Input Data is not Valid!");
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormAddOrderDetail formAddOrderDetail = new FormAddOrderDetail();
            formAddOrderDetail.ShowDialog();
            LoadData();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                OrderDetailRepository repo = new();
                var updateOrdde = repo.GetById((int)(dataGridView1.SelectedRows[0].Cells[0].Value));
                if (updateOrdde != null)
                {
                    FormUpdateOrderDetail formUpdateOrderDetail = new FormUpdateOrderDetail(updateOrdde);
                    formUpdateOrderDetail.ShowDialog();
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
                MessageBox.Show("Please select an Order Detail to Update!");
            }
        }
    }
}
