namespace Final_Project
{
    partial class Purchase_Order
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
            this.label = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combcust = new System.Windows.Forms.ComboBox();
            this.ptype = new System.Windows.Forms.ComboBox();
            this.combpro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.advance = new System.Windows.Forms.TextBox();
            this.combemp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.advdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.com = new System.Windows.Forms.TextBox();
            this.purid = new System.Windows.Forms.TextBox();
            this.butsave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.butref = new System.Windows.Forms.Button();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.setproID = new System.Windows.Forms.TextBox();
            this.setcusID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ddate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.remarks = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.com_name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(318, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 34);
            this.label1.TabIndex = 32;
            this.label1.Text = "Purchase Order";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label.Location = new System.Drawing.Point(17, 73);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 22);
            this.label.TabIndex = 48;
            this.label.Text = "Date";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(99, 75);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(121, 20);
            this.date.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(510, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 58;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(249, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 59;
            this.label3.Text = "Product Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 60;
            this.label4.Text = "Product";
            // 
            // combcust
            // 
            this.combcust.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combcust.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combcust.FormattingEnabled = true;
            this.combcust.Location = new System.Drawing.Point(654, 72);
            this.combcust.Name = "combcust";
            this.combcust.Size = new System.Drawing.Size(159, 21);
            this.combcust.TabIndex = 61;
            this.combcust.SelectedIndexChanged += new System.EventHandler(this.combcust_SelectedIndexChanged);
            // 
            // ptype
            // 
            this.ptype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ptype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ptype.FormattingEnabled = true;
            this.ptype.Items.AddRange(new object[] {
            "Offline",
            "Online",
            "App",
            "Other"});
            this.ptype.Location = new System.Drawing.Point(376, 75);
            this.ptype.Name = "ptype";
            this.ptype.Size = new System.Drawing.Size(122, 21);
            this.ptype.TabIndex = 62;
            // 
            // combpro
            // 
            this.combpro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combpro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combpro.FormattingEnabled = true;
            this.combpro.Location = new System.Drawing.Point(99, 173);
            this.combpro.Name = "combpro";
            this.combpro.Size = new System.Drawing.Size(214, 21);
            this.combpro.TabIndex = 63;
            this.combpro.SelectedIndexChanged += new System.EventHandler(this.combpro_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 64;
            this.label5.Text = "Total ";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(99, 215);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(214, 20);
            this.total.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(613, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 66;
            this.label6.Text = "Advance ";
            // 
            // advance
            // 
            this.advance.Location = new System.Drawing.Point(701, 215);
            this.advance.Name = "advance";
            this.advance.Size = new System.Drawing.Size(101, 20);
            this.advance.TabIndex = 67;
            // 
            // combemp
            // 
            this.combemp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combemp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combemp.FormattingEnabled = true;
            this.combemp.Location = new System.Drawing.Point(99, 256);
            this.combemp.Name = "combemp";
            this.combemp.Size = new System.Drawing.Size(214, 21);
            this.combemp.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(12, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 68;
            this.label7.Text = "Employee";
            // 
            // advdate
            // 
            this.advdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.advdate.Location = new System.Drawing.Point(472, 216);
            this.advdate.Name = "advdate";
            this.advdate.Size = new System.Drawing.Size(135, 20);
            this.advdate.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(343, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 22);
            this.label8.TabIndex = 70;
            this.label8.Text = "Advance Date";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cbox
            // 
            this.cbox.AutoSize = true;
            this.cbox.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox.Location = new System.Drawing.Point(347, 252);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(227, 26);
            this.cbox.TabIndex = 72;
            this.cbox.Text = "Commission Applicable";
            this.cbox.UseVisualStyleBackColor = true;
            this.cbox.CheckedChanged += new System.EventHandler(this.cbox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.com);
            this.panel1.Location = new System.Drawing.Point(636, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 36);
            this.panel1.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(24, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 22);
            this.label9.TabIndex = 89;
            this.label9.Text = "%";
            // 
            // com
            // 
            this.com.Location = new System.Drawing.Point(68, 6);
            this.com.Name = "com";
            this.com.Size = new System.Drawing.Size(94, 20);
            this.com.TabIndex = 68;
            // 
            // purid
            // 
            this.purid.Location = new System.Drawing.Point(736, 28);
            this.purid.Name = "purid";
            this.purid.Size = new System.Drawing.Size(46, 20);
            this.purid.TabIndex = 74;
            this.purid.Visible = false;
            // 
            // butsave
            // 
            this.butsave.BackColor = System.Drawing.SystemColors.Control;
            this.butsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butsave.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butsave.Location = new System.Drawing.Point(251, 10);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(105, 34);
            this.butsave.TabIndex = 75;
            this.butsave.Text = "Save";
            this.butsave.UseVisualStyleBackColor = false;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(499, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 34);
            this.button3.TabIndex = 77;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // butref
            // 
            this.butref.BackColor = System.Drawing.SystemColors.Control;
            this.butref.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butref.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butref.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butref.Location = new System.Drawing.Point(375, 10);
            this.butref.Name = "butref";
            this.butref.Size = new System.Drawing.Size(105, 34);
            this.butref.TabIndex = 78;
            this.butref.Text = "Refresh";
            this.butref.UseVisualStyleBackColor = false;
            this.butref.Click += new System.EventHandler(this.butref_Click);
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            this.data1.AllowUserToDeleteRows = false;
            this.data1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.data1.Location = new System.Drawing.Point(8, 396);
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            this.data1.Size = new System.Drawing.Size(805, 173);
            this.data1.TabIndex = 76;
            this.data1.DoubleClick += new System.EventHandler(this.data1_DoubleClick_1);
            // 
            // setproID
            // 
            this.setproID.Enabled = false;
            this.setproID.Location = new System.Drawing.Point(11, 29);
            this.setproID.Name = "setproID";
            this.setproID.Size = new System.Drawing.Size(29, 20);
            this.setproID.TabIndex = 82;
            this.setproID.Visible = false;
            // 
            // setcusID
            // 
            this.setcusID.Enabled = false;
            this.setcusID.Location = new System.Drawing.Point(561, 46);
            this.setcusID.Name = "setcusID";
            this.setcusID.Size = new System.Drawing.Size(29, 20);
            this.setcusID.TabIndex = 81;
            this.setcusID.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.purid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.setproID);
            this.panel2.Location = new System.Drawing.Point(1, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 60);
            this.panel2.TabIndex = 83;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.butsave);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.butref);
            this.panel3.Location = new System.Drawing.Point(1, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(829, 51);
            this.panel3.TabIndex = 84;
            // 
            // addr
            // 
            this.addr.Enabled = false;
            this.addr.Location = new System.Drawing.Point(99, 115);
            this.addr.Multiline = true;
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(399, 39);
            this.addr.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label10.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(12, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 22);
            this.label10.TabIndex = 86;
            this.label10.Text = "Address";
            // 
            // ddate
            // 
            this.ddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ddate.Location = new System.Drawing.Point(470, 174);
            this.ddate.Name = "ddate";
            this.ddate.Size = new System.Drawing.Size(137, 20);
            this.ddate.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label11.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(343, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 22);
            this.label11.TabIndex = 87;
            this.label11.Text = "Delivery Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label12.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(12, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 22);
            this.label12.TabIndex = 89;
            this.label12.Text = "Remarks";
            // 
            // remarks
            // 
            this.remarks.Location = new System.Drawing.Point(99, 300);
            this.remarks.Name = "remarks";
            this.remarks.Size = new System.Drawing.Size(368, 20);
            this.remarks.TabIndex = 90;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label13.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(510, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 22);
            this.label13.TabIndex = 91;
            this.label13.Text = "Company name";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // com_name
            // 
            this.com_name.Enabled = false;
            this.com_name.Location = new System.Drawing.Point(654, 115);
            this.com_name.Name = "com_name";
            this.com_name.Size = new System.Drawing.Size(159, 20);
            this.com_name.TabIndex = 92;
            // 
            // Purchase_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(825, 581);
            this.Controls.Add(this.com_name);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.remarks);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ddate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.setcusID);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.advdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combemp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.advance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combpro);
            this.Controls.Add(this.ptype);
            this.Controls.Add(this.combcust);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label);
            this.Name = "Purchase_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.Purchase_Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combcust;
        private System.Windows.Forms.ComboBox ptype;
        private System.Windows.Forms.ComboBox combpro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox advance;
        private System.Windows.Forms.ComboBox combemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker advdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox com;
        private System.Windows.Forms.TextBox purid;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button butref;
        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.TextBox setproID;
        private System.Windows.Forms.TextBox setcusID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker ddate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox remarks;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox com_name;
    }
}