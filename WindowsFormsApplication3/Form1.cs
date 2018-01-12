using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        double num3 = 0;
        double result = 0;
        double item;
        string op;
        bool isOpPerformed = false;
        string copy;
        double? mem = 0;
        double? mem_store = null;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void playaudio()
        {
            SoundPlayer audio = new SoundPlayer(WindowsFormsApplication3.Properties.Resources.WindowsDing);
            audio.Play();
        }
        private void Button_Click(object sender, EventArgs e)
        {
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") || (isOpPerformed))

                textBox1.Text = string.Empty;
            isOpPerformed = false;
            textBox1.Text = textBox1.Text + button0.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
            label3.Text = string.Empty;
            num1 = 0;
            num2 = 0;
            num3 = 0;
            mem = null;
            mem_store = null;
            textBox1.Focus();
        }

        private void buttonClearentry_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox1.Focus();
            panel3.Visible = false;
            groupBox4.Visible = false;
            this.Width = 271;
            this.Height = 410;
            textBox1.Width = 244;
            standerdToolStripMenuItem.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") || (isOpPerformed))

                textBox1.Text = string.Empty;
            isOpPerformed = false;
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") || (isOpPerformed))

                textBox1.Text = string.Empty;
            isOpPerformed = false;
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") || (isOpPerformed))

                textBox1.Text = string.Empty;
            isOpPerformed = false;
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") || (isOpPerformed))

                textBox1.Text = string.Empty;
            isOpPerformed = false;
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") || (isOpPerformed))

                textBox1.Text = string.Empty;
            isOpPerformed = false;
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") || (isOpPerformed))

                textBox1.Text = string.Empty;
            isOpPerformed = false;
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") || (isOpPerformed))

                textBox1.Text = string.Empty;

            isOpPerformed = false;
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") || (isOpPerformed))

                textBox1.Text = string.Empty;
            isOpPerformed = false;
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") || (isOpPerformed))

                textBox1.Text = string.Empty;
            isOpPerformed = false;
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                playaudio();
            }
            else if (!textBox1.Text.Contains(".") || (isOpPerformed))
            {
                isOpPerformed = false;
                textBox1.Text = textBox1.Text + buttonDot.Text;

            }

        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1 != 0)
                {
                    button25.PerformClick();
                    isOpPerformed = true;
                    op = "+";
                    label3.Text = label3.Text + textBox1.Text + buttonSum.Text;
                }

                else
                {
                    op = "+";
                    num1 = Convert.ToDouble(textBox1.Text);
                    isOpPerformed = true;
                    label3.Text = label3.Text + textBox1.Text + buttonSum.Text;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); label3.Text = label3.Text + textBox1.Text;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {

            try
            {

                switch (op)
                {

                    case "+":
                        textBox1.Text = (num1 + Convert.ToDouble(textBox1.Text)).ToString();
                        break;

                    case "-":
                        textBox1.Text = (num1 - Convert.ToDouble(textBox1.Text)).ToString();
                        break;

                    case "*":
                        textBox1.Text = (num1 * Convert.ToDouble(textBox1.Text)).ToString();
                        break;

                    case "/":
                        textBox1.Text = (num1 / Convert.ToDouble(textBox1.Text)).ToString();
                        if (textBox1.Text.Equals("NaN") || textBox1.Text.Equals("Infinity"))
                        {
                            playaudio();
                        }

                        break;
                    case "Exp":

                        result = num3 * (Math.Pow(10, Convert.ToDouble(textBox1.Text)));
                        textBox1.Text = Convert.ToString(result);
                        break;
                    case "Mod":
                        num2 = Convert.ToDouble(textBox1.Text);
                        label3.Text = label3.Text + num2;
                        result = num3 % num2;
                        textBox1.Text = Convert.ToString(result);
                        break;

                    case "Rootn":
                        num2 = Convert.ToDouble(textBox1.Text);
                        result = Math.Pow(num3, 1 / num2);
                        textBox1.Text = Convert.ToString(result);
                        break;

                    case "^":
                        num2 = Convert.ToDouble(textBox1.Text);
                        label3.Text = label3.Text + num2;
                        result = Math.Pow(num3, num2);
                        textBox1.Text = Convert.ToString(result);
                        break;

                    default:
                        break;
                }
                    num1 = Convert.ToDouble(textBox1.Text);
                op = "";
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            try
            {
                    button25.PerformClick();
                    isOpPerformed = true;
                    op = "-";
                    label3.Text = label3.Text + textBox1.Text + buttonSub.Text;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = label3.Text + textBox1.Text + buttonMul.Text;
                button25.PerformClick();
                op = "*";
                isOpPerformed = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = label3.Text + textBox1.Text + buttonDiv.Text;
                button25.PerformClick();
                op = "/";
                isOpPerformed = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonParcent_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = label3.Text + textBox1.Text + buttonParcent.Text;
                num2 = Convert.ToDouble(textBox1.Text);
                result = num1 * (num2 / 100);
                textBox1.Text = Convert.ToString(result);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = buttonRoot.Text + textBox1.Text;
                textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSS_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) * -1));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDerivative_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "1/" + textBox1.Text;
                textBox1.Text = Convert.ToString((1 / Convert.ToDouble(textBox1.Text)));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            catch (Exception)
            {

                playaudio();
            }
        }

        private void buttonMplus_Click(object sender, EventArgs e)
        {
            try
            {
                mem = mem + Convert.ToDouble(textBox1.Text);
                MessageBox.Show("Memory Added!");
                textBox1.Text = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMresult_Click(object sender, EventArgs e)
        {
            try
            {
                if (mem_store != null)
                {
                    label3.Text = "Memory Result::";
                    textBox1.Text = Convert.ToString(mem_store);

                }
                else if (mem_store == null)
                {
                    label3.Text = "Memory Result::";
                    textBox1.Text = Convert.ToString(mem);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonMminus_Click(object sender, EventArgs e)
        {
            try
            {
                mem = mem - Convert.ToDouble(textBox1.Text);
                MessageBox.Show("Memory Substracted!");
                textBox1.Text = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMclear_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = null;
                mem = null;
                MessageBox.Show("Memory Cleared!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMstore_Click(object sender, EventArgs e)
        {
            try
            {
                mem_store = Convert.ToDouble(textBox1.Text);
                MessageBox.Show("Memory Stored!");
                textBox1.Text = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void standerdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standerdToolStripMenuItem.Checked = true;
            scientificToolStripMenuItem.Checked = false;
            statisticsToolStripMenuItem.Checked = false;
            groupBox4.Visible = false;
            panel3.Visible = false;
            panel1.Location = new Point(0, 41);
            this.Width = 271;
            this.Height = 410;
            panel1.Width = 255;
            textBox1.Width = 244;
            label3.Width = 244;
            panel1.Visible = true;
            textBox1.Text = "0";
            textBox1.Focus();
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standerdToolStripMenuItem.Checked = false;
            statisticsToolStripMenuItem.Checked = false;
            scientificToolStripMenuItem.Checked = true;
            groupBox2.Visible = false;
            groupBox4.Visible = true;
            this.Width = 530;
            this.Height = 410;
            panel3.Visible = false;
            panel1.Width = 510;
            textBox1.Width = 502;
            label3.Width = 500;
            panel1.Visible = true;
            textBox1.Focus();
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonDegrees.Checked)
                {
                    label3.Text = "tanD" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Tan(Convert.ToDouble(textBox1.Text) * Math.PI / 180));
                }
                else if (radioButtonRadians.Checked)
                {
                    label3.Text = "tanR" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Tan(Convert.ToDouble(textBox1.Text)));
                }
                else if (radioButtonGradians.Checked)
                {
                    label3.Text = "tanG" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Tan(Convert.ToDouble(textBox1.Text) * Math.PI / 200));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToDouble(textBox1.Text).ToString("0.'.'e+#'0'");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.PI);
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "log" + "(" + textBox1.Text + ")";
                textBox1.Text = Convert.ToString(Math.Log10(Convert.ToDouble(textBox1.Text)));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSinh_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonDegrees.Checked)
                {
                    label3.Text = "sinh" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Sinh(Convert.ToDouble(textBox1.Text)));
                }
                else if (radioButtonRadians.Checked)
                {
                    label3.Text = "sinh" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Sinh(Convert.ToDouble(textBox1.Text)));
                }
                else if (radioButtonGradians.Checked)
                {
                    label3.Text = "sinh" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Sinh(Convert.ToDouble(textBox1.Text)));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonDegrees.Checked)
                {
                    label3.Text = "sinD" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Sin(Convert.ToDouble(textBox1.Text) * Math.PI / 180));
                }
                else if (radioButtonRadians.Checked)
                {
                    label3.Text = "sinR" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Sin(Convert.ToDouble(textBox1.Text)));
                }
                else if (radioButtonGradians.Checked)
                {
                    label3.Text = "sinG" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Sin(Convert.ToDouble(textBox1.Text) * Math.PI / 200.0));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "sqr" + "(" + textBox1.Text + ")";
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                double dac = 1;
                int count;
                if (num1 < 0)
                {
                    playaudio();
                    textBox1.Text = ("Error! Factorial of negetive number does not exist!");
                }
                else
                {
                    for (count = 1; count <= num1; ++count)
                    {
                        dac *= count;
                        textBox1.Text = Convert.ToString(dac);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDms_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPowern_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = textBox1.Text + "^";
                num3 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = null;
                op = "^";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCosh_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "cosh" + "(" + textBox1.Text + ")";
                textBox1.Text = Convert.ToString(Math.Cosh(Convert.ToDouble(textBox1.Text)));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonDegrees.Checked)
                {
                    label3.Text = "cosD" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Cos(Convert.ToDouble(textBox1.Text) * Math.PI / 180));
                }
                else if (radioButtonRadians.Checked)
                {
                    label3.Text = "cosR" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Cos(Convert.ToDouble(textBox1.Text)));
                }
                else if (radioButtonGradians.Checked)
                {
                    label3.Text = "cosG" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Cos(Convert.ToDouble(textBox1.Text) * Math.PI / 200));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTanh_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "tanh" + "(" + textBox1.Text + ")";
                textBox1.Text = Convert.ToString(Math.Tanh(Convert.ToDouble(textBox1.Text)));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSquarecube_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "cube" + "(" + textBox1.Text + ")";
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCubicroot_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), (1.0 / 3.0)));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFe_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToDouble(textBox1.Text).ToString("0.##########################################################e+0");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = textBox1.Text + " Mod ";
                num3 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = null;
                op = "Mod";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPowerten_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "powten" + "(" + textBox1.Text + ")";
                textBox1.Text = Convert.ToString(Math.Pow(10, Convert.ToDouble(textBox1.Text)));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRootn_Click(object sender, EventArgs e)
        {
            try
            {
                num3 = Convert.ToDouble(textBox1.Text);
                label3.Text = num3 + " nroot";
                textBox1.Text = null;
                op = "Rootn";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonln_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToString(Math.Log(Convert.ToDouble(textBox1.Text), Math.E));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInv_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible != true)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }

        }

        private void buttonInt_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToDouble(textBox1.Text).ToString("#");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBin_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "Bin" + "(" + textBox1.Text + ")";
                string num = (textBox1.Text);
                string binary = Convert.ToString(Convert.ToInt32(num, fromBase: 10), toBase: 2);
                textBox1.Text = binary;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonHex_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "Hex" + "(" + textBox1.Text + ")";
                string num = (textBox1.Text);
                string hexa = Convert.ToString(Convert.ToInt32(num, fromBase: 10), toBase: 16);
                textBox1.Text = hexa.ToString().ToUpper();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonOct_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "Oct" + "(" + textBox1.Text + ")";
                string num = (textBox1.Text);
                string octal = Convert.ToString(Convert.ToInt32(num, fromBase: 10), toBase: 8);
                textBox1.Text = octal;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSinhinv_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                label3.Text = "asinh" + "(" + textBox1.Text + ")";
                textBox1.Text = Convert.ToString(Math.Log(num1 + Math.Sqrt(num1 * num1 + 1)));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCoshinv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            label3.Text = "acosh" + "(" + textBox1.Text + ")";
            textBox1.Text = Convert.ToString(Math.Log(num1 + Math.Sqrt(num1 * num1 - 1)));
        }

        private void buttonTanhinv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            label3.Text = "atanh" + "(" + textBox1.Text + ")";
            textBox1.Text = Convert.ToString(Math.Log((1 + num1) / (1 - num1)) / 2);
        }

        private void buttonSininv_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                if (radioButtonDegrees.Checked)
                {
                    label3.Text = "asinD" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Asin(num1) * 180 / Math.PI);
                }
                else if (radioButtonRadians.Checked)
                {
                    label3.Text = "asinR" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Asin(num1));
                }
                else if (radioButtonGradians.Checked)
                {
                    label3.Text = "asinG" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Asin(num1) * 200.0 / Math.PI);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCosinv_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonDegrees.Checked)
                {
                    label3.Text = "acosD" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Acos(Convert.ToDouble(textBox1.Text)) * Math.PI / 180);
                }
                else if (radioButtonRadians.Checked)
                {
                    label3.Text = "acosR" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Acos(Convert.ToDouble(textBox1.Text)));
                }
                else if (radioButtonGradians.Checked)
                {
                    label3.Text = "acosG" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Acos(Convert.ToDouble(textBox1.Text)) * Math.PI / 200);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTaninv_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonDegrees.Checked)
                {
                    label3.Text = "atanD" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Atan(Convert.ToDouble(textBox1.Text)) * Math.PI / 180);
                }
                else if (radioButtonRadians.Checked)
                {
                    label3.Text = "atanR" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Atan(Convert.ToDouble(textBox1.Text)));
                }
                else if (radioButtonGradians.Checked)
                {
                    label3.Text = "atanG" + "(" + textBox1.Text + ")";
                    textBox1.Text = Convert.ToString(Math.Atan(Convert.ToDouble(textBox1.Text)) * Math.PI / 200);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standerdToolStripMenuItem.Checked = false;
            scientificToolStripMenuItem.Checked = false;
            statisticsToolStripMenuItem.Checked = true;
            panel3.Location = new Point(0, 41);
            this.Width = 278;
            this.Height = 473;
            panel3.Visible = true;
            panel1.Visible = false;
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                item = Convert.ToDouble(textBox2.Text);
                if (textBox2.Text.Contains("e"))
                {
                    listBox1.Items.Add(item.ToString("0.################e+0"));
                }
                else
                {
                    listBox1.Items.Add(item);
                }
                textBox2.Text = string.Empty;
                label2.Text = "Count::" + listBox1.Items.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonSsumx_Click(object sender, EventArgs e)
        {
            try
            {
                double result = 0; int i = 0;
                while (i < listBox1.Items.Count)
                {
                    result = result + Convert.ToDouble(listBox1.Items[i]);
                    i++;
                }
                textBox2.Text = result.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonS0_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("0"))
            {
                textBox2.Text = string.Empty;
                textBox2.Text = textBox2.Text + buttonS0.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + buttonS0.Text;
            }
        }

        private void buttonS1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("0"))
            {
                textBox2.Text = string.Empty;
                textBox2.Text = textBox2.Text + buttonS1.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + buttonS1.Text;
            }
        }

        private void buttonS2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("0"))
            {
                textBox2.Text = string.Empty;
                textBox2.Text = textBox2.Text + buttonS2.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + buttonS2.Text;
            }
        }

        private void buttonS3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("0"))
            {
                textBox2.Text = string.Empty;
                textBox2.Text = textBox2.Text + buttonS3.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + buttonS3.Text;
            }
        }

        private void buttonS4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("0"))
            {
                textBox2.Text = string.Empty;
                textBox2.Text = textBox2.Text + buttonS4.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + buttonS4.Text;
            }
        }

        private void buttonS5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("0"))
            {
                textBox2.Text = string.Empty;
                textBox2.Text = textBox2.Text + buttonS5.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + buttonS5.Text;
            }
        }

        private void buttonS6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("0"))
            {
                textBox2.Text = string.Empty;
                textBox2.Text = textBox2.Text + buttonS6.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + buttonS6.Text;
            }
        }

        private void buttonS7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("0"))
            {
                textBox2.Text = string.Empty;
                textBox2.Text = textBox2.Text + buttonS7.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + buttonS7.Text;
            }
        }

        private void buttonS8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("0"))
            {
                textBox2.Text = string.Empty;
                textBox2.Text = textBox2.Text + buttonS8.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + buttonS8.Text;
            }
        }

        private void buttonS9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("0"))
            {
                textBox2.Text = string.Empty;
                textBox2.Text = textBox2.Text + buttonS9.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + buttonS9.Text;
            }
        }

        private void buttonSClearentry_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            label2.Text = string.Empty;
            listBox1.Items.Clear();
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void buttonSBack_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
            }
            catch (Exception)
            {

                playaudio();
            }
        }

        private void buttonSClear_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void buttonSFe_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Contains("e"))
                {
                    textBox2.Text = Convert.ToDouble(textBox2.Text).ToString();
                }
                else
                {
                    textBox2.Text = Convert.ToDouble(textBox2.Text).ToString("0.################e+0");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    label2.Text = "Count::" + listBox1.Items.Count.ToString();
                }


                else if (e.KeyCode == Keys.Insert)
                {
                    listBox1.Items.Insert(listBox1.SelectedIndex, textBox2.Text);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Insert(listBox1.SelectedIndex, textBox2.Text);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSDot_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Contains("."))
            {
                textBox2.Text = textBox2.Text + buttonSDot.Text;
            }
            else
            {
                playaudio();
            }
        }

        private void buttonSsumxsquare_Click(object sender, EventArgs e)
        {
            try
            {
                double result = 0; int i = 0;
                while (i < listBox1.Items.Count)
                {
                    double add = Convert.ToDouble(listBox1.Items[i]);
                    i++;
                    double result_temp = add * add;
                    result = result_temp + result;
                }
                textBox2.Text = result.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXvar_Click(object sender, EventArgs e)
        {
            try
            {
                double result_temp = 0; int i = 0;
                while (i < listBox1.Items.Count)
                {
                    result_temp = result_temp + Convert.ToDouble(listBox1.Items[i]);
                    i++;
                }
                double result = result_temp / listBox1.Items.Count;
                textBox2.Text = result.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXsquarevar_Click(object sender, EventArgs e)
        {
            try
            {
                double result = 0; int i = 0;
                while (i < listBox1.Items.Count)
                {
                    double add = Convert.ToDouble(listBox1.Items[i]);
                    i++;
                    double result_temp = add * add;
                    result = result_temp + result;
                }
                double result_final = result / listBox1.Items.Count;
                textBox2.Text = result_final.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSd_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0; int j = 0;
                double total_itemvalue = 0;
                double average = 0;
                while (i < listBox1.Items.Count)
                {
                    total_itemvalue = total_itemvalue + Convert.ToDouble(listBox1.Items[i]);
                    i++;
                }
                average = total_itemvalue / listBox1.Items.Count;

                double variance = 0;
                double pre_sd = 0;

                double Final_pre_sd = 0;
                double Mid_pre_sd = 0;
                double result = 0;


                while (j < listBox1.Items.Count)
                {
                    variance = Convert.ToDouble(listBox1.Items[j]) - average;

                    pre_sd = Math.Pow(variance, 2);
                    Mid_pre_sd = Mid_pre_sd + pre_sd;
                    j++;
                }
                Final_pre_sd = Mid_pre_sd / listBox1.Items.Count; ;
                result = Math.Sqrt(Final_pre_sd);
                textBox2.Text = result.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSSs_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = Convert.ToString((Convert.ToDouble(textBox2.Text) * -1));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSMclear_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = null;
                mem = null;
                MessageBox.Show("Memory Cleared!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSExp_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = Convert.ToDouble(textBox2.Text).ToString("0.0e+#'0'");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSMresult_Click(object sender, EventArgs e)
        {
            try
            {
                if (mem_store != null)
                {
                    textBox2.Text = Convert.ToString(mem_store);

                }
                else if (mem_store == null)
                {
                    textBox2.Text = Convert.ToString(mem);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSMstore_Click(object sender, EventArgs e)
        {
            try
            {
                mem_store = Convert.ToDouble(textBox2.Text);
                MessageBox.Show("Memory Stored!");
                textBox2.Text = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSMminus_Click(object sender, EventArgs e)
        {
            try
            {
                mem = mem - Convert.ToDouble(textBox2.Text);
                MessageBox.Show("Memory Substracted!");
                textBox2.Text = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSMplus_Click(object sender, EventArgs e)
        {
            try
            {
                mem = mem + Convert.ToDouble(textBox2.Text);
                MessageBox.Show("Memory Added!");
                textBox2.Text = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSsigmaminus_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0; int j = 0;
                double total_itemvalue = 0;
                double average = 0;
                while (i < listBox1.Items.Count)
                {
                    total_itemvalue = total_itemvalue + Convert.ToDouble(listBox1.Items[i]);
                    i++;
                }
                average = total_itemvalue / listBox1.Items.Count;

                double variance = 0;
                double pre_sd = 0;

                double Final_pre_sd = 0;
                double Mid_pre_sd = 0;
                double result = 0;


                while (j < listBox1.Items.Count)
                {
                    variance = Convert.ToDouble(listBox1.Items[j]) - (average);

                    pre_sd = Math.Pow(variance, 2);
                    Mid_pre_sd = Mid_pre_sd + pre_sd;
                    j++;
                }
                Final_pre_sd = Mid_pre_sd / (listBox1.Items.Count - 1);
                result = Math.Sqrt(Final_pre_sd);
                textBox2.Text = result.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator created by SAJEEB CHADAN.\nIt's an open source application.\nThanks to .NET and specially Microsoft for such an incredible framework.\n\nDedicated to my Father.");
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome\n\n\nTo use Calculator you need to have the knowledge of math.\nFor addition::\n\nEnter a number;\nThen press '+';\nThen enter another number;\nThen press '='.\n\nIn this Calculator project you can do those this without clicking on button. Sust simply use your keyboard's numpad (Available only for basic operation.).\n\n\nThank you.");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == true && textBox2.Visible == false)
            {
                copy = textBox1.Text;
                textBox1.Text = string.Empty;
            }
            else if (textBox2.Visible == true && textBox1.Visible == false)
            {
                copy = textBox2.Text;
                textBox2.Text = string.Empty;
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == true && textBox2.Visible == false)
            {
                textBox1.Text = copy;
            }
            else if (textBox2.Visible == true && textBox1.Visible == false)
            {
                textBox2.Text = copy;
            }
        }

        private void textBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                if (textBox2.Text.Equals("0"))
                {
                    textBox2.Text = string.Empty;
                    textBox2.Text = textBox2.Text + buttonS0.Text;
                }
                else
                {
                    textBox2.Text = textBox2.Text + buttonS0.Text;
                }
            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                if (textBox2.Text.Equals("0"))
                {
                    textBox2.Text = string.Empty;
                    textBox2.Text = textBox2.Text + buttonS1.Text;
                }
                else
                {
                    textBox2.Text = textBox2.Text + buttonS1.Text;
                }
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                if (textBox2.Text.Equals("0"))
                {
                    textBox2.Text = string.Empty;
                    textBox2.Text = textBox2.Text + buttonS2.Text;
                }
                else
                {
                    textBox2.Text = textBox2.Text + buttonS2.Text;
                }
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                if (textBox2.Text.Equals("0"))
                {
                    textBox2.Text = string.Empty;
                    textBox2.Text = textBox2.Text + buttonS3.Text;
                }
                else
                {
                    textBox2.Text = textBox2.Text + buttonS3.Text;
                }
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                if (textBox2.Text.Equals("0"))
                {
                    textBox2.Text = string.Empty;
                    textBox2.Text = textBox2.Text + buttonS4.Text;
                }
                else
                {
                    textBox2.Text = textBox2.Text + buttonS4.Text;
                }
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                if (textBox2.Text.Equals("0"))
                {
                    textBox2.Text = string.Empty;
                    textBox2.Text = textBox2.Text + buttonS5.Text;
                }
                else
                {
                    textBox2.Text = textBox2.Text + buttonS5.Text;
                }
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                if (textBox2.Text.Equals("0"))
                {
                    textBox2.Text = string.Empty;
                    textBox2.Text = textBox2.Text + buttonS6.Text;
                }
                else
                {
                    textBox2.Text = textBox2.Text + buttonS6.Text;
                }
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                if (textBox2.Text.Equals("0"))
                {
                    textBox2.Text = string.Empty;
                    textBox2.Text = textBox2.Text + buttonS7.Text;
                }
                else
                {
                    textBox2.Text = textBox2.Text + buttonS7.Text;
                }
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                if (textBox2.Text.Equals("0"))
                {
                    textBox2.Text = string.Empty;
                    textBox2.Text = textBox2.Text + buttonS8.Text;
                }
                else
                {
                    textBox2.Text = textBox2.Text + buttonS8.Text;
                }
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                if (textBox2.Text.Equals("0"))
                {
                    textBox2.Text = string.Empty;
                    textBox2.Text = textBox2.Text + buttonS9.Text;
                }
                else
                {
                    textBox2.Text = textBox2.Text + buttonS9.Text;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    item = Convert.ToDouble(textBox2.Text);
                    if (textBox2.Text.Contains("e"))
                    {
                        listBox1.Items.Add(item.ToString("0.################e+0"));
                    }
                    else
                    {
                        listBox1.Items.Add(item);
                    }
                    textBox2.Text = string.Empty;
                    label2.Text = "Count::" + listBox1.Items.Count.ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                if (textBox1.Visible == true && textBox2.Visible == false)
                {
                    copy = textBox1.Text;
                    textBox1.Text = string.Empty;
                }
                else if (textBox2.Visible == true && textBox1.Visible == false)
                {
                    copy = textBox2.Text;
                    textBox2.Text = string.Empty;
                }
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                if (textBox1.Visible == true && textBox2.Visible == false)
                {
                    textBox1.Text = copy;
                }
                else if (textBox2.Visible == true && textBox1.Visible == false)
                {
                    textBox2.Text = copy;
                }
            }
            else if (e.KeyCode == Keys.Back)
            {
                try
                {
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
                }
                catch (Exception)
                {

                    playaudio();
                }
            }

        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                if (textBox1.Text.Equals("0") || (isOpPerformed))

                    textBox1.Text = string.Empty;
                isOpPerformed = false;
                textBox1.Text = textBox1.Text + button0.Text;
            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                if (textBox1.Text.Equals("0") || (isOpPerformed))

                    textBox1.Text = string.Empty;
                isOpPerformed = false;
                textBox1.Text = textBox1.Text + button1.Text;
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                if (textBox1.Text.Equals("0") || (isOpPerformed))

                    textBox1.Text = string.Empty;
                isOpPerformed = false;
                textBox1.Text = textBox1.Text + button2.Text;
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                if (textBox1.Text.Equals("0") || (isOpPerformed))

                    textBox1.Text = string.Empty;
                isOpPerformed = false;
                textBox1.Text = textBox1.Text + button3.Text;
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                if (textBox1.Text.Equals("0") || (isOpPerformed))

                    textBox1.Text = string.Empty;
                isOpPerformed = false;
                textBox1.Text = textBox1.Text + button4.Text;
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                if (textBox1.Text.Equals("0") || (isOpPerformed))

                    textBox1.Text = string.Empty;
                isOpPerformed = false;
                textBox1.Text = textBox1.Text + button5.Text;
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                if (textBox1.Text.Equals("0") || (isOpPerformed))

                    textBox1.Text = string.Empty;
                isOpPerformed = false;
                textBox1.Text = textBox1.Text + button6.Text;
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                if (textBox1.Text.Equals("0") || (isOpPerformed))

                    textBox1.Text = string.Empty;
                isOpPerformed = false;
                textBox1.Text = textBox1.Text + button7.Text;
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                if (textBox1.Text.Equals("0") || (isOpPerformed))

                    textBox1.Text = string.Empty;
                isOpPerformed = false;
                textBox1.Text = textBox1.Text + button8.Text;
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                if (textBox1.Text.Equals("0") || (isOpPerformed))

                    textBox1.Text = string.Empty;
                isOpPerformed = false;
                textBox1.Text = textBox1.Text + button9.Text;
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                if (textBox1.Text.Contains("."))
                {
                    playaudio();
                }
                else if (!textBox1.Text.Contains(".") || (isOpPerformed))
                {
                    textBox1.Text = textBox1.Text + buttonDot.Text;
                    isOpPerformed = false;
                }
            }
            else if (e.KeyCode == Keys.Back)
            {
                try
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
                catch (Exception)
                {

                    playaudio();
                }
            }
            else if (e.KeyCode == Keys.Add)
            {
                try
                {
                    if (num1 != 0)
                    {
                        button25.PerformClick();
                        isOpPerformed = true;
                        op = "+";
                        label3.Text = label3.Text + textBox1.Text + buttonSum.Text;
                    }

                    else
                    {
                        op = "+";
                        num1 = Convert.ToDouble(textBox1.Text);
                        isOpPerformed = true;
                        label3.Text = label3.Text + textBox1.Text + buttonSum.Text;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message); label3.Text = label3.Text + textBox1.Text;
                }
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                try
                {
                    button25.PerformClick();
                    isOpPerformed = true;
                    op = "-";
                    label3.Text = label3.Text + textBox1.Text + buttonSub.Text;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message); label3.Text = label3.Text + textBox1.Text;
                }
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                try
                {
                    label3.Text = label3.Text + textBox1.Text + buttonMul.Text;
                    button25.PerformClick();
                    op = "*";
                    isOpPerformed = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message); label3.Text = label3.Text + textBox1.Text;
                }
            }
            else if (e.KeyCode == Keys.Divide)
            {
                try
                {
                    label3.Text = label3.Text + textBox1.Text + buttonDiv.Text;
                    button25.PerformClick();
                    op = "/";
                    isOpPerformed = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message); label3.Text = label3.Text + textBox1.Text;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    switch (op)
                    {

                        case "+":
                            textBox1.Text = (num1 + Convert.ToDouble(textBox1.Text)).ToString();
                            break;

                        case "-":
                            textBox1.Text = (num1 - Convert.ToDouble(textBox1.Text)).ToString();
                            break;

                        case "*":
                            textBox1.Text = (num1 * Convert.ToDouble(textBox1.Text)).ToString();
                            break;

                        case "/":
                            textBox1.Text = (num1 / Convert.ToDouble(textBox1.Text)).ToString();
                            if (textBox1.Text.Equals("NaN") || textBox1.Text.Equals("Infinity"))
                            {
                                playaudio();
                            }

                            break;
                        case "Exp":

                            result = num3 * (Math.Pow(10, Convert.ToDouble(textBox1.Text)));
                            textBox1.Text = Convert.ToString(result);
                            break;
                        case "Mod":
                            num2 = Convert.ToDouble(textBox1.Text);
                            label3.Text = label3.Text + num2;
                            result = num3 % num2;
                            textBox1.Text = Convert.ToString(result);
                            break;

                        case "Rootn":
                            num2 = Convert.ToDouble(textBox1.Text);
                            result = Math.Pow(num3, 1 / num2);
                            textBox1.Text = Convert.ToString(result);
                            break;

                        case "^":
                            num2 = Convert.ToDouble(textBox1.Text);
                            label3.Text = label3.Text + num2;
                            result = Math.Pow(num3, num2);
                            textBox1.Text = Convert.ToString(result);
                            break;

                        default:
                            break;
                    }
                    num1 = Convert.ToDouble(textBox1.Text);
                    op = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                if (textBox1.Visible == true && textBox2.Visible == false)
                {
                    copy = textBox1.Text;
                    textBox1.Text = string.Empty;
                }
                else if (textBox2.Visible == true && textBox1.Visible == false)
                {
                    copy = textBox2.Text;
                    textBox2.Text = string.Empty;
                }
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                if (textBox1.Visible == true && textBox2.Visible == false)
                {
                    textBox1.Text = copy;
                }
                else if (textBox2.Visible == true && textBox1.Visible == false)
                {
                    textBox2.Text = copy;
                }
            }
            else if (e.KeyCode == Keys.C)
            {
                textBox1.Clear();
                textBox1.Text = "0";
                label3.Text = string.Empty;
                num1 = 0;
                num2 = 0;
                num3 = 0;
                mem = null;
                mem_store = null;
                textBox1.Focus();
            }
        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://facebook.com/sajeeb.chandan");
        }
    }
}
