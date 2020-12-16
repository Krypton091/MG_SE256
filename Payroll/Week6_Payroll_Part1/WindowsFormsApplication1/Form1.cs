using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddPayCheck_Click(object sender, EventArgs e)
        {
            //create a string to gather the data
            string myPayRollRecord;

            //start storing payroll data
            myPayRollRecord = DateTime.Now.ToShortDateString() + "," + txtFName.Text + "," + txtMName.Text + "," + txtLName.Text + "," + txtRate.Text + "," + txtHours.Text;

            //calculate the gross pay
            double myPay = double.Parse(txtRate.Text) * double.Parse(txtHours.Text);

            //Add this last piece of data to our record
            myPayRollRecord += ("," + myPay.ToString());

            lblFeedback.Text = myPayRollRecord;

            FileIO.writeFile(@"c:\Test\Payroll.csv", myPayRollRecord);
        }
    }
}
