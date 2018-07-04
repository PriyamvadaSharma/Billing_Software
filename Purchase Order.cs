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
    public partial class Purchase_Order : Form
    {
        public Purchase_Order()
        {
            InitializeComponent();
        }

        private void Purchase_Order_Load(object sender, EventArgs e)
        {
            Class1.CreateConnection();
            setgrid();
            setcustomer();
            setemployee();
            setproduct();
            cbox.Checked =false;
            //panel1.Show();
            if (cbox.Checked == false)
                panel1.Hide();
            else if (cbox.Checked == true)
                panel1.Show();
            setcusID.Text = combcust.SelectedValue.ToString();
            setproID.Text = combpro.SelectedValue.ToString();
            setcomid();


        }
        void setcomid()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select Client_company,Client_id from customer where Client_id='" + combcust.SelectedValue.ToString() + "'", Class1.Cnn);
            Da.Fill(Dt);
            if (Dt.Rows.Count > 0)
            {
                com_name.Text = Dt.Rows[0]["Client_company"].ToString();
            }
        }

        void setgrid()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select purno as [Purchase No],* from purchase order by purno desc", Class1.Cnn);
            Da.Fill(Dt);
            data1.DataSource = Dt;
        }
        void setcustomer()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select Client_id,Client_name from customer order by Client_id", Class1.Cnn);
            Da.Fill(Dt);
            DataRow anyRow = Dt.NewRow();
            anyRow[0] = "0";
            anyRow[1] = "<--Select-->";
            Dt.Rows.InsertAt(anyRow, 0);

            combcust.DisplayMember = "Client_name";
            combcust.ValueMember = "Client_id";
            combcust.DataSource = Dt;
        }
        void setemployee()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select Employee_id,Employee_name from employee order by Employee_id", Class1.Cnn);
            Da.Fill(Dt);
            DataRow anyRow = Dt.NewRow();
            anyRow[0] = "0";
            anyRow[1] = "<--Select-->";
            Dt.Rows.InsertAt(anyRow, 0);

            combemp.DataSource = Dt;
            combemp.DisplayMember = "Employee_name";
            combemp.ValueMember = "Employee_id";
        }
        void setproduct()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select Product_id,Product_Name from product order by Product_id", Class1.Cnn);
            Da.Fill(Dt);
            DataRow anyRow = Dt.NewRow();
            anyRow[0] = "0";
            anyRow[1] = "<--Select-->";
            Dt.Rows.InsertAt(anyRow, 0);

            combpro.DataSource = Dt;
            combpro.DisplayMember = "Product_Name";
            combpro.ValueMember = "Product_id";
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Refresh")
            {
                Refr();
                butsave.Text = "Save";
                butref.Text = "Refresh";
                button3.Text = "Close";
            }
            else
            {
                this.Close();
            }
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
                    SqlCommand CmdIns1 = new SqlCommand("SELECT * FROM purchase WHERE Purchase_id=" + data1[0, data1.CurrentRow.Index].Value.ToString() + "", Class1.Cnn);
                    SqlDataReader Dr1 = CmdIns1.ExecuteReader();
                    Dr1.Read();
                    if (Dr1.HasRows)
                    {
                        if (MessageBox.Show("Do you want to delete (" + data1[0, data1.CurrentRow.Index].Value.ToString() + ") Record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;

                        DeleteRecord();
                        setgrid();
                        Refr();
                        date.Focus();
                        butref.Text = "Refresh";
                        butsave.Text = "Save";
                    }
                }
            }
        }
        void DeleteRecord()
        {
            SqlCommand CmdDel = new SqlCommand("DELETE  FROM purchase WHERE Purchase_id= " + long.Parse(purid.Text.ToString()) + " ", Class1.Cnn);
            CmdDel.ExecuteNonQuery();
            CmdDel.Dispose();
            MessageBox.Show("Deleted Successfully", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        void Refr()
        {
            com_name.Text = "";
            ptype.Text = "";
            combpro.Text = "";
            combcust.Text = "";
            date.Text = System.DateTime.Now.ToString();
            total.Text = "";
            advance.Text = "";
            combemp.Text = "";
            advdate.Text = System.DateTime.Now.ToString();
            com.Text = "";
            setcusID.Text = "";
            setproID.Text = "";
            addr.Text = ""; 
            ddate.Text = System.DateTime.Now.ToString();
            remarks.Text = "";
         }
        private void data1_DoubleClick(object sender, EventArgs e)
        {
            purid.Text = data1["Purchase_id", data1.CurrentRow.Index].Value.ToString();
            butsave.Text = "Update";
            butref.Text = "Delete";
            Showw();

        }
        void Showw()
        {
            DataTable Ds1 = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("Select * from purchase where Purchase_id='" + purid.Text.ToString() + "'", Class1.Cnn);
            Da.Fill(Ds1);
            if (Ds1.Rows.Count>0)
            {
                butsave.Enabled = true;
                butref.Enabled = true;
                string STR = @"select * from cash_book where Pur_ID ='" + purid.Text.ToString() + "' ";
                SqlDataAdapter DD = new SqlDataAdapter(STR, Class1.Cnn);
                DataTable dtt = new DataTable();
                DD.Fill(dtt);
                if (dtt.Rows.Count > 0)
                {
                    butsave.Enabled = false;
                    butref.Enabled = false;
                }
                STR = @"select * from dbo.billing where Purchase_ID ='" + purid.Text.ToString() + "' ";
                SqlDataAdapter DD1 = new SqlDataAdapter(STR, Class1.Cnn);
                DataTable dtt1 = new DataTable();
                DD1.Fill(dtt1);
                if (dtt1.Rows.Count > 0)
                {
                    butsave.Enabled = false;
                    butref.Enabled = false;
                }
                com_name.Text = Ds1.Rows[0]["Company_name"].ToString();
                date.Text = Ds1.Rows[0]["Purchase_date"].ToString();
                ptype.Text = Ds1.Rows[0]["Product_type"].ToString();
                combcust.Text = Ds1.Rows[0]["Customer"].ToString();
                combpro.Text = Ds1.Rows[0]["Product"].ToString();
                total.Text = Ds1.Rows[0]["TotalCost"].ToString();
                advance.Text = Ds1.Rows[0]["AdvanceCost"].ToString();
                combemp.Text = Ds1.Rows[0]["Employee"].ToString();
                advdate.Text = Ds1.Rows[0]["Advance_date"].ToString();
                setcusID.Text = Ds1.Rows[0]["Customer_ID"].ToString();
                setproID.Text = Ds1.Rows[0]["Product_ID"].ToString();
                ddate.Text = Ds1.Rows[0]["Delivery_Date"].ToString();
                remarks.Text = Ds1.Rows[0]["Remarks"].ToString();
                addr.Text = Ds1.Rows[0]["Address"].ToString();
                string c = "";
                c = Ds1.Rows[0]["Commission"].ToString();
                com.Text = Ds1.Rows[0]["Commission"].ToString();
               // if (cbox.Equals("Commission Applicable"))
                if(c!="0")
                {
                    cbox.Checked = true; panel1.Show();
                    cbox_CheckedChanged(null, null);
                }
                else
                {
                    cbox.Checked = false; panel1.Hide();
                    cbox_CheckedChanged(null, null);
                }

            }
        }

        private void cbox_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox.Checked == true)
            {
                panel1.Show();
                com.Focus();
            }
            else if (cbox.Checked == false)
                panel1.Hide();
           
        }
        bool IsValidforAdd()
        {
            bool retval = false;
            if (date.Text.ToString() == "")
                MessageBox.Show("Enter the Date", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (combcust.Text.ToString() == "")
                MessageBox.Show("Enter customer", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
           else if (ptype.Text.ToString()=="")
                MessageBox.Show("Enter a Product type.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (combpro.Text.ToString() == "")
                MessageBox.Show("Enter a Product", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (ddate.Text.ToString() == "")
                MessageBox.Show("Enter Delivery Date", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (total.Text.ToString() == "")
                MessageBox.Show("Enter total cost", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (advance.Text.ToString() == "")
                MessageBox.Show("Enter advance cost", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cbox.Checked == true && com.Text.ToString()=="")
                MessageBox.Show("Enter commission %", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (date.Value > ddate.Value)
                MessageBox.Show("Enter Proper Delivery Date", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (date.Value > advdate.Value)
                MessageBox.Show("Enter Proper Advance Date", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (advdate.Value >= ddate.Value)
                MessageBox.Show("Enter Proper Advance Date", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       
            else retval = true;
            return retval;
        }

        private string  getPurNo(string FLd, string Tbl,string Pre)
        {
             long No = 0;
                string PurNo="";
            try
            {
               
                string str = @"select MAX(right(" + FLd + ",4))+1  as MID from " + Tbl + "";
                SqlDataAdapter dd = new SqlDataAdapter(str, Class1.Cnn);
                DataTable dt = new DataTable();
                dd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    No = Convert.ToInt32(dt.Rows[0]["MID"].ToString());
                }
            }
            catch (Exception ex)
            {
            }
            return PurNo = Pre + No.ToString("0000");
        }
        private void butsave_Click(object sender, EventArgs e)
        {
            Class1.CreateConnection();
            string c="";
            if(butsave.Text.Trim()=="Save")
            {
                if (IsValidforAdd())
                {
                    if (cbox.Checked == true)
                        c = cbox.Text.ToString();

                    string Code = getPurNo("purno", "purchase", "PUR");
                    if (Convert.ToDecimal(advance.Text) < Convert.ToDecimal(total.Text))
                    {
                        SqlCommand cmd = new SqlCommand("insert into purchase(purno,Purchase_date,Product_type,Address,Customer,Customer_ID,Company_name,Product,Product_ID,Delivery_Date,TotalCost,AdvanceCost,Employee,Advance_date,Commission,Remarks) values('" + Code + "','" + date.Value.ToString() + "','" + ptype.Text.ToString() + "','" + addr.Text.ToString() + "','" + combcust.Text.ToString() + "','" + combcust.SelectedValue + "','" + com_name.Text.ToString() + "','" + combpro.Text.ToString() + "','" + combpro.SelectedValue + "','" + ddate.Value.ToString() + "','" + total.Text.ToString() + "','" + advance.Text.ToString() + "','" + combemp.Text.ToString() + "','" + advdate.Text.ToString() + "','" + com.Text.ToString() + "','" + remarks.Text.ToString() + "')", Class1.Cnn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        setgrid();
                        MessageBox.Show("Saved Successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setgrid();
                        Refr();
                        setgrid();
                    }
                    else
                        MessageBox.Show("Advance Amount can't be greater than Total Amount...Enter Valid Amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else if (butsave.Text == "Update")
            {
                if (date.Text.Trim() == "")
                    MessageBox.Show("Select a record first to Delete", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (date.Text.Trim() != "" && data1.RowCount > 0)
                {
                    SqlCommand cmd = new SqlCommand("SElect * from purchase where Purchase_id='" + purid.Text.ToString() + "' ", Class1.Cnn);
                    SqlDataReader Dr = cmd.ExecuteReader();
                    if (Dr.HasRows == true)
                        if (Convert.ToDecimal(advance.Text) < Convert.ToDecimal(total.Text))
                        {
                            if (MessageBox.Show("Do you want to Update (" + data1[0, data1.CurrentRow.Index].Value.ToString() + ") User", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                return;


                            UpdateRecord();
                            setgrid();
                            Refr();
                            date.Focus();
                            butsave.Text = "Save";
                            butref.Text = "Refresh";
                        }
                        else
                            MessageBox.Show("Advance Amount can't be greater than Total Amount...Enter Valid Amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Value for this Id is not yet entered", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void UpdateRecord()
        {
            string c= "";
            if (cbox.Checked == true) c = cbox.Text;
            if (com.Text.Trim() == "") com.Text = "0";

            SqlCommand CmdDel = new SqlCommand("update purchase set Company_name='"+com_name.Text.ToString()+"',Purchase_date = '" + date.Value.ToString() + "',Product_type= '" + ptype.Text.ToString() + "',Address='" + addr.Text.ToString() + "',Customer= '" + combcust.Text.ToString() + "',Customer_ID='" + combcust.SelectedValue + "',Product= '" + combpro.Text.ToString() + "',Product_ID= '" + combpro.SelectedValue + "',Delivery_Date= '" + ddate.Value.ToString() + "',TotalCost= '" + total.Text.ToString() + "',AdvanceCost= '" + advance.Text.ToString() + "',Employee= '" + combemp.Text.ToString() + "',Advance_Date= '" + advdate.Text.ToString() + "',Commission= '" + com.Text.ToString() + "',Remarks= '" + remarks.Text.ToString() + "' where Purchase_id='" + purid.Text.ToString() + "' ", Class1.Cnn);
              CmdDel.ExecuteNonQuery();
              CmdDel.Dispose();
              MessageBox.Show("Updated Successfully", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
              setgrid();
        }

        private void data1_DoubleClick_1(object sender, EventArgs e)
        {
            purid.Text = data1["Purchase_id", data1.CurrentRow.Index].Value.ToString();
            butsave.Text = "Update";
            butref.Text = "Delete";
            button3.Text = "Refresh";
            Showw();
        
        }
        void setadd()
        {
            SqlCommand cmd = new SqlCommand("insert into temp_ad(cus_id,addr)select Client_id,Client_add from customer where Client_id='" + combcust.SelectedValue.ToString() + "' ", Class1.Cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        void setadd2()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("Select top 1 * from temp_ad order by sn desc", Class1.Cnn);
            Da.Fill(Dt);
            if (Dt.Rows.Count > 0)
            {
                addr.Text = Dt.Rows[0]["addr"].ToString();
            }
        }

        private void combcust_SelectedIndexChanged(object sender, EventArgs e)
        {
            setcusID.Text = combcust.SelectedValue.ToString();
            setadd();
            setadd2();
            setcomid();
        }

        private void combpro_SelectedIndexChanged(object sender, EventArgs e)
        {
            setproID.Text = combpro.SelectedValue.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
