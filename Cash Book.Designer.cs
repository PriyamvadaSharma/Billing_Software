namespace Final_Project
{
    partial class Cash_Book
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
            this.label1 = new System.Windows.Forms.Label();
            this.combpro2 = new System.Windows.Forms.ComboBox();
            this.combcust2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdate = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.cashid = new System.Windows.Forms.TextBox();
            this.data2 = new System.Windows.Forms.DataGridView();
            this.cuID = new System.Windows.Forms.TextBox();
            this.prID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addre = new System.Windows.Forms.TextBox();
            this.combid = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.bleft = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butref = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.com_name2 = new System.Windows.Forms.TextBox();
            this.addate = new System.Windows.Forms.DateTimePicker();
            this.deldate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.data2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(235, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cash Book";
            // 
            // combpro2
            // 
            this.combpro2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combpro2.Enabled = false;
            this.combpro2.FormattingEnabled = true;
            this.combpro2.Location = new System.Drawing.Point(159, 201);
            this.combpro2.Name = "combpro2";
            this.combpro2.Size = new System.Drawing.Size(174, 21);
            this.combpro2.TabIndex = 69;
            this.combpro2.SelectedIndexChanged += new System.EventHandler(this.combpro2_SelectedIndexChanged);
            // 
            // combcust2
            // 
            this.combcust2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combcust2.Enabled = false;
            this.combcust2.FormattingEnabled = true;
            this.combcust2.Location = new System.Drawing.Point(159, 126);
            this.combcust2.Name = "combcust2";
            this.combcust2.Size = new System.Drawing.Size(237, 21);
            this.combcust2.TabIndex = 68;
            this.combcust2.SelectedIndexChanged += new System.EventHandler(this.combcust2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(17, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 67;
            this.label4.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(18, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 66;
            this.label2.Text = "Customer";
            // 
            // rdate
            // 
            this.rdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdate.Location = new System.Drawing.Point(467, 280);
            this.rdate.Name = "rdate";
            this.rdate.Size = new System.Drawing.Size(111, 20);
            this.rdate.TabIndex = 65;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label.Location = new System.Drawing.Point(330, 280);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(131, 22);
            this.label.TabIndex = 64;
            this.label.Text = "Receiving Date";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(159, 282);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(121, 20);
            this.amount.TabIndex = 71;
            // 
            // cashid
            // 
            this.cashid.Location = new System.Drawing.Point(507, 25);
            this.cashid.Name = "cashid";
            this.cashid.Size = new System.Drawing.Size(39, 20);
            this.cashid.TabIndex = 72;
            this.cashid.Visible = false;
            // 
            // data2
            // 
            this.data2.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data2.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.data2.Location = new System.Drawing.Point(10, 376);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(585, 194);
            this.data2.TabIndex = 76;
            this.data2.DoubleClick += new System.EventHandler(this.data2_DoubleClick);
            this.data2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data2_CellContentClick);
            // 
            // cuID
            // 
            this.cuID.Location = new System.Drawing.Point(18, 25);
            this.cuID.Name = "cuID";
            this.cuID.Size = new System.Drawing.Size(39, 20);
            this.cuID.TabIndex = 77;
            this.cuID.Visible = false;
            // 
            // prID
            // 
            this.prID.Location = new System.Drawing.Point(552, 26);
            this.prID.Name = "prID";
            this.prID.Size = new System.Drawing.Size(39, 20);
            this.prID.TabIndex = 78;
            this.prID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.cashid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cuID);
            this.panel1.Controls.Add(this.prID);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 56);
            this.panel1.TabIndex = 79;
            // 
            // addre
            // 
            this.addre.Enabled = false;
            this.addre.Location = new System.Drawing.Point(415, 126);
            this.addre.Multiline = true;
            this.addre.Name = "addre";
            this.addre.Size = new System.Drawing.Size(182, 61);
            this.addre.TabIndex = 81;
            // 
            // combid
            // 
            this.combid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combid.FormattingEnabled = true;
            this.combid.Location = new System.Drawing.Point(159, 89);
            this.combid.Name = "combid";
            this.combid.Size = new System.Drawing.Size(237, 21);
            this.combid.TabIndex = 83;
            this.combid.SelectedIndexChanged += new System.EventHandler(this.combid_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(18, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 82;
            this.label5.Text = "Purchase Id";
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Location = new System.Drawing.Point(159, 243);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(121, 20);
            this.total.TabIndex = 90;
            // 
            // bleft
            // 
            this.bleft.Enabled = false;
            this.bleft.Location = new System.Drawing.Point(467, 239);
            this.bleft.Name = "bleft";
            this.bleft.Size = new System.Drawing.Size(111, 20);
            this.bleft.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(328, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 87;
            this.label7.Text = "Balance Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(20, -22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 70;
            this.label3.Text = "Amount";
            // 
            // butref
            // 
            this.butref.BackColor = System.Drawing.SystemColors.Control;
            this.butref.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butref.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butref.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butref.Location = new System.Drawing.Point(260, 8);
            this.butref.Name = "butref";
            this.butref.Size = new System.Drawing.Size(93, 34);
            this.butref.TabIndex = 73;
            this.butref.Text = "Refresh";
            this.butref.UseVisualStyleBackColor = false;
            this.butref.Click += new System.EventHandler(this.butref_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(368, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 74;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // butsave
            // 
            this.butsave.BackColor = System.Drawing.SystemColors.Control;
            this.butsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butsave.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butsave.Location = new System.Drawing.Point(150, 8);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(98, 34);
            this.butsave.TabIndex = 75;
            this.butsave.Text = "Save";
            this.butsave.UseVisualStyleBackColor = false;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.butsave);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.butref);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-2, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 50);
            this.panel2.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(17, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 91;
            this.label6.Text = "Total Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(17, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 92;
            this.label8.Text = "Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(18, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 22);
            this.label9.TabIndex = 94;
            this.label9.Text = "Company Name";
            // 
            // com_name2
            // 
            this.com_name2.Enabled = false;
            this.com_name2.Location = new System.Drawing.Point(159, 167);
            this.com_name2.Name = "com_name2";
            this.com_name2.Size = new System.Drawing.Size(237, 20);
            this.com_name2.TabIndex = 93;
            // 
            // addate
            // 
            this.addate.Location = new System.Drawing.Point(467, 201);
            this.addate.Name = "addate";
            this.addate.Size = new System.Drawing.Size(111, 20);
            this.addate.TabIndex = 95;
            this.addate.Visible = false;
            // 
            // deldate
            // 
            this.deldate.Location = new System.Drawing.Point(350, 202);
            this.deldate.Name = "deldate";
            this.deldate.Size = new System.Drawing.Size(111, 20);
            this.deldate.TabIndex = 96;
            this.deldate.Visible = false;
            // 
            // Cash_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(607, 582);
            this.Controls.Add(this.deldate);
            this.Controls.Add(this.addate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.com_name2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.total);
            this.Controls.Add(this.bleft);
            this.Controls.Add(this.label);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.rdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.combpro2);
            this.Controls.Add(this.combcust2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "Cash_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Book";
            this.Load += new System.EventHandler(this.Cash_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combpro2;
        private System.Windows.Forms.ComboBox combcust2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker rdate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox cashid;
        private System.Windows.Forms.DataGridView data2;
        private System.Windows.Forms.TextBox cuID;
        private System.Windows.Forms.TextBox prID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox addre;
        private System.Windows.Forms.ComboBox combid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox bleft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butref;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox com_name2;
        private System.Windows.Forms.DateTimePicker addate;
        private System.Windows.Forms.DateTimePicker deldate;
    }
}