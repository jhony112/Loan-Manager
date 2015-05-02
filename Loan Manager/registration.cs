using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Loan_Manager
{
    public partial class registration : UserControl
    {
        public registration()
        {
            InitializeComponent();
        }

        public void populate(string[] items, string tag) //use this to populate the registration control
        {

            switch (tag)
            {
                case "p":

                default:
                    break;
            }



        }

        private void iTalk_TextBox_Small9_TextChanged(object sender, EventArgs e)
        {

        }
        public void SaveApplicant()
        {


            MySqlConnection connection = new MySqlConnection(ConManager.MyConnectionString);
            MySqlCommand cmd;
            connection.Open();

            try
            {

                cmd = connection.CreateCommand();
                 
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    MessageBox.Show("New record is added successfully!", "Success");

                    //loadData();
                }

            }

        }
        private void iTalk_Label14_Click(object sender, EventArgs e)
        {

        }


    }
}

