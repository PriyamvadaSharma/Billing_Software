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
    public partial class LedgerReportForm : Form
    {
        public LedgerReportForm()
        {
            InitializeComponent();
            Class1.CreateConnection();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            setcustomer();
            setproduct();

        }
        void setcustomer()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select Client_id,Client_name from customer order by Client_id", Class1.Cnn);
            Da.Fill(Dt);
            DataRow anyRow = Dt.NewRow();
            anyRow[0] = "0";
            anyRow[1] = "<-Select-->";
            Dt.Rows.InsertAt(anyRow, 0);
            combcust4.DataSource = Dt;
            combcust4.DisplayMember = "Client_name";
            combcust4.ValueMember = "Client_id";
            
        }
        void setproduct()
        {
            DataTable Dt = new DataTable();
            string WHERECOND = " 1 = 1";
            if (combcust4.SelectedIndex > 0)
            {
                WHERECOND = " 1 = 1 and Customer_ID = " + combcust4.SelectedValue + "";
            }
            SqlDataAdapter Da = new SqlDataAdapter("select Product_ID,Product from purchase  where " + WHERECOND + " ", Class1.Cnn);
            Da.Fill(Dt);
            DataRow anyRow = Dt.NewRow();
            anyRow[0] = "0";
            anyRow[1] = "<--All-->";
            Dt.Rows.InsertAt(anyRow, 0);
            combpro4.DataSource = Dt;
            combpro4.DisplayMember = "Product";
            combpro4.ValueMember = "Product_ID";
            
        }

        private void combcust4_SelectedIndexChanged(object sender, EventArgs e)
        {
            setproduct();
        }
        void temp()
        {
            Class1.CreateConnection();

            SqlCommand cmd = new SqlCommand("Insert into report (custid,cust,proid,pro) values('" + combcust4.SelectedValue + "','" + combcust4.Text.ToString() + "','" + combpro4.SelectedValue + "','" + combpro4.Text.ToString() + "') ", Class1.Cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        private void butshow_Click(object sender, EventArgs e)
        {
            temp();
            string str = " 1 = 1";
            if (combpro4.SelectedIndex == 0)
            {
                 str = "where cusID='" + combcust4.SelectedValue + "' ";

            }
            else
            {
                str = " where cusID='" + combcust4.SelectedValue + "'and proID='" + combpro4.SelectedValue + "' ";
            }
           
            
            // get fist comm report form
            ReportForm frm = new ReportForm();
            ledgerReportCR rpt = new ledgerReportCR();
                
            //  get data from sql
            //str ="select Customer,Product,cusID,proID,CONVERT(VARCHAR, Submit_date,103) AS Submit_date,Amount,Total,balance_left from  cash_book";
            DataTable dt = new DataTable();
            SqlDataAdapter Da2 = new SqlDataAdapter("select cash_book.Customer,cash_book.Product,cusID,proID,CONVERT(VARCHAR, Submit_date,103) AS Submit_date,Amount,Total,AdvanceCost from  cash_book inner join purchase on purchase.Purchase_id=cash_book.Pur_ID " + str, Class1.Cnn);
            Da2.Fill(dt);

            // set data for report object
            rpt.SetDataSource(dt);

            // set report for showing object (crystal report viwer)
            frm.crystalReportViewer1.ReportSource = rpt;

            // show report form
            frm.ShowDialog();

        }
    }
}
