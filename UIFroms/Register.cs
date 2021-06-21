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

namespace prescriptionSystem_project
{
    public partial class Register : Form
    {
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;

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

        public Register()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
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
            Database.DatabaseManager DB = Database.DatabaseManager.GetInstance();
            
            int txnif = int.Parse(tx_nif.Text);
            string txpass = tx_pass.Text;
            string txname = tx_name.Text;
            int txphone = int.Parse(tx_phone.Text);
            string txaddress = tx_address.Text;
            DateTime txbirth = dt_birth.Value;

            if (rd_patient.Checked)
            {
                Patient patient = new Patient(txnif, txpass, txname, txphone, txaddress, txbirth);
                
                DB.addPatient(patient);
            }
            else if (rd_therapist.Checked)
            {
                Therapist therapist = new Therapist(txnif, txpass, txname, txphone, txaddress, txbirth);
                DB.addTherapist(therapist);
            }
            else
            {
                Debug.Write("Selecionar um tipo");
            }
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
