using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        private string number;
        private string currentOperator;
        private bool lastClickOperator = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            // make the buttons colorful
            BTNZero.BackColor = System.Drawing.Color.LightGray;
            BTNOne.BackColor = System.Drawing.Color.LightGray;
            BTNTwo.BackColor = System.Drawing.Color.LightGray;
            BTNThree.BackColor = System.Drawing.Color.LightGray;
            BTNFour.BackColor = System.Drawing.Color.LightGray;
            BTNFive.BackColor = System.Drawing.Color.LightGray;
            BTNSix.BackColor = System.Drawing.Color.LightGray;
            BTNSeven.BackColor = System.Drawing.Color.LightGray;
            BTNEight.BackColor = System.Drawing.Color.LightGray;
            BTNNine.BackColor = System.Drawing.Color.LightGray;
            BTNPlus.BackColor = System.Drawing.Color.DarkGray;
            BTNMinus.BackColor = System.Drawing.Color.DarkGray;
            BTNMultiply.BackColor = System.Drawing.Color.DarkGray;
            BTNDivide.BackColor = System.Drawing.Color.DarkGray;
            BTNEquals.BackColor = System.Drawing.Color.DarkGray;
            BTNClear.BackColor = System.Drawing.Color.DarkOrange;
            
            // if this is a postback request reset the local variables to their ViewState value
            if (this.IsPostBack)
            {
                number = (string)ViewState["number"];
                currentOperator = (string)ViewState["currentOperator"];
                lastClickOperator = (bool)ViewState["lastClickOperator"];
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            // on page render assign the local variables to a ViewState
            ViewState["number"] = number;
            ViewState["currentOperator"] = currentOperator;
            ViewState["lastClickOperator"] = lastClickOperator;
        }

        protected void BTN_Add_Value_Click(object sender, EventArgs e)
        {
            try
            {
                // add button value to textfield
                Button btn = (Button)sender;
                InputField.Text += btn.CommandArgument;
            }
            catch (Exception ex)
            {
                ExceptionHandler.BackColor = System.Drawing.Color.Red;
                ExceptionHandler.Text = "An error occured on the 'BTN_Add_Value' event. Exception Message: " + ex.Message;
            }
        }

        protected void BTN_Operator_Click(object sender, EventArgs e)
        {
            try
            {
                // add the operator to the textfield. if one has already been clicked replace the old operator with the new one
                Button btn = (Button)sender;
                InputField.Enabled = true;
                if (!lastClickOperator)
                {
                    currentOperator = btn.CommandArgument;
                    number = InputField.Text;
                    InputField.Text = number.ToString() + " " + btn.CommandArgument + " ";
                }
                else
                {
                    InputField.Text = InputField.Text.Replace(currentOperator, btn.CommandArgument);
                }
                currentOperator = btn.CommandArgument;
                InputField.Enabled = false;
                lastClickOperator = true;
            }
            catch (Exception ex)
            {
                ExceptionHandler.BackColor = System.Drawing.Color.Red;
                ExceptionHandler.Text = "An error occured on the 'BTN_Operator' event. Exception Message: " + ex.Message;
            }
        }

        protected void BTN_Equals_Click(object sender, EventArgs e)
        {
            try
            {
                // if an operator has been clicked run calculation
                InputField.Enabled = true;
                if (lastClickOperator)
                {
                    // assign our numbers to two seperate variables
                    int secondNumberLastIndex = InputField.Text.LastIndexOf(" ") + 1;
                    string secondNumberString = InputField.Text.Substring(secondNumberLastIndex, InputField.Text.Length - secondNumberLastIndex);
                    int FirstNumber = Convert.ToInt32(number);
                    int SecondNumber = Convert.ToInt32(secondNumberString);

                    int total = 0;

                    // find which operator has been selected and calculate accordingly
                    if (currentOperator == "+")
                    {
                        total = FirstNumber + SecondNumber;
                    }
                    else if (currentOperator == "-")
                    {
                        total = FirstNumber - SecondNumber;
                    }
                    else if (currentOperator == "x")
                    {
                        total = FirstNumber * SecondNumber;
                    }
                    else if (currentOperator == "/")
                    {
                        if (FirstNumber == 0 || SecondNumber == 0)
                        {
                            total = 0;
                        }
                        else
                        {
                            total = FirstNumber / SecondNumber;
                        }
                    }

                    InputField.Text = total.ToString();
                }
                InputField.Enabled = false;
            }
            catch (Exception ex)
            {
                ExceptionHandler.BackColor = System.Drawing.Color.Red;
                ExceptionHandler.Text = "An error occured on the 'BTN_Equals' event. Exception Message: " + ex.Message;
            }
        }

        protected void BTN_Clear_Click(object sender, EventArgs e)
        {
            try
            {
                // reset the calculator
                InputField.Text = "";
                number = null;
                currentOperator = null;
                lastClickOperator = false;
            }
            catch (Exception ex)
            {
                ExceptionHandler.BackColor = System.Drawing.Color.Red;
                ExceptionHandler.Text = "An error occured on the 'BTN_Clear' event. Exception Message: " + ex.Message;
            }
        }
    }
}