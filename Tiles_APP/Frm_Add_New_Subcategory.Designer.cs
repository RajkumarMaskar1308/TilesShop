namespace Tiles_APP
{
    partial class Frm_Add_New_Subcategory
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
            this.cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Subcategory_Name = new System.Windows.Forms.TextBox();
            this.tb_Category_ID = new System.Windows.Forms.TextBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.lbl_Subcategory_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Category_Name
            // 
            this.cmb_Category_Name.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Category_Name.FormattingEnabled = true;
            this.cmb_Category_Name.Location = new System.Drawing.Point(707, 93);
            this.cmb_Category_Name.Name = "cmb_Category_Name";
            this.cmb_Category_Name.Size = new System.Drawing.Size(364, 50);
            this.cmb_Category_Name.TabIndex = 78;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Wheat;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Location = new System.Drawing.Point(510, 500);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(192, 56);
            this.btn_Save.TabIndex = 77;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // tb_Subcategory_Name
            // 
            this.tb_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Subcategory_Name.Location = new System.Drawing.Point(707, 348);
            this.tb_Subcategory_Name.Name = "tb_Subcategory_Name";
            this.tb_Subcategory_Name.Size = new System.Drawing.Size(364, 50);
            this.tb_Subcategory_Name.TabIndex = 75;
            // 
            // tb_Category_ID
            // 
            this.tb_Category_ID.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Category_ID.Location = new System.Drawing.Point(707, 223);
            this.tb_Category_ID.Name = "tb_Category_ID";
            this.tb_Category_ID.Size = new System.Drawing.Size(364, 50);
            this.tb_Category_ID.TabIndex = 76;
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Category_Name.Location = new System.Drawing.Point(262, 93);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(287, 45);
            this.lbl_Category_Name.TabIndex = 72;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(272, 353);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(341, 45);
            this.lbl_Subcategory_Name.TabIndex = 73;
            this.lbl_Subcategory_Name.Text = "Subcategory Name";
            // 
            // lbl_Subcategory_ID
            // 
            this.lbl_Subcategory_ID.AutoSize = true;
            this.lbl_Subcategory_ID.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Subcategory_ID.Location = new System.Drawing.Point(272, 228);
            this.lbl_Subcategory_ID.Name = "lbl_Subcategory_ID";
            this.lbl_Subcategory_ID.Size = new System.Drawing.Size(285, 45);
            this.lbl_Subcategory_ID.TabIndex = 74;
            this.lbl_Subcategory_ID.Text = "Subcategory ID";
            // 
            // Frm_Add_New_Subcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_Category_Name);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Subcategory_Name);
            this.Controls.Add(this.tb_Category_ID);
            this.Controls.Add(this.lbl_Category_Name);
            this.Controls.Add(this.lbl_Subcategory_Name);
            this.Controls.Add(this.lbl_Subcategory_ID);
            this.Name = "Frm_Add_New_Subcategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm Add New Subcategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_Category_Name;
        private Button btn_Save;
        private TextBox tb_Subcategory_Name;
        private TextBox tb_Category_ID;
        private Label lbl_Category_Name;
        private Label lbl_Subcategory_Name;
        private Label lbl_Subcategory_ID;
    }
}