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
    public partial class Cash_Book : Form
    {
        public Cash_Book()
        {
            Class1.CreateConnection();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void setgrid()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from cash_book order by Submit_date desc", Class1.Cnn);
            Da.Fill(Dt);
            data2.DataSource = Dt;

        }
        void setcustomer()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select Client_id,Client_name from customer order by Client_id desc", Class1.Cnn);
            Da.Fill(Dt);
            DataRow anyRow = Dt.NewRow();
            anyRow[0] = "0";
            anyRow[1] = "<---->";
            Dt.Rows.InsertAt(anyRow, 0);
            combcust2.DisplayMember = "Client_name";
            combcust2.ValueMember = "Client_id";
            combcust2.DataSource = Dt;
        }
        void setproduct()
        {
            //setcustomer();Customer_ID='" + combcust2.SelectedValue.ToString() + "'
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from purchase  where 1=1 ", Class1.Cnn);
            Da.Fill(Dt);
            //DataRow anyRow = Dt.NewRow();
            //anyRow[0] = "0";
            //anyRow[1] = "<---->";
            //Dt.Rows.InsertAt(anyRow, 0);
            combpro2.DisplayMember = "Product";
            combpro2.ValueMember = "Product_ID";
            combpro2.DataSource = Dt;  
        }
        bool IsValidforAdd()
        {
            bool retval = false;
            if (combcust2.Text.ToString() == "")
                MessageBox.Show("Please enter customer", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (combpro2.Text.ToString() == "")
                MessageBox.Show("Please enter Product", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (rdate.Text.ToString() == "")
                MessageBox.Show("Please enter date", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (amount.Text.ToString() == "")
                MessageBox.Show("Please enter Amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (rdate.Value > deldate.Value)
                MessageBox.Show("Enter Proper receiving Date", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (rdate.Value < addate.Value)
                MessageBox.Show("Enter Proper receiving Date", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            else retval = true;
            return retval;
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            
            if (butsave.Text.Trim() == "Save")
            {
                if (IsValidforAdd())
                {
                    if (Convert.ToDecimal(amount.Text) < Convert.ToDecimal(bleft.Text))
                    {
                        SqlCommand cmd = new SqlCommand("insert into cash_book (Customer,Company_name,cusID,Address,Product,proID,Total,balance_left,Submit_date,Amount,Pur_ID)values('" + combcust2.Text.ToString() + "','" + com_name2.Text.ToString() + "','" + combcust2.SelectedValue + "','" + addre.Text.ToString() + "','" + combpro2.Text.ToString() + "','" + combpro2.SelectedValue + "','" + total.Text.ToString() + "','" + bleft.Text.ToString() + "','" + rdate.Value.ToString() + "','" + amount.Text.ToString() + "','" + combid.SelectedValue.ToString() + "') ", Class1.Cnn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        MessageBox.Show("Saved successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        setgrid();
                        Refr();
                    }
                    else
                        MessageBox.Show("Can't enter amount greater than left Amount...Enter Valid Amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            else if (butsave.Text == "Update")
            {
                if (rdate.Text.Trim() == "")
                    MessageBox.Show("Select a record first to Update", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (rdate.Text.Trim() != "" && data2.RowCount > 0)
                {
                    SqlCommand cmd = new SqlCommand("SElect * from cash_book where cashID='" + cashid.Text.ToString() + "' ", Class1.Cnn);
                    SqlDataReader Dr = cmd.ExecuteReader();
                    if (Dr.HasRows == true)
                        if (Convert.ToDecimal(amount.Text) < Convert.ToDecimal(bleft.Text))
                        {
                            if (MessageBox.Show("Do you want to Update (" + data2[0, data2.CurrentRow.Index].Value.ToString() + ") User", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                return;



                            UpdateRecord();
                            setgrid();
                            Refr();
                            rdate.Focus();
                            butsave.Text = "Save";
                            butref.Text = "Refresh";
                        }
                        else
                            MessageBox.Show("Can't enter amount greater than left Amount...Enter Valid Amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Value for this Id is not yet entered", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void UpdateRecord()
        {
            SqlCommand CmdDel = new SqlCommand("update cash_book set Company_name='"+com_name2.Text.ToString()+"',Customer= '" + combcust2.Text.ToString() + "',cusID= '" + combcust2.SelectedValue + "',Address= '" + addre.Text.ToString() + "',Product= '" + combpro2.Text.ToString() + "',proID= '" + combpro2.SelectedValue + "',Total='" + total.Text.ToString() + "',balance_left='" + bleft.Text.ToString() + "',Submit_date= '" + rdate.Text.ToString() + "',Amount='" + amount.Text.ToString() + "' where cashID='" + cashid.Text.ToString() + "' ", Class1.Cnn);
            CmdDel.ExecuteNonQuery();
            CmdDel.Dispose();
            MessageBox.Show("Updated Successfully", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            setgrid();
        }
        void Refr()
        {
            combid.Text = "";
            combpro2.Text = "   ";
            combcust2.Text = "   ";
            rdate.Text = System.DateTime.Now.ToString();
            amount.Text = "";
            addre.Text = "";
            total.Text = "";
            bleft.Text = "";
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
                else if (butref.Text.Trim() != "" && data2.RowCount > 0)
                {
                    SqlCommand CmdIns1 = new SqlCommand("SELECT * FROM cash_book WHERE cashID =" + data2[0, data2.CurrentRow.Index].Value.ToString() + "", Class1.Cnn);
                    SqlDataReader Dr1 = CmdIns1.ExecuteReader();
                    Dr1.Read();
                    if (Dr1.HasRows)
                    {
                        if (MessageBox.Show("Do you want to delete (" + data2[0, data2.CurrentRow.Index].Value.ToString() + ") Record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;

                        DeleteRecord();
                        setgrid();
                        Refr();
                        rdate.Focus();
                        butref.Text = "Refresh";
                        butsave.Text = "Save";
                    }
                }
            }
        }
        void DeleteRecord()
        {
            SqlCommand CmdDel = new SqlCommand("DELETE  FROM cash_book WHERE cashID= " + long.Parse(cashid.Text.ToString()) + " ", Class1.Cnn);
            CmdDel.ExecuteNonQuery();
            CmdDel.Dispose();
            MessageBox.Show("Deleted Successfully", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void data2_DoubleClick(object sender, EventArgs e)
        {
            cashid.Text = data2["cashID", data2.CurrentRow.Index].Value.ToString();
            combid.SelectedValue = data2["Pur_ID", data2.CurrentRow.Index].Value.ToString();
            butsave.Text = "Update";
            butref.Text = "Delete";
            Showw();
        }
        void Showw()
        {
            DataTable Ds1 = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("Select * from cash_book where Pur_ID='" + combid.SelectedValue.ToString() +"'", Class1.Cnn);
            Da.Fill(Ds1);
            if (Ds1.Rows.Count>0)
            {
                butsave.Enabled = true;
                butref.Enabled = true;
                string STR = @"select * from billing where Purchase_ID ='" + combid.SelectedValue.ToString()  +"' ";
                SqlDataAdapter DD = new SqlDataAdapter(STR, Class1.Cnn);
                DataTable dtt = new DataTable();
                DD.Fill(dtt);
                if (dtt.Rows.Count > 0)
                {
                    butsave.Enabled = false;
                    butref.Enabled = false;
                }
                com_name2.Text = Ds1.Rows[0]["Company_name"].ToString();
                rdate.Text = Ds1.Rows[0]["Submit_date"].ToString();
                combcust2.Text = Ds1.Rows[0]["Customer"].ToString();
                combpro2.Text = Ds1.Rows[0]["Product"].ToString();
                cuID.Text = Ds1.Rows[0]["cusID"].ToString();
                prID.Text = Ds1.Rows[0]["proID"].ToString();
                amount.Text = Ds1.Rows[0]["Amount"].ToString();
                addre.Text = Ds1.Rows[0]["Address"].ToString();
                total.Text = Ds1.Rows[0]["Total"].ToString();
                bleft.Text = Ds1.Rows[0]["balance_left"].ToString();
                com_name2.Text = Ds1.Rows[0]["Company_name"].ToString();

            }
        }
        void setcomid()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select Client_company,Client_id from customer where Client_id='" + combcust2.SelectedValue.ToString() + "'", Class1.Cnn);
            Da.Fill(Dt);
            if (Dt.Rows.Count > 0)
            {
                com_name2.Text = Dt.Rows[0]["Client_company"].ToString();
            }
        }
        private void Cash_Book_Load(object sender, EventArgs e)
        {
            Class1.CreateConnection();
            setpurid();
            setgrid();
            setcustomer();
            setproduct();
            try
            {
                cuID.Text = combcust2.SelectedValue.ToString();
                prID.Text = combpro2.SelectedValue.ToString();
            }
            catch (Exception ex) { }
        }
        void setpurid()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select Purchase_id, (Purno+' - '+Customer) as Name  from purchase order by Purchase_id desc", Class1.Cnn);
            Da.Fill(Dt);

            DataRow anyRow = Dt.NewRow();
            anyRow[0] = "0";
            anyRow[1] = "<--Select-->";
            Dt.Rows.InsertAt(anyRow, 0);

            combid.DisplayMember = "Name";
            combid.ValueMember = "Purchase_id";
            combid.DataSource = Dt;
        }
        private void combcust2_SelectedIndexChanged(object sender, EventArgs e)
        {
            setproduct();
            cuID.Text = combcust2.SelectedValue.ToString();
            setadd();
            setadd2();
            setcomid();
        }
        void setadd()
        {
            SqlCommand cmd = new SqlCommand("insert into temp_ad(cus_id,addr)select Client_id,Client_add from customer where Client_id='" + combcust2.SelectedValue.ToString() + "' ", Class1.Cnn);
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
                addre.Text = Dt.Rows[0]["addr"].ToString();
            }
        }
        private void combpro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            prID.Text = combpro2.SelectedValue.ToString();

        }

        private void combid_SelectedIndexChanged(object sender, EventArgs e)
        {
                butsave.Enabled = true;
                butref.Enabled = true;
                string STR = @"select * from billing where Purchase_ID ='" + combid.SelectedValue.ToString() + "' ";
                SqlDataAdapter DD = new SqlDataAdapter(STR, Class1.Cnn);
                DataTable dtt = new DataTable();
                DD.Fill(dtt);
                if (dtt.Rows.Count > 0)
                {
                    butsave.Enabled = false;
                    butref.Enabled = false;
                    MessageBox.Show("This Client have already taken the bill", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    
                }
            
            if (combid.SelectedIndex > 0)
            {
                decimal Advance = 0;
                if (bleft.Text.Trim() == "") bleft.Text = "0";
                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter("select * from purchase where Purchase_id='" + combid.SelectedValue.ToString() + "' ", Class1.Cnn);
                Da.Fill(Dt);
                if(Dt.Rows.Count>0)
                {
                    deldate.Text = Dt.Rows[0]["Delivery_Date"].ToString();
                    addate.Text = Dt.Rows[0]["Advance_date"].ToString();
                    combcust2.Text = Dt.Rows[0]["Customer"].ToString();
                    combpro2.Text = Dt.Rows[0]["Product"].ToString();
                    total.Text = Dt.Rows[0]["TotalCost"].ToString();
                    Advance = Convert.ToDecimal(Dt.Rows[0]["AdvanceCost"].ToString());
                    bleft.Text = (Convert.ToDecimal(total.Text) - Advance).ToString();
                }
                decimal bl = 0, l = 0;
                DataTable Dt1 = new DataTable();
                SqlDataAdapter Da1 = new SqlDataAdapter("select top 1 * from cash_book where Pur_ID='" + combid.SelectedValue.ToString() + "' order by cashID desc ", Class1.Cnn);
                Da1.Fill(Dt1);
                if (Dt1.Rows.Count > 0)
                {
                    for (int i = 0; i < Dt1.Rows.Count; i++)
                        bl += Convert.ToDecimal(Dt1.Rows[i]["Amount"]);
                
                    l = Convert.ToDecimal(bleft.Text) - bl;
                    bleft.Text = l.ToString();
                }
                else if (Dt1.Rows.Count == 0)
                {
                    //l = Convert.ToDecimal(total.Text) - Convert.ToDecimal(Dt.Rows[0]["AdvanceCost"]);
                    //bleft.Text = l.ToString();
                }

            }
            else if (combid.SelectedIndex <= 0)
            {
                Refr();
                addre.Text = "     ";

            }
        }

        private void data2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
