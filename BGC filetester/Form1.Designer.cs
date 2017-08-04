namespace BGC_filetester
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.lbTrans = new System.Windows.Forms.Label();
            this.lbSkrivdag = new System.Windows.Forms.Label();
            this.lbLayout = new System.Windows.Forms.Label();
            this.lbBetKund = new System.Windows.Forms.Label();
            this.lbBetBank = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(1, 43);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(748, 251);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Trankod";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bet. dag";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Period";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Självförnyade";
            this.columnHeader4.Width = 32;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Bet.nummer";
            this.columnHeader5.Width = 82;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Belopp";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Bankgironummer";
            this.columnHeader7.Width = 82;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ref";
            this.columnHeader8.Width = 67;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ladda fil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTrans
            // 
            this.lbTrans.AutoSize = true;
            this.lbTrans.Location = new System.Drawing.Point(12, 9);
            this.lbTrans.Name = "lbTrans";
            this.lbTrans.Size = new System.Drawing.Size(93, 13);
            this.lbTrans.TabIndex = 2;
            this.lbTrans.Text = "#Transkationskod";
            // 
            // lbSkrivdag
            // 
            this.lbSkrivdag.AutoSize = true;
            this.lbSkrivdag.Location = new System.Drawing.Point(146, 9);
            this.lbSkrivdag.Name = "lbSkrivdag";
            this.lbSkrivdag.Size = new System.Drawing.Size(56, 13);
            this.lbSkrivdag.TabIndex = 3;
            this.lbSkrivdag.Text = "#Skrivdag";
            // 
            // lbLayout
            // 
            this.lbLayout.AutoSize = true;
            this.lbLayout.Location = new System.Drawing.Point(245, 9);
            this.lbLayout.Name = "lbLayout";
            this.lbLayout.Size = new System.Drawing.Size(35, 13);
            this.lbLayout.TabIndex = 4;
            this.lbLayout.Text = "#TYP";
            // 
            // lbBetKund
            // 
            this.lbBetKund.AutoSize = true;
            this.lbBetKund.Location = new System.Drawing.Point(339, 9);
            this.lbBetKund.Name = "lbBetKund";
            this.lbBetKund.Size = new System.Drawing.Size(200, 13);
            this.lbBetKund.TabIndex = 5;
            this.lbBetKund.Text = "#BET. MOTTAGRENS KUNDNUMMER";
            // 
            // lbBetBank
            // 
            this.lbBetBank.AutoSize = true;
            this.lbBetBank.Location = new System.Drawing.Point(545, 9);
            this.lbBetBank.Name = "lbBetBank";
            this.lbBetBank.Size = new System.Drawing.Size(149, 13);
            this.lbBetBank.TabIndex = 6;
            this.lbBetBank.Text = "#BET. MOTTAGRENS BANK";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Generera Fil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(12, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Förnyas Täckning";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Coral;
            this.button4.Location = new System.Drawing.Point(12, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Täckning saknas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(121, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Fel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 332);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 363);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbBetBank);
            this.Controls.Add(this.lbBetKund);
            this.Controls.Add(this.lbLayout);
            this.Controls.Add(this.lbSkrivdag);
            this.Controls.Add(this.lbTrans);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BGC pwner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTrans;
        private System.Windows.Forms.Label lbSkrivdag;
        private System.Windows.Forms.Label lbLayout;
        private System.Windows.Forms.Label lbBetKund;
        private System.Windows.Forms.Label lbBetBank;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

