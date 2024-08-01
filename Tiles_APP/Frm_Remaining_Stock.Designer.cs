namespace Tiles_APP
{
    partial class Frm_Remaining_Stock
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgb_Remaining_Stock = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.cmb_Subcategory_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Remaining_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_Product_Name);
            this.panel1.Controls.Add(this.dgb_Remaining_Stock);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.dtp_Date);
            this.panel1.Controls.Add(this.lbl_Date);
            this.panel1.Controls.Add(this.cmb_Subcategory_Name);
            this.panel1.Controls.Add(this.lbl_Product_Name);
            this.panel1.Controls.Add(this.cmb_Category_Name);
            this.panel1.Controls.Add(this.lbl_Subcategory_Name);
            this.panel1.Controls.Add(this.lbl_Category_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 653);
            this.panel1.TabIndex = 50;
            // 
            // dgb_Remaining_Stock
            // 
            this.dgb_Remaining_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_Remaining_Stock.Location = new System.Drawing.Point(3, 141);
            this.dgb_Remaining_Stock.Name = "dgb_Remaining_Stock";
            this.dgb_Remaining_Stock.RowHeadersWidth = 51;
            this.dgb_Remaining_Stock.RowTemplate.Height = 29;
            this.dgb_Remaining_Stock.Size = new System.Drawing.Size(1279, 512);
            this.dgb_Remaining_Stock.TabIndex = 68;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1031, 72);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(141, 44);
            this.btn_Search.TabIndex = 67;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_Date.Location = new System.Drawing.Point(677, 73);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(276, 39);
            this.dtp_Date.TabIndex = 52;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Date.Location = new System.Drawing.Point(579, 71);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(92, 35);
            this.lbl_Date.TabIndex = 51;
            this.lbl_Date.Text = "Date :";
            // 
            // cmb_Subcategory_Name
            // 
            this.cmb_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Subcategory_Name.FormattingEnabled = true;
            this.cmb_Subcategory_Name.Location = new System.Drawing.Point(812, 15);
            this.cmb_Subcategory_Name.Name = "cmb_Subcategory_Name";
            this.cmb_Subcategory_Name.Size = new System.Drawing.Size(360, 39);
            this.cmb_Subcategory_Name.TabIndex = 23;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Product_Name.Location = new System.Drawing.Point(14, 72);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(215, 35);
            this.lbl_Product_Name.TabIndex = 16;
            this.lbl_Product_Name.Text = "Product Name :";
            // 
            // cmb_Category_Name
            // 
            this.cmb_Category_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Category_Name.FormattingEnabled = true;
            this.cmb_Category_Name.Location = new System.Drawing.Point(238, 14);
            this.cmb_Category_Name.Name = "cmb_Category_Name";
            this.cmb_Category_Name.Size = new System.Drawing.Size(282, 39);
            this.cmb_Category_Name.TabIndex = 24;
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(536, 15);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(270, 35);
            this.lbl_Subcategory_Name.TabIndex = 21;
            this.lbl_Subcategory_Name.Text = "Subcategory Name :";
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Category_Name.Location = new System.Drawing.Point(12, 14);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(237, 35);
            this.lbl_Category_Name.TabIndex = 20;
            this.lbl_Category_Name.Text = "Category Name : ";
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(238, 67);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(282, 39);
            this.cmb_Product_Name.TabIndex = 72;
            // 
            // Frm_Remaining_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Remaining_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remaining Stock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Remaining_Stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private ComboBox cmb_Subcategory_Name;
        private ComboBox cmb_Category_Name;
        private Label lbl_Subcategory_Name;
        private Label lbl_Category_Name;
        private Label lbl_Product_Name;
        private DateTimePicker dtp_Date;
        private Label lbl_Date;
        private Button btn_Search;
        private DataGridView dgb_Remaining_Stock;
        private ComboBox cmb_Product_Name;
    }
}