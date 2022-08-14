
namespace OrderManagement
{
    partial class FormUpdateProduct
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
            this.ddlProductStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlProductCategoryId = new System.Windows.Forms.ComboBox();
            this.numboxProductPrice = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpProductCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numboxProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlProductStatus
            // 
            this.ddlProductStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlProductStatus.FormattingEnabled = true;
            this.ddlProductStatus.Location = new System.Drawing.Point(130, 140);
            this.ddlProductStatus.Name = "ddlProductStatus";
            this.ddlProductStatus.Size = new System.Drawing.Size(109, 23);
            this.ddlProductStatus.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Product Status";
            // 
            // ddlProductCategoryId
            // 
            this.ddlProductCategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlProductCategoryId.FormattingEnabled = true;
            this.ddlProductCategoryId.Location = new System.Drawing.Point(130, 169);
            this.ddlProductCategoryId.Name = "ddlProductCategoryId";
            this.ddlProductCategoryId.Size = new System.Drawing.Size(109, 23);
            this.ddlProductCategoryId.TabIndex = 20;
            // 
            // numboxProductPrice
            // 
            this.numboxProductPrice.Location = new System.Drawing.Point(130, 64);
            this.numboxProductPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numboxProductPrice.Name = "numboxProductPrice";
            this.numboxProductPrice.Size = new System.Drawing.Size(109, 23);
            this.numboxProductPrice.TabIndex = 15;
            this.numboxProductPrice.ThousandsSeparator = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(87, 198);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProduct.TabIndex = 19;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Product Category Id";
            // 
            // dtpProductCreatedDate
            // 
            this.dtpProductCreatedDate.Location = new System.Drawing.Point(12, 111);
            this.dtpProductCreatedDate.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dtpProductCreatedDate.Name = "dtpProductCreatedDate";
            this.dtpProductCreatedDate.Size = new System.Drawing.Size(227, 23);
            this.dtpProductCreatedDate.TabIndex = 17;
            this.dtpProductCreatedDate.Value = new System.DateTime(2022, 7, 17, 20, 21, 21, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product Created Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Product Price";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(130, 35);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(109, 23);
            this.txtProductName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product Name";
            // 
            // txtProductId
            // 
            this.txtProductId.Enabled = false;
            this.txtProductId.Location = new System.Drawing.Point(130, 6);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(109, 23);
            this.txtProductId.TabIndex = 24;
            this.txtProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Product ID";
            // 
            // FormUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 229);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddlProductStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddlProductCategoryId);
            this.Controls.Add(this.numboxProductPrice);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpProductCreatedDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Existing Product";
            ((System.ComponentModel.ISupportInitialize)(this.numboxProductPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlProductStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlProductCategoryId;
        private System.Windows.Forms.NumericUpDown numboxProductPrice;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpProductCreatedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label5;
    }
}