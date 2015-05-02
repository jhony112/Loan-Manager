using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Loan_Manager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            
        }

        private void iTalk_Button_27_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iTalk_MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void iTalk_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Customer Name", 150);
            listView1.Columns.Add("Account Number", 150);
            listView1.Columns.Add("Category", 150);
            listView1.Columns.Add("Ammount Loaned", 150);
            ListViewItem item;
            string[] arr = new string[4];
            arr[0] = "me";
            arr[1] = "my guy";
            arr[2] = "my guy";
            arr[3] = "my guy";
            item = new ListViewItem(arr);
            listView1.Items.Add(item);

        }
    }
}
