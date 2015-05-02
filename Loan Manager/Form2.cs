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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           // this.WindowState = FormWindowState.Maximized;
            listView1.Columns.Add("Form Number", 100);
            listView1.Columns.Add("Name", 150);

            listView1.Columns.Add("Gender", 80);
            listView1.Columns.Add("Loan Rate", 80);
            listView1.Columns.Add("Loan Ammount", 80);
            listView1.Columns.Add("Loan Payback", 80);
            listView1.Columns.Add("Phone", 80);
            listView1.Columns.Add("Occcupation", 100);
            listView1.Columns.Add("Email", 100);
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            tabcontrol1.SelectedTab = tabPage2;
        }
        public void preparelistview()
        {
           
        }
        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {
            tabcontrol1.SelectedTab = tabPage1;
        }

        private void iTalk_Button_21_Click_1(object sender, EventArgs e)
        {
            saveToDatabase("a");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void populateList(string tag)
        {
            listView1.Items.Clear();
         MySqlConnection cn =new MySqlConnection();
         MySqlCommand cmd;
         MySqlDataReader reader;
         cn.ConnectionString = ConManager.MyConnectionString;
         listView1.FullRowSelect = true;
         listView1.GridLines = true;
         listView1.View = View.Details;
        
        
         
         try
         {
             cn.Open();

             cmd = cn.CreateCommand();
             if (tag == "a") {
                 cmd.CommandText = "SELECT * FROM applicants";
             }
             else if (tag == "r")
             {

                 cmd.CommandText = "SELECT * FROM registered";
             }

             reader = cmd.ExecuteReader();
             ListViewItem item;
             while (reader.Read())
             {
                 string[] arr = new string[9];

                 arr[0] = reader["form_id"].ToString();
                 arr[1] = reader["name"].ToString();
                 arr[2] = reader["gender"].ToString();
                 arr[3] = reader["loan_rate"].ToString();
                 arr[4] = reader["loan_amnt"].ToString();
                 arr[5] = reader["loan_payback"].ToString();
                 arr[6] = reader["phone"].ToString();
                 arr[7] = reader["occupation"].ToString();
                 arr[8] = reader["email"].ToString();
                  item = new ListViewItem(arr);
                 listView1.Items.Add(item);
                 

             }
         }
         catch (Exception)
         {
             
             throw;
         }
            
            

        }
        public void saveToDatabase(string tag) {
          
            
           
            MySqlConnection connection = new MySqlConnection(ConManager.MyConnectionString);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                
                
                  
                    cmd = connection.CreateCommand();
                    if (tag == "a") {
                        cmd.CommandText = "INSERT INTO applicants(name,address,gender,phone,occupation,marital_status,email,driver_lisc,kin_name,kin_relation,colateral,colateral_add,loan_type,loan_rate,loan_amnt,loan_payback,p_passport,p_sign,g_passport,g_sign,g_gender,g_name,g_address,g_marital, g_phone,g_occupation,g_email,g_dob,g_driver)VALUES(@name,@address,@gender,@phone,@occupation,@marital_status,@email,@driver_lisc,@kin_name,@kin_relation,@colateral,@colateral_add,@loan_type,@loan_rate,@loan_amnt,@loan_payback,@p_passport,@p_sign,@g_passport,@g_sign,@g_gender,@g_name,@g_address,@g_marital,@g_phone,@g_occupation,@g_email,@g_dob,@g_driver)";
                       
                    }
                    else if (tag == "r")
                    {

                        cmd.CommandText = "INSERT INTO registered(name,address,gender,phone,occupation,marital_status,email,driver_lisc,kin_name,kin_relation,colateral,colateral_add,loan_type,loan_rate,loan_amnt,loan_payback,p_passport,p_sign,g_passport,g_sign,g_gender,g_name,g_address,g_marital, g_phone,g_occupation,g_email,g_dob,g_driver)VALUES(@name,@address,@gender,@phone,@occupation,@marital_status,@email,@driver_lisc,@kin_name,@kin_relation,@colateral,@colateral_add,@loan_type,@loan_rate,@loan_amnt,@loan_payback,@p_passport,@p_sign,@g_passport,@g_sign,@g_gender,@g_name,@g_address,@g_marital,@g_phone,@g_occupation,@g_email,@g_dob,@g_driver)";
                      
                    }
                    byte[] ppix =imagetobyte(img_passport.Image);
                byte[] psign =imagetobyte(img_sign.Image);
                 byte[] gpix =imagetobyte(img_passport.Image);
                byte[] gsign =imagetobyte(img_sign.Image);
                  //  cmd.CommandText = "INSERT INTO loans.applicants(name,address,gender,phone ,occupation,marital_status ,email,driver_lisc,kin_name,,kin_relation,colateral,colateral_add,loan_type,loan_rate,loan_amnt,loan_paybck,p_passport,p_sign,g_passport,g_sign,g_gender,g_name,g_address,g_marital, g_phone,g_occupation,g_email,g_dob,g_driver)";
                    cmd.Parameters.AddWithValue("@name",p_name.Text);
                    cmd.Parameters.AddWithValue("@address", p_address.Text);
                    cmd.Parameters.AddWithValue("@gender", p_gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@phone", p_tel_no.Text);
                    cmd.Parameters.AddWithValue("@occupation", p_occupation.Text);
                    cmd.Parameters.AddWithValue("@marital_status", p_marital_status.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@email", p_email.Text);
                    cmd.Parameters.AddWithValue("@driver_lisc", p_driver.Text);
                    cmd.Parameters.AddWithValue("@kin_name", p_kin.Text);
                    cmd.Parameters.AddWithValue("@kin_relation", p_kinRelation.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@colateral", p_colateral.Text);
                    cmd.Parameters.AddWithValue("@colateral_add",colateral_add.Text );
                    cmd.Parameters.AddWithValue("@loan_type",loan_type.SelectedItem.ToString() );
                    cmd.Parameters.AddWithValue("@loan_rate",intrest_rate.Text );
                    cmd.Parameters.AddWithValue("@loan_amnt",loan_amount.Text );
                    cmd.Parameters.AddWithValue("@loan_payback",loan_repay.Text );
                
                    cmd.Parameters.AddWithValue("@p_passport",ppix );
                    cmd.Parameters.AddWithValue("@p_sign", psign);
                    cmd.Parameters.AddWithValue("@g_passport", gpix);
                    cmd.Parameters.AddWithValue("@g_sign", gsign);
                    cmd.Parameters.AddWithValue("@g_gender", g_gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@g_name", g_name.Text);
                    cmd.Parameters.AddWithValue("@g_address", g_address.Text);
                    cmd.Parameters.AddWithValue("@g_marital", g_marital.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@g_phone", g_tel.Text);
                    cmd.Parameters.AddWithValue("@g_occupation", g_email.Text);
                    cmd.Parameters.AddWithValue("@g_email", g_email.Text);
                    cmd.Parameters.AddWithValue("@g_dob", g_dob.Text);
                    cmd.Parameters.AddWithValue("@g_driver", g_driver.Text);
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
                   // MessageBox.Show(p_name.Text + p_address.Text );
                   
                }
                
            }
        
       
        
        }
         public static byte[] imagetobyte(Image path){

  

           try 
	{	        
		System.IO.MemoryStream ms= new System.IO.MemoryStream();
               Bitmap bmpimage= new Bitmap(path);
               bmpimage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
               byte[] byteimage = ms.ToArray();
              
                ms.Close();
               ms.Dispose();
               return byteimage;
	}
	catch (Exception)
	{
		
		throw;
	}
               


        }

         private void btn_pasport_Click(object sender, EventArgs e)
         {
             OpenFileDialog sfd = new OpenFileDialog();
             if (sfd.ShowDialog()== DialogResult.OK)
             {
                 img_passport.ImageLocation = sfd.FileName;



             }
         }

         private void btn_sign_Click(object sender, EventArgs e)
         {
             OpenFileDialog sfd = new OpenFileDialog();
             if (sfd.ShowDialog() == DialogResult.OK)
             {
                 img_sign.ImageLocation = sfd.FileName;



             }
         }

         private void iTalk_Button_11_Click(object sender, EventArgs e)
         {
             OpenFileDialog sfd = new OpenFileDialog();
             if (sfd.ShowDialog() == DialogResult.OK)
             {
                 g_image.ImageLocation = sfd.FileName;



             }
         }

         private void iTalk_Button_12_Click(object sender, EventArgs e)
         {
             OpenFileDialog sfd = new OpenFileDialog();
             if (sfd.ShowDialog() == DialogResult.OK)
             {
                 g_sign.ImageLocation = sfd.FileName;



             }
         }

         private void viewApplicantToolStripMenuItem_Click(object sender, EventArgs e)
         {
           //  preparelistview();
             populateList("a");
             tabcontrol1.SelectedTab = tabPage3;

         }

         private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
         {
             tabcontrol1.SelectedTab = tabPage1;
         }

         private void listView1_MouseClick(object sender, MouseEventArgs e)
         {
             listView1.ContextMenuStrip = this.listmenu;
             listView1.ContextMenuStrip.Show(Cursor.Position);
         }

         private void makePaymentToolStripMenuItem_Click(object sender, EventArgs e)
         {
             tabcontrol1.SelectedTab = tabPage4;
         }
         public void AproveAplicant(string key) {

             MySqlConnection connection = new MySqlConnection(ConManager.MyConnectionString);
             MySqlCommand cmd;
             connection.Open();
             try
             {
                  cmd = connection.CreateCommand();
                 cmd.CommandText="INSERT INTO registered SELECT * FROM applicants WHERE form_id=" + key ;
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
                     MessageBox.Show("User Aprroved successfully!", "Success");
                     try
                     {
                         connection.Open();
                          cmd = connection.CreateCommand();
                 cmd.CommandText="DELETE FROM applicants WHERE form_id=" + key ;
                 cmd.ExecuteNonQuery();
                     }
                     catch (Exception)
                     {
                         
                         throw;
                     }
                     connection.Close();
                     populateList("a");
                 }

             }
        
         
         }
         private void approveApplicantToolStripMenuItem_Click(object sender, EventArgs e)
         {
             string productName = listView1.SelectedItems[0].SubItems[0].Text;
            // MessageBox.Show(productName);
             AproveAplicant(productName);
         }

        private void viewRegisteredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            populateList("r");
             tabcontrol1.SelectedTab = tabPage3;
        }

        private void iTalk_Button_23_Click(object sender, EventArgs e)
        {
            SearchUser(repay_id.Text.Trim());
        }
        public void updater(string content,string id,string curentpay) {

            MySqlConnection cn = new MySqlConnection();
            MySqlCommand cmd;
          
            cn.ConnectionString = ConManager.MyConnectionString;

            try
            {
                cn.Open();
                cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE loans.registered SET loan_payback='"+content+"' WHERE registered.form_id ="+id;
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                
                MessageBox.Show("Updated");
                Logger logger=new Logger();
                logger.PaymentLogger("Payment of " + curentpay+ " made on ");
                logger.CommitPaymentLogs(id);
                r_curent.Clear();
                MessageBox.Show("Updated Account");
                cn.Close();

            }

            
        }


        public  int CalcIntrest(int wat,int total)
        {

            int value;
              value= (wat*total) / 100;
          // MessageBox.Show(value.ToString());
            return value;


        }
        public void SearchUser(string tag)
        {
            MySqlConnection cn = new MySqlConnection();
            MySqlCommand cmd;
            MySqlDataReader reader;
            cn.ConnectionString = ConManager.MyConnectionString;
           



            try
            {
                cn.Open();

                cmd = cn.CreateCommand();


                cmd.CommandText = "SELECT * FROM registered WHERE form_id="+tag;
                

                reader = cmd.ExecuteReader();
                int intrest = 0;
                while (reader.Read())
                {
                    string[] arr = new string[9];

                    arr[0] = reader["loan_type"].ToString();
                    arr[1] = reader["name"].ToString();
                    arr[2] = reader["gender"].ToString();
                    arr[3] = reader["loan_rate"].ToString();
                    arr[4] = reader["loan_amnt"].ToString();
                    arr[5] = reader["loan_payback"].ToString();
                    r_intrestrate.Text = arr[3];
                    if (arr[3] != "")
                    {
                       
                        intrest = CalcIntrest(int.Parse(arr[3]), int.Parse(arr[4]));
                        
                        r_a_tobepaid.Text = (int.Parse(arr[4]) + intrest).ToString();
                    }
                    if (int.Parse(arr[5]) <= int.Parse(arr[4]))
                    {

                        int balance = int.Parse(arr[4])+ intrest - int.Parse(arr[5]);
                        r_balance.Text = balance.ToString();

                    }
                    r_name.Text = arr[1];
                    if (arr[2]=="Male"){
                        gender.Text = "Mr";
                    }
                    else
                    {
                        gender.Text = "Mrs";
                    }
                    r_loaned.Text = arr[4];
                   
                    r_loantype.Text = arr[0];

                    r_a_paid.Text = arr[5];
                }
            }
            catch (Exception)
            {

                throw;
            }

            cn.Close();

        }

        private void iTalk_Button_24_Click(object sender, EventArgs e)
        {
            if (r_a_paid.Text != "")
            {
                int total = int.Parse(r_a_paid.Text) + int.Parse(r_curent.Text);
                updater(total.ToString(), repay_id.Text, r_curent.Text);
            }
            else {
                updater(r_curent.Text, repay_id.Text, r_curent.Text);
            }

            
        }

        private void iTalk_HeaderLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
