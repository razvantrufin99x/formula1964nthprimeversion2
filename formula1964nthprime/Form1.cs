using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formula1964nthprime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        //formula for primes ?
        //c.p. willans , 1964

        public string DEBUGMODEON = "RUNMODEON";
        public bool isFirstRun = true;

        public static Int64 Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        //generate factorial of n numbers and save them in a list
       public List<Int64> Factoriale = new List<Int64>();

        public void runNFactorials(int N)
        {
            if (DEBUGMODEON == "DEIGNMODEISON")
            {

                for (int i = 0; i <= N; i++)
                {
                    Factoriale.Add(Factorial(i));
                }
            }
        }
        public void printListToTextBox(ref TextBox t, ref List<Int64> fint)
        {
            if (DEBUGMODEON == "DEBUGISON")
            {
                for (int i = 0; i < fint.Count; i++)
                {
                    t.Text += "Factoriale.Add(";
                    t.Text += fint[i];
                    t.Text += ");\r\n";
                }
            }
        }
        public double doublewillansnthprimeformula1964(int x)
        {
            int n = x;
            double c = 0;
            double nthprime = 0;
            double cospi = Math.Cos(Math.PI);

            for (int i = 1; i <= Math.Pow(2, n); i++)
            {
                if (DEBUGMODEON == "DEBUGISON")
                {
                    this.textBox2.Text += "\r\n";
                }
                for (int j = 1; j <= i; j++)
                {

                    //OPTIMISATION ARE ON 

                    // c += Math.Pow((Math.Cos(Math.PI) * ((Factorial(j - 1) + 1) / j)), 2);
                    // c += Math.Pow((Math.Cos(Math.PI) * ((Factoriale[j-1] + 1) / j)), 2);
                    
                        c += Math.Pow((cospi * ((Factoriale[j - 1] + 1) / j)), 2);
                    
                    if (DEBUGMODEON == "DEBUGISON") { 
                        this.textBox2.Text += "\r\t";
                        this.textBox2.Text += j.ToString();
                        this.textBox2.Text += "\r\t";
                        this.textBox2.Text += c.ToString();
                    Refresh();
                    }

                }
                if (DEBUGMODEON == "DEBUGISON")
                {
                    this.textBox2.Text += "\r\n";
                }
                try
                {
                    nthprime += Math.Pow((n / c), (1 / n));
                }
                catch { };
                   // c = 0;
            }
            return 1 + nthprime;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            //run this just one time 
            if (this.isFirstRun == true)
            {
                addFactorialeForSpeedUp();
                this.isFirstRun = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "nth number -> " + "prime -> " + "prime/3+1 -> " + "prime/3+1.5 -> " + "ceiling(prime/3+1.5) -> " + "floor(prime/3+1.5) -> " + "difference";
            this.textBox1.Text += "\r\n";

            //!! MORE THEN 5 WILL CRUSH

            for (int i = 0; i < 5; i++)
            {
                this.textBox1.Text += i.ToString();

                this.textBox1.Text += "\r\t";
                this.textBox1.Text += doublewillansnthprimeformula1964(i).ToString();

                this.textBox1.Text += "\r\t";
                this.textBox1.Text += (doublewillansnthprimeformula1964(i) / 3 + 1).ToString();
                if (DEBUGMODEON == "DEBUGISON")
                {

                    this.textBox1.Text += "\r\t";
                    this.textBox1.Text += (doublewillansnthprimeformula1964(i) / 3 + 1.5).ToString();


                    this.textBox1.Text += "\r\t";
                    this.textBox1.Text += Math.Ceiling(doublewillansnthprimeformula1964(i) / 3 + 1.5).ToString();

                    this.textBox1.Text += "\r\t";
                    this.textBox1.Text += Math.Ceiling(doublewillansnthprimeformula1964(i) / 3 + 1.5).ToString();

                    this.textBox1.Text += "\r\t";
                    this.textBox1.Text += ((Math.Ceiling(doublewillansnthprimeformula1964(i) / 3 + 1.5)) - (Math.Floor(doublewillansnthprimeformula1964(i) / 3 + 1.5))).ToString();
                }
                this.textBox1.Text += "\r\n";
            }

        }

        public void addFactorialeForSpeedUp()
        {

            //self generated code used here 
            Factoriale.Add(1);
            Factoriale.Add(1);
            Factoriale.Add(2);
            Factoriale.Add(6);
            Factoriale.Add(24);
            Factoriale.Add(120);
            Factoriale.Add(720);
            Factoriale.Add(5040);
            Factoriale.Add(40320);
            Factoriale.Add(362880);
            Factoriale.Add(3628800);
            Factoriale.Add(39916800);
            Factoriale.Add(479001600);
            Factoriale.Add(6227020800);
            Factoriale.Add(87178291200);
            Factoriale.Add(1307674368000);
            Factoriale.Add(20922789888000);
            Factoriale.Add(355687428096000);
            Factoriale.Add(6402373705728000);
            Factoriale.Add(121645100408832000);
            Factoriale.Add(2432902008176640000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DEBUGMODEON == "DESIGNMODEISON")
            {
                runNFactorials(25);
                printListToTextBox(ref textBox1, ref Factoriale);
            }
        }
    }
}

