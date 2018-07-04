namespace Final_Project
{
    partial class Branch_Master
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
            this.bname = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.butsave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.butref = new System.Windows.Forms.Button();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.bid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(119, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branch Master";
            // 
            // bname
            // 
            this.bname.Location = new System.Drawing.Point(184, 83);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(212, 20);
            this.bname.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label.Location = new System.Drawing.Point(37, 83);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(123, 22);
            this.label.TabIndex = 7;
            this.label.Text = "Branch Name";
            // 
            // butsave
            // 
            this.butsave.BackColor = System.Drawing.SystemColors.Control;
            this.butsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butsave.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butsave.Location = new System.Drawing.Point(76, 9);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(93, 34);
            this.butsave.TabIndex = 26;
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
            this.button3.Location = new System.Drawing.Point(284, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 34);
            this.button3.TabIndex = 25;
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
            this.butref.Location = new System.Drawing.Point(177, 9);
            this.butref.Name = "butref";
            this.butref.Size = new System.Drawing.Size(96, 34);
            this.butref.TabIndex = 24;
            this.butref.Text = "Refresh";
            this.butref.UseVisualStyleBackColor = false;
            this.butref.Click += new System.EventHandler(this.butref_Click);
            // 
            // data1
            // 
            this.data1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.data1.Location = new System.Drawing.Point(8, 197);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(433, 150);
            this.data1.TabIndex = 27;
            this.data1.DoubleClick += new System.EventHandler(this.data1_DoubleClick);
            this.data1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data1_CellContentClick);
            // 
            // bid
            // 
            this.bid.Location = new System.Drawing.Point(349, 28);
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(38, 20);
            this.bid.TabIndex = 28;
            this.bid.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.bid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 54);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.butsave);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.butref);
            this.panel2.Location = new System.Drawing.Point(1, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 51);
            this.panel2.TabIndex = 30;
            // 
            // Branch_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(447, 353);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.bname);
            this.Controls.Add(this.label);
            this.Name = "Branch_Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branch Master";
            this.Load += new System.EventHandler(this.Branch_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bname;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button butref;
        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.TextBox bid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}