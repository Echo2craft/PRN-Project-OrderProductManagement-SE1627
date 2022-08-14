using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProductRepo1.Models;
using ProductRepo1.Repository;

namespace OrderManagement
{
    public partial class FormUpdateCategory : Form
    {
        public FormUpdateCategory(Category cat)
        {
            InitializeComponent();
            LoadData(cat);
        }
        private void LoadData(Category cat)
        {
            txtId.Text = cat.Id.ToString();
            txtName.Text = cat.Name.ToString();
            StatusNameList.SelectedValue = cat.Status;

            Dictionary<int, string> comboSource = new Dictionary<int, string>() {
                {0,"InActive" },{1,"Active" }
            };
            StatusNameList.DataSource = new BindingSource(comboSource, null);
            StatusNameList.DisplayMember = "Value";
            StatusNameList.ValueMember = "Key";
        }
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                if (MessageBox.Show("Are you sure to Update this Category?",
                "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    /*CategoryRepository repo = new();
                    var cat = new Category()
                    {
                        Name = txtName.Text,
                        Status = StatusNameList.SelectedIndex
                    };
                    repo.Update(cat);*/
                    CategoryRepository repo = new();
                    var cat = new Category()
                    {
                        Id = Convert.ToInt32(txtId.Text),
                        Name = txtName.Text,
                        Status = Convert.ToInt32(StatusNameList.SelectedValue.ToString())
                    };
                    repo.Update(cat);
                    if(MessageBox.Show("Successfully Update Category: "+ cat.Id + " !", "Done",MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancel Update Category !");
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
            if (txtName.Text.Length > 6)
                return false;
            return true;
        }
    }
}
