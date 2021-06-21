
namespace prescriptionSystem_project
{
    partial class Register
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
            this.lb_register = new System.Windows.Forms.Label();
            this.bt_register = new System.Windows.Forms.Button();
            this.tx_nif = new System.Windows.Forms.TextBox();
            this.tx_pass = new System.Windows.Forms.TextBox();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.dt_birth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_phone = new System.Windows.Forms.TextBox();
            this.tx_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd_patient = new System.Windows.Forms.RadioButton();
            this.rd_therapist = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_WindowTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_register
            // 
            this.lb_register.AutoSize = true;
            this.lb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lb_register.Location = new System.Drawing.Point(135, 59);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(134, 37);
            this.lb_register.TabIndex = 0;
            this.lb_register.Text = "Register";
            // 
            // bt_register
            // 
            this.bt_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.bt_register.Location = new System.Drawing.Point(142, 470);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(670, 51);
            this.bt_register.TabIndex = 1;
            this.bt_register.Text = "Register";
            this.bt_register.UseVisualStyleBackColor = true;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // tx_nif
            // 
            this.tx_nif.Location = new System.Drawing.Point(193, 34);
            this.tx_nif.Name = "tx_nif";
            this.tx_nif.Size = new System.Drawing.Size(471, 20);
            this.tx_nif.TabIndex = 2;
            // 
            // tx_pass
            // 
            this.tx_pass.Location = new System.Drawing.Point(193, 60);
            this.tx_pass.Name = "tx_pass";
            this.tx_pass.Size = new System.Drawing.Size(471, 20);
            this.tx_pass.TabIndex = 3;
            // 
            // tx_name
            // 
            this.tx_name.Location = new System.Drawing.Point(193, 27);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(471, 20);
            this.tx_name.TabIndex = 4;
            // 
            // dt_birth
            // 
            this.dt_birth.Location = new System.Drawing.Point(193, 53);
            this.dt_birth.Name = "dt_birth";
            this.dt_birth.Size = new System.Drawing.Size(471, 20);
            this.dt_birth.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fiscal Number (NIF)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(4, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birth Date";
            // 
            // tx_phone
            // 
            this.tx_phone.Location = new System.Drawing.Point(193, 49);
            this.tx_phone.Name = "tx_phone";
            this.tx_phone.Size = new System.Drawing.Size(471, 20);
            this.tx_phone.TabIndex = 5;
            // 
            // tx_address
            // 
            this.tx_address.Location = new System.Drawing.Point(193, 23);
            this.tx_address.Name = "tx_address";
            this.tx_address.Size = new System.Drawing.Size(471, 20);
            this.tx_address.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(4, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(4, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Phone Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tx_address);
            this.groupBox1.Controls.Add(this.tx_phone);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.groupBox1.Location = new System.Drawing.Point(142, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 86);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tx_name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dt_birth);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.groupBox2.Location = new System.Drawing.Point(142, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 97);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_patient);
            this.groupBox3.Controls.Add(this.rd_therapist);
            this.groupBox3.Controls.Add(this.tx_pass);
            this.groupBox3.Controls.Add(this.tx_nif);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.groupBox3.Location = new System.Drawing.Point(142, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(670, 117);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login Info";
            // 
            // rd_patient
            // 
            this.rd_patient.AutoSize = true;
            this.rd_patient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.rd_patient.Location = new System.Drawing.Point(91, 87);
            this.rd_patient.Name = "rd_patient";
            this.rd_patient.Size = new System.Drawing.Size(58, 17);
            this.rd_patient.TabIndex = 11;
            this.rd_patient.TabStop = true;
            this.rd_patient.Text = "Patient";
            this.rd_patient.UseVisualStyleBackColor = true;
            // 
            // rd_therapist
            // 
            this.rd_therapist.AutoSize = true;
            this.rd_therapist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.rd_therapist.Location = new System.Drawing.Point(16, 87);
            this.rd_therapist.Name = "rd_therapist";
            this.rd_therapist.Size = new System.Drawing.Size(69, 17);
            this.rd_therapist.TabIndex = 10;
            this.rd_therapist.TabStop = true;
            this.rd_therapist.Text = "Therapist";
            this.rd_therapist.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lb_WindowTitle);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 27);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lb_WindowTitle
            // 
            this.lb_WindowTitle.AutoSize = true;
            this.lb_WindowTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_WindowTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_WindowTitle.Location = new System.Drawing.Point(455, 7);
            this.lb_WindowTitle.Name = "lb_WindowTitle";
            this.lb_WindowTitle.Size = new System.Drawing.Size(49, 14);
            this.lb_WindowTitle.TabIndex = 1;
            this.lb_WindowTitle.Text = "Register";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::prescriptionSystem_project.Properties.Resources.close;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(925, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.lb_register);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 484);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_register;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.TextBox tx_nif;
        private System.Windows.Forms.TextBox tx_pass;
        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.DateTimePicker dt_birth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_phone;
        private System.Windows.Forms.TextBox tx_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rd_patient;
        private System.Windows.Forms.RadioButton rd_therapist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_WindowTitle;
    }
}