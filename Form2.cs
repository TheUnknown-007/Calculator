using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator
{
    public partial class Form2 : Form
    {
        #region Variables
        enum Operations
        {
            Null,
            Plus,
            Minus,
            Multiply,
            Divide,
            Root,
            Power
        }
        Operations oper = Operations.Null;

        string num1 = "";
        string num2 = "";
        bool tempSigni = false;
        bool decimaled = false;
        bool power = false;
        bool tempPower = false;
        int panelWidth = 170;
        bool Hidden = true;
        bool Hidden2 = true;
        #endregion

        public Form2()
        {
            InitializeComponent();
            InitializeTheme();

            //button16.Focus();
            //richTextBox1.Enabled = false;
            KeyPress += Form1_KeyPress;
            richTextBox1.KeyPress += Form1_KeyPress;
            button1.KeyPress += Form1_KeyPress;
            button2.KeyPress += Form1_KeyPress;
            button3.KeyPress += Form1_KeyPress;
            button4.KeyPress += Form1_KeyPress;
            button5.KeyPress += Form1_KeyPress;
            button6.KeyPress += Form1_KeyPress;
            button7.KeyPress += Form1_KeyPress;
            button8.KeyPress += Form1_KeyPress;
            button9.KeyPress += Form1_KeyPress;
            button10.KeyPress += Form1_KeyPress;
            button11.KeyPress += Form1_KeyPress;
            button12.KeyPress += Form1_KeyPress;
            button13.KeyPress += Form1_KeyPress;
            button14.KeyPress += Form1_KeyPress;
            button15.KeyPress += Form1_KeyPress;
            button16.KeyPress += Form1_KeyPress;
            button17.KeyPress += Form1_KeyPress;
            button18.KeyPress += Form1_KeyPress;
            button19.KeyPress += Form1_KeyPress;
            button20.KeyPress += Form1_KeyPress;
        }

        private void InitializeTheme()
        {
            BackColor = Color.FromArgb(9, 24, 51);
            richTextBox1.BackColor = Color.FromArgb(9, 24, 51);
            richTextBox1.ForeColor = Color.FromArgb(0, 235, 100);
            PanelSlide.BackColor = Color.FromArgb(14, 35, 75);

            button1.BackColor  = Color.FromArgb(9, 24, 51);
            button2.BackColor  = Color.FromArgb(9, 24, 51);
            button3.BackColor  = Color.FromArgb(9, 24, 51);
            button4.BackColor  = Color.FromArgb(9, 24, 51);
            button5.BackColor  = Color.FromArgb(9, 24, 51);
            button6.BackColor  = Color.FromArgb(9, 24, 51);
            button7.BackColor  = Color.FromArgb(9, 24, 51);
            button8.BackColor  = Color.FromArgb(9, 24, 51);
            button9.BackColor  = Color.FromArgb(9, 24, 51);
            button10.BackColor = Color.FromArgb(9, 24, 51);
            button11.BackColor = Color.FromArgb(9, 24, 51);
            button12.BackColor = Color.FromArgb(9, 24, 51);
            button13.BackColor = Color.FromArgb(9, 24, 51);
            button14.BackColor = Color.FromArgb(9, 24, 51);
            button15.BackColor = Color.FromArgb(9, 24, 51);
            button16.BackColor = Color.FromArgb(9, 24, 51);
            button17.BackColor = Color.FromArgb(9, 24, 51);
            button18.BackColor = Color.FromArgb(9, 24, 51);
            button19.BackColor = Color.FromArgb(9, 24, 51);
            button20.BackColor = Color.FromArgb(9, 24, 51);
            button21.BackColor = Color.FromArgb(9, 24, 51);
            button22.BackColor = Color.FromArgb(9, 24, 51);
            button23.BackColor = Color.FromArgb(9, 24, 51);
            button24.BackColor = Color.FromArgb(9, 24, 51);

            button1.ForeColor  = Color.FromArgb(0, 235, 100);
            button2.ForeColor  = Color.FromArgb(0, 235, 100);
            button3.ForeColor  = Color.FromArgb(0, 235, 100);
            button4.ForeColor  = Color.FromArgb(0, 235, 100);
            button5.ForeColor  = Color.FromArgb(0, 235, 100);
            button6.ForeColor  = Color.FromArgb(0, 235, 100);
            button7.ForeColor  = Color.FromArgb(0, 235, 100);
            button8.ForeColor  = Color.FromArgb(0, 235, 100);
            button9.ForeColor  = Color.FromArgb(0, 235, 100);
            button10.ForeColor = Color.FromArgb(0, 235, 100);
            button11.ForeColor = Color.FromArgb(0, 235, 100);
            button12.ForeColor = Color.FromArgb(0, 235, 100);
            button13.ForeColor = Color.FromArgb(0, 235, 100);
            button14.ForeColor = Color.FromArgb(0, 235, 100);
            button15.ForeColor = Color.FromArgb(0, 235, 100);
            button16.ForeColor = Color.FromArgb(234, 0, 217);
            button17.ForeColor = Color.FromArgb(0, 235, 100);
            button18.ForeColor = Color.FromArgb(0, 235, 100);
            button19.ForeColor = Color.FromArgb(0, 235, 100);
            button20.ForeColor = Color.FromArgb(0, 235, 100);
            button21.ForeColor = Color.FromArgb(0, 235, 100);
            button22.ForeColor = Color.FromArgb(0, 235, 100);
            button23.ForeColor = Color.FromArgb(234, 0, 217);
            button24.ForeColor = Color.FromArgb(0, 235, 100);


            button1.FlatAppearance.MouseDownBackColor  = Color.FromArgb(9, 24, 51);
            button2.FlatAppearance.MouseDownBackColor  = Color.FromArgb(9, 24, 51);
            button3.FlatAppearance.MouseDownBackColor  = Color.FromArgb(9, 24, 51);
            button4.FlatAppearance.MouseDownBackColor  = Color.FromArgb(9, 24, 51);
            button5.FlatAppearance.MouseDownBackColor  = Color.FromArgb(9, 24, 51);
            button6.FlatAppearance.MouseDownBackColor  = Color.FromArgb(9, 24, 51);
            button7.FlatAppearance.MouseDownBackColor  = Color.FromArgb(9, 24, 51);
            button8.FlatAppearance.MouseDownBackColor  = Color.FromArgb(9, 24, 51);
            button9.FlatAppearance.MouseDownBackColor  = Color.FromArgb(9, 24, 51);
            button10.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
            button11.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
            button12.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
            button13.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
            button14.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
            button15.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
            button16.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
            button17.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
            button18.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
            button19.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
            button20.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
            button21.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
            button22.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
            button23.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
            button24.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 24, 51);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (((byte)e.KeyChar).ToString() == "27")
            {
                richTextBox1.Text = "";
                oper = Operations.Null;
                num1 = "";
                num2 = "";
                tempSigni = false;
                decimaled = false;
                power = false;
                tempPower = false;
            }
            if (((byte)e.KeyChar).ToString() == "8")
            {
                if(richTextBox1.Text.Length < 1)
                    return;
                if (richTextBox1.Text.Substring(richTextBox1.Text.Length - 1).IndexOfAny(new char[] { '÷', '√', '×', '-', 'ⁿ', '+' }) != -1)
                {
                    num2 = "";
                    oper = Operations.Null;
                    power = false;
                }
                if (richTextBox1.Text.Substring(richTextBox1.Text.Length - 1).IndexOf('.') != -1)
                {
                    decimaled = false;
                    tempSigni = true;
                }
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
            }

            if (((byte)e.KeyChar).ToString() == "13") button16_Click(null, null);
            if (((byte)e.KeyChar).ToString() == "46")
            {
                if (decimaled) return;
                if (oper != Operations.Null) num2 += "0.";
                if (tempSigni)
                {
                    if (power)
                    {
                        if (!tempPower)
                        {
                            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                            tempPower = true;
                        }
                        richTextBox1.Text += "'";
                    }
                    else richTextBox1.Text += ".";
                }
                else
                {
                    if (power)
                    {
                        if (!tempPower)
                        {
                            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                            tempPower = true;
                        }
                        richTextBox1.Text += "⁰'";
                    }
                    else richTextBox1.Text += "0.";
                }
                decimaled = true;
                if (num2 == "") num1 = ".";
                return;
            }
            if (((byte)e.KeyChar).ToString() == "48")
            {
                if (!tempSigni) return;
                if (power)
                {
                    if (!tempPower)
                    {
                        richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                        tempPower = true;
                    }
                    richTextBox1.Text += "⁰";
                }
                else richTextBox1.Text += "0";
                if (oper != Operations.Null) num2 += "0";
                if (num2 == "") num1 = ".";
                return;
            }
            if (((byte)e.KeyChar).ToString() == "49")
            {
                if (oper != Operations.Null) num2 += "1";
                if (!power)
                    richTextBox1.Text += "1";
                else
                {
                    if (!tempPower)
                    {
                        richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                        tempPower = true;
                    }
                    richTextBox1.Text += "¹";
                }
                tempSigni = true;
                if (num2 == "") num1 = ".";
            }
            if (((byte)e.KeyChar).ToString() == "50")
            {
                if (oper != Operations.Null) num2 += "2";
                if (!power)
                    richTextBox1.Text += "2";
                else
                {
                    if (!tempPower)
                    {
                        richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                        tempPower = true;
                    }
                    richTextBox1.Text += "²";
                }
                tempSigni = true;
                if (num2 == "") num1 = ".";
            }
            if (((byte)e.KeyChar).ToString() == "51")
            {
                if (oper != Operations.Null) num2 += "3";
                if (!power)
                    richTextBox1.Text += "3";
                else
                {
                    if (!tempPower)
                    {
                        richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                        tempPower = true;
                    }
                    richTextBox1.Text += "³";
                }
                tempSigni = true;
                if (num2 == "") num1 = ".";
            }
            if (((byte)e.KeyChar).ToString() == "52")
            {
                if (oper != Operations.Null) num2 += "4";
                if (!power)
                    richTextBox1.Text += "4";
                else
                {
                    if (!tempPower)
                    {
                        richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                        tempPower = true;
                    }
                    richTextBox1.Text += "⁴";
                }
                tempSigni = true;
                if (num2 == "") num1 = ".";
            }
            if (((byte)e.KeyChar).ToString() == "53")
            {
                if (oper != Operations.Null) num2 += "5";
                if (!power)
                    richTextBox1.Text += "5";
                else
                {
                    if (!tempPower)
                    {
                        richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                        tempPower = true;
                    }
                    richTextBox1.Text += "⁵";
                }
                tempSigni = true;
                if (num2 == "") num1 = ".";
            }
            if (((byte)e.KeyChar).ToString() == "54")
            {
                if (oper != Operations.Null) num2 += "6";
                if (!power)
                    richTextBox1.Text += "6";
                else
                {
                    if (!tempPower)
                    {
                        richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                        tempPower = true;
                    }
                    richTextBox1.Text += "⁶";
                }
                tempSigni = true;
                if (num2 == "") num1 = ".";
            }
            if (((byte)e.KeyChar).ToString() == "55")
            {
                if (oper != Operations.Null) num2 += "7";
                if (!power)
                    richTextBox1.Text += "7";
                else
                {
                    if (!tempPower)
                    {
                        richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                        tempPower = true;
                    }
                    richTextBox1.Text += "⁷";
                }
                tempSigni = true;
                if (num2 == "") num1 = ".";
            }
            if (((byte)e.KeyChar).ToString() == "56")
            {
                if (oper != Operations.Null) num2 += "8";
                if (!power)
                    richTextBox1.Text += "8";
                else
                {
                    if (!tempPower)
                    {
                        richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                        tempPower = true;
                    }
                    richTextBox1.Text += "⁸";
                }
                tempSigni = true;
                if (num2 == "") num1 = ".";
            }
            if (((byte)e.KeyChar).ToString() == "57")
            {
                if (oper != Operations.Null) num2 += "9";
                if (!power)
                    richTextBox1.Text += "9";
                else
                {
                    if (!tempPower)
                    {
                        richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                        tempPower = true;
                    }
                    richTextBox1.Text += "⁹";
                }
                tempSigni = true;
                if (num2 == "") num1 = ".";
            }
        }

        private void numberButtons_Click(object sender, EventArgs e)
        {
            Button myButton = sender as Button;
            switch(myButton.Name)
            {
                case "button17":
                    if (!tempSigni) break;
                    if (power)
                    {
                        if (!tempPower)
                        {
                            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                            tempPower = true;
                        }
                        richTextBox1.Text += "⁰";
                    }
                    else richTextBox1.Text += myButton.Text;
                    if (oper != Operations.Null) num2 += myButton.Text;
                    if (num2 == "") num1 = ".";
                    break;
                case "button18":
                    if (decimaled) break;
                    if (oper != Operations.Null) num2 += "0.";
                    if (tempSigni)
                    {
                        if (power)
                        {
                            if (!tempPower)
                            {
                                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                                tempPower = true;
                            }
                            richTextBox1.Text += "'";
                        }
                        else richTextBox1.Text += ".";
                    }
                    else
                    {
                        if (power)
                        {
                            if (!tempPower)
                            {
                                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                                tempPower = true;
                            }
                            richTextBox1.Text += "⁰'";
                        }
                        else richTextBox1.Text += "0.";
                    }
                    decimaled = true;
                    if (num2 == "") num1 = ".";
                    break;


                case "button1":
                    if (oper != Operations.Null) num2 += myButton.Text;
                    if (!power) 
                        richTextBox1.Text += myButton.Text;
                    else 
                    {
                        if (!tempPower)
                        {
                            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                            tempPower = true;
                        }
                        richTextBox1.Text += "¹";
                    }
                    tempSigni = true;
                    if (num2 == "") num1 = ".";
                    break;
                case "button2":
                    if (oper != Operations.Null) num2 += myButton.Text;
                    if (!power) 
                        richTextBox1.Text += myButton.Text;
                    else 
                    {
                        if (!tempPower)
                        {
                            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                            tempPower = true;
                        }
                        richTextBox1.Text += "²";
                    }
                    tempSigni = true;
                    if (num2 == "") num1 = ".";
                    break;
                case "button3":
                    if (oper != Operations.Null) num2 += myButton.Text;
                    if (!power)
                        richTextBox1.Text += myButton.Text;
                    else
                    {
                        if (!tempPower)
                        {
                            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                            tempPower = true;
                        }
                        richTextBox1.Text += "³";
                    }
                    tempSigni = true;
                    if (num2 == "") num1 = ".";
                    break;
                case "button4":
                    if (oper != Operations.Null) num2 += myButton.Text;
                    if (!power)
                        richTextBox1.Text += myButton.Text;
                    else
                    {
                        if (!tempPower)
                        {
                            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                            tempPower = true;
                        }
                        richTextBox1.Text += "⁴";
                    }
                    tempSigni = true;
                    if (num2 == "") num1 = ".";
                    break;
                case "button5":
                    if (oper != Operations.Null) num2 += myButton.Text;
                    if (!power)
                        richTextBox1.Text += myButton.Text;
                    else
                    {
                        if (!tempPower)
                        {
                            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                            tempPower = true;
                        }
                        richTextBox1.Text += "⁵";
                    }
                    tempSigni = true;
                    if (num2 == "") num1 = ".";
                    break;
                case "button6":
                    if (oper != Operations.Null) num2 += myButton.Text;
                    if (!power)
                        richTextBox1.Text += myButton.Text;
                    else
                    {
                        if (!tempPower)
                        {
                            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                            tempPower = true;
                        }
                        richTextBox1.Text += "⁶";
                    }
                    tempSigni = true;
                    if (num2 == "") num1 = ".";
                    break;
                case "button7":
                    if (oper != Operations.Null) num2 += myButton.Text;
                    if (!power)
                        richTextBox1.Text += myButton.Text;
                    else
                    {
                        if (!tempPower)
                        {
                            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                            tempPower = true;
                        }
                        richTextBox1.Text += "⁷";
                    }
                    tempSigni = true;
                    if (num2 == "") num1 = ".";
                    break;
                case "button8":
                    if (oper != Operations.Null) num2 += myButton.Text;
                    if (!power)
                        richTextBox1.Text += myButton.Text;
                    else
                    {
                        if (!tempPower)
                        {
                            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                            tempPower = true;
                        }
                        richTextBox1.Text += "⁸";
                    }
                    tempSigni = true;
                    break;
                case "button9":
                    if (oper != Operations.Null) num2 += myButton.Text;
                    if (!power)
                        richTextBox1.Text += myButton.Text;
                    else
                    {
                        if (!tempPower)
                        {
                            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                            tempPower = true;
                        }
                        richTextBox1.Text += "⁹";
                    }
                    tempSigni = true;
                    if (num2 == "") num1 = ".";
                    break;
            }
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            if ((oper != Operations.Null && num2 == "") || num1 == "" || power)
                return;
            if (num2 != "") button16_Click(null, null);
            decimaled = false;
            tempSigni = false;
            Button myButton = sender as Button;
            switch (myButton.Name)
            {
                case "button10":
                    num1 = richTextBox1.Text;
                    richTextBox1.Text += myButton.Text;
                    oper = Operations.Multiply;
                    break;
                case "button11":
                    num1 = richTextBox1.Text;
                    richTextBox1.Text += myButton.Text;
                    oper = Operations.Minus;
                    break;
                case "button12":
                    num1 = richTextBox1.Text;
                    richTextBox1.Text += myButton.Text;
                    oper = Operations.Plus;
                    break;
                case "button13":
                    if (oper == Operations.Null && !power)
                    {
                        BigFloat num01 = BigFloat.Parse(richTextBox1.Text);
                        richTextBox1.Text = num01.Sqrt().ToString();
                        num1 = richTextBox1.Text;
                        num2 = "";
                        tempPower = false;
                    }
                    break;
                case "button14":
                    num1 = richTextBox1.Text;
                    richTextBox1.Text += "ⁿ";
                    oper = Operations.Power;
                    power = true;
                    break;
                case "button15":
                    num1 = richTextBox1.Text;
                    richTextBox1.Text += myButton.Text;
                    oper = Operations.Divide;
                    break;
            }
        }

        private void specialButtons(object sender, EventArgs e)
        {
            Button myButton = sender as Button;
            switch (myButton.Name)
            {
                case "button19":
                    if (richTextBox1.Text.Length < 1)
                        break;
                    if (richTextBox1.Text.Substring(richTextBox1.Text.Length - 1).IndexOfAny(new char[] { '÷', '√', '×', '-', 'ⁿ', '+' }) != -1)
                    {
                        oper = Operations.Null;
                        power = false;
                    }
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                    break;
                case "button20":
                    richTextBox1.Text = "";
                    oper = Operations.Null;
                    num1 = "";
                    num2 = "";
                    tempSigni = false;
                    decimaled = false;
                    power = false;
                    tempPower = false;
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (num1 == "" || num2 == "" || oper == Operations.Null) return;
            BigFloat num01 = BigFloat.Parse(num1);
            BigFloat num02 = BigFloat.Parse(num2);
            num2 = "";
            if (oper == Operations.Plus) richTextBox1.Text = (num01 + num02).ToString();
            if (oper == Operations.Minus) richTextBox1.Text = (num01 - num02).ToString();
            if (oper == Operations.Multiply) richTextBox1.Text = (num01 * num02).ToString();
            if (oper == Operations.Divide) richTextBox1.Text = (num01 / num02).ToString();
            if (oper == Operations.Power)
            {
                BigFloat num03 = num01;
                for (int i = 1; i < num02; i++)
                    num03 *= num01;
                richTextBox1.Text = num03.ToString();
            }
            oper = Operations.Null;
            power = false;
            tempPower = false;
            num1 = richTextBox1.Text;
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            if (!Hidden && PanelSlide.Width == 170)
                timer2.Start();

            Button myButton = sender as Button;
            if(myButton.Name != "button16") myButton.ForeColor = Color.FromArgb(234, 0, 217);
            else myButton.ForeColor = Color.FromArgb(0, 235, 100);
            myButton.BackColor = Color.FromArgb(9, 24, 51);

            if (myButton.Name == "button22")
                myButton.BackgroundImage = Properties.Resources.SettingsP;
            if (myButton.Name == "button23")
                myButton.BackgroundImage = Properties.Resources.ScientificP;
            if (myButton.Name == "button24")
                myButton.BackgroundImage = Properties.Resources.SettingsButtonP;
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            Button myButton = sender as Button;
            if (myButton.Name != "button16") myButton.ForeColor = Color.FromArgb(0, 235, 100);
            else myButton.ForeColor = Color.FromArgb(234, 0, 217);
            myButton.BackColor = Color.FromArgb(9, 24, 51);

            if (myButton.Name == "button22")
                myButton.BackgroundImage = Properties.Resources.Settings;
            if (myButton.Name == "button23")
                myButton.BackgroundImage = Properties.Resources.Scientific;
            if (myButton.Name == "button24")
                myButton.BackgroundImage = Properties.Resources.SettingsButton;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            int thickness = 2;
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.FromArgb(0, 235, 100), thickness))
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness, halfThickness, PanelSlide.ClientSize.Width - thickness, PanelSlide.ClientSize.Height - thickness));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                PanelSlide.Width += 20;
                if (PanelSlide.Width >= panelWidth)
                {
                    Hidden = false;
                    timer1.Stop();
                    timer2.Start();
                }
            }
            else
            {
                PanelSlide.Width -= 40;
                if (PanelSlide.Width <= 0)
                {
                    Hidden = true;
                    timer1.Stop();
                }
            }
            Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Hidden2)
            {
                button21.Width += 45;
                button23.Width += 45;
                button24.Width += 45;
                if (button23.Width >= 150)
                {
                    button21.Width = 150;
                    button23.Width = 150;
                    button24.Width = 150;
                    button21.Text = "Standard";
                    button23.Text = "Scientific";
                    button24.Text = "Settings";
                    Hidden2 = false;
                    timer2.Stop();
                }
            }
            else
            {
                button21.Text = "----";
                button23.Text = "----";
                button24.Text = "----";
                button21.Width -= 60;
                button23.Width -= 60;
                button24.Width -= 60;
                if (button23.Width <= 0)
                {
                    button21.Width = 0;
                    button23.Width = 0;
                    button24.Width = 0;
                    Hidden2 = true;
                    timer2.Stop();
                    timer1.Start();
                }
            }
            Refresh();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(Hidden) timer1.Start();
            else timer2.Start();
        }

        private void panelButtons_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            switch (myButton.Name)
            {
                case "button21": //Standard
                    ProgramHandler.calcType = ProgramHandler.CalculatorType.Standard;
                    DialogResult = DialogResult.Retry;
                    break;
                /*(case "button23": //Scientific
                    ProgramHandler.calcType = ProgramHandler.CalculatorType.Scientific;
                    DialogResult = DialogResult.Retry;
                    Close();
                    break;*/
                case "button24": //Settings
                    DialogResult = DialogResult.Ignore;
                    Close();
                    break;
            }
        }
    }
}