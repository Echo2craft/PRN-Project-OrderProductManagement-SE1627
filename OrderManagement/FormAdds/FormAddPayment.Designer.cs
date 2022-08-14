
namespace OrderManagement
{
    partial class FormAddPayment
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
            this.ddlPaymentOrderID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlPaymentPayType = new System.Windows.Forms.ComboBox();
            this.numboxPaymentAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAddNewPayment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpPaymentPayTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numboxPaymentAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlPaymentOrderID
            // 
            this.ddlPaymentOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPaymentOrderID.FormattingEnabled = true;
            this.ddlPaymentOrderID.Location = new System.Drawing.Point(150, 80);
            this.ddlPaymentOrderID.Name = "ddlPaymentOrderID";
            this.ddlPaymentOrderID.Size = new System.Drawing.Size(115, 23);
            this.ddlPaymentOrderID.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "New Payment Order ID";
            // 
            // ddlPaymentPayType
            // 
            this.ddlPaymentPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPaymentPayType.FormattingEnabled = true;
            this.ddlPaymentPayType.Location = new System.Drawing.Point(150, 109);
            this.ddlPaymentPayType.Name = "ddlPaymentPayType";
            this.ddlPaymentPayType.Size = new System.Drawing.Size(115, 23);
            this.ddlPaymentPayType.TabIndex = 18;
            // 
            // numboxPaymentAmount
            // 
            this.numboxPaymentAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numboxPaymentAmount.Location = new System.Drawing.Point(150, 52);
            this.numboxPaymentAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numboxPaymentAmount.Name = "numboxPaymentAmount";
            this.numboxPaymentAmount.Size = new System.Drawing.Size(115, 23);
            this.numboxPaymentAmount.TabIndex = 13;
            this.numboxPaymentAmount.ThousandsSeparator = true;
            // 
            // btnAddNewPayment
            // 
            this.btnAddNewPayment.Location = new System.Drawing.Point(102, 138);
            this.btnAddNewPayment.Name = "btnAddNewPayment";
            this.btnAddNewPayment.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewPayment.TabIndex = 17;
            this.btnAddNewPayment.Text = "Add";
            this.btnAddNewPayment.UseVisualStyleBackColor = true;
            this.btnAddNewPayment.Click += new System.EventHandler(this.btnAddNewPayment_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "New Payment Pay Type";
            // 
            // dtpPaymentPayTime
            // 
            this.dtpPaymentPayTime.Location = new System.Drawing.Point(12, 26);
            this.dtpPaymentPayTime.MinDate = new System.DateTime(2022, 7, 17, 0, 0, 0, 0);
            this.dtpPaymentPayTime.Name = "dtpPaymentPayTime";
            this.dtpPaymentPayTime.Size = new System.Drawing.Size(253, 23);
            this.dtpPaymentPayTime.TabIndex = 15;
            this.dtpPaymentPayTime.Value = new System.DateTime(2022, 7, 18, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "New Payment Pay Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "New Payment Amount";
            // 
            // FormAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 166);
            this.Controls.Add(this.ddlPaymentOrderID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddlPaymentPayType);
            this.Controls.Add(this.numboxPaymentAmount);
            this.Controls.Add(this.btnAddNewPayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpPaymentPayTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormAddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Payment";
            ((System.ComponentModel.ISupportInitialize)(this.numboxPaymentAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlPaymentOrderID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlPaymentPayType;
        private System.Windows.Forms.NumericUpDown numboxPaymentAmount;
        private System.Windows.Forms.Button btnAddNewPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPaymentPayTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}