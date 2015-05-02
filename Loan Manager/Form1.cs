using MySql.Data.MySqlClient;
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

        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cmd;
        MySqlDataReader reader;

        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity == 0)
            {
                Form2 newform = new Form2();

                newform.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                newform.Show();
                this.Hide();
                timer1.Stop();
            }
        }
        public bool CheckLogin(string user, string pass)
        {


            cn.ConnectionString = ConManager.MyConnectionString;

            try
            {
                cn.Open();

                int count = 0;

                //  cmd.CommandText = "SELECT * FROM admin WHERE user='" + this.txtUname.Text + "' and password='" + this.txtPassword.Text + "'";

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    count++;

                }
            }
            catch (Exception)
            {

                throw;
            }
            return false;


        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_user.Text);
            timer1.Start();
        }
    }
}
