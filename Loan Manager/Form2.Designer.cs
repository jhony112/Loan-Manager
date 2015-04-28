namespace Loan_Manager
{
    partial class Form2
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
            ControlRenderer controlRenderer1 = new ControlRenderer();
            MSColorTable msColorTable1 = new MSColorTable();
            this.iTalk_ThemeContainer1 = new iTalk_ThemeContainer();
            this.iTalk_Panel1 = new iTalk_Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iTalk_MenuStrip1 = new iTalk_MenuStrip();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanRepaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewApplicantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRegisteredCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iTalk_Listview1 = new iTalk_Listview();
            this.iTalk_ThemeContainer1.SuspendLayout();
            this.iTalk_Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.iTalk_MenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iTalk_ThemeContainer1
            // 
            this.iTalk_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.iTalk_ThemeContainer1.Controls.Add(this.iTalk_Panel1);
            this.iTalk_ThemeContainer1.Controls.Add(this.tabControl1);
            this.iTalk_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_ThemeContainer1.DrawBottomBar = true;
            this.iTalk_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_ThemeContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_ThemeContainer1.Name = "iTalk_ThemeContainer1";
            this.iTalk_ThemeContainer1.Padding = new System.Windows.Forms.Padding(3, 28, 3, 28);
            this.iTalk_ThemeContainer1.Size = new System.Drawing.Size(890, 600);
            this.iTalk_ThemeContainer1.TabIndex = 0;
            this.iTalk_ThemeContainer1.Text = "iTalk_ThemeContainer1";
            this.iTalk_ThemeContainer1.TextBottom = null;
            this.iTalk_ThemeContainer1.Click += new System.EventHandler(this.iTalk_ThemeContainer1_Click);
            // 
            // iTalk_Panel1
            // 
            this.iTalk_Panel1.BackColor = System.Drawing.Color.DarkRed;
            this.iTalk_Panel1.Controls.Add(this.panel1);
            this.iTalk_Panel1.Location = new System.Drawing.Point(6, 31);
            this.iTalk_Panel1.Name = "iTalk_Panel1";
            this.iTalk_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel1.Size = new System.Drawing.Size(166, 538);
            this.iTalk_Panel1.TabIndex = 1;
            this.iTalk_Panel1.Text = "iTalk_Panel1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.iTalk_MenuStrip1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 526);
            this.panel1.TabIndex = 2;
            // 
            // iTalk_MenuStrip1
            // 
            this.iTalk_MenuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iTalk_MenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordsToolStripMenuItem,
            this.loanRepaymentToolStripMenuItem,
            this.loanRecordsToolStripMenuItem,
            this.transactionRecordsToolStripMenuItem,
            this.registrationToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.iTalk_MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_MenuStrip1.Name = "iTalk_MenuStrip1";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            this.iTalk_MenuStrip1.Renderer = controlRenderer1;
            this.iTalk_MenuStrip1.Size = new System.Drawing.Size(149, 526);
            this.iTalk_MenuStrip1.TabIndex = 1;
            this.iTalk_MenuStrip1.Text = "iTalk_MenuStrip1";
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem});
            this.recordsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.recordsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(136, 33);
            this.recordsToolStripMenuItem.Text = "Records";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.addNewToolStripMenuItem.Text = "Add New";
            // 
            // loanRepaymentToolStripMenuItem
            // 
            this.loanRepaymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentHistoryToolStripMenuItem,
            this.paymentRatesToolStripMenuItem,
            this.paymentToolStripMenuItem});
            this.loanRepaymentToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.loanRepaymentToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.loanRepaymentToolStripMenuItem.Name = "loanRepaymentToolStripMenuItem";
            this.loanRepaymentToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.loanRepaymentToolStripMenuItem.Size = new System.Drawing.Size(136, 33);
            this.loanRepaymentToolStripMenuItem.Text = "Loan Repayment";
            // 
            // paymentHistoryToolStripMenuItem
            // 
            this.paymentHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.paymentHistoryToolStripMenuItem.Name = "paymentHistoryToolStripMenuItem";
            this.paymentHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.paymentHistoryToolStripMenuItem.Text = "Payment History";
            // 
            // paymentRatesToolStripMenuItem
            // 
            this.paymentRatesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.paymentRatesToolStripMenuItem.Name = "paymentRatesToolStripMenuItem";
            this.paymentRatesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.paymentRatesToolStripMenuItem.Text = "Payment Rates";
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.paymentToolStripMenuItem.Text = "Make Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // loanRecordsToolStripMenuItem
            // 
            this.loanRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewApplicantsToolStripMenuItem,
            this.viewRegisteredCustomersToolStripMenuItem});
            this.loanRecordsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.loanRecordsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.loanRecordsToolStripMenuItem.Name = "loanRecordsToolStripMenuItem";
            this.loanRecordsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.loanRecordsToolStripMenuItem.Size = new System.Drawing.Size(136, 33);
            this.loanRecordsToolStripMenuItem.Text = "Loan Records";
            // 
            // viewApplicantsToolStripMenuItem
            // 
            this.viewApplicantsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.viewApplicantsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.viewApplicantsToolStripMenuItem.Name = "viewApplicantsToolStripMenuItem";
            this.viewApplicantsToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.viewApplicantsToolStripMenuItem.Text = "View Applicants";
            // 
            // viewRegisteredCustomersToolStripMenuItem
            // 
            this.viewRegisteredCustomersToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.viewRegisteredCustomersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.viewRegisteredCustomersToolStripMenuItem.Name = "viewRegisteredCustomersToolStripMenuItem";
            this.viewRegisteredCustomersToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.viewRegisteredCustomersToolStripMenuItem.Text = "View Registered Customers";
            // 
            // transactionRecordsToolStripMenuItem
            // 
            this.transactionRecordsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.transactionRecordsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.transactionRecordsToolStripMenuItem.Name = "transactionRecordsToolStripMenuItem";
            this.transactionRecordsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.transactionRecordsToolStripMenuItem.Size = new System.Drawing.Size(136, 33);
            this.transactionRecordsToolStripMenuItem.Text = "Transaction Records";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.registrationToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(136, 33);
            this.registrationToolStripMenuItem.Text = "Registration";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.transactionToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(136, 33);
            this.transactionToolStripMenuItem.Text = "Change Password";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 33);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(166, 31);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.iTalk_Listview1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // iTalk_Listview1
            // 
            this.iTalk_Listview1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iTalk_Listview1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.iTalk_Listview1.Location = new System.Drawing.Point(164, 64);
            this.iTalk_Listview1.Name = "iTalk_Listview1";
            this.iTalk_Listview1.Size = new System.Drawing.Size(360, 97);
            this.iTalk_Listview1.TabIndex = 0;
            this.iTalk_Listview1.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 600);
            this.Controls.Add(this.iTalk_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "iTalk_ThemeContainer1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.iTalk_ThemeContainer1.ResumeLayout(false);
            this.iTalk_Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.iTalk_MenuStrip1.ResumeLayout(false);
            this.iTalk_MenuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk_ThemeContainer iTalk_ThemeContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private iTalk_Panel iTalk_Panel1;
        private System.Windows.Forms.Panel panel1;
        private iTalk_MenuStrip iTalk_MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanRepaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewApplicantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRegisteredCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentRatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private iTalk_Listview iTalk_Listview1;
    }
}