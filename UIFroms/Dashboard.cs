using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prescriptionSystem_project
{
    public partial class Dashboard : Form
    {
        private Database.DatabaseManager DB = Database.DatabaseManager.GetInstance();
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
        private User user;

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
        public Dashboard(User user)
        {   
            //Get logged user
            this.user = user;
            InitializeComponent();
            
            //Round panels
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            pn_activeTreatments.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pn_activeTreatments.Width, pn_activeTreatments.Height, 15, 15));
            pn_finishedTreatments.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pn_finishedTreatments.Width, pn_finishedTreatments.Height, 15, 15));
            
            //First panel
            HideAllPanels();
            pn_dashboard.Show();

            //Populate user name label
            lb_username.Text = user.FullName;

            //User type description
            lb_ops.Text = user.UserType;
            
            //Populate comboxes
            combox_item.DataSource = Enum.GetValues(typeof(ItemType));
            combo_treatments.DataSource = Enum.GetValues(typeof(ActionsType));
            combox_patient.DataSource = DB.GetAllUsers();
            combox_patientsTreatment.DataSource = DB.GetAllUsers();
            combo_patientsTreatmentSession.DataSource = DB.GetAllUsers();
            combo_TreatmentList.DataSource = Enum.GetValues(typeof(ActionsType));
            listView1.View = View.List;

            if (user.UserType == "patient")
            {
                bt_treatmentSession.Hide();
                bt_crPrescriptions.Hide();
                bt_crTreatment.Hide();
                br_crTreatmentPlan.Hide();
            }
            else
            {
                //TODO: buttons form patient hidden
            }

        }

        private void HideAllPanels()
        {
            pn_dashboard.Hide();
            pn_createPrescription.Hide();
            pn_crTreatment.Hide();
            pn_treatmentSession.Hide();
        }

        private int ExtractPatient(ComboBox comboBox)
        {
            string patientValue = comboBox.SelectedItem.ToString();

            string[] subs = patientValue.Split(',');

            patientValue = subs[0].Substring(1, subs[0].Length - 1);

            return int.Parse(patientValue);
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void br_crTreatmentPlan_Click(object sender, EventArgs e)
        {

        }

        private void bt_dashboard_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pn_dashboard.Show();
        }

        private void bt_crPrescriptions_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pn_createPrescription.Show();
        }

        private void pn_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int patientValue = ExtractPatient(combox_patient);
            string item = combox_item.SelectedItem.ToString();
            string description = tx_description.Text;
            int quantity = int.Parse(nm_quantity.Text);

            DB.createPrescription(user.Nif, patientValue, item, description, quantity);
        }

        private void lb_doses_Click(object sender, EventArgs e)
        {

        }

        private void tx_notes_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_doses_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_crTreatments_Click(object sender, EventArgs e)
        {
            int patientValue = ExtractPatient(combox_patientsTreatment);
            string startdate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string enddate = dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss");
            int prescriptionid = int.Parse((combo_userPrescription.SelectedItem as dynamic).Value.ToString());
            string action = combo_treatments.SelectedItem.ToString(); ;

            DB.createTreatment(user.Nif, patientValue, startdate, enddate, prescriptionid, action);
        }

        private void bt_crTreatment_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pn_crTreatment.Show();
        }

        private void bt_treatmentSession_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pn_treatmentSession.Show();
        }

        private void bt_createTreatmentSession_Click(object sender, EventArgs e)
        {
            int patientValue = ExtractPatient(combo_patientsTreatmentSession);
            string notes = tx_sessionNotes.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void combo_patientsTreatmentSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            int patientValue = ExtractPatient(combo_patientsTreatmentSession);

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Action";
            dataGridView1.Columns[1].Name = "Start Date";
            dataGridView1.Columns[2].Name = "End Date";
            dataGridView1.Columns[3].Name = "Prescription ID";
            dataGridView1.Columns[4].Name = "Status";

            DB.getPatienttreatments(patientValue).ForEach(delegate(List<string> list)
            {
                dataGridView1.Rows.Add(list.ToArray());
            });
        }

        private void combox_patientsTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_userPrescription.Items.Clear();
            int patientValue = ExtractPatient(combox_patientsTreatment);
            combo_userPrescription.DisplayMember = "Item";
            combo_userPrescription.ValueMember = "Value";

            DB.GetUserPrescriptions(patientValue).ForEach(delegate (List<string> list)
            {
                list.ToArray();
                string title = list[1] + " (" + list[2] +")";
                combo_userPrescription.Items.Add(new { Item = title, Value = list[0] });
            });

        }

        private void combo_userPrescription_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void combo_treatments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_treatments.SelectedItem.ToString() == "Prescription")
            {
                lb_presc.Show();
                combo_userPrescription.Show();
            }
            else
            {
                lb_presc.Hide();
                combo_userPrescription.Hide();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string title = (combo_TreatmentItem.SelectedItem as dynamic).Item.ToString();
            //string value = (combo_userPrescription.SelectedItem as dynamic).Value.ToString();
            listView1.Items.Add(title);
        }

        private void combo_TreatmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_TreatmentItem.Items.Clear();

            int patientValue = ExtractPatient(combox_patientsTreatment);
            string type = combo_TreatmentList.SelectedItem.ToString();

            combo_TreatmentItem.DisplayMember = "Item";
            combo_TreatmentItem.ValueMember = "Value";

            DB.GetUserTreatments(patientValue, type).ForEach(delegate (List<string> list)
            {
                list.ToArray();
                string title = list[1] + " (" + list[2] +" - "+ list[3] +")";
                combo_TreatmentItem.Items.Add(new { Item = title, Value = list[0] });
            });
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 475;
                mouseY = MousePosition.Y - 5;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
    }
}
