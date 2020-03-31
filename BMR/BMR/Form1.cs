using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace BMR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.Tag = 1;
            checkBox2.Tag = 2;
        }

        private void Oblicz_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked) && (checkBox2.Checked))
            {

            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Zaznacz plec";
                if (checkBox1.Checked)
                {
                    if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != ""))
                    {


                        label1.ForeColor = Color.Black;
                        int waga = Convert.ToInt32(textBox1.Text);
                        float wzrost = Convert.ToSingle(textBox2.Text);
                        float wiek = Convert.ToSingle(textBox3.Text);
                        double bmi = (9.99 * waga) + (6.25 * wzrost) - (4.92 * wiek) - 161;
                        label1.Text = bmi.ToString();

                    }
                    else
                    {
                        label1.ForeColor = Color.Red;
                        label1.Text = "Brak Danych";
                    }
                }
                else
                {
                 
                }


                if (checkBox2.Checked)
                {
                    if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != ""))
                    {


                        label1.ForeColor = Color.Black;
                        int waga = Convert.ToInt32(textBox1.Text);
                        float wzrost = Convert.ToSingle(textBox2.Text);
                        float wiek = Convert.ToSingle(textBox3.Text);
                        double bmi = (9.99 * waga) + (6.25 * wzrost) - (4.92 * wiek) + 5;
                        label1.Text = bmi.ToString();

                    }
                    else
                    {
                        label1.ForeColor = Color.Red;
                        label1.Text = "Brak Danych";
                    }
                }
                else
                {

                }
            }  


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!bChecking)
                SelectingCheckBox(1);
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!bChecking)
                SelectingCheckBox(2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("prosze podawac tylko cyfry");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("prosze podawac tylko cyfry");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("prosze podawac tylko cyfry");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
        }

        bool bChecking;
        private void SelectingCheckBox(int myTag)
        {
            int numberChecked = 0;
            CheckBox[] array = new CheckBox[] { checkBox1, checkBox2, };
            for (int i = 0; i < array.Length; i++)
            {
                bChecking = true;
                if (Convert.ToInt32(array[i].Tag) == myTag)
                    array[i].Checked = true;
                else
                    array[i].Checked = false;
            }
            bChecking = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}

