namespace Final_Project
{
    partial class Product_Master
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
            this.pid = new System.Windows.Forms.TextBox();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.butsave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.butref = new System.Windows.Forms.Button();
            this.pname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pid
            // 
            this.pid.Location = new System.Drawing.Point(346, 25);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(38, 20);
            this.pid.TabIndex = 36;
            this.pid.Visible = false;
            // 
            // data1
            // 
            this.data1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.data1.Location = new System.Drawing.Point(12, 181);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(392, 121);
            this.data1.TabIndex = 35;
            this.data1.DoubleClick += new System.EventHandler(this.data1_DoubleClick_1);
            // 
            // butsave
            // 
            this.butsave.BackColor = System.Drawing.SystemColors.Control;
            this.butsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butsave.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butsave.Location = new System.Drawing.Point(71, 8);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(90, 34);
            this.butsave.TabIndex = 34;
            this.butsave.Text = "Save";
            this.butsave.UseVisualStyleBackColor = false;
            this.butsave.Click += new System.EventHandler(this.butsave_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(267, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 34);
            this.button3.TabIndex = 33;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // butref
            // 
            this.butref.BackColor = System.Drawing.SystemColors.Control;
            this.butref.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butref.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butref.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butref.Location = new System.Drawing.Point(167, 8);
            this.butref.Name = "butref";
            this.butref.Size = new System.Drawing.Size(94, 34);
            this.butref.TabIndex = 32;
            this.butref.Text = "Refresh";
            this.butref.UseVisualStyleBackColor = false;
            this.butref.Click += new System.EventHandler(this.butref_Click_1);
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(201, 83);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(180, 20);
            this.pname.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(107, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 34);
            this.label1.TabIndex = 29;
            this.label1.Text = "Product Master";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label.Location = new System.Drawing.Point(40, 83);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(128, 22);
            this.label.TabIndex = 37;
            this.label.Text = "Product Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.butsave);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.butref);
            this.panel1.Location = new System.Drawing.Point(-3, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 51);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.pid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 57);
            this.panel2.TabIndex = 39;
            // 
            // Product_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(416, 307);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.pname);
            this.Name = "Product_Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Master";
            this.Load += new System.EventHandler(this.Product_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button butref;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}