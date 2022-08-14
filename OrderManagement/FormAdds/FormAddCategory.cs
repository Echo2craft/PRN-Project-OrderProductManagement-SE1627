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
    public partial class FormAddCategory : Form
    {
        public FormAddCategory()
        {
            InitializeComponent();
            LoadStatus();
        }
        private void LoadStatus()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>() {
                {0,"InActive" },{1,"Active" }
            };
            StatusNameListCreate.DataSource = new BindingSource(comboSource, null);
            StatusNameListCreate.DisplayMember = "Value";
            StatusNameListCreate.ValueMember = "Key";
            StatusNameListCreate.SelectedValue = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                if (MessageBox.Show("Are you sure to Create this Category?",
                    "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    CategoryRepository repo = new();
                    var cat = new Category()
                    {
                        Name = txtName.Text,
                        Status = Convert.ToInt32(StatusNameListCreate.SelectedValue.ToString())
                    };
                    repo.Create(cat);
                    if (MessageBox.Show("Successfully Create Category: " + cat.Name + " !", "Done", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancel Create New Category!");
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
