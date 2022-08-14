using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductRepo1.Repository;
using ProductRepo1.Models;

namespace OrderManagement
{
    public partial class ucCategory : UserControl
    {
        public ucCategory()
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
            CategoryRepository repo = new();
            var category = repo.Get();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = category;

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory fac = new();
            fac.ShowDialog();
            LoadData();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CategoryRepository repo = new();
                var updateCat = repo.GetById((int)(dataGridView1.SelectedRows[0].Cells[0].Value));
                if (updateCat != null)
                {
                    DialogResult result = MessageBox.Show("Would You Like to Permanently Delete this Category? " +
                        "\nWe recommend you to change Category ID of all Products \nAssociated with this Category's ID before Permanently Deleting it!" +
                        "\n- Yes: Permanently Delete it and it's Associated Items in the Database" +
                        "\n- No: Status Change" +
                        "\n- Cancel: Cancel Changes",
                "Delete", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        int id = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);
                        repo.PermanentDelete(id);
                        MessageBox.Show("Category and it's associated Products are Permanently Deleted !");
                    }
                    else if(result == DialogResult.No)
                    {
                        int id = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);
                        repo.Delete(id);
                        MessageBox.Show("Category Status Changed!");
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a Category to Delete!");
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                CategoryRepository repo = new();
                var updateCat = repo.GetById((int)(dataGridView1.SelectedRows[0].Cells[0].Value));
                if (updateCat != null)
                {
                    FormUpdateCategory formUpdateCategory = new FormUpdateCategory(updateCat);
                    formUpdateCategory.ShowDialog();
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
                MessageBox.Show("Please select a Category to Update!");
            }
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
                if (txtCategorySearchName.Text == "")
                {
                    MessageBox.Show("Show All Categories!\n You can search a Category By fill in the Name or Id in the Empty Box next to Search Button!");
                    LoadData();
                }
                else if (txtCategorySearchName.Text != "" && searchByIdOrName.SelectedValue.Equals(0))
                {
                    try
                    {
                        List<Category> pldh = new List<Category>();
                        CategoryRepository repo = new();
                        var category = repo.GetById(Convert.ToInt32(txtCategorySearchName.Text));
                        if (category != null)
                        {
                            pldh = new()
                            {
                                category
                            };
                        }
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = pldh;
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("Your Input Data is not Valid!");
                    }
                }
                else if (txtCategorySearchName.Text != "" && searchByIdOrName.SelectedValue.Equals(1))
                {
                    CategoryRepository repo = new();
                    var category = repo.GetByName(txtCategorySearchName.Text.ToUpper());
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = category;
                }
        }
    }
}
