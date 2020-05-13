using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipster
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// 4.1 - 4.5
        /// This form uses multi forms to display calculations of how much 
        /// each member will need to pay, including the tip
        /// Author: Shan Ahmed 21813031
        /// </summary>
        /// 

        double x, y, answer, tipchoice, totalBill;

        public Form1()
        {
            InitializeComponent();
        }

        private void none_CheckedChanged(object sender, EventArgs e)
        {
            tipchoice = 0;
        }

        private void normal_CheckedChanged(object sender, EventArgs e)
        {
            double z;
            z = Convert.ToDouble(Bill.Text);
            tipchoice = z * 0.1;
        }

        private void generous_CheckedChanged(object sender, EventArgs e)
        {
            double z;
            z = Convert.ToDouble(Bill.Text);
            tipchoice = z * 0.15;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mad_CheckedChanged(object sender, EventArgs e)
        {
            double z;
            z = Convert.ToDouble(Bill.Text);
            tipchoice = z * 0.2;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// the below calculates how many each need to and also provides an error 
        /// message if the wrong input is put in. 
        /// Also launches the results form
        /// </summary>

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(AmountofPeople.Text);
                y = Convert.ToDouble(Bill.Text);

                answer = y / x;

                Results newForm = new Results();
                newForm.Show();

                totalBill = (y + tipchoice)/x;
                newForm.Total.Text = Bill.Text;
                newForm.People.Text = AmountofPeople.Text;
                newForm.BillAndTip.Text = totalBill.ToString();

                newForm.Result.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("Error in Data Entry");
            }
           


        }

        private void Bill_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
