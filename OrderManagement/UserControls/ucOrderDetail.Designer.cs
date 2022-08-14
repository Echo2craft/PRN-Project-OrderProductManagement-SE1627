
namespace OrderManagement
{
    partial class ucOrderDetail
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchByIdOrName = new System.Windows.Forms.ComboBox();
            this.txtOrderDetailSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchOrderDetail = new System.Windows.Forms.Button();
            this.btnDeleteOrderDetail = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDetailProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDetailOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDetailQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchByIdOrName
            // 
            this.searchByIdOrName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByIdOrName.FormattingEnabled = true;
            this.searchByIdOrName.Location = new System.Drawing.Point(246, 355);
            this.searchByIdOrName.Name = "searchByIdOrName";
            this.searchByIdOrName.Size = new System.Drawing.Size(114, 23);
            this.searchByIdOrName.TabIndex = 30;
            // 
            // txtOrderDetailSearchName
            // 
            this.txtOrderDetailSearchName.Location = new System.Drawing.Point(3, 355);
            this.txtOrderDetailSearchName.Name = "txtOrderDetailSearchName";
            this.txtOrderDetailSearchName.Size = new System.Drawing.Size(156, 23);
            this.txtOrderDetailSearchName.TabIndex = 29;
            // 
            // btnSearchOrderDetail
            // 
            this.btnSearchOrderDetail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchOrderDetail.Location = new System.Drawing.Point(165, 355);
            this.btnSearchOrderDetail.Name = "btnSearchOrderDetail";
            this.btnSearchOrderDetail.Size = new System.Drawing.Size(75, 23);
            this.btnSearchOrderDetail.TabIndex = 28;
            this.btnSearchOrderDetail.Text = "Search";
            this.btnSearchOrderDetail.UseVisualStyleBackColor = false;
            this.btnSearchOrderDetail.Click += new System.EventHandler(this.btnSearchOrderDetail_Click);
            // 
            // btnDeleteOrderDetail
            // 
            this.btnDeleteOrderDetail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteOrderDetail.Location = new System.Drawing.Point(165, 326);
            this.btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            this.btnDeleteOrderDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrderDetail.TabIndex = 27;
            this.btnDeleteOrderDetail.Text = "Delete";
            this.btnDeleteOrderDetail.UseVisualStyleBackColor = false;
            this.btnDeleteOrderDetail.Click += new System.EventHandler(this.btnDeleteOrderDetail_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateProduct.Location = new System.Drawing.Point(84, 326);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProduct.TabIndex = 26;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddProduct.Location = new System.Drawing.Point(3, 326);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 25;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderDetailId,
            this.OrderDetailProductID,
            this.OrderDetailOrderID,
            this.OrderDetailQuantity,
            this.OrderDetailPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(700, 320);
            this.dataGridView1.TabIndex = 24;
            // 
            // OrderDetailId
            // 
            this.OrderDetailId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderDetailId.DataPropertyName = "Id";
            this.OrderDetailId.HeaderText = "Id";
            this.OrderDetailId.Name = "OrderDetailId";
            this.OrderDetailId.ReadOnly = true;
            this.OrderDetailId.Width = 42;
            // 
            // OrderDetailProductID
            // 
            this.OrderDetailProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderDetailProductID.DataPropertyName = "ProductID";
            this.OrderDetailProductID.HeaderText = "Product ID";
            this.OrderDetailProductID.Name = "OrderDetailProductID";
            this.OrderDetailProductID.ReadOnly = true;
            this.OrderDetailProductID.Width = 88;
            // 
            // OrderDetailOrderID
            // 
            this.OrderDetailOrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderDetailOrderID.DataPropertyName = "Orderid";
            this.OrderDetailOrderID.HeaderText = "Order ID";
            this.OrderDetailOrderID.Name = "OrderDetailOrderID";
            this.OrderDetailOrderID.ReadOnly = true;
            this.OrderDetailOrderID.Width = 76;
            // 
            // OrderDetailQuantity
            // 
            this.OrderDetailQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderDetailQuantity.DataPropertyName = "Quantity";
            this.OrderDetailQuantity.HeaderText = "Quantity";
            this.OrderDetailQuantity.Name = "OrderDetailQuantity";
            this.OrderDetailQuantity.ReadOnly = true;
            this.OrderDetailQuantity.Width = 78;
            // 
            // OrderDetailPrice
            // 
            this.OrderDetailPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderDetailPrice.DataPropertyName = "Price";
            this.OrderDetailPrice.HeaderText = "Price";
            this.OrderDetailPrice.Name = "OrderDetailPrice";
            this.OrderDetailPrice.ReadOnly = true;
            this.OrderDetailPrice.Width = 58;
            // 
            // ucOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.searchByIdOrName);
            this.Controls.Add(this.txtOrderDetailSearchName);
            this.Controls.Add(this.btnSearchOrderDetail);
            this.Controls.Add(this.btnDeleteOrderDetail);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ucOrderDetail";
            this.Size = new System.Drawing.Size(700, 383);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchByIdOrName;
        private System.Windows.Forms.TextBox txtOrderDetailSearchName;
        private System.Windows.Forms.Button btnSearchOrderDetail;
        private System.Windows.Forms.Button btnDeleteOrderDetail;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDetailProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDetailOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDetailQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDetailPrice;
    }
}
