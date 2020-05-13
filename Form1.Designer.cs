namespace Tipster
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
            this.Bill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountofPeople = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.none = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.generous = new System.Windows.Forms.RadioButton();
            this.mad = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bill
            // 
            this.Bill.Location = new System.Drawing.Point(99, 82);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(215, 22);
            this.Bill.TabIndex = 0;
            this.Bill.TextChanged += new System.EventHandler(this.Bill_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill";
            // 
            // AmountofPeople
            // 
            this.AmountofPeople.FormattingEnabled = true;
            this.AmountofPeople.ItemHeight = 16;
            this.AmountofPeople.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.AmountofPeople.Location = new System.Drawing.Point(258, 277);
            this.AmountofPeople.Name = "AmountofPeople";
            this.AmountofPeople.Size = new System.Drawing.Size(56, 84);
            this.AmountofPeople.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of People";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(476, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(476, 337);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(92, 41);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(626, 337);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 41);
            this.Quit.TabIndex = 6;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mad);
            this.groupBox1.Controls.Add(this.generous);
            this.groupBox1.Controls.Add(this.normal);
            this.groupBox1.Controls.Add(this.none);
            this.groupBox1.Location = new System.Drawing.Point(16, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipping";
            // 
            // none
            // 
            this.none.AutoSize = true;
            this.none.Location = new System.Drawing.Point(22, 36);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(61, 21);
            this.none.TabIndex = 0;
            this.none.TabStop = true;
            this.none.Text = "none";
            this.none.UseVisualStyleBackColor = true;
            this.none.CheckedChanged += new System.EventHandler(this.none_CheckedChanged);
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Location = new System.Drawing.Point(149, 36);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(72, 21);
            this.normal.TabIndex = 1;
            this.normal.TabStop = true;
            this.normal.Text = "normal";
            this.normal.UseVisualStyleBackColor = true;
            this.normal.CheckedChanged += new System.EventHandler(this.normal_CheckedChanged);
            // 
            // generous
            // 
            this.generous.AutoSize = true;
            this.generous.Location = new System.Drawing.Point(22, 64);
            this.generous.Name = "generous";
            this.generous.Size = new System.Drawing.Size(89, 21);
            this.generous.TabIndex = 2;
            this.generous.TabStop = true;
            this.generous.Text = "generous";
            this.generous.UseVisualStyleBackColor = true;
            this.generous.CheckedChanged += new System.EventHandler(this.generous_CheckedChanged);
            // 
            // mad
            // 
            this.mad.AutoSize = true;
            this.mad.Location = new System.Drawing.Point(149, 64);
            this.mad.Name = "mad";
            this.mad.Size = new System.Drawing.Size(56, 21);
            this.mad.TabIndex = 3;
            this.mad.TabStop = true;
            this.mad.Text = "mad";
            this.mad.UseVisualStyleBackColor = true;
            this.mad.CheckedChanged += new System.EventHandler(this.mad_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AmountofPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bill);
            this.Name = "Form1";
            this.Text = "Tipster Entry Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Bill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.ListBox AmountofPeople;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton mad;
        private System.Windows.Forms.RadioButton generous;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.RadioButton none;
    }
}

