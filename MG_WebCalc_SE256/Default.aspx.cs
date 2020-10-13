using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MG_WebCalc_SE256
{
    public partial class _Default : Page
    {
        public Double dblNum1;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void NumButtons_Click(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            txtLCD.Text += temp.Text;
        }

        protected void btnEquals_Click(object sender, EventArgs e)
        {
            Double Num2 = Double.Parse(txtLCD.Text);
            Double Num1 = Double.Parse(Session["Num1"].ToString());
            String Operand = Session["Operand"].ToString();
            Double Result = 0;

            if (Operand == "+")
            {
                Result = Num1 + Num2;
            }

            if (Operand == "-")
            {
                Result = Num1 - Num2;
            }

            if (Operand == "*")
            {
                Result = Num1 * Num2;
            }

            if (Operand == "/")
            {
                Result = Num1 / Num2;
            }

            txtLCD.Text = Result.ToString();
        }
        protected void btnPlus_Click(object sender, EventArgs e)
        {
            Session["Num1"] = txtLCD.Text;
            dblNum1 = Int32.Parse(txtLCD.Text);
            Session["Operand"] = "+";
            txtLCD.Text += "+";
        }

        protected void btnMinus_Click(object sender, EventArgs e)
        {
            Session["Num1"] = txtLCD.Text;
            dblNum1 = Int32.Parse(txtLCD.Text);
            Session["Operand"] = "-";
            txtLCD.Text += "-";
        }
        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            Session["Num1"] = txtLCD.Text;
            dblNum1 = Int32.Parse(txtLCD.Text);
            Session["Operand"] = "*";
            txtLCD.Text += "*";
        }
        protected void btnDivide_Click(object sender, EventArgs e)
        {
            Session["Num1"] = txtLCD.Text;
            dblNum1 = Double.Parse(txtLCD.Text);
            Session["Operand"] = "/";
            txtLCD.Text += "/";
        }
    }
}