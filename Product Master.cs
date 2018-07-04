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
    public partial class Product_Master : Form
    {
        public Product_Master()
        {
            InitializeComponent();
        }

        private void Product_Master_Load(object sender, EventArgs e)
        {
            setgrid();
        }
        void setgrid()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("Select * from product order by  Product_id", Class1.Cnn);
            Da.Fill(Dt);
            data1.DataSource = Dt;
        }

        private void butref_Click(object sender, EventArgs e)
        {
        }
        void Refr()
        {
            pname.Text = "";
        }
        void DeleteRecord()
        {
            SqlCommand CmdDel = new SqlCommand("DELETE  FROM product WHERE Product_id= " + long.Parse(pid.Text.ToString()) + " ", Class1.Cnn);
            CmdDel.ExecuteNonQuery();
            CmdDel.Dispose();
            MessageBox.Show("Deleted Successfully", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        bool IsValidforAdd()
        {
            bool retval = false;
            if (pname.Text.ToString() == "")
                MessageBox.Show("Enter the Product Name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pname.Text.Length > 30)
                MessageBox.Show("Enter a valid Product Name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else retval = true;
            return retval;
        }
        private void butsave_Click(object sender, EventArgs e)
        {
            
        }
        void UpdateRecord()
        {
            SqlCommand CmdDel = new SqlCommand("update product set Product_Name = '" + pname.Text.ToString() + "' where Product_id='" + pid.Text.ToString() + "' ", Class1.Cnn);
            CmdDel.ExecuteNonQuery();
            CmdDel.Dispose();
            MessageBox.Show("Updated Successfully", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void data1_DoubleClick(object sender, EventArgs e)
        {
            
        }
        void Showw()
        {
            DataTable Ds1 = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("Select * from product where Product_id='" + pid.Text.ToString() + "'", Class1.Cnn);
            Da.Fill(Ds1);
            if (Ds1.Rows.Count > 0)
            {
                pname.Text = Ds1.Rows[0]["Product_Name"].ToString();
            }
        }

        private void butsave_Click_1(object sender, EventArgs e)
        {
            Class1.CreateConnection();
            if (butsave.Text == "Save")
            {
                if (IsValidforAdd())
                {

                    SqlCommand cmd = new SqlCommand("insert into product(Product_Name) values('" + pname.Text.ToString() + "')", Class1.Cnn);
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
                if (pname.Text.Trim() == "")
                    MessageBox.Show("Select a record first to Delete", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (pname.Text.Trim() != "" && data1.RowCount > 0)
                {
                    SqlCommand cmd = new SqlCommand("SElect * from product where Product_id='" + pid.Text.ToString() + "' ", Class1.Cnn);
                    SqlDataReader Dr = cmd.ExecuteReader();
                    if (Dr.HasRows == true)
                        if (MessageBox.Show("Do you want to Update (" + data1[0, data1.CurrentRow.Index].Value.ToString() + ") User", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;


                    UpdateRecord();
                    setgrid();
                    Refr();
                    pname.Focus();
                    butsave.Text = "Save";
                    butref.Text = "Refresh";

                }
                else
                    MessageBox.Show("Value for this Id is not yet entered", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void butref_Click_1(object sender, EventArgs e)
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
                        pname.Focus();
                        butref.Text = "Refresh";
                        butsave.Text = "Save";
                    }
                }
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void data1_DoubleClick_1(object sender, EventArgs e)
        {
            pid.Text = data1["Product_id", data1.CurrentRow.Index].Value.ToString();
            butsave.Text = "Update";
            butref.Text = "Delete";
            Showw();
        }
    }
}
