
namespace OrderManagement
{
    partial class FormUpdateOrder
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
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlOrderStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numboxOrderPrice = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.dtpOrderOrderedDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numboxOrderPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrderId
            // 
            this.txtOrderId.Enabled = false;
            this.txtOrderId.Location = new System.Drawing.Point(148, 6);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(142, 23);
            this.txtOrderId.TabIndex = 35;
            this.txtOrderId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Order ID";
            // 
            // ddlOrderStatus
            // 
            this.ddlOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlOrderStatus.FormattingEnabled = true;
            this.ddlOrderStatus.Location = new System.Drawing.Point(148, 181);
            this.ddlOrderStatus.Name = "ddlOrderStatus";
            this.ddlOrderStatus.Size = new System.Drawing.Size(142, 23);
            this.ddlOrderStatus.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Order Status";
            // 
            // numboxOrderPrice
            // 
            this.numboxOrderPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numboxOrderPrice.Location = new System.Drawing.Point(148, 108);
            this.numboxOrderPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numboxOrderPrice.Name = "numboxOrderPrice";
            this.numboxOrderPrice.Size = new System.Drawing.Size(142, 23);
            this.numboxOrderPrice.TabIndex = 28;
            this.numboxOrderPrice.ThousandsSeparator = true;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(112, 210);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateOrder.TabIndex = 31;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // dtpOrderOrderedDate
            // 
            this.dtpOrderOrderedDate.Location = new System.Drawing.Point(12, 152);
            this.dtpOrderOrderedDate.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dtpOrderOrderedDate.Name = "dtpOrderOrderedDate";
            this.dtpOrderOrderedDate.Size = new System.Drawing.Size(278, 23);
            this.dtpOrderOrderedDate.TabIndex = 30;
            this.dtpOrderOrderedDate.Value = new System.DateTime(2022, 7, 17, 20, 21, 21, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Order Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Order Price";
            // 
            // txtOrderCustomerName
            // 
            this.txtOrderCustomerName.Location = new System.Drawing.Point(148, 35);
            this.txtOrderCustomerName.Name = "txtOrderCustomerName";
            this.txtOrderCustomerName.Size = new System.Drawing.Size(142, 23);
            this.txtOrderCustomerName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Order Customer  Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Order Customer  Address";
            // 
            // txtOrderAddress
            // 
            this.txtOrderAddress.Location = new System.Drawing.Point(12, 79);
            this.txtOrderAddress.Name = "txtOrderAddress";
            this.txtOrderAddress.Size = new System.Drawing.Size(278, 23);
            this.txtOrderAddress.TabIndex = 37;
            // 
            // FormUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 240);
            this.Controls.Add(this.txtOrderAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddlOrderStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numboxOrderPrice);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.dtpOrderOrderedDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Existing Order";
            ((System.ComponentModel.ISupportInitialize)(this.numboxOrderPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlOrderStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numboxOrderPrice;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.DateTimePicker dtpOrderOrderedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderAddress;
    }
}