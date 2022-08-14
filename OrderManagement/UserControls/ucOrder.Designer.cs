
namespace OrderManagement
{
    partial class ucOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.searchByIdOrName = new System.Windows.Forms.ComboBox();
            this.txtOrderSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchPayment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.OrderCustomerName,
            this.OrderAddress,
            this.OrderPrice,
            this.OrderOrderDate,
            this.OrderStatus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(700, 320);
            this.dataGridView1.TabIndex = 2;
            // 
            // OrderID
            // 
            this.OrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderID.DataPropertyName = "Id";
            this.OrderID.HeaderText = "Id";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Width = 42;
            // 
            // OrderCustomerName
            // 
            this.OrderCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderCustomerName.DataPropertyName = "CustomerName";
            this.OrderCustomerName.HeaderText = "Customer Name";
            this.OrderCustomerName.Name = "OrderCustomerName";
            this.OrderCustomerName.ReadOnly = true;
            this.OrderCustomerName.Width = 109;
            // 
            // OrderAddress
            // 
            this.OrderAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderAddress.DataPropertyName = "Address";
            this.OrderAddress.HeaderText = "Address";
            this.OrderAddress.Name = "OrderAddress";
            this.OrderAddress.ReadOnly = true;
            this.OrderAddress.Width = 74;
            // 
            // OrderPrice
            // 
            this.OrderPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderPrice.DataPropertyName = "Price";
            this.OrderPrice.HeaderText = "Price";
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.ReadOnly = true;
            this.OrderPrice.Width = 58;
            // 
            // OrderOrderDate
            // 
            this.OrderOrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderOrderDate.DataPropertyName = "OrderDate";
            this.OrderOrderDate.HeaderText = "Order Date";
            this.OrderOrderDate.Name = "OrderOrderDate";
            this.OrderOrderDate.ReadOnly = true;
            this.OrderOrderDate.Width = 82;
            // 
            // OrderStatus
            // 
            this.OrderStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderStatus.DataPropertyName = "Status";
            this.OrderStatus.HeaderText = "Status";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            this.OrderStatus.Width = 64;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteOrder.Location = new System.Drawing.Point(165, 326);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrder.TabIndex = 7;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateOrder.Location = new System.Drawing.Point(84, 326);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateOrder.TabIndex = 6;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddOrder.Location = new System.Drawing.Point(3, 326);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 5;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // searchByIdOrName
            // 
            this.searchByIdOrName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByIdOrName.FormattingEnabled = true;
            this.searchByIdOrName.Location = new System.Drawing.Point(246, 355);
            this.searchByIdOrName.Name = "searchByIdOrName";
            this.searchByIdOrName.Size = new System.Drawing.Size(125, 23);
            this.searchByIdOrName.TabIndex = 26;
            // 
            // txtOrderSearchName
            // 
            this.txtOrderSearchName.Location = new System.Drawing.Point(3, 355);
            this.txtOrderSearchName.Name = "txtOrderSearchName";
            this.txtOrderSearchName.Size = new System.Drawing.Size(156, 23);
            this.txtOrderSearchName.TabIndex = 25;
            // 
            // btnSearchPayment
            // 
            this.btnSearchPayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchPayment.Location = new System.Drawing.Point(165, 355);
            this.btnSearchPayment.Name = "btnSearchPayment";
            this.btnSearchPayment.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPayment.TabIndex = 24;
            this.btnSearchPayment.Text = "Search";
            this.btnSearchPayment.UseVisualStyleBackColor = false;
            this.btnSearchPayment.Click += new System.EventHandler(this.btnSearchPayment_Click);
            // 
            // ucOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.searchByIdOrName);
            this.Controls.Add(this.txtOrderSearchName);
            this.Controls.Add(this.btnSearchPayment);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ucOrder";
            this.Size = new System.Drawing.Size(700, 383);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.ComboBox searchByIdOrName;
        private System.Windows.Forms.TextBox txtOrderSearchName;
        private System.Windows.Forms.Button btnSearchPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
    }
}
