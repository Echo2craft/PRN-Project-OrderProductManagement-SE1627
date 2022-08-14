
namespace OrderManagement
{
    partial class FormAddOrderDetail
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
            this.numboxODQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numboxODPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewOrderDetail = new System.Windows.Forms.Button();
            this.ddlODProductID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlODOrderID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numboxODQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numboxODPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // numboxODQuantity
            // 
            this.numboxODQuantity.Location = new System.Drawing.Point(128, 67);
            this.numboxODQuantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numboxODQuantity.Name = "numboxODQuantity";
            this.numboxODQuantity.Size = new System.Drawing.Size(115, 23);
            this.numboxODQuantity.TabIndex = 17;
            this.numboxODQuantity.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "New OD Quantity";
            // 
            // numboxODPrice
            // 
            this.numboxODPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numboxODPrice.Location = new System.Drawing.Point(128, 96);
            this.numboxODPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numboxODPrice.Name = "numboxODPrice";
            this.numboxODPrice.Size = new System.Drawing.Size(115, 23);
            this.numboxODPrice.TabIndex = 19;
            this.numboxODPrice.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "New OD Price";
            // 
            // btnAddNewOrderDetail
            // 
            this.btnAddNewOrderDetail.Location = new System.Drawing.Point(83, 125);
            this.btnAddNewOrderDetail.Name = "btnAddNewOrderDetail";
            this.btnAddNewOrderDetail.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewOrderDetail.TabIndex = 20;
            this.btnAddNewOrderDetail.Text = "Add";
            this.btnAddNewOrderDetail.UseVisualStyleBackColor = true;
            this.btnAddNewOrderDetail.Click += new System.EventHandler(this.btnAddNewOrderDetail_Click);
            // 
            // ddlODProductID
            // 
            this.ddlODProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlODProductID.FormattingEnabled = true;
            this.ddlODProductID.Location = new System.Drawing.Point(128, 6);
            this.ddlODProductID.Name = "ddlODProductID";
            this.ddlODProductID.Size = new System.Drawing.Size(115, 23);
            this.ddlODProductID.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "New OD Product ID";
            // 
            // ddlODOrderID
            // 
            this.ddlODOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlODOrderID.FormattingEnabled = true;
            this.ddlODOrderID.Location = new System.Drawing.Point(128, 38);
            this.ddlODOrderID.Name = "ddlODOrderID";
            this.ddlODOrderID.Size = new System.Drawing.Size(115, 23);
            this.ddlODOrderID.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "New OD Order ID";
            // 
            // FormAddOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 156);
            this.Controls.Add(this.ddlODOrderID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlODProductID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddNewOrderDetail);
            this.Controls.Add(this.numboxODPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numboxODQuantity);
            this.Controls.Add(this.label2);
            this.Name = "FormAddOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Order Detail";
            ((System.ComponentModel.ISupportInitialize)(this.numboxODQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numboxODPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numboxODQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numboxODPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewOrderDetail;
        private System.Windows.Forms.ComboBox ddlODProductID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlODOrderID;
        private System.Windows.Forms.Label label3;
    }
}