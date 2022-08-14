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
    public partial class FormUpdateProduct : Form
    {
        public FormUpdateProduct(Product product)
        {
            InitializeComponent();
            LoadStatus(product);
            LoadCateId(product);
            LoadData(product);
        }
        private void LoadData(Product product)
        {
            txtProductId.Text = product.Id.ToString();
            txtProductName.Text = product.Name.ToString();
            numboxProductPrice.Value = Convert.ToInt32(product.Price.Value);
            dtpProductCreatedDate.Value = Convert.ToDateTime(product.CreatedDate.Value);
        }
        private void LoadStatus(Product product)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>() {
                {0,"InActive" },{1,"Active" }
            };
            ddlProductStatus.DataSource = new BindingSource(comboSource, null);
            ddlProductStatus.DisplayMember = "Value";
            ddlProductStatus.ValueMember = "Key";
            ddlProductStatus.SelectedValue = product.Status;
        }
        private void LoadCateId(Product product)
        {
            CategoryRepository catrepo = new();
            ddlProductCategoryId.DataSource = new BindingSource(catrepo.Get(), null);
            ddlProductCategoryId.DisplayMember = "Name";
            ddlProductCategoryId.ValueMember = "ID";
            ddlProductCategoryId.SelectedValue = product.CategoryId.Value;
        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
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
                    ProductRepository repo = new();
                    var pro = new Product()
                    {
                        Id = Convert.ToInt32(txtProductId.Text),
                        Name = txtProductName.Text,
                        Price = Convert.ToDouble(numboxProductPrice.Value),
                        CreatedDate = Convert.ToDateTime(dtpProductCreatedDate.Value),
                        Status = Convert.ToInt32(ddlProductStatus.SelectedValue.ToString()),
                        CategoryId = Convert.ToInt32(ddlProductCategoryId.SelectedValue.ToString())
                    };
                    repo.Update(pro);
                    if (MessageBox.Show("Successfully Update Product: " + pro.Id + " !", "Done", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancel Update Product !");
                }
            }
            else
            {
                MessageBox.Show("Your Input Data is not Valid!");
            }
        }
        private bool CheckValid()
        {
            if (txtProductName.Text == "")
                return false;
            return true;
        }
    }
}
