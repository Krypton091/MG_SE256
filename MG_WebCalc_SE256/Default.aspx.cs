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
        public Boolean numInMemory;
        public string operandVar;

        protected void checkMem(string operation)
        {
            if (numInMemory == true)
            {
                memIndicator.InnerText = "M";
                operandIndicator.InnerText = operation;

            }
            else
            {
                memIndicator.InnerText = "";
                operandIndicator.InnerText = "";
            }
        }

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

            numInMemory = false;
        }
        protected void btnPlus_Click(object sender, EventArgs e)
        {
            Session["Num1"] = txtLCD.Text;
            dblNum1 = Int32.Parse(txtLCD.Text);
            Session["Operand"] = "+";
            operandVar = Session["Operand"].ToString();
            txtLCD.Text = "";
            numInMemory = true;
            checkMem(operandVar);
        }

        protected void btnMinus_Click(object sender, EventArgs e)
        {
            Session["Num1"] = txtLCD.Text;
            dblNum1 = Int32.Parse(txtLCD.Text);
            Session["Operand"] = "-";
            operandVar = Session["Operand"].ToString();
            txtLCD.Text = "-";
            numInMemory = true;
            checkMem(operandVar);
        }
        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            Session["Num1"] = txtLCD.Text;
            dblNum1 = Int32.Parse(txtLCD.Text);
            Session["Operand"] = "*";
            operandVar = Session["Operand"].ToString();
            txtLCD.Text = "";
            numInMemory = true;
            checkMem(operandVar);
        }
        protected void btnDivide_Click(object sender, EventArgs e)
        {
            Session["Num1"] = txtLCD.Text;
            dblNum1 = Double.Parse(txtLCD.Text);
            Session["Operand"] = "/";
            operandVar = Session["Operand"].ToString();
            txtLCD.Text = "";
            numInMemory = true;
            checkMem(operandVar);

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Session["Num1"] = null;
            Session["Operand"] = null;
            txtLCD.Text = "";
            numInMemory = false;
            memIndicator.InnerText = "";
            operandIndicator.InnerText = "";
        }
    }
}