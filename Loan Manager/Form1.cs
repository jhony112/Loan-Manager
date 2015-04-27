using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loan_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity == 0) {
                Form2 newform = new Form2();
                
                newform.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                newform.Show();
                this.Hide();
                timer1.Stop();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
