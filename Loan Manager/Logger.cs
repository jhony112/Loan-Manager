using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loan_Manager
{

    class Logger
    {
        StringBuilder PaymentLoggerBuilder = new StringBuilder();
        public void PaymentLogger(string message)
        {
            PaymentLoggerBuilder.Append(message + " " + DateTime.Now).AppendLine();


        }
        public void CommitPaymentLogs(string index)
        {
            MySqlConnection cn = new MySqlConnection();
            MySqlCommand cmd;
           
            cn.ConnectionString = ConManager.MyConnectionString;




            try
            {
                cn.Open();

                cmd = cn.CreateCommand();


                cmd.CommandText = "UPDATE registered SET logs=CONCAT(logs,'"+PaymentLoggerBuilder.ToString()+"')WHERE form_id="+index;
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
