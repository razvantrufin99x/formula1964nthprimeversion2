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




        public int Factorial(int x)
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

       

       
        public double doublewillansnthprimeformula1964(int x)
        {
            int n = x;
            double c = 0;
            double nthprime = 0;

            for (int i = 1; i <= Math.Pow(2, n); i++)
            {

                this.textBox2.Text += "\r\n";

                for (int j = 1; j <= i; j++)
                {
                    c += Math.Pow((Math.Cos(Math.PI) * ((Factorial(j - 1) + 1) / j)), 2);

                    this.textBox2.Text += "\r\t";
                    this.textBox2.Text += j.ToString();
                    this.textBox2.Text += "\r\t";
                    this.textBox2.Text += c.ToString();
                    Refresh();
                    
                }
                this.textBox2.Text += "\r\n";
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
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "nth number -> " + "prime -> " + "prime/3+1 -> " + "prime/3+1.5 -> " + "ceiling(prime/3+1.5) -> " + "floor(prime/3+1.5) -> " + "difference";
            this.textBox1.Text += "\r\n";
            for (int i = 0; i < 5; i++)
            {
                this.textBox1.Text += i.ToString();

                this.textBox1.Text += "\r\t";
                this.textBox1.Text += doublewillansnthprimeformula1964(i).ToString();

                this.textBox1.Text += "\r\t";
                this.textBox1.Text += (doublewillansnthprimeformula1964(i) / 3 + 1).ToString();


                this.textBox1.Text += "\r\t";
                this.textBox1.Text += (doublewillansnthprimeformula1964(i) / 3 + 1.5).ToString();


                this.textBox1.Text += "\r\t";
                this.textBox1.Text += Math.Ceiling(doublewillansnthprimeformula1964(i) / 3 + 1.5).ToString();

                this.textBox1.Text += "\r\t";
                this.textBox1.Text += Math.Ceiling(doublewillansnthprimeformula1964(i) / 3 + 1.5).ToString();

                this.textBox1.Text += "\r\t";
                this.textBox1.Text += ((Math.Ceiling(doublewillansnthprimeformula1964(i) / 3 + 1.5)) - (Math.Floor(doublewillansnthprimeformula1964(i) / 3 + 1.5))).ToString();

                this.textBox1.Text += "\r\n";
            }

        }
    }
}
