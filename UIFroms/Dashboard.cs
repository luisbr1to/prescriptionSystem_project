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
using prescriptionSystem_project.Database;
using prescriptionSystem_project.Repositorys;

namespace prescriptionSystem_project
{
    public partial class Dashboard : Form
    {
       // private Database.DatabaseManager DB = Database.DatabaseManager.GetInstance();
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
        private User user;
        private List<Treatment> session_treatments_list = new List<Treatment>();

        //Repository's
        private PrescriptionRepository prescriptionRepo = new PrescriptionRepository();
        private TreatmentRepository treatmentRepo = new TreatmentRepository();
        private UserRepository userRepo = new UserRepository();
        private PatientRepository patientRepo = new PatientRepository();
        private SessionRepository sessionRepo = new SessionRepository();
        private RequestsRepository requestsRepo = new RequestsRepository();

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
            this.CenterToScreen();
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
            combo_TreatmentList.DataSource = Enum.GetValues(typeof(ActionsType));

            combox_patient.DisplayMember = "fullname";
            combox_patient.DataSource = patientRepo.GetAllPatients();
            
            combox_patientsTreatment.DisplayMember = "fullname";
            combox_patientsTreatment.DataSource = patientRepo.GetAllPatients();

            combo_patientsTreatmentSession.DisplayMember = "fullname";
            combo_patientsTreatmentSession.DataSource = patientRepo.GetAllPatients();

            combo_patientPrHistory.DisplayMember = "fullname";
            combo_patientPrHistory.DataSource = patientRepo.GetAllPatients();

            if (user.UserType == "therapist")
            {
                dataGridView4.Hide();
                dataGridView3.Show();
                dataGridView3.DataSource = requestsRepo.getAllRequestsForTherapist(user.Nif);
                dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dataGridView3.Hide();
                dataGridView4.Show();
                
                dataGridView4.DataSource = requestsRepo.getAllRequestsForPatient(user.Nif);

                DataGridViewButtonColumn acceptButton = new DataGridViewButtonColumn();
                {
                    acceptButton.Name = "bt_accept";
                    acceptButton.HeaderText = "Accept";
                    acceptButton.Text = "Accept";
                    acceptButton.UseColumnTextForButtonValue = true; //dont forget this line
                    this.dataGridView4.Columns.Add(acceptButton);
                }

                DataGridViewButtonColumn rejectButton = new DataGridViewButtonColumn();
                {
                    rejectButton.Name = "bt_reject";
                    rejectButton.HeaderText = "Reject";
                    rejectButton.Text = "Reject";
                    rejectButton.UseColumnTextForButtonValue = true; //dont forget this line
                    this.dataGridView4.Columns.Add(rejectButton);
                }

            }

            //List views
            listView1.View = View.List;


            if (user.UserType == "patient")
            {
                bt_treatmentSession.Hide();
                bt_crPrescriptions.Hide();
                bt_crTreatment.Hide();
                bt_crTreatmentPlan.Hide();
                bt_prescriptionHistory.Hide();
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
            pn_PrescriptionHistory.Hide();
        }

        private int ExtractPatientNif(ComboBox comboBox)
        {
            Patient patient = (Patient)comboBox.SelectedItem;
            
            return patient == null ? 0 : patient.Nif;
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
            dataGridView4.DataSource = requestsRepo.getAllRequestsForPatient(user.Nif);
            dataGridView3.DataSource = requestsRepo.getAllRequestsForTherapist(user.Nif); ;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int therapistId = user.Nif; 
            int patientId = ExtractPatientNif(combox_patient);
            ItemType item = (ItemType)combox_item.SelectedItem;
            string description = tx_description.Text;
            int quantity = int.Parse(nm_quantity.Text);
            DateTime date = DateTime.Now;

            Prescription prescription = new Prescription(therapistId, patientId, item, description, date, quantity);

            prescriptionRepo.InsertPrescription(prescription);
        }
        
        private void bt_crTreatments_Click(object sender, EventArgs e)
        {
            Treatment treatment;
            int therapistId = user.Nif;
            int patientId = ExtractPatientNif(combox_patientsTreatment);
            DateTime startdate = DateTime.Now;
            DateTime enddate = dateTimePicker1.Value;
            ActionsType action = (ActionsType)combo_treatments.SelectedItem; //TODO check this cast
            string status = "Active";

            int prescriptionId;
            if (combo_treatments.SelectedItem.ToString() == "Prescription")
            {
                Prescription prescription = (Prescription) combo_userPrescription.SelectedItem;
                prescriptionId = prescription.Id;
                treatment = new Treatment(therapistId, patientId, action, prescriptionId, startdate, enddate, status);
            }
            else
            {
                 treatment = new Treatment(therapistId, patientId, action, startdate, enddate, status);
            }
            
            treatmentRepo.InsertTreatment(treatment);
        }

