using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Final_Project
{
    public partial class Billing : Form
    {
        public Billing()
        {
            Class1.CreateConnection();
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            refno.Text = setrefno();
            
                setgrid();
                setpurid();
                //setrefno();
                
                cID.Text = combcust3.SelectedValue.ToString();
                //pID.Text = combpro3.SelectedValue.ToString();
                cbox2.Checked = false;
                panel2.Hide();
                netamt.Text = net.Text;
        }
        void setcomid()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select Client_company,Client_id from customer where Client_id='" + combcust3.SelectedValue.ToString() + "'", Class1.Cnn);
            Da.Fill(Dt);
            if (Dt.Rows.Count > 0)
            {
                com_name3.Text = Dt.Rows[0]["Client_company"].ToString();
            }
        }
        void cal()
        {
            if (discount.Text.Trim() == "") discount.Text = "0";
            if (st.Text.Trim() == "") st.Text = "0";
            if (txttotal.Text.Trim() == "") txttotal.Text = "0";
            if (left.Text.Trim() == "") left.Text = "0";

            decimal amtafterdisc = 0;

            net.Text = (Convert.ToDecimal(txttotal.Text) - Convert.ToDecimal(discount.Text)).ToString();
            if (cbox2.Checked == true)
            {
                decimal n = Convert.ToDecimal(st.Text);
                decimal n1 = Convert.ToDecimal(net.Text);
                decimal n2 = (n / 100) * (n1);
                stamt.Text = n2.ToString();
                decimal n3 = Convert.ToDecimal(left.Text);
                decimal a = n2 + n3;
                netamt.Text = a.ToString();
                decimal a1 = n2 + n1;
                billamt.Text = a1.ToString();
            }
            else
            {
                netamt.Text = left.Text;
                billamt.Text = net.Text;
            }
        }
        void setpurid()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select Purchase_id, (Customer+' - '+Purno) as Name  from purchase", Class1.Cnn);
            Da.Fill(Dt);
            DataRow anyRow = Dt.NewRow();
            anyRow[0] = "0";
            anyRow[1] = "<--Select-->";
            Dt.Rows.InsertAt(anyRow, 0);
            combid2.DisplayMember = "Name";
            combid2.ValueMember = "Purchase_id";
            combid2.DataSource = Dt;
           
        }
        void setcustomer()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select Client_id,Client_name from customer order by Client_id", Class1.Cnn);
            Da.Fill(Dt);

            DataRow anyRow = Dt.NewRow();
            anyRow[0] = "0";
            anyRow[1] = "<---->";
            Dt.Rows.InsertAt(anyRow, 0);
            combcust3.DisplayMember = "Client_name";
            combcust3.ValueMember = "Client_id";
            combcust3.DataSource = Dt;

         }
        void setproduct()
        {
           // setcustomer();
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from purchase where Customer_ID='"+combcust3.SelectedValue.ToString()+"' ", Class1.Cnn);
            Da.Fill(Dt);

            //DataRow anyRow = Dt.NewRow();
            //anyRow[0] = "0";
            //anyRow[1] = "<---->";
            //Dt.Rows.InsertAt(anyRow, 0);
            combpro3.DisplayMember = "Product";
            combpro3.ValueMember = "Product_ID";
            combpro3.DataSource = Dt;

         }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combcust3_SelectedIndexChanged(object sender, EventArgs e)
        {
            setproduct();
            cID.Text = combcust3.SelectedValue.ToString();
            setadd();
            setadd2();
            setcomid();
        }
        void setadd()
        {
            SqlCommand cmd = new SqlCommand("insert into temp_ad(cus_id,addr)select Client_id,Client_add from customer where Client_id='" + combcust3.SelectedValue.ToString() + "' ", Class1.Cnn);
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
                addres.Text = Dt.Rows[0]["addr"].ToString();
            }
        }
        void temp()
        {
            Class1.CreateConnection();

            SqlCommand cmd = new SqlCommand("Insert into [temp_cost](tot,adv)select TotalCost,AdvanceCost from purchase where Purchase_id ='" +combid2.SelectedValue+ "' ", Class1.Cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        //void del_rec()
        //{
        //    Class1.CreateConnection();
        //    SqlCommand CmdDel = new SqlCommand("DELETE  FROM temp_cost ", Class1.Cnn);
        //    CmdDel.ExecuteNonQuery();
        //    CmdDel.Dispose();

        //}
        void tempShow()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("Select top 1 * from temp_cost order by costid desc", Class1.Cnn);
            Da.Fill(Dt);
            if (Dt.Rows.Count > 0)
            {
                txttotal.Text = Dt.Rows[0]["tot"].ToString();
                txtadv.Text = Dt.Rows[0]["adv"].ToString();
            }
        }
        void setgrid()
        {
            DataTable Dt=new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("Select * from billing order by Refno", Class1.Cnn);
            Da.Fill(Dt);
            grid.DataSource = Dt;
        }
        decimal tempShow2()
        {
            decimal bl = 0, l = 0;
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select Submit_date,Amount from cash_book where Pur_ID='"+combid2.SelectedValue.ToString()+"'   ", Class1.Cnn);
            Da.Fill(Dt);
            data3.DataSource = Dt;
            if (stamt.Text == "") stamt.Text = "0";
            if (discount.Text == "") discount.Text = "0";

            if (txttotal.Text == "") txttotal.Text = "0";
            if (txtadv.Text == "") txtadv.Text = "0";

            if (ramt.Text == "") ramt.Text = "0";

            if (Dt.Rows.Count > 0)
            {
                for (int i = 0; i < Dt.Rows.Count; i++)
                    bl += Convert.ToDecimal(Dt.Rows[i]["Amount"]);
            }
            l = Convert.ToDecimal(txttotal.Text) - Convert.ToDecimal(txtadv.Text) - bl;
            left.Text = l.ToString();
            return l;
        }
       
        //private void butshow_Click_1(object sender, EventArgs e)
        //{
        //    temp();
        //    tempShow();
        //    tempShow2();
        //}
        bool IsValidforAdd()
        {
            bool retval = false;
            if (combcust3.Text.ToString() == "")
                MessageBox.Show("Please enter customer", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (combpro3.Text.ToString() == "")
                MessageBox.Show("Please enter Product", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txttotal.Text.ToString() == "")
                MessageBox.Show("Please enter Product", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtadv.Text.ToString() == "")
                MessageBox.Show("Please enter Product", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (left.Text.ToString() == "")
                MessageBox.Show("Please enter Product", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pdate.Value > bdate.Value)
                MessageBox.Show("Enter Proper billing Date", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            else retval = true;
            return retval;
        }
        private void butsave_Click(object sender, EventArgs e)
        {
        //    if (cbox2.Checked == false)
        //        netamt.Text = net.Text;
            if (combid2.SelectedIndex > 0)
            {
                if (IsValidforAdd())
                {
                    refno.Text = setrefno();
                    if (Convert.ToDecimal(discount.Text) < Convert.ToDecimal(left.Text)) 
                    {
                        if ((Convert.ToDecimal(ramt.Text) == Convert.ToDecimal(netamt.Text)) && ramt.Text !="0")
                        {
                            if (st.Text.Trim() == "") st.Text = "0";
                            if (stamt.Text.Trim() == "") stamt.Text = "0";
                            SqlCommand cmd = new SqlCommand("insert into billing (Refno,Purchase_ID,Customer,Company_name,Product,Total,After_Discount,NetAmt,Received_Amt,Bill_date,Service_Tax,Tax_Amount,BillAmt)values('" + refno.Text.ToString() + "','" + combid2.SelectedValue.ToString() + "','" + combcust3.Text.ToString() + "','" + com_name3.Text.ToString() + "','" + combpro3.Text.ToString() + "','" + txttotal.Text.ToString() + "','" + net.Text.ToString() + "','" + netamt.Text.ToString() + "','" + ramt.Text.ToString() + "','" + bdate.Value + "','" + st.Text.ToString() + "','" + stamt.Text.ToString() + "','" + billamt.Text.ToString() + "') ", Class1.Cnn);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            MessageBox.Show("Saved Successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            setgrid();
                            refr();

                            if (MessageBox.Show("Do you want to Print the Bill", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            {
                                refr();
                                return;
                            }
                            else
                            {
                                billingID.Text = "";
                                SqlDataAdapter da = new SqlDataAdapter("select top 1 * from billing  order by BillId desc", Class1.Cnn);
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                if(dt.Rows.Count>0)
                                    billingID.Text = dt.Rows[0]["BillId"].ToString();
                                butprint_Click(null, null);
                                refr();
                            }
                            setgrid();
                            //del_rec();
                        }
                        else
                            MessageBox.Show("Values cannot be saved till received amount is not equal to net amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Enter Valid Amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Enter Data to be Saved", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        void refr()
        {
            combcust3.Text = "";
            combpro3.Text = "";
            txttotal.Text = "0";
            txtadv.Text = "0";
            left.Text = "0";
            net.Text = "0";
            discount.Text = "0";
            netamt.Text = "0";
            ramt.Text = "0";
            st.Text = "0";
            remark.Text = "";
            bdate.Text=System.DateTime.Now.ToString();
            pdate.Text = System.DateTime.Now.ToString();
            //refno.Text = "0";
            addres.Text = "";
        }

        private void butref_Click(object sender, EventArgs e)
        {
            refr();
            //del_rec();
            //tempShow();
        }
        void setpdate()
        {
            SqlCommand cmd = new SqlCommand("insert into temp_date(pro_id,date1,remark)select Product_ID,Purchase_date,Remarks from purchase where Purchase_id='" + combid2.SelectedValue.ToString() + "'  ", Class1.Cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        void setpdate2()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("Select top 1 * from temp_date order by sn desc", Class1.Cnn);
            Da.Fill(Dt);
            if (Dt.Rows.Count > 0)
            {
                pdate.Text = Dt.Rows[0]["date1"].ToString();
                remark.Text = Dt.Rows[0]["remark"].ToString();

            }
        }
        
        private void combpro3_SelectedIndexChanged(object sender, EventArgs e)
        {
            pID.Text = combpro3.SelectedValue.ToString();
            setpdate();
            setpdate2();

            temp();
            tempShow();
            tempShow2();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void st_TextChanged(object sender, EventArgs e)
        {
            cal();
        }
        string setrefno()
        {
            long Id = 0;
            string t = System.DateTime.Now.ToString("dd");
            string t1 = System.DateTime.Now.ToString("MM");
            string t2 = t + "/" + t1;
            string  dd1 = bdate.Value.ToString("MM/dd/yyyy");

            string str = @"select MAX(RIGHT(refno,4)) as tt from billing where convert(varchar,Bill_date,101) >= '" + dd1 + "' and convert(varchar,Bill_date,101) <= '" + dd1 + "'";
            SqlDataAdapter dd = new SqlDataAdapter(str, Class1.Cnn);
            DataTable dt = new DataTable();
            dd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (!string.IsNullOrEmpty(dt.Rows[0]["tt"].ToString()))
                    Id = Convert.ToInt32(dt.Rows[0]["tt"]) + 1;

                else
                    Id = 1;
            }
            t2 = t2 + "-" + Id.ToString("0000");
            return t2;
        }

        private void discount_TextChanged(object sender, EventArgs e)
        {
            cal();
            //if (discount.Text == "")
            //    discount.Text = "0";
            //else
            //{
            //    decimal d = tempShow2();
            //    decimal d5 = Convert.ToDecimal(txttotal.Text);
            //    decimal d1 = Convert.ToDecimal(discount.Text);
            //    decimal d2 = d5 - d1;
            //    net.Text = d2.ToString();

            //    if (cbox2.Checked == false)
            //    {
            //        panel2.Hide();
            //        netamt.Text = net.Text;
            //    }
            //}
        }

        private void cbox_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox2.Checked == true)
            {
                st.Focus();
                panel2.Show();
            }
            else
            {
                panel2.Hide();
                netamt.Text = net.Text;
            }
        }

        private void butprint_Click(object sender, EventArgs e)
        {
            // get fist comm report form
            ReportForm frm = new ReportForm();
            
            // create report object
            Bill rpt = new Bill();

            //  get data from sql
            DataTable dt = new DataTable();
            SqlDataAdapter Da2 = new SqlDataAdapter("select Refno,After_Discount,billing.Company_name,Product_Type,Service_Tax,purchase.Product,BillAmt,Tax_Amount,CONVERT(VARCHAR, Bill_date,103) AS Bill_date,Client_name,Client_add,Client_mob from billing inner join purchase on billing.Purchase_ID = purchase.Purchase_id inner Join customer on customer.Client_id = purchase.Customer_ID where billing.BillId='" + billingID.Text.ToString() + "' ", Class1.Cnn);
            Da2.Fill(dt);

            // set data for report object
            rpt.SetDataSource(dt);

            // set report for showing object (crystal report viwer)
            frm.crystalReportViewer1.ReportSource = rpt;

            // show report form
            frm.ShowDialog();

        }

        private void ramt_TextChanged(object sender, EventArgs e)
        {
            //if (ramt.Text == netamt.Text)
            //    MessageBox.Show("You can Successfully Print the Bill now", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //else
            //{
            //    decimal m = Convert.ToDecimal(netamt.Text);
            //    decimal m2 = Convert.ToDecimal(ramt.Text);
            //    decimal m3 = m - m2;
            //    MessageBox.Show("You cannot Print the Bill now as you are left with '" + m3 + "' Rupees", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }

        private void data3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void combid2_SelectedIndexChanged(object sender, EventArgs e)
        {
            setcustomer();
            setproduct();

            butsave.Enabled = true;
            butref.Enabled = true;
            string STR = @"select * from billing where Purchase_ID ='" + combid2.SelectedValue + "' ";
            SqlDataAdapter DD = new SqlDataAdapter(STR, Class1.Cnn);
            DataTable dtt = new DataTable();
            DD.Fill(dtt);
            if (dtt.Rows.Count > 0)
            {
                butsave.Enabled = false;
                butref.Enabled = false;
                MessageBox.Show("This Client have already taken the bill", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (combid2.SelectedIndex > 0)
            {
                //decimal Advance = 0;
               // if (bleft.Text.Trim() == "") bleft.Text = "0";
                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter("select * from purchase where Purchase_id='" + combid2.SelectedValue.ToString() + "' ", Class1.Cnn);
                Da.Fill(Dt);
                if(Dt.Rows.Count>0)
                {
                    combcust3.Text = Dt.Rows[0]["Customer"].ToString();
                    combpro3.Text = Dt.Rows[0]["Product"].ToString();
                    
                }
            }
            else if (combid2.SelectedIndex <0)
            {
                refr();
                combpro3.Text = "";
                combcust3.Text = "";
            }
        
        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {
            refno.Text=grid["Refno",grid.CurrentRow.Index].Value.ToString();
            billingID.Text = grid["BillId", grid.CurrentRow.Index].Value.ToString();
            combid2.SelectedValue = grid["Purchase_ID", grid.CurrentRow.Index].Value.ToString();
            

            Showw();
        }
        void Showw()
        {
            DataTable Ds1 = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("Select * from billing where Refno='" + refno.Text.ToString() + "'", Class1.Cnn);
            Da.Fill(Ds1);
            if (Ds1.Rows.Count > 0)
            {
                temp();
                tempShow();
                
                //billingID.Text = Ds1.Rows[0]["BillId"].ToString();
                combcust3.Text = Ds1.Rows[0]["Customer"].ToString();
                combpro3.Text = Ds1.Rows[0]["Product"].ToString();
                
                net.Text = Ds1.Rows[0]["After_Discount"].ToString();
                txttotal.Text = Ds1.Rows[0]["Total"].ToString();
                ramt.Text = Ds1.Rows[0]["Received_Amt"].ToString();
                st.Text = Ds1.Rows[0]["Service_Tax"].ToString();
                stamt.Text = Ds1.Rows[0]["Tax_Amount"].ToString();
                netamt.Text = Ds1.Rows[0]["NetAmt"].ToString();
                DataTable Dt1 = new DataTable();
                SqlDataAdapter Da1 = new SqlDataAdapter("select Submit_date,Amount from cash_book where Pur_ID='" + combid2.SelectedValue.ToString() + "'   ", Class1.Cnn);
                Da1.Fill(Dt1);
                data3.DataSource = Dt1;
            }

        }

        private void refno_TextChanged(object sender, EventArgs e)
        {

        }

        private void netamt_TextChanged(object sender, EventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void left_TextChanged(object sender, EventArgs e)
        {

        }

        private void net_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
