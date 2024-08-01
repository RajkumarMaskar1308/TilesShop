namespace Tiles_APP
{
    partial class Frm_Purchase_List
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
            this.tb_Supplier_ID = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_ID = new System.Windows.Forms.Label();
            this.cmb_Supplier = new System.Windows.Forms.ComboBox();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.dtp_Start_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_From_Date = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.dtp_Last_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Total_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Total_Amount = new System.Windows.Forms.Label();
            this.dgv_Purchase_Bill_List = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Bill_List)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Supplier_ID
            // 
            this.tb_Supplier_ID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Supplier_ID.Location = new System.Drawing.Point(163, 25);
            this.tb_Supplier_ID.Name = "tb_Supplier_ID";
            this.tb_Supplier_ID.Size = new System.Drawing.Size(94, 34);
            this.tb_Supplier_ID.TabIndex = 43;
            // 
            // lbl_Purchase_ID
            // 
            this.lbl_Purchase_ID.AutoSize = true;
            this.lbl_Purchase_ID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Purchase_ID.Location = new System.Drawing.Point(12, 29);
            this.lbl_Purchase_ID.Name = "lbl_Purchase_ID";
            this.lbl_Purchase_ID.Size = new System.Drawing.Size(146, 25);
            this.lbl_Purchase_ID.TabIndex = 42;
            this.lbl_Purchase_ID.Text = "Purchase ID:";
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Location = new System.Drawing.Point(428, 26);
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(321, 34);
            this.cmb_Supplier.TabIndex = 49;
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(263, 29);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(168, 25);
            this.lbl_Supplier_Name.TabIndex = 48;
            this.lbl_Supplier_Name.Text = "Supplier Name:";
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Product_Name.Location = new System.Drawing.Point(928, 23);
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(342, 34);
            this.tb_Product_Name.TabIndex = 51;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Product_Name.Location = new System.Drawing.Point(755, 28);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(167, 25);
            this.lbl_Product_Name.TabIndex = 50;
            this.lbl_Product_Name.Text = "Product Name:";
            // 
            // dtp_Start_Date
            // 
            this.dtp_Start_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtp_Start_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Start_Date.Location = new System.Drawing.Point(148, 71);
            this.dtp_Start_Date.Name = "dtp_Start_Date";
            this.dtp_Start_Date.Size = new System.Drawing.Size(159, 34);
            this.dtp_Start_Date.TabIndex = 53;
            // 
            // lbl_From_Date
            // 
            this.lbl_From_Date.AutoSize = true;
            this.lbl_From_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_From_Date.Location = new System.Drawing.Point(12, 78);
            this.lbl_From_Date.Name = "lbl_From_Date";
            this.lbl_From_Date.Size = new System.Drawing.Size(130, 25);
            this.lbl_From_Date.TabIndex = 52;
            this.lbl_From_Date.Text = "From Date:";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_To.Location = new System.Drawing.Point(323, 78);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(37, 25);
            this.lbl_To.TabIndex = 54;
            this.lbl_To.Text = "To";
            // 
            // dtp_Last_Date
            // 
            this.dtp_Last_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtp_Last_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Last_Date.Location = new System.Drawing.Point(366, 74);
            this.dtp_Last_Date.Name = "dtp_Last_Date";
            this.dtp_Last_Date.Size = new System.Drawing.Size(189, 34);
            this.dtp_Last_Date.TabIndex = 55;
            // 
            // tb_Total_Amount
            // 
            this.tb_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Total_Amount.Location = new System.Drawing.Point(755, 75);
            this.tb_Total_Amount.Name = "tb_Total_Amount";
            this.tb_Total_Amount.Size = new System.Drawing.Size(193, 34);
            this.tb_Total_Amount.TabIndex = 64;
            // 
            // lbl_Total_Amount
            // 
            this.lbl_Total_Amount.AutoSize = true;
            this.lbl_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Total_Amount.Location = new System.Drawing.Point(580, 78);
            this.lbl_Total_Amount.Name = "lbl_Total_Amount";
            this.lbl_Total_Amount.Size = new System.Drawing.Size(156, 25);
            this.lbl_Total_Amount.TabIndex = 63;
            this.lbl_Total_Amount.Text = "Total Amount:";
            // 
            // dgv_Purchase_Bill_List
            // 
            this.dgv_Purchase_Bill_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Purchase_Bill_List.Location = new System.Drawing.Point(3, 124);
            this.dgv_Purchase_Bill_List.Name = "dgv_Purchase_Bill_List";
            this.dgv_Purchase_Bill_List.RowHeadersWidth = 51;
            this.dgv_Purchase_Bill_List.RowTemplate.Height = 29;
            this.dgv_Purchase_Bill_List.Size = new System.Drawing.Size(1279, 604);
            this.dgv_Purchase_Bill_List.TabIndex = 65;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1027, 70);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(141, 40);
            this.btn_Search.TabIndex = 66;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // Frm_Purchase_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_Purchase_Bill_List);
            this.Controls.Add(this.tb_Total_Amount);
            this.Controls.Add(this.lbl_Total_Amount);
            this.Controls.Add(this.dtp_Last_Date);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.dtp_Start_Date);
            this.Controls.Add(this.lbl_From_Date);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.lbl_Product_Name);
            this.Controls.Add(this.cmb_Supplier);
            this.Controls.Add(this.lbl_Supplier_Name);
            this.Controls.Add(this.tb_Supplier_ID);
            this.Controls.Add(this.lbl_Purchase_ID);
            this.Name = "Frm_Purchase_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Purchase_List";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Bill_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnl_Head;
        private Label lbl_Head;
        private Button btn_Logout;
        private TextBox tb_Supplier_ID;
        private Label lbl_Purchase_ID;
        private ComboBox cmb_Supplier;
        private Label lbl_Supplier_Name;
        private TextBox tb_Product_Name;
        private Label lbl_Product_Name;
        private DateTimePicker dtp_Start_Date;
        private Label lbl_From_Date;
        private Label lbl_To;
        private DateTimePicker dtp_Last_Date;
        private TextBox tb_Total_Amount;
        private Label lbl_Total_Amount;
        private DataGridView dgv_Purchase_Bill_List;
        private Button btn_Search;
    }
}