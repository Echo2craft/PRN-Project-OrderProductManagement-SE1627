
namespace OrderManagement
{
    partial class FormUpdateOrderDetail
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
            this.txtOderDetailId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlODOrderID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlODProductID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateExistingOrderDetail = new System.Windows.Forms.Button();
            this.numboxODPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numboxODQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numboxODPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numboxODQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOderDetailId
            // 
            this.txtOderDetailId.Enabled = false;
            this.txtOderDetailId.Location = new System.Drawing.Point(148, 11);
            this.txtOderDetailId.Name = "txtOderDetailId";
            this.txtOderDetailId.ReadOnly = true;
            this.txtOderDetailId.Size = new System.Drawing.Size(109, 23);
            this.txtOderDetailId.TabIndex = 26;
            this.txtOderDetailId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Order Detail ID";
            // 
            // ddlODOrderID
            // 
            this.ddlODOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlODOrderID.FormattingEnabled = true;
            this.ddlODOrderID.Location = new System.Drawing.Point(148, 72);
            this.ddlODOrderID.Name = "ddlODOrderID";
            this.ddlODOrderID.Size = new System.Drawing.Size(109, 23);
            this.ddlODOrderID.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Order Detail Order ID";
            // 
            // ddlODProductID
            // 
            this.ddlODProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlODProductID.FormattingEnabled = true;
            this.ddlODProductID.Location = new System.Drawing.Point(148, 40);
            this.ddlODProductID.Name = "ddlODProductID";
            this.ddlODProductID.Size = new System.Drawing.Size(109, 23);
            this.ddlODProductID.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Order Detail Product ID";
            // 
            // btnUpdateExistingOrderDetail
            // 
            this.btnUpdateExistingOrderDetail.Location = new System.Drawing.Point(97, 159);
            this.btnUpdateExistingOrderDetail.Name = "btnUpdateExistingOrderDetail";
            this.btnUpdateExistingOrderDetail.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateExistingOrderDetail.TabIndex = 31;
            this.btnUpdateExistingOrderDetail.Text = "Update";
            this.btnUpdateExistingOrderDetail.UseVisualStyleBackColor = true;
            this.btnUpdateExistingOrderDetail.Click += new System.EventHandler(this.btnUpdateExistingOrderDetail_Click);
            // 
            // numboxODPrice
            // 
            this.numboxODPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numboxODPrice.Location = new System.Drawing.Point(148, 130);
            this.numboxODPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numboxODPrice.Name = "numboxODPrice";
            this.numboxODPrice.Size = new System.Drawing.Size(109, 23);
            this.numboxODPrice.TabIndex = 30;
            this.numboxODPrice.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Order Detail Price";
            // 
            // numboxODQuantity
            // 
            this.numboxODQuantity.Location = new System.Drawing.Point(148, 101);
            this.numboxODQuantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numboxODQuantity.Name = "numboxODQuantity";
            this.numboxODQuantity.Size = new System.Drawing.Size(109, 23);
            this.numboxODQuantity.TabIndex = 28;
            this.numboxODQuantity.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Order Detail Quantity";
            // 
            // FormUpdateOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 192);
            this.Controls.Add(this.ddlODOrderID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlODProductID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdateExistingOrderDetail);
            this.Controls.Add(this.numboxODPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numboxODQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOderDetailId);
            this.Controls.Add(this.label5);
            this.Name = "FormUpdateOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Existing Order Detail";
            ((System.ComponentModel.ISupportInitialize)(this.numboxODPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numboxODQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOderDetailId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlODOrderID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlODProductID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateExistingOrderDetail;
        private System.Windows.Forms.NumericUpDown numboxODPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numboxODQuantity;
        private System.Windows.Forms.Label label2;
    }
}