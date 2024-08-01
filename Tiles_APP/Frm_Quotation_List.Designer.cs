namespace Tiles_APP
{
    partial class Frm_Quotation_List
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Quotation_ID = new System.Windows.Forms.Label();
            this.dgv_Product_List = new System.Windows.Forms.DataGridView();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1124, 7);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(152, 54);
            this.btn_Search.TabIndex = 38;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Product_Name.Location = new System.Drawing.Point(673, 14);
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(435, 39);
            this.tb_Product_Name.TabIndex = 41;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Product_ID.Location = new System.Drawing.Point(180, 17);
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(262, 39);
            this.tb_Product_ID.TabIndex = 42;
            // 
            // lbl_Quotation_ID
            // 
            this.lbl_Quotation_ID.AutoSize = true;
            this.lbl_Quotation_ID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Quotation_ID.Location = new System.Drawing.Point(0, 18);
            this.lbl_Quotation_ID.Name = "lbl_Quotation_ID";
            this.lbl_Quotation_ID.Size = new System.Drawing.Size(184, 35);
            this.lbl_Quotation_ID.TabIndex = 39;
            this.lbl_Quotation_ID.Text = "Quotation ID";
            // 
            // dgv_Product_List
            // 
            this.dgv_Product_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_List.Location = new System.Drawing.Point(0, 107);
            this.dgv_Product_List.Name = "dgv_Product_List";
            this.dgv_Product_List.RowHeadersWidth = 51;
            this.dgv_Product_List.RowTemplate.Height = 29;
            this.dgv_Product_List.Size = new System.Drawing.Size(1276, 547);
            this.dgv_Product_List.TabIndex = 43;
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Customer_Name.Location = new System.Drawing.Point(448, 17);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(219, 35);
            this.lbl_Customer_Name.TabIndex = 40;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // Frm_Quotation_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.tb_Product_ID);
            this.Controls.Add(this.lbl_Quotation_ID);
            this.Controls.Add(this.dgv_Product_List);
            this.Controls.Add(this.lbl_Customer_Name);
            this.Name = "Frm_Quotation_List";
            this.Text = "Quotation List";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Search;
        private TextBox tb_Product_Name;
        private TextBox tb_Product_ID;
        private Label lbl_Quotation_ID;
        private DataGridView dgv_Product_List;
        private Label lbl_Customer_Name;
    }
}