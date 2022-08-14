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
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
            Dictionary<int, string> comboSource = new Dictionary<int, string>() {
                {0,"By Id" },{1,"By Name" }
            };
            searchByIdOrName.DataSource = new BindingSource(comboSource, null);
            searchByIdOrName.DisplayMember = "Value";
            searchByIdOrName.ValueMember = "Key";
            searchByIdOrName.SelectedValue = 0;
            LoadData();
        }

        private void LoadData()
        {
            ProductRepository repo = new();
            var product = repo.Get();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = product;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ProductRepository repo = new();
                var updatePro = repo.GetById((int)(dataGridView1.SelectedRows[0].Cells[0].Value));
                if (updatePro != null)
                {
                    DialogResult result = MessageBox.Show("Would You Like to Permanently Delete this Product? " +
                        "\nWe recommend you to change Product ID of all Order Details \nAssociated with this Product's ID before Permanently Deleting it!" +
                        "\n- Yes: Permanently Delete it and it's Associated Items in the Database" +
                        "\n- No: Status Change" +
                        "\n- Cancel: Cancel Changes",
                "Delete", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        int id = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);
                        repo.PermanentDelete(id);
                        MessageBox.Show("Product and it's associated Order Details are Permanently Deleted !");
                    }
                    else if (result == DialogResult.No)
                    {
                        int id = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);
                        repo.Delete(id);
                        MessageBox.Show("Product Status Changed!");
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a Product to Delete!");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct fac = new();
            fac.ShowDialog();
            LoadData();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (txtProductSearchName.Text == "")
            {
                MessageBox.Show("Show All Products!\n You can search a Product By fill in the Name or Id in the Empty Box next to Search Button!");
                LoadData();
            }
            else if (txtProductSearchName.Text != "" && searchByIdOrName.SelectedValue.Equals(0))
            {
                try
                {
                    List<Product> pldh = new List<Product>();
                    ProductRepository repo = new();
                    var product = repo.GetById(Convert.ToInt32(txtProductSearchName.Text));
                    if (product != null)
                    {
                        pldh = new()
                        {
                            product
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
            else if (txtProductSearchName.Text != "" && searchByIdOrName.SelectedValue.Equals(1))
            {
                ProductRepository repo = new();
                var product = repo.GetByName(txtProductSearchName.Text);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = product;
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ProductRepository repo = new();
                var updatePro = repo.GetById((int)(dataGridView1.SelectedRows[0].Cells[0].Value));
                if (updatePro != null)
                {
                    FormUpdateProduct formUpdateProduct = new FormUpdateProduct(updatePro);
                    formUpdateProduct.ShowDialog();
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
                MessageBox.Show("Please select a Product to Update!");
            }
        }
    }
}
