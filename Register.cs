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
    public partial class Register : Form
    {
        public Register()
        {
            Class1.CreateConnection();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butref_Click(object sender, EventArgs e)
        {
            refr();
        }
        void refr()
        {
            name.Text="";
            uname.Text="";
            pass.Text="";
            confpas.Text="";
        }
        private void Register_Load(object sender, EventArgs e)
        {
            name.Focus();
            Class1.CreateConnection();
         }
        bool IsValidforAdd()
        {
            bool retval = false;
            if (name.Text.Trim() == "")
                MessageBox.Show("Please enter your Name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (name.Text.Length > 29)
                MessageBox.Show("Please enter valid Name not containing any digit or special Character", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (uname.Text.Trim() == "")
                MessageBox.Show("Please enter a UserName", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (uname.Text.Length > 15)
                MessageBox.Show("Please enter a UserName of Less than 15 Characters", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pass.Text.Trim() == "")
                MessageBox.Show("Please enter Password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pass.Text.Length > 10)
                MessageBox.Show("Please enter a Password of Less than 10 Characters", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (confpas.Text.Trim() == "")
                MessageBox.Show("Please enter your Password for confirmation", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (confpas.Text.Trim() != pass.Text.Trim())
                MessageBox.Show("Please enter your correct Password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else retval = true;

            return retval;
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            Class1.CreateConnection();
            if (IsValidforAdd())
            {
                SqlCommand cmd = new SqlCommand("Insert into tbl_login(Name,Uname,Password,Confirm_password)values('" + name.Text.ToString() + "','" + uname.Text.ToString() + "','" + pass.Text.ToString() + "','" + confpas.Text.ToString() + "') ", Class1.Cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Saved Successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                refr();
            }
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
