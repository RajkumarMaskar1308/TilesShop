namespace Tiles_APP
{
    public partial class Frm_Tiles_App_Login : Form
    {
        public Frm_Tiles_App_Login()
        {
            InitializeComponent();
            Tiles_APP_Shared_Content Db;
            
        }



        private void btn_Login_Click(object sender, EventArgs e)
        {
            Frm_Menu Obj= new Frm_Menu();
            Obj.Show();
            this.Hide();
        }

        private void Frm_Tiles_App_Login_Load(object sender, EventArgs e)
        {
          
        }
    }
}