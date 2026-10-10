namespace Bai5_2
{
    partial class frmService
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lstAvailableServices = new System.Windows.Forms.ListBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lstSelectedServices = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.IblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(131, 64);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(96, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Loại dịch vụ:";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(285, 64);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 28);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(106, 130);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(112, 20);
            this.lblAvailable.TabIndex = 2;
            this.lblAvailable.Text = "Dịch vụ có sẵn";
            // 
            // lstAvailableServices
            // 
            this.lstAvailableServices.FormattingEnabled = true;
            this.lstAvailableServices.ItemHeight = 20;
            this.lstAvailableServices.Location = new System.Drawing.Point(98, 165);
            this.lstAvailableServices.Name = "lstAvailableServices";
            this.lstAvailableServices.Size = new System.Drawing.Size(120, 84);
            this.lstAvailableServices.TabIndex = 3;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(464, 130);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(122, 20);
            this.lblSelected.TabIndex = 4;
            this.lblSelected.Text = "Dịch vụ đã chọn";
            this.lblSelected.Click += new System.EventHandler(this.lblSelected_Click);
            // 
            // lstSelectedServices
            // 
            this.lstSelectedServices.FormattingEnabled = true;
            this.lstSelectedServices.ItemHeight = 20;
            this.lstSelectedServices.Location = new System.Drawing.Point(466, 165);
            this.lstSelectedServices.Name = "lstSelectedServices";
            this.lstSelectedServices.Size = new System.Drawing.Size(120, 84);
            this.lstSelectedServices.TabIndex = 5;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(301, 165);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = ">";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(301, 194);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(301, 226);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "<<";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // IblTotal
            // 
            this.IblTotal.AutoSize = true;
            this.IblTotal.Location = new System.Drawing.Point(49, 278);
            this.IblTotal.Name = "IblTotal";
            this.IblTotal.Size = new System.Drawing.Size(156, 20);
            this.IblTotal.TabIndex = 9;
            this.IblTotal.Text = "Tổng tiền chưa giảm:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(49, 320);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(150, 20);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.Text = "Tỷ lệ chiết khấu (%):";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(49, 364);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(169, 20);
            this.lblPayment.TabIndex = 11;
            this.lblPayment.Text = "Thành tiền thanh toán:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(276, 278);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 12;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(276, 320);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 26);
            this.txtDiscount.TabIndex = 13;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(276, 364);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(100, 26);
            this.txtPayment.TabIndex = 14;
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.IblTotal);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstSelectedServices);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lstAvailableServices);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblCategory);
            this.Name = "frmService";
            this.Text = "BẢNG TÍNH TIỀN DỊCH VỤ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.ListBox lstAvailableServices;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ListBox lstSelectedServices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label IblTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtPayment;
    }
}

