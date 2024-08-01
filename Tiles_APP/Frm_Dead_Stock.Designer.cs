namespace Tiles_APP
{
    partial class Frm_Dead_Stock
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
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Dead_Date = new System.Windows.Forms.Label();
            this.lbl_Dead_No = new System.Windows.Forms.Label();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.gb_Product_Information = new System.Windows.Forms.GroupBox();
            this.tb_Total_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Total_Amount = new System.Windows.Forms.Label();
            this.lbl_Stock_Quantity = new System.Windows.Forms.Label();
            this.tb_Stock_Quantity = new System.Windows.Forms.TextBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Subcategory_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.dgv_Dead_Stock = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Product_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dead_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_Date.Location = new System.Drawing.Point(994, 12);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(276, 39);
            this.dtp_Date.TabIndex = 54;
            // 
            // lbl_Dead_Date
            // 
            this.lbl_Dead_Date.AutoSize = true;
            this.lbl_Dead_Date.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dead_Date.Location = new System.Drawing.Point(830, 12);
            this.lbl_Dead_Date.Name = "lbl_Dead_Date";
            this.lbl_Dead_Date.Size = new System.Drawing.Size(158, 35);
            this.lbl_Dead_Date.TabIndex = 53;
            this.lbl_Dead_Date.Text = "Dead Date:";
            // 
            // lbl_Dead_No
            // 
            this.lbl_Dead_No.AutoSize = true;
            this.lbl_Dead_No.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dead_No.Location = new System.Drawing.Point(12, 9);
            this.lbl_Dead_No.Name = "lbl_Dead_No";
            this.lbl_Dead_No.Size = new System.Drawing.Size(136, 35);
            this.lbl_Dead_No.TabIndex = 55;
            this.lbl_Dead_No.Text = "Dead No:";
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Product_ID.Location = new System.Drawing.Point(142, 9);
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(201, 39);
            this.tb_Product_ID.TabIndex = 56;
            // 
            // gb_Product_Information
            // 
            this.gb_Product_Information.Controls.Add(this.tb_Total_Amount);
            this.gb_Product_Information.Controls.Add(this.lbl_Total_Amount);
            this.gb_Product_Information.Controls.Add(this.lbl_Stock_Quantity);
            this.gb_Product_Information.Controls.Add(this.tb_Stock_Quantity);
            this.gb_Product_Information.Controls.Add(this.cmb_Product_Name);
            this.gb_Product_Information.Controls.Add(this.label1);
            this.gb_Product_Information.Controls.Add(this.cmb_Subcategory_Name);
            this.gb_Product_Information.Controls.Add(this.lbl_Subcategory_Name);
            this.gb_Product_Information.Controls.Add(this.btn_Add);
            this.gb_Product_Information.Controls.Add(this.cmb_Category_Name);
            this.gb_Product_Information.Controls.Add(this.lbl_Category_Name);
            this.gb_Product_Information.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_Product_Information.Location = new System.Drawing.Point(3, 57);
            this.gb_Product_Information.Name = "gb_Product_Information";
            this.gb_Product_Information.Size = new System.Drawing.Size(1280, 159);
            this.gb_Product_Information.TabIndex = 63;
            this.gb_Product_Information.TabStop = false;
            this.gb_Product_Information.Text = "Product Information";
            // 
            // tb_Total_Amount
            // 
            this.tb_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Total_Amount.Location = new System.Drawing.Point(1102, 93);
            this.tb_Total_Amount.Name = "tb_Total_Amount";
            this.tb_Total_Amount.Size = new System.Drawing.Size(155, 39);
            this.tb_Total_Amount.TabIndex = 75;
            // 
            // lbl_Total_Amount
            // 
            this.lbl_Total_Amount.AutoSize = true;
            this.lbl_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Total_Amount.Location = new System.Drawing.Point(909, 92);
            this.lbl_Total_Amount.Name = "lbl_Total_Amount";
            this.lbl_Total_Amount.Size = new System.Drawing.Size(187, 35);
            this.lbl_Total_Amount.TabIndex = 74;
            this.lbl_Total_Amount.Text = "Total Amount";
            // 
            // lbl_Stock_Quantity
            // 
            this.lbl_Stock_Quantity.AutoSize = true;
            this.lbl_Stock_Quantity.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Stock_Quantity.Location = new System.Drawing.Point(529, 91);
            this.lbl_Stock_Quantity.Name = "lbl_Stock_Quantity";
            this.lbl_Stock_Quantity.Size = new System.Drawing.Size(204, 35);
            this.lbl_Stock_Quantity.TabIndex = 73;
            this.lbl_Stock_Quantity.Text = "Stock Quantity";
            // 
            // tb_Stock_Quantity
            // 
            this.tb_Stock_Quantity.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Stock_Quantity.Location = new System.Drawing.Point(739, 87);
            this.tb_Stock_Quantity.Name = "tb_Stock_Quantity";
            this.tb_Stock_Quantity.Size = new System.Drawing.Size(164, 39);
            this.tb_Stock_Quantity.TabIndex = 72;
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(230, 92);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(282, 39);
            this.cmb_Product_Name.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 35);
            this.label1.TabIndex = 65;
            this.label1.Text = "Product Name";
            // 
            // cmb_Subcategory_Name
            // 
            this.cmb_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Subcategory_Name.FormattingEnabled = true;
            this.cmb_Subcategory_Name.Location = new System.Drawing.Point(794, 23);
            this.cmb_Subcategory_Name.Name = "cmb_Subcategory_Name";
            this.cmb_Subcategory_Name.Size = new System.Drawing.Size(282, 39);
            this.cmb_Subcategory_Name.TabIndex = 69;
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(529, 22);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(252, 35);
            this.lbl_Subcategory_Name.TabIndex = 68;
            this.lbl_Subcategory_Name.Text = "Subcategory Name";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1116, 16);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(141, 51);
            this.btn_Add.TabIndex = 67;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // cmb_Category_Name
            // 
            this.cmb_Category_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Category_Name.FormattingEnabled = true;
            this.cmb_Category_Name.Location = new System.Drawing.Point(230, 19);
            this.cmb_Category_Name.Name = "cmb_Category_Name";
            this.cmb_Category_Name.Size = new System.Drawing.Size(282, 39);
            this.cmb_Category_Name.TabIndex = 70;
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Category_Name.Location = new System.Drawing.Point(8, 23);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(211, 35);
            this.lbl_Category_Name.TabIndex = 67;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // dgv_Dead_Stock
            // 
            this.dgv_Dead_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dead_Stock.Location = new System.Drawing.Point(3, 222);
            this.dgv_Dead_Stock.Name = "dgv_Dead_Stock";
            this.dgv_Dead_Stock.RowHeadersWidth = 51;
            this.dgv_Dead_Stock.RowTemplate.Height = 29;
            this.dgv_Dead_Stock.Size = new System.Drawing.Size(1278, 346);
            this.dgv_Dead_Stock.TabIndex = 64;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Coral;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Location = new System.Drawing.Point(551, 585);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(175, 56);
            this.btn_Save.TabIndex = 65;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // Frm_Dead_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dgv_Dead_Stock);
            this.Controls.Add(this.gb_Product_Information);
            this.Controls.Add(this.tb_Product_ID);
            this.Controls.Add(this.lbl_Dead_No);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_Dead_Date);
            this.Name = "Frm_Dead_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dead Stock";
            this.gb_Product_Information.ResumeLayout(false);
            this.gb_Product_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dead_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker dtp_Date;
        private Label lbl_Dead_Date;
        private Label lbl_Dead_No;
        private TextBox tb_Product_ID;
        private GroupBox gb_Product_Information;
        private Button btn_Add;
        private ComboBox cmb_Product_Name;
        private Label label1;
        private ComboBox cmb_Subcategory_Name;
        private Label lbl_Subcategory_Name;
        private ComboBox cmb_Category_Name;
        private Label lbl_Category_Name;
        private DataGridView dgv_Dead_Stock;
        private Label lbl_Stock_Quantity;
        private TextBox tb_Stock_Quantity;
        private TextBox tb_Total_Amount;
        private Label lbl_Total_Amount;
        private Button btn_Save;
    }
}