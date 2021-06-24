using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using prescriptionSystem_project.Repositorys;

namespace prescriptionSystem_project
{
    public partial class Register : Form
    {
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
        private UserRepository userRepo = new UserRepository();
        private Login login;
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

        public Register(Login login)
        {
            InitializeComponent();
            this.CenterToScreen();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.login = login;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            int txnif = int.Parse(tx_nif.Text);
            string txpass = tx_pass.Text;
            string txname = tx_name.Text;
            int txphone = int.Parse(tx_phone.Text);
            string txaddress = tx_address.Text;
            DateTime txbirth = dt_birth.Value;

            if (rd_patient.Checked)
            {
                Patient patient = new Patient(txnif, txpass, txname, txphone, txaddress, txbirth);
                userRepo.InsertUserPatient(patient);
                MessageBox.Show("Account Registered Successfully!");
                this.Dispose();
                login.Show();
            }
            else if (rd_therapist.Checked)
            {
                Therapist therapist = new Therapist(txnif, txpass, txname, txphone, txaddress, txbirth);
                userRepo.InsertUserTherapist(therapist);
                MessageBox.Show("Account Registered Successfully!");
                this.Dispose();
                login.Show();
            }
            else
            {
                MessageBox.Show("Select an user type !");
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 475;
                mouseY = MousePosition.Y - 5;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
