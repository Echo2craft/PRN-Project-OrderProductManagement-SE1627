
namespace OrderManagement
{
    partial class FormAddOrder
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numboxOrderPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.dtpOrderedDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderCustomerAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numboxOrderPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlStatus
            // 
            this.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Location = new System.Drawing.Point(111, 156);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(180, 23);
            this.ddlStatus.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "New Order Status";
            // 
            // numboxOrderPrice
            // 
            this.numboxOrderPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numboxOrderPrice.Location = new System.Drawing.Point(111, 82);
            this.numboxOrderPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numboxOrderPrice.Name = "numboxOrderPrice";
            this.numboxOrderPrice.Size = new System.Drawing.Size(180, 23);
            this.numboxOrderPrice.TabIndex = 15;
            this.numboxOrderPrice.ThousandsSeparator = true;
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.Location = new System.Drawing.Point(111, 185);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewOrder.TabIndex = 18;
            this.btnAddNewOrder.Text = "Add";
            this.btnAddNewOrder.UseVisualStyleBackColor = true;
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
            // 
            // dtpOrderedDate
            // 
            this.dtpOrderedDate.Location = new System.Drawing.Point(12, 127);
            this.dtpOrderedDate.MinDate = new System.DateTime(2022, 7, 17, 0, 0, 0, 0);
            this.dtpOrderedDate.Name = "dtpOrderedDate";
            this.dtpOrderedDate.Size = new System.Drawing.Size(279, 23);
            this.dtpOrderedDate.TabIndex = 17;
            this.dtpOrderedDate.Value = new System.DateTime(2022, 7, 18, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "New Order Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "New Order Price";
            // 
            // txtOrderCustomerName
            // 
            this.txtOrderCustomerName.Location = new System.Drawing.Point(182, 6);
            this.txtOrderCustomerName.Name = "txtOrderCustomerName";
            this.txtOrderCustomerName.Size = new System.Drawing.Size(109, 23);
            this.txtOrderCustomerName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "New Order Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "New Order Customer Address";
            // 
            // txtOrderCustomerAddress
            // 
            this.txtOrderCustomerAddress.Location = new System.Drawing.Point(12, 53);
            this.txtOrderCustomerAddress.Name = "txtOrderCustomerAddress";
            this.txtOrderCustomerAddress.Size = new System.Drawing.Size(279, 23);
            this.txtOrderCustomerAddress.TabIndex = 22;
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 215);
            this.Controls.Add(this.txtOrderCustomerAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numboxOrderPrice);
            this.Controls.Add(this.btnAddNewOrder);
            this.Controls.Add(this.dtpOrderedDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Order";
            ((System.ComponentModel.ISupportInitialize)(this.numboxOrderPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numboxOrderPrice;
        private System.Windows.Forms.Button btnAddNewOrder;
        private System.Windows.Forms.DateTimePicker dtpOrderedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderCustomerAddress;
    }
}