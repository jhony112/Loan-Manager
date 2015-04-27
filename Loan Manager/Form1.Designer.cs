namespace Loan_Manager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iTalk_ThemeContainer1 = new iTalk_ThemeContainer();
            this.panel_login = new iTalk_Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_login = new iTalk_Button_2();
            this.iTalk_HeaderLabel1 = new iTalk_HeaderLabel();
            this.txt_pass = new iTalk_TextBox_Big();
            this.txt_user = new iTalk_TextBox_Big();
            this.iTalk_ThemeContainer1.SuspendLayout();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // iTalk_ThemeContainer1
            // 
            this.iTalk_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.iTalk_ThemeContainer1.Controls.Add(this.panel_login);
            this.iTalk_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_ThemeContainer1.DrawBottomBar = true;
            this.iTalk_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_ThemeContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_ThemeContainer1.Name = "iTalk_ThemeContainer1";
            this.iTalk_ThemeContainer1.Padding = new System.Windows.Forms.Padding(3, 28, 3, 28);
            this.iTalk_ThemeContainer1.Size = new System.Drawing.Size(876, 600);
            this.iTalk_ThemeContainer1.TabIndex = 0;
            this.iTalk_ThemeContainer1.Text = "iTalk_ThemeContainer1";
            this.iTalk_ThemeContainer1.TextBottom = null;
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.DimGray;
            this.panel_login.Controls.Add(this.pictureBox2);
            this.panel_login.Controls.Add(this.pictureBox1);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.iTalk_HeaderLabel1);
            this.panel_login.Controls.Add(this.txt_pass);
            this.panel_login.Controls.Add(this.txt_user);
            this.panel_login.Location = new System.Drawing.Point(221, 176);
            this.panel_login.Name = "panel_login";
            this.panel_login.Padding = new System.Windows.Forms.Padding(5);
            this.panel_login.Size = new System.Drawing.Size(436, 260);
            this.panel_login.TabIndex = 0;
            this.panel_login.Text = "iTalk_Panel1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Loan_Manager.Properties.Resources.Password;
            this.pictureBox2.Location = new System.Drawing.Point(33, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Loan_Manager.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(33, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Image = null;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(74, 208);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(266, 40);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(104, 5);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(210, 46);
            this.iTalk_HeaderLabel1.TabIndex = 2;
            this.iTalk_HeaderLabel1.Text = "Admin Login";
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.Transparent;
            this.txt_pass.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_pass.ForeColor = System.Drawing.Color.DimGray;
            this.txt_pass.Image = null;
            this.txt_pass.Location = new System.Drawing.Point(74, 134);
            this.txt_pass.MaxLength = 32767;
            this.txt_pass.Multiline = false;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.ReadOnly = false;
            this.txt_pass.Size = new System.Drawing.Size(266, 41);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.Text = "Password";
            this.txt_pass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_pass.UseSystemPasswordChar = false;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.Transparent;
            this.txt_user.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_user.ForeColor = System.Drawing.Color.DimGray;
            this.txt_user.Image = null;
            this.txt_user.Location = new System.Drawing.Point(74, 70);
            this.txt_user.MaxLength = 32767;
            this.txt_user.Multiline = false;
            this.txt_user.Name = "txt_user";
            this.txt_user.ReadOnly = false;
            this.txt_user.Size = new System.Drawing.Size(266, 41);
            this.txt_user.TabIndex = 0;
            this.txt_user.Text = "Username";
            this.txt_user.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_user.UseSystemPasswordChar = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 600);
            this.Controls.Add(this.iTalk_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTalk_ThemeContainer1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.iTalk_ThemeContainer1.ResumeLayout(false);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk_ThemeContainer iTalk_ThemeContainer1;
        private iTalk_Panel panel_login;
        private iTalk_HeaderLabel iTalk_HeaderLabel1;
        private iTalk_TextBox_Big txt_pass;
        private iTalk_TextBox_Big txt_user;
        private iTalk_Button_2 btn_login;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

