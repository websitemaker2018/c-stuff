using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //a number is 5
            var numberboi = 0;
            var isitboi = false;
    //var number1 "user input"
   // var number2 "user input"

            for (int i = 0; i < 100000; i++)
            {
                if (numberboi + 5 * 2 == numberboi * 2 + 5)
                //  if (numberboi + number1 * number2 == numberboi * number2 + number1)
                {

                    isitboi = true;
                }
                else
                {
                    numberboi = numberboi + 1;

                }
            }
                if (isitboi == true)
                {
                    label1.Text = "Number: " + numberboi + "!";
                }

                else if(isitboi == false)
                {
                    label1.Text = "Welp, No number found. :(";
                }
            
        }
    }
}
