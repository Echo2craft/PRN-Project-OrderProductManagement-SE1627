
namespace OrderManagement
{
    partial class ucPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchByIdOrName = new System.Windows.Forms.ComboBox();
            this.txtPaymentSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchPayment = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.btnUpdatePayment = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentPaytime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentPayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.searchByIdOrName.TabIndex = 23;
            // 
            // txtPaymentSearchName
            // 
            this.txtPaymentSearchName.Location = new System.Drawing.Point(3, 355);
            this.txtPaymentSearchName.Name = "txtPaymentSearchName";
            this.txtPaymentSearchName.Size = new System.Drawing.Size(156, 23);
            this.txtPaymentSearchName.TabIndex = 22;
            // 
            // btnSearchPayment
            // 
            this.btnSearchPayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchPayment.Location = new System.Drawing.Point(165, 355);
            this.btnSearchPayment.Name = "btnSearchPayment";
            this.btnSearchPayment.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPayment.TabIndex = 21;
            this.btnSearchPayment.Text = "Search";
            this.btnSearchPayment.UseVisualStyleBackColor = false;
            this.btnSearchPayment.Click += new System.EventHandler(this.btnSearchPayment_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeletePayment.Location = new System.Drawing.Point(165, 326);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePayment.TabIndex = 20;
            this.btnDeletePayment.Text = "Delete";
            this.btnDeletePayment.UseVisualStyleBackColor = false;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // btnUpdatePayment
            // 
            this.btnUpdatePayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdatePayment.Location = new System.Drawing.Point(84, 326);
            this.btnUpdatePayment.Name = "btnUpdatePayment";
            this.btnUpdatePayment.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePayment.TabIndex = 19;
            this.btnUpdatePayment.Text = "Update";
            this.btnUpdatePayment.UseVisualStyleBackColor = false;
            this.btnUpdatePayment.Click += new System.EventHandler(this.btnUpdatePayment_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPayment.Location = new System.Drawing.Point(3, 326);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(75, 23);
            this.btnAddPayment.TabIndex = 18;
            this.btnAddPayment.Text = "Add";
            this.btnAddPayment.UseVisualStyleBackColor = false;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentId,
            this.PaymentPaytime,
            this.PaymentAmount,
            this.PaymentOrderId,
            this.PaymentPayType});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(415, 320);
            this.dataGridView1.TabIndex = 17;
            // 
            // PaymentId
            // 
            this.PaymentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaymentId.DataPropertyName = "Id";
            this.PaymentId.HeaderText = "Id";
            this.PaymentId.Name = "PaymentId";
            this.PaymentId.ReadOnly = true;
            this.PaymentId.Width = 42;
            // 
            // PaymentPaytime
            // 
            this.PaymentPaytime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaymentPaytime.DataPropertyName = "PayTime";
            this.PaymentPaytime.HeaderText = "Pay Time";
            this.PaymentPaytime.Name = "PaymentPaytime";
            this.PaymentPaytime.ReadOnly = true;
            this.PaymentPaytime.Width = 80;
            // 
            // PaymentAmount
            // 
            this.PaymentAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaymentAmount.DataPropertyName = "Amount";
            this.PaymentAmount.HeaderText = "Amount";
            this.PaymentAmount.Name = "PaymentAmount";
            this.PaymentAmount.ReadOnly = true;
            this.PaymentAmount.Width = 76;
            // 
            // PaymentOrderId
            // 
            this.PaymentOrderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaymentOrderId.DataPropertyName = "OrderId";
            this.PaymentOrderId.HeaderText = "Order ID";
            this.PaymentOrderId.Name = "PaymentOrderId";
            this.PaymentOrderId.ReadOnly = true;
            this.PaymentOrderId.Width = 76;
            // 
            // PaymentPayType
            // 
            this.PaymentPayType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaymentPayType.DataPropertyName = "PayType";
            this.PaymentPayType.HeaderText = "Pay Type";
            this.PaymentPayType.Name = "PaymentPayType";
            this.PaymentPayType.ReadOnly = true;
            this.PaymentPayType.Width = 78;
            // 
            // ucPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.searchByIdOrName);
            this.Controls.Add(this.txtPaymentSearchName);
            this.Controls.Add(this.btnSearchPayment);
            this.Controls.Add(this.btnDeletePayment);
            this.Controls.Add(this.btnUpdatePayment);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ucPayment";
            this.Size = new System.Drawing.Size(700, 383);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchByIdOrName;
        private System.Windows.Forms.TextBox txtPaymentSearchName;
        private System.Windows.Forms.Button btnSearchPayment;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.Button btnUpdatePayment;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentPaytime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentPayType;
    }
}
