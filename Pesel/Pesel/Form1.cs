using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Pesel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 11)
            {
                string P = textBox1.Text;
                int d = P.Length;
                int [] a = P.Select(g => Convert.ToInt32(g.ToString())).ToArray();
                int wz = (1 * a[0]) + (3 * a[1]) + (7 * a[2]) + (9 * a[3]) + (1 * a[4]) + (3 * a[5]) + (7 * a[6]) + (9 * a[7]) + (1 * a[8]) + (3 * a[9]);
                string B = Convert.ToString(wz);
                int c = B.Length;
                int[] h = B.Select(j => Convert.ToInt32(j.ToString())).ToArray();
                int u = h.Last();
                int q = 10 - u;
                string V = Convert.ToString(q);
                label3.Text = Convert.ToString(h[1]) + " Ostatnia cyfra wyniku";
                label4.Text = Convert.ToString(a[10]) + " Ostatnia cyfra numeru Pesel";



                 
                if (q == a[10])
                {


                    MessageBox.Show(V + " Obliczona wartość ze wzoru");
                    label2.Text = "Pesel Poprawny";
                }
                else
                {
                    MessageBox.Show(B + " Obliczona wartość ze wzoru");
                    label2.Text = "Pesel Błędny";
                }
            }
            else
            {
                label2.Text = "Za krótki pesel";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 11;
            
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