        private void bt_crTreatment_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pn_crTreatment.Show();
            int patientValue = ExtractPatientNif(combox_patientsTreatment);
            Debug.Write("\n" + patientRepo.GetPatientPrescriptionsByNif(patientValue));
            combo_userPrescription.DataSource = patientRepo.GetPatientPrescriptionsByNif(patientValue);
            combo_userPrescription.DisplayMember = "Description";
        }

        private void bt_treatmentSession_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pn_treatmentSession.Show();
        }

        private void bt_createTreatmentSession_Click(object sender, EventArgs e)
        {
            int patientValue = ExtractPatientNif(combo_patientsTreatmentSession);
            string notes = tx_sessionNotes.Text;
            sessionRepo.InsertSession(user.Nif, patientValue, notes);
            
            foreach (var treatment in session_treatments_list)
            {
                sessionRepo.addSessions_Treatments(sessionRepo.GetLastSessionId(), treatment.Id);
            }

            session_treatments_list.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void combo_patientsTreatmentSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            int patientValue = ExtractPatientNif(combo_patientsTreatmentSession);
            dataGridView1.DataSource = patientRepo.GetPatientTreatmentsByNif(patientValue);
        }

        private void combox_patientsTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int patientValue = ExtractPatientNif(combox_patientsTreatment);
            combo_userPrescription.DisplayMember = "description";
            combo_userPrescription.DataSource = patientRepo.GetPatientPrescriptionsByNif(patientValue);
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
            Treatment value = (Treatment)combo_TreatmentItem.SelectedItem;
            string title = (value.Action.ToString() +" (" +value.EndDate.ToString()+")");
            
            listView1.Items.Add(title);
            session_treatments_list.Add(value);
        }

        private void combo_TreatmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExtractPatientNif(combox_patientsTreatment) != 0)
            {
                int patientValue = ExtractPatientNif(combox_patientsTreatment);
                string type = combo_TreatmentList.SelectedItem.ToString();

                combo_TreatmentItem.DisplayMember = "action"; // TODO mostrar mais dados na combo box
                combo_TreatmentItem.DataSource = patientRepo.GetPatientTreatmentsByAction(patientValue, type);
            }
        }


        private void bt_prescriptionHistory_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            int patient = ExtractPatientNif(combo_patientPrHistory);
            dataGridView2.DataSource = prescriptionRepo.getAllPrescriptionsFromPatient_WithAccess(user.Nif, patient);
            ck_protectedPrescriptionList.DataSource = prescriptionRepo.getAllPrescriptionsFromOtherTherapists(user.Nif, patient);
            ck_protectedPrescriptionList.DisplayMember = "DisplayMemberChecklist";

            pn_PrescriptionHistory.Show();
        }

        private void combo_patientPrHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int patient = ExtractPatientNif(combo_patientPrHistory);
            dataGridView2.DataSource = prescriptionRepo.getAllPrescriptionsFromPatient_WithAccess(user.Nif, patient);
            ck_protectedPrescriptionList.DataSource = prescriptionRepo.getAllPrescriptionsFromOtherTherapists(user.Nif, patient);
            ck_protectedPrescriptionList.DisplayMember = "DisplayMemberChecklist";
        }

        private void bt_requestAccess_Click(object sender, EventArgs e)
        {
            int patient = ExtractPatientNif(combo_patientPrHistory);
            List<Requests> values = new List<Requests>();

            foreach (Prescription item in ck_protectedPrescriptionList.CheckedItems)
            {
                int prescriptionId = item.Id;
                Requests request = new Requests(prescriptionId, user.Nif, patient, "Pending");
                values.Add(request);
            }

            foreach (Requests request in values)
            {
                requestsRepo.InsertRequest(request);
            }
            
        }

        private void pn_dashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            Hide();
            Login loginpanel = new Login();
            loginpanel.ShowDialog();
            Close();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView4.CurrentCell.RowIndex;
            int requestId = int.Parse(dataGridView4.Rows[rowindex].Cells[2].Value.ToString());

            int prescriptionId = int.Parse(dataGridView4.Rows[rowindex].Cells[3].Value.ToString());
            int therapistId = int.Parse(dataGridView4.Rows[rowindex].Cells[4].Value.ToString());
            int patientId = int.Parse(dataGridView4.Rows[rowindex].Cells[5].Value.ToString());

            if (dataGridView4.Columns[e.ColumnIndex].Name == "bt_accept")
            {
                requestsRepo.updateRequest(requestId, "Accepted");
                prescriptionRepo.updatePrescriptionHistory(prescriptionId, therapistId, patientId);
                MessageBox.Show("Request accepted!");
                dataGridView4.DataSource = requestsRepo.getAllRequestsForPatient(user.Nif);
            }
            else if (dataGridView4.Columns[e.ColumnIndex].Name == "bt_reject")
            {
                requestsRepo.updateRequest(requestId, "Rejected");
                MessageBox.Show("Request Rejected!");
                dataGridView4.DataSource = requestsRepo.getAllRequestsForPatient(user.Nif);
            }
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
