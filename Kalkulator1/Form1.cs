using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Jace;
using static System.Net.Mime.MediaTypeNames;

namespace Kalkulator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonLn.Visible = false;
            buttonLog.Visible = false;
            buttonSilnia.Visible = false;
            buttonEXP.Visible = false;
            buttonTAN.Visible = false;
            buttonCOS.Visible = false;
            buttonSIN.Visible = false;
            buttonPierwiastek.Visible = false;
            buttonlnv.Visible = false;
            buttonPI.Visible = false;
            buttonE.Visible = false;
            button_wtf.Visible = false;
            button10.Visible = false;
            buttonRan.Visible = false;
        }

        bool nowa_liczba = true;
        private string ANS = "0";
        private bool isLnMode = false;
        private bool islnv = false;



        private void button0_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "0";
                nowa_liczba = false;
            }
            else
                textBox1.Text += "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "1";
                nowa_liczba = false;
            }
            else
                textBox1.Text += "1";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "2";
                nowa_liczba = false;
            }
            else
                textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "3";
                nowa_liczba = false;
            }
            else
                textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "4";
                nowa_liczba = false;
            }
            else
                textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "5";
                nowa_liczba = false;
            }
            else
                textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "6";
                nowa_liczba = false;
            }
            else
                textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "7";
                nowa_liczba = false;
            }
            else
                textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "8";
                nowa_liczba = false;
            }
            else
                textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "9";
                nowa_liczba = false;
            }
            else
                textBox1.Text += "9";
        }

        private void buttonWynik_Click(object sender, EventArgs e)
        {
            string tekst = textBox1.Text;
            CalculationEngine engine = new CalculationEngine();

            if (isLnMode && tekst.Substring(tekst.Length - 1) != ")")
            {
                textBox1.Text += ")";
                isLnMode = false;
            }
            string text = textBox1.Text;
            ListViewItem item = new ListViewItem(text);
            item.SubItems.Add(textBox1.ToString());
            listView1.Items.Add(item);

            engine.AddFunction("f", Factorial);
            engine.AddFunction("EXP", (args) => Math.Exp(Convert.ToDouble(args[0])));
            engine.AddFunction("^", (args) => Math.Pow(Convert.ToDouble(args[0]), Convert.ToDouble(args[1])));
            text = text.Replace("e", Math.E.ToString());
            text = text.Replace("kocham πwo", "π");
            text = text.Replace("π", Math.PI.ToString());
            text = text.Replace("√", "sqrt(");
            text = text.Replace("%", "*0,01");
            text = text.Replace("ln(", "loge(");
            text = text.Replace("log(", "log10(");
            text = text.Replace("!", "f(");
            text = text.Replace(".", ",");



            double result = engine.Calculate(text);
            textBox1.Text = result.ToString();
            ANS = result.ToString();
            nowa_liczba = true;
        }

        private double Factorial(double x)
        {
            if (x < 0)
            {
                throw new ArgumentException("Silnia jest możliwa tylko dla liczb dodatnich");
            }

            if (x == 0)
            {
                return 1;
            }

            double result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }

            return result;
        }


        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "+";
                nowa_liczba = false;
            }
            else
            {

                textBox1.Text += "+";
            }

        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "-";
                nowa_liczba = false;
            }
            else
            {

                textBox1.Text += "-";
            }

        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "*";
                nowa_liczba = false;
            }
            else
            {

                textBox1.Text += "*";
            }

        }

        private void buttonDzielenie_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "/";
                nowa_liczba = false;
            }
            else
            {

                textBox1.Text += "/";
            }
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            nowa_liczba = true;
        }

        private void buttonProcent_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "%";
                nowa_liczba = false;
            }
            else
                textBox1.Text += "%";
        }

        private void buttonLB_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "(";
                nowa_liczba = false;
            }
            else
                textBox1.Text += "(";
        }

        private void buttonRB_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = ")";
                nowa_liczba = false;
            }
            else
            {
                if (isLnMode == true)
                {
                    isLnMode = false;
                }
                textBox1.Text += ")";
            }

        }

        private void buttonANS_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Brak zapisanej odpowiedzi", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox1.Text += ANS.ToString();
                nowa_liczba = false;
            }
        }

        private void buttonNaukowy_Click(object sender, EventArgs e)
        {
            buttonLn.Visible = !buttonLn.Visible;
            buttonLog.Visible = !buttonLog.Visible;
            buttonSilnia.Visible = !buttonSilnia.Visible;
            buttonEXP.Visible = !buttonEXP.Visible;
            buttonTAN.Visible = !buttonTAN.Visible;
            buttonCOS.Visible = !buttonCOS.Visible;
            buttonSIN.Visible = !buttonSIN.Visible;
            buttonPierwiastek.Visible = !buttonPierwiastek.Visible;
            buttonlnv.Visible = !buttonlnv.Visible;
            buttonPI.Visible = !buttonPI.Visible;
            buttonE.Visible = !buttonE.Visible;
            button_wtf.Visible = !button_wtf.Visible;
            if (islnv == true)
            {
                button10.Visible = !button10.Visible;
                buttonRan.Visible = !buttonRan.Visible;
            }
            

        }

        private void buttonLn_Click(object sender, EventArgs e)
        {
            //ln-> e^x
            if (buttonLn.Text == "e^x")
            {
                if (nowa_liczba)
                {
                    textBox1.Text = "e^";
                    nowa_liczba = false;
                }
                else
                    textBox1.Text += "e^";
            }
            else
            {
                isLnMode = true;
                if (nowa_liczba)
                {
                    textBox1.Text = "ln(";
                    nowa_liczba = false;
                }
                else
                    textBox1.Text += "ln(";
            }

            

        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (buttonLog.Text == "*10^x")
            {
                if (nowa_liczba)
                {
                    textBox1.Text = "10^";
                    nowa_liczba = false;
                }
                else
                    textBox1.Text += "*10^";
            }
            else
            {
                isLnMode = true;
                if (nowa_liczba)
                {
                    textBox1.Text = "log(";
                    nowa_liczba = false;
                }
                else
                    textBox1.Text += "log(";
            }
        }

        private void buttonSilnia_Click(object sender, EventArgs e)
        {
            if (buttonSilnia.Text == "x^2")
            {
                if (nowa_liczba)
                {
                    textBox1.Text = "0^2";
                    nowa_liczba = false;
                }
                else
                    textBox1.Text += "^2";
            }
            else
            {
                isLnMode = true;
                if (nowa_liczba)
                {
                    textBox1.Text = "!";
                    nowa_liczba = false;
                }
                else
                    textBox1.Text += "!";
            }
        }

        private void buttonEXP_Click(object sender, EventArgs e)
        {
            isLnMode = true;
            if (nowa_liczba)
            {
                textBox1.Text = "EXP(";
                nowa_liczba = false;
            }

            else
                textBox1.Text += "EXP(";
        }

        private void buttonTAN_Click(object sender, EventArgs e)
        {
            isLnMode = true;
            if (buttonTAN.Text == "tan")
            {
                if (nowa_liczba)
                {
                    textBox1.Text = "tan(";
                    nowa_liczba = false;
                }
                else
                    textBox1.Text += "tan(";
            }
            else
            {
                if (nowa_liczba)
                {
                    textBox1.Text = "atan(";
                    nowa_liczba = false;
                }
                else
                    textBox1.Text += "atan(";
            }
        }

        private void buttonCOS_Click(object sender, EventArgs e)
        {
            isLnMode = true;
            if (buttonCOS.Text == "cos")
            {
                if (nowa_liczba)
                {
                    textBox1.Text = "cos(";
                    nowa_liczba = false;
                }
                else
                    textBox1.Text += "cos(";
            }
            else
            {
                if (nowa_liczba)
                {
                    textBox1.Text = "acos(";
                    nowa_liczba = false;
                }
                else
                    textBox1.Text += "acos(";
            }
        }

        private void buttonSIN_Click(object sender, EventArgs e)
        {
            isLnMode = true;
            if (buttonSIN.Text == "sin")
            {
                if (nowa_liczba)
                {
                    textBox1.Text = "sin(";
                    nowa_liczba = false;
                }
                else
                    textBox1.Text += "sin(";
            }
            else
            {
                if (nowa_liczba)
                {
                    textBox1.Text = "asin(";
                    nowa_liczba = false;
                }
                else
                    textBox1.Text += "asin(";
            }
        }

        private void buttonPierwiastek_Click(object sender, EventArgs e)
        {
            isLnMode = true;
            if (nowa_liczba)
            {
                textBox1.Text = "√";
                nowa_liczba = false;
            }
            else
            {
                textBox1.Text += "√";

            }
        }

        private void buttonlnv_Click(object sender, EventArgs e)
        {
            
            islnv = !islnv;

            if (islnv)
            {
                buttonSIN.Text = "asin";
                buttonCOS.Text = "acos";
                buttonTAN.Text = "atan";
                buttonLn.Text = "e^x";
                buttonLog.Text = "*10^x";
                buttonSilnia.Text = "x^2";
                buttonRan.Visible = true;
                button10.Visible = true;

            }
            else
            {
                buttonSIN.Text = "sin";
                buttonCOS.Text = "cos";
                buttonTAN.Text = "tan";
                buttonLn.Text = "ln";
                buttonLog.Text = "log";
                buttonSilnia.Text = "!";
                buttonRan.Visible = false;
                button10.Visible = false;

            }

        }

        private void buttonPI_Click(object sender, EventArgs e)
        {

            if (nowa_liczba)
            {
                textBox1.Text = "π";
                nowa_liczba = false;
            }
            else
            {
                textBox1.Text += "π";

            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "e";
                nowa_liczba = false;
            }
            else
            {
                textBox1.Text += "e";

            }
        }

        private void button_wtf_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = "^";
                nowa_liczba = false;
            }
            else
            {
                textBox1.Text += "^";

            }
        }

        private void buttonWHistorie_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void buttonkropka_Click(object sender, EventArgs e)
        {
            if (nowa_liczba)
            {
                textBox1.Text = ".";
                nowa_liczba = false;
            }
            else
            {

                textBox1.Text += ".";
            }
        }

        private bool isReplaced = false;
        private void button10_Click(object sender, EventArgs e)
        {
            if (isReplaced)
            {
                textBox1.Text = textBox1.Text.Replace("kocham πwo", "π");
                isReplaced = false;
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("π", "kocham πwo");
                isReplaced = true;
            }

        }

        private void buttonRan_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (nowa_liczba)
            {
                string randomowa_liczba = random.NextDouble().ToString("0.#######");
                textBox1.Text = randomowa_liczba;
                nowa_liczba = false;
            }
            else
            {
                textBox1.Text += random.NextDouble().ToString("0.#######");
            }
        }
    }
}