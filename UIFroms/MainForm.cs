using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prescriptionSystem_project.UIFroms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            if (loginForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // check login here
            }
        }
    }
}
