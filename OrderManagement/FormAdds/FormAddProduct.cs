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
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
            LoadCateID();
            LoadStatus();
        }
        private void LoadCateID()
        {
            CategoryRepository catrepo = new();
            ddlCategoryId.DataSource = new BindingSource(catrepo.Get(), null);
            ddlCategoryId.DisplayMember = "Name";
            ddlCategoryId.ValueMember = "ID";
            ddlCategoryId.SelectedValue = catrepo.Get().First().Id;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                if (MessageBox.Show("Are you sure to Create this Product?",
                    "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ProductRepository repo = new();
                    var pro = new Product()
                    {
                        Name = txtName.Text,
                        Price = Convert.ToDouble(numboxPrice.Value),
                        CreatedDate = Convert.ToDateTime(dtpCreatedDate.Value),
                        CategoryId =  Convert.ToInt32(ddlCategoryId.SelectedValue.ToString()),
                        Status = Convert.ToInt32(ddlStatus.SelectedValue.ToString())
                    };
                    repo.Create(pro);
                    if (MessageBox.Show("Successfully Create Product: " + pro.Name + " !", "Done", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancel Create New Product!");
                }
            }
            else
            {
                MessageBox.Show("Your Input Data is not Valid!");
            }
        }
        private bool CheckValid()
        {
            if (txtName.Text == "")
                return false;
            return true;
        }
    }
}
