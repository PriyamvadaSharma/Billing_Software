using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Final_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            uname.Focus();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool IsValidforAdd()
        {
            bool retval = false;
            if (uname.Text.Trim() == "")
                MessageBox.Show("Please enter UserName", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pass.Text.Trim() == "")
                MessageBox.Show("Please enter Password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pass.Text.Length > 10)
                MessageBox.Show("Please enter a Password of Less than 10 Characters", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (uname.Text.Length > 15)
                MessageBox.Show("Please enter a UserName of Less than 15 Characters", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else retval = true;

            return retval;
        }

        private void butlog_Click(object sender, EventArgs e)
        {
            if (IsValidforAdd())
            {
                Class1.CreateConnection();
                SqlCommand cmd = new SqlCommand("select * from tbl_login where Uname='" + uname.Text.ToString() + "'and Password='" + pass.Text.ToString() + "' ", Class1.Cnn);
                SqlDataReader Dr = cmd.ExecuteReader();
                if (Dr.HasRows == true)
                {
                    Dr.Read();
                    Class1.uid = Dr["Uid"].ToString();
                    this.Hide();
                    MDI_Form f = new MDI_Form();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Invalid UserName Or Password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    refr();
                    uname.Focus();
                }
            }
        }
        void refr()
        {
            uname.Text = "";
            pass.Text = "";
        }
        private void butreg_Click(object sender, EventArgs e)
        {
           
        }

    }
}
