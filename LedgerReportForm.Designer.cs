namespace Final_Project
{
    partial class LedgerReportForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.combpro4 = new System.Windows.Forms.ComboBox();
            this.combcust4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butshow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 52);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(124, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Report Form";
            // 
            // combpro4
            // 
            this.combpro4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combpro4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combpro4.FormattingEnabled = true;
            this.combpro4.Location = new System.Drawing.Point(179, 108);
            this.combpro4.Name = "combpro4";
            this.combpro4.Size = new System.Drawing.Size(174, 21);
            this.combpro4.TabIndex = 73;
            // 
            // combcust4
            // 
            this.combcust4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combcust4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combcust4.FormattingEnabled = true;
            this.combcust4.Location = new System.Drawing.Point(179, 68);
            this.combcust4.Name = "combcust4";
            this.combcust4.Size = new System.Drawing.Size(174, 21);
            this.combcust4.TabIndex = 72;
            this.combcust4.SelectedIndexChanged += new System.EventHandler(this.combcust4_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(80, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 71;
            this.label4.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(81, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 70;
            this.label2.Text = "Customer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.butshow);
            this.panel2.Location = new System.Drawing.Point(0, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 51);
            this.panel2.TabIndex = 74;
            // 
            // butshow
            // 
            this.butshow.BackColor = System.Drawing.SystemColors.Control;
            this.butshow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butshow.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butshow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butshow.Location = new System.Drawing.Point(162, 8);
            this.butshow.Name = "butshow";
            this.butshow.Size = new System.Drawing.Size(98, 34);
            this.butshow.TabIndex = 76;
            this.butshow.Text = "Show";
            this.butshow.UseVisualStyleBackColor = false;
            this.butshow.Click += new System.EventHandler(this.butshow_Click);
            // 
            // LedgerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(426, 201);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.combpro4);
            this.Controls.Add(this.combcust4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "LedgerReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combpro4;
        private System.Windows.Forms.ComboBox combcust4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butshow;

    }
}