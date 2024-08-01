using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiles_APP
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
            CustomizedDesign();



        }
        private void CustomizedDesign()
        {
            pnl_Master_Submenu.Visible = false;
            pnl_Purchase_Submenu.Visible = false;
            pnl_Sale_Submenu.Visible = false;
            pnl_Stock_Submenu.Visible = false;  

        }
        private void Hidesubmenu()
        {
            if(pnl_Master_Submenu.Visible== true) 
                pnl_Master_Submenu.Visible= false;
            if(pnl_Purchase_Submenu.Visible==true)
                pnl_Purchase_Submenu.Visible=false;
            if (pnl_Sale_Submenu.Visible == true)
                pnl_Sale_Submenu.Visible = false;
            if (pnl_Stock_Submenu.Visible == true)
                pnl_Stock_Submenu.Visible = false;               
        }
        private void Showsubmenu(Panel subMenu)
        {
            if(subMenu.Visible== false)
            {
                Hidesubmenu();
                subMenu.Visible = true;

            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btn_Master_Click(object sender, EventArgs e)
        {
            Showsubmenu(pnl_Master_Submenu);
        }

        private void btn_Customer_Information_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Frm_Customer_Information());
            Hidesubmenu();

            lbl_Head.Text = "Customer Information";
        }

        private void btn_Supplier_Information_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Frm_Add_New_Supplier());
            Hidesubmenu();
        }

        private void btn_Product_information_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Frm_Add_New_Product());
            Hidesubmenu();
            lbl_Head.Text = "Add New Product";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Frm_Regular_Customer());
            Hidesubmenu();
            lbl_Head.Text = "Regular Customer";

        }

        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            Showsubmenu(pnl_Purchase_Submenu);

        }

        private void btn_Purchase_Bill_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Frm_Purchase_Bill());  
            Hidesubmenu();
            lbl_Head.Text = "Purchase Bill";

        }

        private void btn_Purchase_Bill_List_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Frm_Purchase_List());
             Hidesubmenu();
            lbl_Head.Text = " Purchase Bill  List";


        }

        private void btn_B1_Click(object sender, EventArgs e)
        {

            Hidesubmenu();

        }

        private void btn_B2_Click(object sender, EventArgs e)
        {

            Hidesubmenu();
        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            Showsubmenu(pnl_Sale_Submenu);
        }

        private void btn_Invoice_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Frm_Invoice());
            Hidesubmenu();
            lbl_Head.Text = "Invoice";


        }

        private void btn_Invoice_List_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Frm_Invoice_List());
            Hidesubmenu();
            lbl_Head.Text = "Invoice List";


        }

        private void btn_Quotation_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Frm_Quotation());
            Hidesubmenu();
            lbl_Head.Text = "Quotation";
        }

        private void btn_Quotation_List_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Frm_Quotation_List());
            Hidesubmenu();
            lbl_Head.Text = "Quotation List";
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            Showsubmenu(pnl_Stock_Submenu);
        }

        private void btn_Remaining_Stock_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Frm_Remaining_Stock());
            Hidesubmenu();
            lbl_Head.Text = "Remaining Stock";
        }

        private void btn_Dead_Stock_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Frm_Dead_Stock());
            Hidesubmenu();
            lbl_Head.Text = "Dead Stock";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {

            Hidesubmenu();
        }

        private void btn_B4_Click(object sender, EventArgs e)
        {

            Hidesubmenu();
        }

        private Form activeForm = null;
private void openChildFormInPanel(Form childForm)
{
    if (activeForm != null)
        activeForm.Close();
    activeForm = childForm;
    childForm.TopLevel = false;
    childForm.FormBorderStyle = FormBorderStyle.None;
    childForm.Dock = DockStyle.Fill;
    pnl_Child_Form.Controls.Add(childForm);
    pnl_Child_Form.Tag = childForm;
    childForm.BringToFront();
    childForm.Show();
}

    }
}
