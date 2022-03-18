namespace radwa_assignment_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Alllbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bigtxt = new System.Windows.Forms.TextBox();
            this.openbtn = new System.Windows.Forms.Button();
            this.insbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.readonelinebtn = new System.Windows.Forms.Button();
            this.readalllinesbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Alllbl
            // 
            this.Alllbl.AutoSize = true;
            this.Alllbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Alllbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(222)))));
            this.Alllbl.Location = new System.Drawing.Point(147, 9);
            this.Alllbl.Name = "Alllbl";
            this.Alllbl.Size = new System.Drawing.Size(692, 37);
            this.Alllbl.TabIndex = 0;
            this.Alllbl.Text = "ID                  FirstName                 LastName                 Age";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(306, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(545, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 23);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(781, 49);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(42, 23);
            this.textBox4.TabIndex = 1;
            // 
            // bigtxt
            // 
            this.bigtxt.Location = new System.Drawing.Point(623, 93);
            this.bigtxt.Multiline = true;
            this.bigtxt.Name = "bigtxt";
            this.bigtxt.Size = new System.Drawing.Size(349, 430);
            this.bigtxt.TabIndex = 2;
            // 
            // openbtn
            // 
            this.openbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.openbtn.Location = new System.Drawing.Point(92, 225);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(92, 67);
            this.openbtn.TabIndex = 3;
            this.openbtn.Text = "OpenFile";
            this.openbtn.UseVisualStyleBackColor = true;
            this.openbtn.Click += new System.EventHandler(this.openbtn_Click);
            // 
            // insbtn
            // 
            this.insbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.insbtn.Location = new System.Drawing.Point(251, 225);
            this.insbtn.Name = "insbtn";
            this.insbtn.Size = new System.Drawing.Size(92, 67);
            this.insbtn.TabIndex = 3;
            this.insbtn.Text = "Insert";
            this.insbtn.UseVisualStyleBackColor = true;
            this.insbtn.Click += new System.EventHandler(this.insbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.closebtn.Location = new System.Drawing.Point(414, 341);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(92, 67);
            this.closebtn.TabIndex = 3;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // readonelinebtn
            // 
            this.readonelinebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.readonelinebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.readonelinebtn.Location = new System.Drawing.Point(92, 341);
            this.readonelinebtn.Name = "readonelinebtn";
            this.readonelinebtn.Size = new System.Drawing.Size(92, 67);
            this.readonelinebtn.TabIndex = 3;
            this.readonelinebtn.Text = "ReadOneLine";
            this.readonelinebtn.UseVisualStyleBackColor = true;
            this.readonelinebtn.Click += new System.EventHandler(this.readonelinebtn_Click);
            // 
            // readalllinesbtn
            // 
            this.readalllinesbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.readalllinesbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.readalllinesbtn.Location = new System.Drawing.Point(251, 341);
            this.readalllinesbtn.Name = "readalllinesbtn";
            this.readalllinesbtn.Size = new System.Drawing.Size(92, 67);
            this.readalllinesbtn.TabIndex = 3;
            this.readalllinesbtn.Text = "ReadAll  Lines";
            this.readalllinesbtn.UseVisualStyleBackColor = true;
            this.readalllinesbtn.Click += new System.EventHandler(this.readalllinesbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.resetbtn.Location = new System.Drawing.Point(414, 225);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(92, 67);
            this.resetbtn.TabIndex = 3;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1003, 543);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.readalllinesbtn);
            this.Controls.Add(this.readonelinebtn);
            this.Controls.Add(this.insbtn);
            this.Controls.Add(this.openbtn);
            this.Controls.Add(this.bigtxt);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Alllbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Alllbl;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox bigtxt;
        private Button openbtn;
        private Button insbtn;
        private Button closebtn;
        private Button readonelinebtn;
        private Button readalllinesbtn;
        private Button resetbtn;
    }
}