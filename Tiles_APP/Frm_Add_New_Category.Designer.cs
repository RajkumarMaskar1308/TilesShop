namespace Tiles_APP
{
    partial class Frm_Add_New_Category
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
            this.pnl_Category = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Category_Name = new System.Windows.Forms.TextBox();
            this.tb_Category_ID = new System.Windows.Forms.TextBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.lbl_Category_ID = new System.Windows.Forms.Label();
            this.pnl_Category.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Category
            // 
            this.pnl_Category.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_Category.Controls.Add(this.btn_Save);
            this.pnl_Category.Controls.Add(this.tb_Category_Name);
            this.pnl_Category.Controls.Add(this.tb_Category_ID);
            this.pnl_Category.Controls.Add(this.lbl_Category_Name);
            this.pnl_Category.Controls.Add(this.lbl_Category_ID);
            this.pnl_Category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Category.Location = new System.Drawing.Point(0, 0);
            this.pnl_Category.Name = "pnl_Category";
            this.pnl_Category.Size = new System.Drawing.Size(1282, 653);
            this.pnl_Category.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Wheat;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Location = new System.Drawing.Point(544, 480);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(192, 56);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // tb_Category_Name
            // 
            this.tb_Category_Name.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Category_Name.Location = new System.Drawing.Point(731, 318);
            this.tb_Category_Name.Name = "tb_Category_Name";
            this.tb_Category_Name.Size = new System.Drawing.Size(364, 50);
            this.tb_Category_Name.TabIndex = 3;
            // 
            // tb_Category_ID
            // 
            this.tb_Category_ID.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Category_ID.Location = new System.Drawing.Point(731, 147);
            this.tb_Category_ID.Name = "tb_Category_ID";
            this.tb_Category_ID.Size = new System.Drawing.Size(364, 50);
            this.tb_Category_ID.TabIndex = 3;
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Category_Name.Location = new System.Drawing.Point(286, 323);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(287, 45);
            this.lbl_Category_Name.TabIndex = 2;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // lbl_Category_ID
            // 
            this.lbl_Category_ID.AutoSize = true;
            this.lbl_Category_ID.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Category_ID.Location = new System.Drawing.Point(286, 147);
            this.lbl_Category_ID.Name = "lbl_Category_ID";
            this.lbl_Category_ID.Size = new System.Drawing.Size(231, 45);
            this.lbl_Category_ID.TabIndex = 2;
            this.lbl_Category_ID.Text = "Category ID";
            // 
            // Frm_Add_New_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Category);
            this.Name = "Frm_Add_New_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Category";
            this.pnl_Category.ResumeLayout(false);
            this.pnl_Category.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnl_Category;
        private Label lbl_Category_Name;
        private Label lbl_Category_ID;
        private TextBox tb_Category_Name;
        private TextBox tb_Category_ID;
        private Button btn_Save;
    }
}