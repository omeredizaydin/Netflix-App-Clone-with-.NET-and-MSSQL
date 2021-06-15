using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace netflixApp
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            btnContinue.Visible = false;
            planForm1.Visible = true;
            seePlanForm1.Visible = false;
        }

        private void seePlanForm1_Load(object sender, EventArgs e)
        {
        }

        private void btnSeethePlans_Click(object sender, EventArgs e)
        {
            planForm1.Visible = false;
            seePlanForm1.Visible = true;
            btnSeethePlans.Visible = false;
            //btnContinue.Visible = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }
    }
}
