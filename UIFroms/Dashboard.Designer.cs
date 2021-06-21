
namespace prescriptionSystem_project
{
    partial class Dashboard
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
            this.pn_menu = new System.Windows.Forms.Panel();
            this.bt_treatmentSession = new System.Windows.Forms.Button();
            this.bt_prescriptionHistory = new System.Windows.Forms.Button();
            this.bt_crPrescriptions = new System.Windows.Forms.Button();
            this.bt_crTreatment = new System.Windows.Forms.Button();
            this.br_crTreatmentPlan = new System.Windows.Forms.Button();
            this.bt_dashboard = new System.Windows.Forms.Button();
            this.pn_userDetails = new System.Windows.Forms.Panel();
            this.lb_ops = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_window = new System.Windows.Forms.Panel();
            this.lb_WindowTitle = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            this.pn_createPrescription = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nm_quantity = new System.Windows.Forms.NumericUpDown();
            this.combox_patient = new System.Windows.Forms.ComboBox();
            this.bt_crPrescription = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_description = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combox_item = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_prescription = new System.Windows.Forms.Label();
            this.pn_crTreatment = new System.Windows.Forms.Panel();
            this.combo_userPrescription = new System.Windows.Forms.ComboBox();
            this.lb_presc = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_patientTreament = new System.Windows.Forms.Label();
            this.combox_patientsTreatment = new System.Windows.Forms.ComboBox();
            this.bt_crTreatments = new System.Windows.Forms.Button();
            this.combo_treatments = new System.Windows.Forms.ComboBox();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_enddate = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.pn_treatmentSession = new System.Windows.Forms.Panel();
            this.lb_tr = new System.Windows.Forms.Label();
            this.lb_pvTreatments = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_notesTsession = new System.Windows.Forms.Label();
            this.tx_sessionNotes = new System.Windows.Forms.RichTextBox();
            this.lb_patient = new System.Windows.Forms.Label();
            this.combo_patientsTreatmentSession = new System.Windows.Forms.ComboBox();
            this.bt_createTreatmentSession = new System.Windows.Forms.Button();
            this.lb_titleTreatmentSession = new System.Windows.Forms.Label();
            this.pn_activeTreatments = new System.Windows.Forms.Panel();
            this.lb_activeTreatmentPlans = new System.Windows.Forms.Label();
            this.lb_activeTreatmentCount = new System.Windows.Forms.Label();
            this.pn_finishedTreatments = new System.Windows.Forms.Panel();
            this.lb_finishedTreatmentPlans = new System.Windows.Forms.Label();
            this.lb_finishedTreatmentCount = new System.Windows.Forms.Label();
            this.pn_dashboard = new System.Windows.Forms.Panel();
            this.combo_TreatmentList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.combo_TreatmentItem = new System.Windows.Forms.ComboBox();
            this.pn_menu.SuspendLayout();
            this.pn_userDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_window.SuspendLayout();
            this.pn_createPrescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_quantity)).BeginInit();
            this.pn_crTreatment.SuspendLayout();
            this.pn_treatmentSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pn_activeTreatments.SuspendLayout();
            this.pn_finishedTreatments.SuspendLayout();
            this.pn_dashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pn_menu.Controls.Add(this.bt_treatmentSession);
            this.pn_menu.Controls.Add(this.bt_prescriptionHistory);
            this.pn_menu.Controls.Add(this.bt_crPrescriptions);
            this.pn_menu.Controls.Add(this.bt_crTreatment);
            this.pn_menu.Controls.Add(this.br_crTreatmentPlan);
            this.pn_menu.Controls.Add(this.bt_dashboard);
            this.pn_menu.Controls.Add(this.pn_userDetails);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu.Location = new System.Drawing.Point(0, 0);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(186, 577);
            this.pn_menu.TabIndex = 0;
            this.pn_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_menu_Paint);
            // 
            // bt_treatmentSession
            // 
            this.bt_treatmentSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_treatmentSession.FlatAppearance.BorderSize = 0;
            this.bt_treatmentSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_treatmentSession.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_treatmentSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bt_treatmentSession.Location = new System.Drawing.Point(0, 360);
            this.bt_treatmentSession.Name = "bt_treatmentSession";
            this.bt_treatmentSession.Size = new System.Drawing.Size(186, 42);
            this.bt_treatmentSession.TabIndex = 5;
            this.bt_treatmentSession.Text = "Treatment Session";
            this.bt_treatmentSession.UseVisualStyleBackColor = true;
            this.bt_treatmentSession.Click += new System.EventHandler(this.bt_treatmentSession_Click);
            // 
            // bt_prescriptionHistory
            // 
            this.bt_prescriptionHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_prescriptionHistory.FlatAppearance.BorderSize = 0;
            this.bt_prescriptionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_prescriptionHistory.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_prescriptionHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bt_prescriptionHistory.Location = new System.Drawing.Point(0, 318);
            this.bt_prescriptionHistory.Name = "bt_prescriptionHistory";
            this.bt_prescriptionHistory.Size = new System.Drawing.Size(186, 42);
            this.bt_prescriptionHistory.TabIndex = 4;
            this.bt_prescriptionHistory.Text = "Prescriptions History";
            this.bt_prescriptionHistory.UseVisualStyleBackColor = true;
            // 
            // bt_crPrescriptions
            // 
            this.bt_crPrescriptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_crPrescriptions.FlatAppearance.BorderSize = 0;
            this.bt_crPrescriptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_crPrescriptions.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_crPrescriptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bt_crPrescriptions.Location = new System.Drawing.Point(0, 276);
            this.bt_crPrescriptions.Name = "bt_crPrescriptions";
            this.bt_crPrescriptions.Size = new System.Drawing.Size(186, 42);
            this.bt_crPrescriptions.TabIndex = 3;
            this.bt_crPrescriptions.Text = "Create Prescriptions";
            this.bt_crPrescriptions.UseVisualStyleBackColor = true;
            this.bt_crPrescriptions.Click += new System.EventHandler(this.bt_crPrescriptions_Click);
            // 
            // bt_crTreatment
            // 
            this.bt_crTreatment.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_crTreatment.FlatAppearance.BorderSize = 0;
            this.bt_crTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_crTreatment.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_crTreatment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bt_crTreatment.Location = new System.Drawing.Point(0, 234);
            this.bt_crTreatment.Name = "bt_crTreatment";
            this.bt_crTreatment.Size = new System.Drawing.Size(186, 42);
            this.bt_crTreatment.TabIndex = 6;
            this.bt_crTreatment.Text = "Create Treatment";
            this.bt_crTreatment.UseVisualStyleBackColor = true;
            this.bt_crTreatment.Click += new System.EventHandler(this.bt_crTreatment_Click);
            // 
            // br_crTreatmentPlan
            // 
            this.br_crTreatmentPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.br_crTreatmentPlan.FlatAppearance.BorderSize = 0;
            this.br_crTreatmentPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.br_crTreatmentPlan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_crTreatmentPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.br_crTreatmentPlan.Location = new System.Drawing.Point(0, 192);
            this.br_crTreatmentPlan.Name = "br_crTreatmentPlan";
            this.br_crTreatmentPlan.Size = new System.Drawing.Size(186, 42);
            this.br_crTreatmentPlan.TabIndex = 2;
            this.br_crTreatmentPlan.Text = "Create Treatment Plan";
            this.br_crTreatmentPlan.UseVisualStyleBackColor = true;
            this.br_crTreatmentPlan.Click += new System.EventHandler(this.br_crTreatmentPlan_Click);
            // 
            // bt_dashboard
            // 
            this.bt_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_dashboard.FlatAppearance.BorderSize = 0;
            this.bt_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bt_dashboard.Location = new System.Drawing.Point(0, 150);
            this.bt_dashboard.Name = "bt_dashboard";
            this.bt_dashboard.Size = new System.Drawing.Size(186, 42);
            this.bt_dashboard.TabIndex = 1;
            this.bt_dashboard.Text = "Dashboard";
            this.bt_dashboard.UseVisualStyleBackColor = true;
            this.bt_dashboard.Click += new System.EventHandler(this.bt_dashboard_Click);
            // 
            // pn_userDetails
            // 
            this.pn_userDetails.Controls.Add(this.lb_ops);
            this.pn_userDetails.Controls.Add(this.lb_username);
            this.pn_userDetails.Controls.Add(this.pictureBox1);
            this.pn_userDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_userDetails.Location = new System.Drawing.Point(0, 0);
            this.pn_userDetails.Name = "pn_userDetails";
            this.pn_userDetails.Size = new System.Drawing.Size(186, 150);
            this.pn_userDetails.TabIndex = 0;
            // 
            // lb_ops
            // 
            this.lb_ops.AutoSize = true;
            this.lb_ops.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ops.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lb_ops.Location = new System.Drawing.Point(39, 121);
            this.lb_ops.Name = "lb_ops";
            this.lb_ops.Size = new System.Drawing.Size(106, 12);
            this.lb_ops.TabIndex = 2;
            this.lb_ops.Text = "Some user text here";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lb_username.Location = new System.Drawing.Point(52, 98);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(79, 16);
            this.lb_username.TabIndex = 1;
            this.lb_username.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prescriptionSystem_project.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pn_window
            // 
            this.pn_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pn_window.Controls.Add(this.lb_WindowTitle);
            this.pn_window.Controls.Add(this.bt_close);
            this.pn_window.Location = new System.Drawing.Point(182, 0);
            this.pn_window.Name = "pn_window";
            this.pn_window.Size = new System.Drawing.Size(770, 27);
            this.pn_window.TabIndex = 1;
            this.pn_window.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.pn_window.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.pn_window.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // lb_WindowTitle
            // 
            this.lb_WindowTitle.AutoSize = true;
            this.lb_WindowTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F);
            this.lb_WindowTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_WindowTitle.Location = new System.Drawing.Point(350, 7);
            this.lb_WindowTitle.Name = "lb_WindowTitle";
            this.lb_WindowTitle.Size = new System.Drawing.Size(64, 14);
            this.lb_WindowTitle.TabIndex = 3;
            this.lb_WindowTitle.Text = "Dashboard";
            // 
            // bt_close
            // 
            this.bt_close.BackgroundImage = global::prescriptionSystem_project.Properties.Resources.close;
            this.bt_close.FlatAppearance.BorderSize = 0;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.Location = new System.Drawing.Point(748, 3);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(17, 23);
            this.bt_close.TabIndex = 2;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // pn_createPrescription
            // 
            this.pn_createPrescription.Controls.Add(this.label5);
            this.pn_createPrescription.Controls.Add(this.label4);
            this.pn_createPrescription.Controls.Add(this.nm_quantity);
            this.pn_createPrescription.Controls.Add(this.combox_patient);
            this.pn_createPrescription.Controls.Add(this.bt_crPrescription);
            this.pn_createPrescription.Controls.Add(this.label3);
            this.pn_createPrescription.Controls.Add(this.tx_description);
            this.pn_createPrescription.Controls.Add(this.label2);
            this.pn_createPrescription.Controls.Add(this.combox_item);
            this.pn_createPrescription.Controls.Add(this.label1);
            this.pn_createPrescription.Controls.Add(this.lb_prescription);
            this.pn_createPrescription.Location = new System.Drawing.Point(182, 24);
            this.pn_createPrescription.Name = "pn_createPrescription";
            this.pn_createPrescription.Size = new System.Drawing.Size(770, 553);
            this.pn_createPrescription.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(131, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(419, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Example of description: Take this medicine 2x a day, 1 on morning the other at ni" +
    "ght";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(36, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Qunatity";
            // 
            // nm_quantity
            // 
            this.nm_quantity.Location = new System.Drawing.Point(131, 224);
            this.nm_quantity.Name = "nm_quantity";
            this.nm_quantity.Size = new System.Drawing.Size(550, 20);
            this.nm_quantity.TabIndex = 10;
            // 
            // combox_patient
            // 
            this.combox_patient.FormattingEnabled = true;
            this.combox_patient.Location = new System.Drawing.Point(131, 96);
            this.combox_patient.Name = "combox_patient";
            this.combox_patient.Size = new System.Drawing.Size(550, 21);
            this.combox_patient.TabIndex = 9;
            // 
            // bt_crPrescription
            // 
            this.bt_crPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_crPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bt_crPrescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.bt_crPrescription.Location = new System.Drawing.Point(131, 450);
            this.bt_crPrescription.Name = "bt_crPrescription";
            this.bt_crPrescription.Size = new System.Drawing.Size(550, 54);
            this.bt_crPrescription.TabIndex = 8;
            this.bt_crPrescription.Text = "Create Prescription";
            this.bt_crPrescription.UseVisualStyleBackColor = true;
            this.bt_crPrescription.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(36, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // tx_description
            // 
            this.tx_description.Location = new System.Drawing.Point(131, 280);
            this.tx_description.Name = "tx_description";
            this.tx_description.Size = new System.Drawing.Size(550, 96);
            this.tx_description.TabIndex = 6;
            this.tx_description.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(36, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // combox_item
            // 
            this.combox_item.FormattingEnabled = true;
            this.combox_item.Location = new System.Drawing.Point(131, 162);
            this.combox_item.Name = "combox_item";
            this.combox_item.Size = new System.Drawing.Size(550, 21);
            this.combox_item.TabIndex = 3;
            this.combox_item.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(38, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item";
            // 
            // lb_prescription
            // 
            this.lb_prescription.AutoSize = true;
            this.lb_prescription.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lb_prescription.Location = new System.Drawing.Point(33, 38);
            this.lb_prescription.Name = "lb_prescription";
            this.lb_prescription.Size = new System.Drawing.Size(281, 38);
            this.lb_prescription.TabIndex = 0;
            this.lb_prescription.Text = "Create Prescription";
            // 
            // pn_crTreatment
            // 
            this.pn_crTreatment.Controls.Add(this.combo_userPrescription);
            this.pn_crTreatment.Controls.Add(this.lb_presc);
            this.pn_crTreatment.Controls.Add(this.dateTimePicker1);
            this.pn_crTreatment.Controls.Add(this.lb_patientTreament);
            this.pn_crTreatment.Controls.Add(this.combox_patientsTreatment);
            this.pn_crTreatment.Controls.Add(this.bt_crTreatments);
            this.pn_crTreatment.Controls.Add(this.combo_treatments);
            this.pn_crTreatment.Controls.Add(this.lb_type);
            this.pn_crTreatment.Controls.Add(this.lb_enddate);
            this.pn_crTreatment.Controls.Add(this.lb_title);
            this.pn_crTreatment.Location = new System.Drawing.Point(182, 24);
            this.pn_crTreatment.Name = "pn_crTreatment";
            this.pn_crTreatment.Size = new System.Drawing.Size(770, 550);
            this.pn_crTreatment.TabIndex = 10;
            // 
            // combo_userPrescription
            // 
            this.combo_userPrescription.FormattingEnabled = true;
            this.combo_userPrescription.Location = new System.Drawing.Point(131, 303);
            this.combo_userPrescription.Name = "combo_userPrescription";
            this.combo_userPrescription.Size = new System.Drawing.Size(572, 21);
            this.combo_userPrescription.TabIndex = 12;
            this.combo_userPrescription.SelectedIndexChanged += new System.EventHandler(this.combo_userPrescription_SelectedIndexChanged);
            // 
            // lb_presc
            // 
            this.lb_presc.AutoSize = true;
            this.lb_presc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_presc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_presc.Location = new System.Drawing.Point(40, 302);
            this.lb_presc.Name = "lb_presc";
            this.lb_presc.Size = new System.Drawing.Size(92, 20);
            this.lb_presc.TabIndex = 11;
            this.lb_presc.Text = "Prescription";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(572, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // lb_patientTreament
            // 
            this.lb_patientTreament.AutoSize = true;
            this.lb_patientTreament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_patientTreament.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_patientTreament.Location = new System.Drawing.Point(36, 103);
            this.lb_patientTreament.Name = "lb_patientTreament";
            this.lb_patientTreament.Size = new System.Drawing.Size(59, 20);
            this.lb_patientTreament.TabIndex = 9;
            this.lb_patientTreament.Text = "Patient";
            // 
            // combox_patientsTreatment
            // 
            this.combox_patientsTreatment.FormattingEnabled = true;
            this.combox_patientsTreatment.Location = new System.Drawing.Point(131, 102);
            this.combox_patientsTreatment.Name = "combox_patientsTreatment";
            this.combox_patientsTreatment.Size = new System.Drawing.Size(572, 21);
            this.combox_patientsTreatment.TabIndex = 8;
            this.combox_patientsTreatment.SelectedIndexChanged += new System.EventHandler(this.combox_patientsTreatment_SelectedIndexChanged);
            // 
            // bt_crTreatments
            // 
            this.bt_crTreatments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_crTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bt_crTreatments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.bt_crTreatments.Location = new System.Drawing.Point(131, 421);
            this.bt_crTreatments.Name = "bt_crTreatments";
            this.bt_crTreatments.Size = new System.Drawing.Size(572, 62);
            this.bt_crTreatments.TabIndex = 7;
            this.bt_crTreatments.Text = "Create Treatment";
            this.bt_crTreatments.UseVisualStyleBackColor = true;
            this.bt_crTreatments.Click += new System.EventHandler(this.bt_crTreatments_Click);
            // 
            // combo_treatments
            // 
            this.combo_treatments.FormattingEnabled = true;
            this.combo_treatments.Location = new System.Drawing.Point(131, 168);
            this.combo_treatments.Name = "combo_treatments";
            this.combo_treatments.Size = new System.Drawing.Size(572, 21);
            this.combo_treatments.TabIndex = 6;
            this.combo_treatments.SelectedIndexChanged += new System.EventHandler(this.combo_treatments_SelectedIndexChanged);
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_type.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_type.Location = new System.Drawing.Point(36, 168);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(54, 20);
            this.lb_type.TabIndex = 5;
            this.lb_type.Text = "Action";
            // 
            // lb_enddate
            // 
            this.lb_enddate.AutoSize = true;
            this.lb_enddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_enddate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_enddate.Location = new System.Drawing.Point(36, 223);
            this.lb_enddate.Name = "lb_enddate";
            this.lb_enddate.Size = new System.Drawing.Size(82, 40);
            this.lb_enddate.TabIndex = 4;
            this.lb_enddate.Text = "Treatment\r\nend date";
            this.lb_enddate.Click += new System.EventHandler(this.lb_doses_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F);
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lb_title.Location = new System.Drawing.Point(33, 38);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(258, 38);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "Create Treatment";
            // 
            // pn_treatmentSession
            // 
            this.pn_treatmentSession.Controls.Add(this.combo_TreatmentItem);
            this.pn_treatmentSession.Controls.Add(this.listView1);
            this.pn_treatmentSession.Controls.Add(this.button1);
            this.pn_treatmentSession.Controls.Add(this.combo_TreatmentList);
            this.pn_treatmentSession.Controls.Add(this.lb_tr);
            this.pn_treatmentSession.Controls.Add(this.lb_pvTreatments);
            this.pn_treatmentSession.Controls.Add(this.dataGridView1);
            this.pn_treatmentSession.Controls.Add(this.lb_notesTsession);
            this.pn_treatmentSession.Controls.Add(this.tx_sessionNotes);
            this.pn_treatmentSession.Controls.Add(this.lb_patient);
            this.pn_treatmentSession.Controls.Add(this.combo_patientsTreatmentSession);
            this.pn_treatmentSession.Controls.Add(this.bt_createTreatmentSession);
            this.pn_treatmentSession.Controls.Add(this.lb_titleTreatmentSession);
            this.pn_treatmentSession.Location = new System.Drawing.Point(182, 24);
            this.pn_treatmentSession.Name = "pn_treatmentSession";
            this.pn_treatmentSession.Size = new System.Drawing.Size(770, 553);
            this.pn_treatmentSession.TabIndex = 10;
            // 
            // lb_tr
            // 
            this.lb_tr.AutoSize = true;
            this.lb_tr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_tr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_tr.Location = new System.Drawing.Point(44, 307);
            this.lb_tr.Name = "lb_tr";
            this.lb_tr.Size = new System.Drawing.Size(139, 20);
            this.lb_tr.TabIndex = 9;
            this.lb_tr.Text = "Select Treatments";
            // 
            // lb_pvTreatments
            // 
            this.lb_pvTreatments.AutoSize = true;
            this.lb_pvTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_pvTreatments.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_pvTreatments.Location = new System.Drawing.Point(44, 177);
            this.lb_pvTreatments.Name = "lb_pvTreatments";
            this.lb_pvTreatments.Size = new System.Drawing.Size(145, 20);
            this.lb_pvTreatments.TabIndex = 8;
            this.lb_pvTreatments.Text = "Previous Tretments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(195, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(516, 126);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lb_notesTsession
            // 
            this.lb_notesTsession.AutoSize = true;
            this.lb_notesTsession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_notesTsession.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_notesTsession.Location = new System.Drawing.Point(43, 416);
            this.lb_notesTsession.Name = "lb_notesTsession";
            this.lb_notesTsession.Size = new System.Drawing.Size(51, 20);
            this.lb_notesTsession.TabIndex = 5;
            this.lb_notesTsession.Text = "Notes";
            // 
            // tx_sessionNotes
            // 
            this.tx_sessionNotes.Location = new System.Drawing.Point(195, 416);
            this.tx_sessionNotes.Name = "tx_sessionNotes";
            this.tx_sessionNotes.Size = new System.Drawing.Size(516, 46);
            this.tx_sessionNotes.TabIndex = 4;
            this.tx_sessionNotes.Text = "";
            // 
            // lb_patient
            // 
            this.lb_patient.AutoSize = true;
            this.lb_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_patient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_patient.Location = new System.Drawing.Point(44, 135);
            this.lb_patient.Name = "lb_patient";
            this.lb_patient.Size = new System.Drawing.Size(59, 20);
            this.lb_patient.TabIndex = 3;
            this.lb_patient.Text = "Patient";
            // 
            // combo_patientsTreatmentSession
            // 
            this.combo_patientsTreatmentSession.FormattingEnabled = true;
            this.combo_patientsTreatmentSession.Location = new System.Drawing.Point(195, 135);
            this.combo_patientsTreatmentSession.Name = "combo_patientsTreatmentSession";
            this.combo_patientsTreatmentSession.Size = new System.Drawing.Size(516, 21);
            this.combo_patientsTreatmentSession.TabIndex = 2;
            this.combo_patientsTreatmentSession.SelectedIndexChanged += new System.EventHandler(this.combo_patientsTreatmentSession_SelectedIndexChanged);
            // 
            // bt_createTreatmentSession
            // 
            this.bt_createTreatmentSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_createTreatmentSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bt_createTreatmentSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.bt_createTreatmentSession.Location = new System.Drawing.Point(195, 476);
            this.bt_createTreatmentSession.Name = "bt_createTreatmentSession";
            this.bt_createTreatmentSession.Size = new System.Drawing.Size(516, 66);
            this.bt_createTreatmentSession.TabIndex = 1;
            this.bt_createTreatmentSession.Text = "Create Treatment Session";
            this.bt_createTreatmentSession.UseVisualStyleBackColor = true;
            this.bt_createTreatmentSession.Click += new System.EventHandler(this.bt_createTreatmentSession_Click);
            // 
            // lb_titleTreatmentSession
            // 
            this.lb_titleTreatmentSession.AutoSize = true;
            this.lb_titleTreatmentSession.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F);
            this.lb_titleTreatmentSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lb_titleTreatmentSession.Location = new System.Drawing.Point(40, 58);
            this.lb_titleTreatmentSession.Name = "lb_titleTreatmentSession";
            this.lb_titleTreatmentSession.Size = new System.Drawing.Size(272, 38);
            this.lb_titleTreatmentSession.TabIndex = 0;
            this.lb_titleTreatmentSession.Text = "Treatment Session";
            // 
            // pn_activeTreatments
            // 
            this.pn_activeTreatments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pn_activeTreatments.Controls.Add(this.lb_activeTreatmentPlans);
            this.pn_activeTreatments.Controls.Add(this.lb_activeTreatmentCount);
            this.pn_activeTreatments.Location = new System.Drawing.Point(76, 74);
            this.pn_activeTreatments.Name = "pn_activeTreatments";
            this.pn_activeTreatments.Size = new System.Drawing.Size(275, 136);
            this.pn_activeTreatments.TabIndex = 0;
            // 
            // lb_activeTreatmentPlans
            // 
            this.lb_activeTreatmentPlans.AutoSize = true;
            this.lb_activeTreatmentPlans.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_activeTreatmentPlans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lb_activeTreatmentPlans.Location = new System.Drawing.Point(19, 80);
            this.lb_activeTreatmentPlans.Name = "lb_activeTreatmentPlans";
            this.lb_activeTreatmentPlans.Size = new System.Drawing.Size(233, 23);
            this.lb_activeTreatmentPlans.TabIndex = 1;
            this.lb_activeTreatmentPlans.Text = "Active Treatment Plans";
            // 
            // lb_activeTreatmentCount
            // 
            this.lb_activeTreatmentCount.AutoSize = true;
            this.lb_activeTreatmentCount.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_activeTreatmentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lb_activeTreatmentCount.Location = new System.Drawing.Point(15, 23);
            this.lb_activeTreatmentCount.Name = "lb_activeTreatmentCount";
            this.lb_activeTreatmentCount.Size = new System.Drawing.Size(45, 45);
            this.lb_activeTreatmentCount.TabIndex = 0;
            this.lb_activeTreatmentCount.Text = "0";
            // 
            // pn_finishedTreatments
            // 
            this.pn_finishedTreatments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pn_finishedTreatments.Controls.Add(this.lb_finishedTreatmentPlans);
            this.pn_finishedTreatments.Controls.Add(this.lb_finishedTreatmentCount);
            this.pn_finishedTreatments.Location = new System.Drawing.Point(406, 74);
            this.pn_finishedTreatments.Name = "pn_finishedTreatments";
            this.pn_finishedTreatments.Size = new System.Drawing.Size(297, 136);
            this.pn_finishedTreatments.TabIndex = 1;
            // 
            // lb_finishedTreatmentPlans
            // 
            this.lb_finishedTreatmentPlans.AutoSize = true;
            this.lb_finishedTreatmentPlans.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_finishedTreatmentPlans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lb_finishedTreatmentPlans.Location = new System.Drawing.Point(23, 80);
            this.lb_finishedTreatmentPlans.Name = "lb_finishedTreatmentPlans";
            this.lb_finishedTreatmentPlans.Size = new System.Drawing.Size(252, 23);
            this.lb_finishedTreatmentPlans.TabIndex = 3;
            this.lb_finishedTreatmentPlans.Text = "Finished Treatment Plans";
            // 
            // lb_finishedTreatmentCount
            // 
            this.lb_finishedTreatmentCount.AutoSize = true;
            this.lb_finishedTreatmentCount.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_finishedTreatmentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lb_finishedTreatmentCount.Location = new System.Drawing.Point(19, 23);
            this.lb_finishedTreatmentCount.Name = "lb_finishedTreatmentCount";
            this.lb_finishedTreatmentCount.Size = new System.Drawing.Size(45, 45);
            this.lb_finishedTreatmentCount.TabIndex = 2;
            this.lb_finishedTreatmentCount.Text = "0";
            // 
            // pn_dashboard
            // 
            this.pn_dashboard.Controls.Add(this.pn_finishedTreatments);
            this.pn_dashboard.Controls.Add(this.pn_activeTreatments);
            this.pn_dashboard.Location = new System.Drawing.Point(182, 24);
            this.pn_dashboard.Name = "pn_dashboard";
            this.pn_dashboard.Size = new System.Drawing.Size(770, 553);
            this.pn_dashboard.TabIndex = 2;
            // 
            // combo_TreatmentList
            // 
            this.combo_TreatmentList.FormattingEnabled = true;
            this.combo_TreatmentList.Location = new System.Drawing.Point(195, 305);
            this.combo_TreatmentList.Name = "combo_TreatmentList";
            this.combo_TreatmentList.Size = new System.Drawing.Size(249, 21);
            this.combo_TreatmentList.TabIndex = 10;
            this.combo_TreatmentList.SelectedIndexChanged += new System.EventHandler(this.combo_TreatmentList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.button1.Location = new System.Drawing.Point(195, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(450, 305);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(261, 98);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // combo_TreatmentItem
            // 
            this.combo_TreatmentItem.FormattingEnabled = true;
            this.combo_TreatmentItem.Location = new System.Drawing.Point(195, 336);
            this.combo_TreatmentItem.Name = "combo_TreatmentItem";
            this.combo_TreatmentItem.Size = new System.Drawing.Size(249, 21);
            this.combo_TreatmentItem.TabIndex = 13;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pn_treatmentSession);
            this.Controls.Add(this.pn_crTreatment);
            this.Controls.Add(this.pn_createPrescription);
            this.Controls.Add(this.pn_dashboard);
            this.Controls.Add(this.pn_window);
            this.Controls.Add(this.pn_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pn_menu.ResumeLayout(false);
            this.pn_userDetails.ResumeLayout(false);
            this.pn_userDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_window.ResumeLayout(false);
            this.pn_window.PerformLayout();
            this.pn_createPrescription.ResumeLayout(false);
            this.pn_createPrescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_quantity)).EndInit();
            this.pn_crTreatment.ResumeLayout(false);
            this.pn_crTreatment.PerformLayout();
            this.pn_treatmentSession.ResumeLayout(false);
            this.pn_treatmentSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pn_activeTreatments.ResumeLayout(false);
            this.pn_activeTreatments.PerformLayout();
            this.pn_finishedTreatments.ResumeLayout(false);
            this.pn_finishedTreatments.PerformLayout();
            this.pn_dashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.Panel pn_userDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_dashboard;
        private System.Windows.Forms.Label lb_ops;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Panel pn_window;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button br_crTreatmentPlan;
        private System.Windows.Forms.Label lb_WindowTitle;
        private System.Windows.Forms.Button bt_crPrescriptions;
        private System.Windows.Forms.Button bt_crTreatment;
        private System.Windows.Forms.Button bt_treatmentSession;
        private System.Windows.Forms.Button bt_prescriptionHistory;
        private System.Windows.Forms.Panel pn_createPrescription;
        private System.Windows.Forms.Label lb_prescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combox_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_crPrescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tx_description;
        private System.Windows.Forms.ComboBox combox_patient;
        private System.Windows.Forms.Panel pn_crTreatment;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_enddate;
        private System.Windows.Forms.Button bt_crTreatments;
        private System.Windows.Forms.ComboBox combo_treatments;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Panel pn_activeTreatments;
        private System.Windows.Forms.Label lb_activeTreatmentPlans;
        private System.Windows.Forms.Label lb_activeTreatmentCount;
        private System.Windows.Forms.Panel pn_finishedTreatments;
        private System.Windows.Forms.Label lb_finishedTreatmentPlans;
        private System.Windows.Forms.Label lb_finishedTreatmentCount;
        private System.Windows.Forms.Panel pn_dashboard;
        private System.Windows.Forms.ComboBox combox_patientsTreatment;
        private System.Windows.Forms.Label lb_patientTreament;
        private System.Windows.Forms.Panel pn_treatmentSession;
        private System.Windows.Forms.Label lb_notesTsession;
        private System.Windows.Forms.RichTextBox tx_sessionNotes;
        private System.Windows.Forms.Label lb_patient;
        private System.Windows.Forms.ComboBox combo_patientsTreatmentSession;
        private System.Windows.Forms.Button bt_createTreatmentSession;
        private System.Windows.Forms.Label lb_titleTreatmentSession;
        private System.Windows.Forms.Label lb_tr;
        private System.Windows.Forms.Label lb_pvTreatments;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nm_quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_userPrescription;
        private System.Windows.Forms.Label lb_presc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo_TreatmentList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox combo_TreatmentItem;
    }
}

