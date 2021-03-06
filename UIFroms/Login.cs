using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prescriptionSystem_project.Repositorys;

namespace prescriptionSystem_project
{
    public partial class Login : Form
    {
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;

        //Initialize Authentication Objects
        private static IAuthentication authentication = new Auth();
        private IAuthentication loginProxy = new Proxy(authentication);
        private UserRepository userRepo = new UserRepository();

        //DB Initialization
        private Database.DatabaseManager DB = Database.DatabaseManager.GetInstance();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );

        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            tx_nif.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bt_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register(this); //this is the change, code for redirect  
            reg.ShowDialog();
        }

        private void bt_signup_Click(object sender, EventArgs e)
        {
            int nif = int.Parse(tx_nif.Text);
            string password = tx_pass.Text;

            bool result  = loginProxy.checkAuthentication(nif, password);

            if (result)
            {
                Hide();
                User user = userRepo.GetUserById(nif) ; //DB get user data by id
                Dashboard dash = new Dashboard(user); //this is the change, code for redirect
                dash.ShowDialog();
                Close();
            }
            else
            {
                tx_pass.Text = "";
                tx_nif.Text = "";
                MessageBox.Show("Input data error, or account not registered!");
                tx_nif.Focus();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 475;
                mouseY = MousePosition.Y - 5;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
