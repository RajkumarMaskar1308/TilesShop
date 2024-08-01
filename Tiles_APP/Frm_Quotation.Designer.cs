namespace Tiles_APP
{
    partial class Frm_Quotation
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
            this.lbl_Quatation_No = new System.Windows.Forms.Label();
            this.tb_Invoice_No = new System.Windows.Forms.TextBox();
            this.dtb_Invoice_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Quotation_Customer_Name = new System.Windows.Forms.Label();
            this.cmb_Customer_Name = new System.Windows.Forms.ComboBox();
            this.btn_Quotation_List = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Product_Details = new System.Windows.Forms.GroupBox();
            this.cmb_Subcategory_Name = new System.Windows.Forms.ComboBox();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.tb_Purchase_Unit = new System.Windows.Forms.TextBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.btn_All_Rate = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Sale_Price = new System.Windows.Forms.Label();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.tb_Total_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Total_Amount = new System.Windows.Forms.Label();
            this.dgv_Purchase_Bill = new System.Windows.Forms.DataGridView();
            this.gb_Product_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Quatation_No
            // 
            this.lbl_Quatation_No.AutoSize = true;
            this.lbl_Quatation_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Quatation_No.Location = new System.Drawing.Point(8, 13);
            this.lbl_Quatation_No.Name = "lbl_Quatation_No";
            this.lbl_Quatation_No.Size = new System.Drawing.Size(156, 25);
            this.lbl_Quatation_No.TabIndex = 68;
            this.lbl_Quatation_No.Text = "Quotation No:";
            // 
            // tb_Invoice_No
            // 
            this.tb_Invoice_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Invoice_No.Location = new System.Drawing.Point(167, 10);
            this.tb_Invoice_No.Name = "tb_Invoice_No";
            this.tb_Invoice_No.Size = new System.Drawing.Size(96, 34);
            this.tb_Invoice_No.TabIndex = 70;
            // 
            // dtb_Invoice_Date
            // 
            this.dtb_Invoice_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtb_Invoice_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtb_Invoice_Date.Location = new System.Drawing.Point(343, 10);
            this.dtb_Invoice_Date.Name = "dtb_Invoice_Date";
            this.dtb_Invoice_Date.Size = new System.Drawing.Size(269, 34);
            this.dtb_Invoice_Date.TabIndex = 72;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Date.Location = new System.Drawing.Point(269, 17);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(68, 25);
            this.lbl_Date.TabIndex = 69;
            this.lbl_Date.Text = "Date:";
            // 
            // lbl_Quotation_Customer_Name
            // 
            this.lbl_Quotation_Customer_Name.AutoSize = true;
            this.lbl_Quotation_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Quotation_Customer_Name.Location = new System.Drawing.Point(626, 13);
            this.lbl_Quotation_Customer_Name.Name = "lbl_Quotation_Customer_Name";
            this.lbl_Quotation_Customer_Name.Size = new System.Drawing.Size(291, 25);
            this.lbl_Quotation_Customer_Name.TabIndex = 71;
            this.lbl_Quotation_Customer_Name.Text = "Quotation Customer Name:";
            // 
            // cmb_Customer_Name
            // 
            this.cmb_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Customer_Name.FormattingEnabled = true;
            this.cmb_Customer_Name.Location = new System.Drawing.Point(923, 10);
            this.cmb_Customer_Name.Name = "cmb_Customer_Name";
            this.cmb_Customer_Name.Size = new System.Drawing.Size(347, 34);
            this.cmb_Customer_Name.TabIndex = 73;
            // 
            // btn_Quotation_List
            // 
            this.btn_Quotation_List.BackColor = System.Drawing.Color.Coral;
            this.btn_Quotation_List.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Quotation_List.Location = new System.Drawing.Point(593, 551);
            this.btn_Quotation_List.Name = "btn_Quotation_List";
            this.btn_Quotation_List.Size = new System.Drawing.Size(241, 52);
            this.btn_Quotation_List.TabIndex = 77;
            this.btn_Quotation_List.Text = "Quotation List";
            this.btn_Quotation_List.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Coral;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Location = new System.Drawing.Point(355, 551);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(123, 52);
            this.btn_Save.TabIndex = 76;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // gb_Product_Details
            // 
            this.gb_Product_Details.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gb_Product_Details.Controls.Add(this.cmb_Subcategory_Name);
            this.gb_Product_Details.Controls.Add(this.tb_Quantity);
            this.gb_Product_Details.Controls.Add(this.lbl_Quantity);
            this.gb_Product_Details.Controls.Add(this.lbl_Unit);
            this.gb_Product_Details.Controls.Add(this.tb_Purchase_Unit);
            this.gb_Product_Details.Controls.Add(this.cmb_Product_Name);
            this.gb_Product_Details.Controls.Add(this.label1);
            this.gb_Product_Details.Controls.Add(this.cmb_Category_Name);
            this.gb_Product_Details.Controls.Add(this.lbl_Subcategory_Name);
            this.gb_Product_Details.Controls.Add(this.btn_All_Rate);
            this.gb_Product_Details.Controls.Add(this.btn_Add);
            this.gb_Product_Details.Controls.Add(this.lbl_Category_Name);
            this.gb_Product_Details.Controls.Add(this.textBox2);
            this.gb_Product_Details.Controls.Add(this.lbl_Sale_Price);
            this.gb_Product_Details.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_Product_Details.Location = new System.Drawing.Point(2, 57);
            this.gb_Product_Details.Name = "gb_Product_Details";
            this.gb_Product_Details.Size = new System.Drawing.Size(1279, 136);
            this.gb_Product_Details.TabIndex = 80;
            this.gb_Product_Details.TabStop = false;
            this.gb_Product_Details.Text = "Product Details";
            // 
            // cmb_Subcategory_Name
            // 
            this.cmb_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Subcategory_Name.FormattingEnabled = true;
            this.cmb_Subcategory_Name.Location = new System.Drawing.Point(684, 19);
            this.cmb_Subcategory_Name.Name = "cmb_Subcategory_Name";
            this.cmb_Subcategory_Name.Size = new System.Drawing.Size(282, 34);
            this.cmb_Subcategory_Name.TabIndex = 83;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Quantity.Location = new System.Drawing.Point(790, 67);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(204, 34);
            this.tb_Quantity.TabIndex = 82;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Quantity.Location = new System.Drawing.Point(684, 70);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(106, 25);
            this.lbl_Quantity.TabIndex = 81;
            this.lbl_Quantity.Text = " Quantity";
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Unit.Location = new System.Drawing.Point(475, 74);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(55, 25);
            this.lbl_Unit.TabIndex = 80;
            this.lbl_Unit.Text = "Unit";
            // 
            // tb_Purchase_Unit
            // 
            this.tb_Purchase_Unit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Purchase_Unit.Location = new System.Drawing.Point(541, 67);
            this.tb_Purchase_Unit.Name = "tb_Purchase_Unit";
            this.tb_Purchase_Unit.Size = new System.Drawing.Size(137, 34);
            this.tb_Purchase_Unit.TabIndex = 79;
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(182, 67);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(282, 34);
            this.cmb_Product_Name.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "Product Name";
            // 
            // cmb_Category_Name
            // 
            this.cmb_Category_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Category_Name.FormattingEnabled = true;
            this.cmb_Category_Name.Location = new System.Drawing.Point(182, 19);
            this.cmb_Category_Name.Name = "cmb_Category_Name";
            this.cmb_Category_Name.Size = new System.Drawing.Size(282, 34);
            this.cmb_Category_Name.TabIndex = 78;
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(475, 21);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(203, 25);
            this.lbl_Subcategory_Name.TabIndex = 73;
            this.lbl_Subcategory_Name.Text = "Subcategory Name";
            // 
            // btn_All_Rate
            // 
            this.btn_All_Rate.BackColor = System.Drawing.Color.Coral;
            this.btn_All_Rate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_All_Rate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_All_Rate.Location = new System.Drawing.Point(1013, 15);
            this.btn_All_Rate.Name = "btn_All_Rate";
            this.btn_All_Rate.Size = new System.Drawing.Size(140, 42);
            this.btn_All_Rate.TabIndex = 65;
            this.btn_All_Rate.Text = "All Rate";
            this.btn_All_Rate.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Coral;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.Location = new System.Drawing.Point(1173, 13);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 46);
            this.btn_Add.TabIndex = 49;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Category_Name.Location = new System.Drawing.Point(12, 19);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(170, 25);
            this.lbl_Category_Name.TabIndex = 72;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(1125, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 34);
            this.textBox2.TabIndex = 54;
            // 
            // lbl_Sale_Price
            // 
            this.lbl_Sale_Price.AutoSize = true;
            this.lbl_Sale_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Sale_Price.Location = new System.Drawing.Point(1000, 76);
            this.lbl_Sale_Price.Name = "lbl_Sale_Price";
            this.lbl_Sale_Price.Size = new System.Drawing.Size(111, 25);
            this.lbl_Sale_Price.TabIndex = 53;
            this.lbl_Sale_Price.Text = "Sale Price";
            // 
            // tb_GST
            // 
            this.tb_GST.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_GST.Location = new System.Drawing.Point(355, 484);
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(180, 34);
            this.tb_GST.TabIndex = 88;
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_GST.Location = new System.Drawing.Point(260, 486);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(77, 32);
            this.lbl_GST.TabIndex = 87;
            this.lbl_GST.Text = "GST:";
            // 
            // tb_Total_Amount
            // 
            this.tb_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Total_Amount.Location = new System.Drawing.Point(792, 486);
            this.tb_Total_Amount.Name = "tb_Total_Amount";
            this.tb_Total_Amount.Size = new System.Drawing.Size(195, 34);
            this.tb_Total_Amount.TabIndex = 90;
            // 
            // lbl_Total_Amount
            // 
            this.lbl_Total_Amount.AutoSize = true;
            this.lbl_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Total_Amount.Location = new System.Drawing.Point(603, 486);
            this.lbl_Total_Amount.Name = "lbl_Total_Amount";
            this.lbl_Total_Amount.Size = new System.Drawing.Size(185, 32);
            this.lbl_Total_Amount.TabIndex = 89;
            this.lbl_Total_Amount.Text = "Total Amount:";
            // 
            // dgv_Purchase_Bill
            // 
            this.dgv_Purchase_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Purchase_Bill.Location = new System.Drawing.Point(2, 199);
            this.dgv_Purchase_Bill.Name = "dgv_Purchase_Bill";
            this.dgv_Purchase_Bill.RowHeadersWidth = 51;
            this.dgv_Purchase_Bill.RowTemplate.Height = 29;
            this.dgv_Purchase_Bill.Size = new System.Drawing.Size(1279, 246);
            this.dgv_Purchase_Bill.TabIndex = 75;
            // 
            // Frm_Quotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.ControlBox = false;
            this.Controls.Add(this.tb_GST);
            this.Controls.Add(this.lbl_GST);
            this.Controls.Add(this.tb_Total_Amount);
            this.Controls.Add(this.lbl_Total_Amount);
            this.Controls.Add(this.gb_Product_Details);
            this.Controls.Add(this.dgv_Purchase_Bill);
            this.Controls.Add(this.lbl_Quatation_No);
            this.Controls.Add(this.tb_Invoice_No);
            this.Controls.Add(this.dtb_Invoice_Date);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Quotation_Customer_Name);
            this.Controls.Add(this.cmb_Customer_Name);
            this.Controls.Add(this.btn_Quotation_List);
            this.Controls.Add(this.btn_Save);
            this.Name = "Frm_Quotation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quotation";
            this.gb_Product_Details.ResumeLayout(false);
            this.gb_Product_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_Quatation_No;
        private TextBox tb_Invoice_No;
        private DateTimePicker dtb_Invoice_Date;
        private Label lbl_Date;
        private Label lbl_Quotation_Customer_Name;
        private ComboBox cmb_Customer_Name;
        private Button btn_Quotation_List;
        private Button btn_Save;
        private GroupBox gb_Product_Details;
        private ComboBox cmb_Subcategory_Name;
        private TextBox tb_Quantity;
        private Label lbl_Quantity;
        private Label lbl_Unit;
        private TextBox tb_Purchase_Unit;
        private ComboBox cmb_Product_Name;
        private Label label1;
        private ComboBox cmb_Category_Name;
        private Label lbl_Subcategory_Name;
        private Button btn_All_Rate;
        private Button btn_Add;
        private Label lbl_Category_Name;
        private TextBox textBox2;
        private Label lbl_Sale_Price;
        private TextBox tb_GST;
        private Label lbl_GST;
        private TextBox tb_Total_Amount;
        private Label lbl_Total_Amount;
        private DataGridView dgv_Purchase_Bill;
    }
}