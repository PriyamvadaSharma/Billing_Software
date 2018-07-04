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
    public partial class Customer_Master : Form
    {
        public Customer_Master()
        {
            InitializeComponent();
            Class1.CreateConnection();
        }
        private void pname_TextChanged(object sender, EventArgs e)
        {
        }

        private void Customer_Master_Load(object sender, EventArgs e)
        {
            setgrid();
        }
        void setgrid()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("Select * from customer order by  Client_id", Class1.Cnn);
            Da.Fill(Dt);
            data1.DataSource = Dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butref_Click(object sender, EventArgs e)
        {
            if (butref.Text == "Refresh")
                Refr();
            else if (butref.Text == "Delete")
            {
                Class1.CreateConnection();
                if (butref.Text.Trim() == "")
                {
                    MessageBox.Show("Select a record First To Delete", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (butref.Text.Trim() != "" && data1.RowCount > 0)
                {
                    SqlCommand CmdIns1 = new SqlCommand("SELECT * FROM product WHERE Product_id=" + data1[0, data1.CurrentRow.Index].Value.ToString() + "", Class1.Cnn);
                    SqlDataReader Dr1 = CmdIns1.ExecuteReader();
                    Dr1.Read();
                    if (Dr1.HasRows)
                    {
                        if (MessageBox.Show("Do you want to delete (" + data1[0, data1.CurrentRow.Index].Value.ToString() + ") Record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;

                        DeleteRecord();
                        setgrid();
                        Refr();
                        cname.Focus();
                        butref.Text = "Refresh";
                        butsave.Text = "Save";
                    }
                }
            }
        }
        void DeleteRecord()
        {
            SqlCommand CmdDel = new SqlCommand("DELETE  FROM customer WHERE Client_id= " + long.Parse(cid.Text.ToString()) + " ", Class1.Cnn);
            CmdDel.ExecuteNonQuery();
            CmdDel.Dispose();
            MessageBox.Show("Deleted Successfully", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        void Refr()
        {
            com_name.Text = "";
            cname.Text = "";
            cadd.Text = "";
            cremark.Text = "";
            cmob.Text = "";
            cemail.Text = "";
        }
        bool IsValidforAdd()
        {
            bool retval = false;
            if (cname.Text.ToString() == "")
                MessageBox.Show("Enter the Customer Name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cname.Text.Length > 30)
                MessageBox.Show("Enter a valid Customer Name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (com_name.Text.ToString() =="")
                MessageBox.Show("Enter company name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cadd.Text.Length > 30)
                MessageBox.Show("Enter a valid Address", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
           else if (cmob.Text.Length != 10)
                MessageBox.Show("Enter a valid Mobile No.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cemail.Text.Length > 50)
                MessageBox.Show("Enter a valid ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else retval = true;
            return retval;
        }
        private void butsave_Click(object sender, EventArgs e)
        {
            Class1.CreateConnection();
            if (butsave.Text == "Save")
            {
                if (IsValidforAdd())
                {

                    SqlCommand cmd = new SqlCommand("insert into customer(Client_name,Client_company,Client_add,Client_mob,Client_mail,Client_remark) values('" + cname.Text.ToString() + "','" + com_name.Text.ToString() + "','" + cadd.Text.ToString() + "','" + cmob.Text.ToString() + "','" + cemail.Text.ToString() + "','" + cremark.Text.ToString() + "')", Class1.Cnn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    setgrid();
                    MessageBox.Show("Saved Successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setgrid();
                    Refr();
                    setgrid();
                }
            }
            else if (butsave.Text == "Update")
            {
                if (cname.Text.Trim() == "")
                    MessageBox.Show("Select a record first to Delete", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (cname.Text.Trim() != "" && data1.RowCount > 0)
                {
                    SqlCommand cmd = new SqlCommand("SElect * from customer where Client_id='" + cid.Text.ToString() + "' ", Class1.Cnn);
                    SqlDataReader Dr = cmd.ExecuteReader();
                    if (Dr.HasRows == true)
                        if (MessageBox.Show("Do you want to Update (" + data1[0, data1.CurrentRow.Index].Value.ToString() + ") User", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;


                    UpdateRecord();
                    setgrid();
                    Refr();
                    cname.Focus();
                    butsave.Text = "Save";
                    butref.Text = "Refresh";

                }
                else
                    MessageBox.Show("Value for this Id is not yet entered", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void UpdateRecord()
        {
            SqlCommand CmdDel = new SqlCommand("update customer set Client_name = '" + cname.Text.ToString() + "',Client_company = '" + com_name.Text.ToString() + "',Client_add = '" + cadd.Text.ToString() + "',Client_mob = '" + cmob.Text.ToString() + "',Client_mail= '" + cemail.Text.ToString() + "',Client_remark = '" + cremark.Text.ToString() + "' where Client_id='" + cid.Text.ToString() + "' ", Class1.Cnn);
            CmdDel.ExecuteNonQuery();
            CmdDel.Dispose();
            MessageBox.Show("Updated Successfully", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void data1_DoubleClick(object sender, EventArgs e)
        {
            cid.Text = data1["Client_id", data1.CurrentRow.Index].Value.ToString();
            butsave.Text = "Update";
            butref.Text = "Delete";
            Showw();
        }
        void Showw()
        {
            DataTable Ds1 = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("Select * from customer where Client_id='" + cid.Text.ToString() + "'", Class1.Cnn);
            Da.Fill(Ds1);
            if (Ds1.Rows.Count>0)
            {
                cname.Text = Ds1.Rows[0]["Client_name"].ToString();
                cadd.Text = Ds1.Rows[0]["Client_add"].ToString();
                cmob.Text = Ds1.Rows[0]["Client_mob"].ToString();
                cemail.Text = Ds1.Rows[0]["Client_mail"].ToString();
                cremark.Text = Ds1.Rows[0]["Client_remark"].ToString();
                com_name.Text = Ds1.Rows[0]["Client_company"].ToString();
            }
        }

        private void cremark_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
