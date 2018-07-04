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
    public partial class Employee_Master : Form
    {
        public Employee_Master()
        {
            InitializeComponent();
        }

        private void Employee_Master_Load(object sender, EventArgs e)
        {
            Class1.CreateConnection();
            offroll.Checked = true;
            onroll.Checked = true;
            setgrid();

        }
        void setgrid()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from employee order by Employee_id", Class1.Cnn);
            Da.Fill(Dt);
            data1.DataSource = Dt;
        }
        private void offroll_CheckedChanged(object sender, EventArgs e)
        {
            if (offroll.Checked == true)
            {
                panel2.Show();
                panel1.Hide();
            }
            
        }

        private void onroll_CheckedChanged(object sender, EventArgs e)
        {
            if (onroll.Checked == true)
            {
                panel1.Show();
                panel2.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool IsValidforAdd()
        {
            bool retval = false;
            if (ename.Text.ToString() == "")
                MessageBox.Show("Enter the Employee Name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (ename.Text.Length > 30)
                MessageBox.Show("Enter a valid Employee Name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (eadd.Text.Length > 30)
                MessageBox.Show("Enter a valid Address", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
           else if (emob.Text.Length > 10)
                MessageBox.Show("Enter a valid Mobile No.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (eemail.Text.Length > 50)
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
                    string E_RollType = "";
                    if (onroll.Checked == true) E_RollType = onroll.Text;
                    if (offroll.Checked == true) E_RollType = offroll.Text;
                    if (sal.Text.Trim() == "") sal.Text = "0";
                    if (comm.Text.Trim() == "") comm.Text = "0";
                   // if(onroll.Checked==true)

                    SqlCommand cmd = new SqlCommand("insert into employee(Employee_name,Employee_add,Employee_mob,Employee_mail,Employee_joinDate,Employee_sal,Employee_comm,Employee_RollType) values('" + ename.Text.ToString() + "','" + eadd.Text.ToString() + "','" + emob.Text.ToString() + "','" + eemail.Text.ToString() + "','" + date.Value.ToString() + "','" + sal.Text.ToString() + "','" + comm.Text.ToString() + "','" + E_RollType + "')", Class1.Cnn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    
                    //else if(offroll.Checked==true)
                    //{
                    //    SqlCommand cmd2 = new SqlCommand("insert into employee(E_name,E_add,E_mob,E_mail,E_joinDate,E_sal,E_comm) values('" + ename.Text.ToString() + "','" + eadd.Text.ToString() + "','" + emob.Text.ToString() + "','" + eemail.Text.ToString() + "','" + date.Value.ToString() + "','0','" +comm.Text.ToString()+ "')", Class1.Cnn);
                    //    cmd2.ExecuteNonQuery();
                    //    cmd2.Dispose();
                    //}   
                    setgrid();
                    MessageBox.Show("Saved Successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setgrid();
                    Refr();
                    setgrid();
                }
            }
            else if (butsave.Text == "Update")
            {
                if (ename.Text.Trim() == "")
                    MessageBox.Show("Select a record first to Delete", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (ename.Text.Trim() != "" && data1.RowCount > 0)
                {
                    SqlCommand cmd = new SqlCommand("SElect * from employee where Employee_id='" + eid.Text.ToString() + "' ", Class1.Cnn);
                    SqlDataReader Dr = cmd.ExecuteReader();
                    if (Dr.HasRows == true)
                        if (MessageBox.Show("Do you want to Update (" + data1[0, data1.CurrentRow.Index].Value.ToString() + ") User", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;


                    UpdateRecord();
                    setgrid();
                    Refr();
                    ename.Focus();
                    butsave.Text = "Save";
                    butref.Text = "Refresh";

                }
                else
                    MessageBox.Show("Value for this Id is not yet entered", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void Refr()
        {
            ename.Text = "";
            eadd.Text = "";
            eemail.Text = "";
            emob.Text = "";
            date.Text = "";
            sal.Text="";
            comm.Text="";
        }
        void UpdateRecord()
        {
            string E_RollType = "";
            if (onroll.Checked == true) E_RollType = onroll.Text;
            if (offroll.Checked == true) E_RollType = offroll.Text;
            if (sal.Text.Trim() == "") sal.Text = "0";
            if (comm.Text.Trim() == "") comm.Text = "0";

            SqlCommand CmdDel = new SqlCommand("update employee set Employee_name = '" + ename.Text.ToString() + "',Employee_add = '" + eadd.Text.ToString() + "',Employee_mob = '" + emob.Text.ToString() + "',Employee_mail= '" + eemail.Text.ToString() + "',Employee_joinDate = '" + date.Value.ToString() + "',Employee_sal= '" + sal.Text.ToString() + "',Employee_comm= '" + comm.Text.ToString() + "',Employee_RollType= '" + E_RollType + "' where Employee_id='" + eid.Text.ToString() + "' ", Class1.Cnn);
                CmdDel.ExecuteNonQuery();
                CmdDel.Dispose();
            
            //else if(offroll.Checked==true)
            //{
            //    SqlCommand CmdDel = new SqlCommand("update employee set E_name = '" + ename.Text.ToString() + "',E_add = '" + eadd.Text.ToString() + "',E_mob = '" + emob.Text.ToString() + "',E_mail= '" + eemail.Text.ToString() + "',E_joinDate = '" + date.Value.ToString()+ "',E_sal= '0',E_comm= '"+comm.Text.ToString()+"' where Eid='" + eid.Text.ToString() + "' ", Class1.Cnn);
            //    CmdDel.ExecuteNonQuery();
            //    CmdDel.Dispose();
            //}
                      
            MessageBox.Show("Updated Successfully", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    SqlCommand CmdIns1 = new SqlCommand("SELECT * FROM employee WHERE Employee_id=" + data1[0, data1.CurrentRow.Index].Value.ToString() + "", Class1.Cnn);
                    SqlDataReader Dr1 = CmdIns1.ExecuteReader();
                    Dr1.Read();
                    if (Dr1.HasRows)
                    {
                        if (MessageBox.Show("Do you want to delete (" + data1[0, data1.CurrentRow.Index].Value.ToString() + ") Record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;

                        DeleteRecord();
                        setgrid();
                        Refr();
                        ename.Focus();
                        butref.Text = "Refresh";
                        butsave.Text = "Save";
                    }
                 }
             }
        }
        void DeleteRecord()
        {
            SqlCommand CmdDel = new SqlCommand("DELETE  FROM employee WHERE Employee_id= " + long.Parse(eid.Text.ToString()) + " ", Class1.Cnn);
            CmdDel.ExecuteNonQuery();
            CmdDel.Dispose();
            MessageBox.Show("Deleted Successfully", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void data1_DoubleClick(object sender, EventArgs e)
        {
            eid.Text = data1["Employee_id", data1.CurrentRow.Index].Value.ToString();
            butsave.Text = "Update";
            butref.Text = "Delete";
            Showw();
        }
        void Showw()
        {
            DataTable Ds1 = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("Select * from employee where Employee_id='" + eid.Text.ToString() + "'", Class1.Cnn);
            Da.Fill(Ds1);
            if (Ds1.Rows.Count > 0)
            {
                ename.Text = Ds1.Rows[0]["Employee_name"].ToString();
                eadd.Text = Ds1.Rows[0]["Employee_add"].ToString();
                emob.Text = Ds1.Rows[0]["Employee_mob"].ToString();
                eemail.Text = Ds1.Rows[0]["Employee_mail"].ToString();
                date.Text = Ds1.Rows[0]["Employee_joinDate"].ToString();
                sal.Text = Ds1.Rows[0]["Employee_sal"].ToString();
                comm.Text = Ds1.Rows[0]["Employee_comm"].ToString();
                string E_RollType = "";
                E_RollType = Ds1.Rows[0]["Employee_RollType"].ToString();
                if (E_RollType.Equals("Off Roll"))
                {
                    offroll.Checked = true;
                    offroll_CheckedChanged(null, null);
                }
                if (E_RollType.Equals("On Roll"))
                {
                    onroll.Checked = true;
                    onroll_CheckedChanged(null, null);
                }
           }
        }

        private void data1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
