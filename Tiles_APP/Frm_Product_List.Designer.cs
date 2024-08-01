namespace Tiles_APP
{
    partial class Frm_Product_List
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
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.pnl_Head = new System.Windows.Forms.Panel();
            this.dgv_Product_List = new System.Windows.Forms.DataGridView();
            this.pnl_Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1118, 128);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(152, 54);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Product_Name.Location = new System.Drawing.Point(677, 138);
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(421, 39);
            this.tb_Product_Name.TabIndex = 21;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Product_ID.Location = new System.Drawing.Point(186, 138);
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(282, 39);
            this.tb_Product_ID.TabIndex = 28;
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Product_ID.Location = new System.Drawing.Point(12, 142);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(158, 35);
            this.lbl_Product_ID.TabIndex = 17;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Head.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Head.Location = new System.Drawing.Point(302, 24);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(431, 77);
            this.lbl_Head.TabIndex = 2;
            this.lbl_Head.Text = " Product List";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Wheat;
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Logout.Location = new System.Drawing.Point(1129, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(151, 125);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Product_Name.Location = new System.Drawing.Point(474, 137);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(197, 35);
            this.lbl_Product_Name.TabIndex = 20;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // pnl_Head
            // 
            this.pnl_Head.BackColor = System.Drawing.Color.Moccasin;
            this.pnl_Head.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Head.Controls.Add(this.lbl_Head);
            this.pnl_Head.Controls.Add(this.btn_Logout);
            this.pnl_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Head.Location = new System.Drawing.Point(0, 0);
            this.pnl_Head.Name = "pnl_Head";
            this.pnl_Head.Size = new System.Drawing.Size(1282, 125);
            this.pnl_Head.TabIndex = 15;
            // 
            // dgv_Product_List
            // 
            this.dgv_Product_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_List.Location = new System.Drawing.Point(0, 188);
            this.dgv_Product_List.Name = "dgv_Product_List";
            this.dgv_Product_List.RowHeadersWidth = 51;
            this.dgv_Product_List.RowTemplate.Height = 29;
            this.dgv_Product_List.Size = new System.Drawing.Size(1281, 564);
            this.dgv_Product_List.TabIndex = 29;
            // 
            // Frm_Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Product_List);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.tb_Product_ID);
            this.Controls.Add(this.lbl_Product_ID);
            this.Controls.Add(this.lbl_Product_Name);
            this.Controls.Add(this.pnl_Head);
            this.Name = "Frm_Product_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product List";
            this.pnl_Head.ResumeLayout(false);
            this.pnl_Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Search;
        private TextBox tb_Product_Name;
        private TextBox tb_Product_ID;
        private Label lbl_Product_ID;
        private Label lbl_Head;
        private Button btn_Logout;
        private Label lbl_Product_Name;
        private Panel pnl_Head;
        private DataGridView dgv_Product_List;
    }
}