using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба1винда
{
    public partial class Form4PROG2 : Form
    {
        public static float A;
        public static float B;
        public Form4PROG2()
        {
            InitializeComponent();
            Text = "Лабораторная №1 windows form";// Задаем название форме
            this.StartPosition = FormStartPosition.CenterScreen; // Задаем расположение формы в центре экрана
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            int c;
            int d;



            if ((float.TryParse(textBox1.Text, out A))) // TryParse преобразует строковое представление числа в эквивалентное ему число c плавающей запятой со знаком. Возвращает значение, указывающее, успешно ли выполнена операция.
            {
                c = 0;
            }
            else
            {
                MessageBox.Show($"Вы не ввели корректное значение А!");
                this.Close();

            }

            if ((float.TryParse(textBox2.Text, out B))) // TryParse преобразует строковое представление числа в эквивалентное ему число c плавающей запятой со знаком. Возвращает значение, указывающее, успешно ли выполнена операция.

                d = 0;
            
            else
            {
                MessageBox.Show($"Вы ввели некорректное значение В!");
                this.Close();
            }

            if (A > B)
            {
                MessageBox.Show("Вы неверно указали промежуток");
                this.Close();
            }
            c = (int)A;
            d = (int)B;

            if (c <= A)
                c = (int)A + 1;
            if (d < B)
                d = (int)B + 1;


            if ((c == d - 1) | (c == d))
            {
                textBox3.Text = count.ToString();

            }

            else if ((((d % c == 0) & (d > c)) | (d > c)) & (c > 0))
            {
               


                while (c < d)
                {
                    d -= 1;
                    if ((d % 13 == 0) & (d % 5 == 0))
                        count += d;
                    

                    
                   
                }

                textBox3.Text = count.ToString();
            }

            else if ((((d % c == 0) & (d > c)) | (d > c)) & (c < 0))
            {
                


                while (c < d)
                {
                    d -= 1;

                    if ((d % 13 == 0) & (d % 5 == 0))
                        count += d;

                }

                textBox3.Text = count.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3PROG newForm = new Form3PROG();// Bторая форма называется Form2, поэтому сначала мы создаем объект данного класса, а потом для его отображения на экране вызываем метод Show
            newForm.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5PROG2 newForm = new Form5PROG2();// Bторая форма называется Form2, поэтому сначала мы создаем объект данного класса, а потом для его отображения на экране вызываем метод Show
            newForm.Show();
            this.Close();
        }
    }
}
