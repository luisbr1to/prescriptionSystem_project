
namespace prescriptionSystem_project
{
    partial class Login
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
            this.bt_signup = new System.Windows.Forms.Button();
            this.lb_nif = new System.Windows.Forms.Label();
            this.tx_nif = new System.Windows.Forms.TextBox();
            this.tx_pass = new System.Windows.Forms.TextBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_signin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_WindowTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_signup
            // 
            this.bt_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bt_signup.Location = new System.Drawing.Point(308, 406);
            this.bt_signup.Name = "bt_signup";
            this.bt_signup.Size = new System.Drawing.Size(375, 47);
            this.bt_signup.TabIndex = 0;
            this.bt_signup.Text = "Sign In";
            this.bt_signup.UseVisualStyleBackColor = true;
            this.bt_signup.Click += new System.EventHandler(this.bt_signup_Click);
            // 
            // lb_nif
            // 
            this.lb_nif.AutoSize = true;
            this.lb_nif.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lb_nif.Location = new System.Drawing.Point(201, 270);
            this.lb_nif.Name = "lb_nif";
            this.lb_nif.Size = new System.Drawing.Size(43, 25);
            this.lb_nif.TabIndex = 1;
            this.lb_nif.Text = "NIF";
            // 
            // tx_nif
            // 
            this.tx_nif.Location = new System.Drawing.Point(308, 276);
            this.tx_nif.Name = "tx_nif";
            this.tx_nif.Size = new System.Drawing.Size(375, 20);
            this.tx_nif.TabIndex = 2;
            // 
            // tx_pass
            // 
            this.tx_pass.Location = new System.Drawing.Point(308, 343);
            this.tx_pass.Name = "tx_pass";
            this.tx_pass.PasswordChar = '●';
            this.tx_pass.Size = new System.Drawing.Size(375, 20);
            this.tx_pass.TabIndex = 4;
            this.tx_pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lb_pass.Location = new System.Drawing.Point(201, 337);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(97, 25);
            this.lb_pass.TabIndex = 3;
            this.lb_pass.Text = "Password";
            this.lb_pass.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lb_title.Location = new System.Drawing.Point(323, 129);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(339, 42);
            this.lb_title.TabIndex = 5;
            this.lb_title.Text = "Prescription System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prescriptionSystem_project.Properties.Resources.snakes;
            this.pictureBox1.Location = new System.Drawing.Point(136, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_signin
            // 
            this.bt_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_signin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.bt_signin.Location = new System.Drawing.Point(308, 484);
            this.bt_signin.Name = "bt_signin";
            this.bt_signin.Size = new System.Drawing.Size(375, 45);
            this.bt_signin.TabIndex = 7;
            this.bt_signin.Text = "Sign Up";
            this.bt_signin.UseVisualStyleBackColor = true;
            this.bt_signin.Click += new System.EventHandler(this.bt_signin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lb_WindowTitle);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 27);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lb_WindowTitle
            // 
            this.lb_WindowTitle.AutoSize = true;
            this.lb_WindowTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_WindowTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_WindowTitle.Location = new System.Drawing.Point(463, 8);
            this.lb_WindowTitle.Name = "lb_WindowTitle";
            this.lb_WindowTitle.Size = new System.Drawing.Size(36, 14);
            this.lb_WindowTitle.TabIndex = 1;
            this.lb_WindowTitle.Text = "Login";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::prescriptionSystem_project.Properties.Resources.close;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(924, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_signin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.tx_pass);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.tx_nif);
            this.Controls.Add(this.lb_nif);
            this.Controls.Add(this.bt_signup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_signup;
        private System.Windows.Forms.Label lb_nif;
        private System.Windows.Forms.TextBox tx_nif;
        private System.Windows.Forms.TextBox tx_pass;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_signin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_WindowTitle;
        private System.Windows.Forms.Button button1;
    }
}