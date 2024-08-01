namespace Tiles_APP
{
    partial class Frm_Invoice_List
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
            this.tb_Invoice_ID = new System.Windows.Forms.TextBox();
            this.lbl_Invoice_ID = new System.Windows.Forms.Label();
            this.dgv_Product_List = new System.Windows.Forms.DataGridView();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1130, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(152, 54);
            this.btn_Search.TabIndex = 31;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // tb_Invoice_ID
            // 
            this.tb_Invoice_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Invoice_ID.Location = new System.Drawing.Point(164, 8);
            this.tb_Invoice_ID.Name = "tb_Invoice_ID";
            this.tb_Invoice_ID.Size = new System.Drawing.Size(232, 39);
            this.tb_Invoice_ID.TabIndex = 35;
            // 
            // lbl_Invoice_ID
            // 
            this.lbl_Invoice_ID.AutoSize = true;
            this.lbl_Invoice_ID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Invoice_ID.Location = new System.Drawing.Point(0, 12);
            this.lbl_Invoice_ID.Name = "lbl_Invoice_ID";
            this.lbl_Invoice_ID.Size = new System.Drawing.Size(148, 35);
            this.lbl_Invoice_ID.TabIndex = 32;
            this.lbl_Invoice_ID.Text = "Invoice ID";
            // 
            // dgv_Product_List
            // 
            this.dgv_Product_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_List.Location = new System.Drawing.Point(0, 76);
            this.dgv_Product_List.Name = "dgv_Product_List";
            this.dgv_Product_List.RowHeadersWidth = 51;
            this.dgv_Product_List.RowTemplate.Height = 29;
            this.dgv_Product_List.Size = new System.Drawing.Size(1281, 578);
            this.dgv_Product_List.TabIndex = 36;
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Customer_Name.Location = new System.Drawing.Point(672, 12);
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(398, 39);
            this.tb_Customer_Name.TabIndex = 60;
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Customer_Name.Location = new System.Drawing.Point(435, 12);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(219, 35);
            this.lbl_Customer_Name.TabIndex = 59;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // Frm_Invoice_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.ControlBox = false;
            this.Controls.Add(this.tb_Customer_Name);
            this.Controls.Add(this.lbl_Customer_Name);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Invoice_ID);
            this.Controls.Add(this.lbl_Invoice_ID);
            this.Controls.Add(this.dgv_Product_List);
            this.Name = "Frm_Invoice_List";
            this.Text = "Invoice List";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Search;
        private TextBox tb_Invoice_ID;
        private Label lbl_Invoice_ID;
        private DataGridView dgv_Product_List;
        private TextBox tb_Customer_Name;
        private Label lbl_Customer_Name;
    }
}