namespace Tipster
{
    partial class Results
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.People = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BillAndTip = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BillAndTip);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.People);
            this.groupBox1.Controls.Add(this.Total);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Bill:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "People:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Each Pays:";
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Total.Location = new System.Drawing.Point(104, 33);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(100, 23);
            this.Total.TabIndex = 2;
            this.Total.Click += new System.EventHandler(this.TotalBill_Click);
            // 
            // People
            // 
            this.People.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.People.Location = new System.Drawing.Point(104, 60);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(100, 23);
            this.People.TabIndex = 3;
            this.People.Click += new System.EventHandler(this.People_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Result.Location = new System.Drawing.Point(134, 202);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 23);
            this.Result.TabIndex = 2;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(273, 247);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bill + Tip:";
            // 
            // BillAndTip
            // 
            this.BillAndTip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BillAndTip.Location = new System.Drawing.Point(104, 86);
            this.BillAndTip.Name = "BillAndTip";
            this.BillAndTip.Size = new System.Drawing.Size(100, 23);
            this.BillAndTip.TabIndex = 5;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 304);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Results";
            this.Text = "Results";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Close;
        public System.Windows.Forms.Label People;
        public System.Windows.Forms.Label Total;
        public System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label BillAndTip;
    }
}