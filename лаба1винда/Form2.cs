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
    public partial class Form3PROG : Form
    {
        public static int n;
        public static float A;
        public static float B;
        public static int counter;// счетчик для первой программы
        public static int l3;
        public static int l4;
        public static int l5;
        public static int k;
        public static long r;

        public Form3PROG()
        {
            InitializeComponent();
            Text = "Лабораторная №1 windows form";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if ((int.TryParse(textBox1.Text, out n)) & (n > 0)) // TryParse преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком. Возвращает значение, указывающее, успешно ли выполнена операция.
                r = n;
            else
            {
                MessageBox.Show($"Вы не ввели то, что нужно!");
            }

            if ((float.TryParse(textBox2.Text, out A))) // TryParse преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком. Возвращает значение, указывающее, успешно ли выполнена операция.
            {
                counter = 0;
            }
            else
            {
                MessageBox.Show($"Вы не ввели корректное значение А!");
                this.Close();
            }

            if ((float.TryParse(textBox3.Text, out B))) // TryParse преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком. Возвращает значение, указывающее, успешно ли выполнена операция.
            {
                l3 = n % 3;

                l4 = n % 4;

                l5 = n % 5;
            }
            else
            {
                MessageBox.Show($"Вы не ввели корректное значение В!");
                this.Close();
                
            }

            if (A > B)
            {
                MessageBox.Show("Вы неверно указали промежуток");
                this.Close();
            }

            while (n > 0)
            {
                k = n % 10;
                n = (int)n / 10;

                if (k > A)
                {
                    counter += 1;
                }


            }

            

            if ((r > A) & (r < B) & (l3 == 0) & (l4 == 0) & (l5 == 0))
            {
                textBox4.Text = counter.ToString();
                textBox5.Text = "Верно";


            }

            else
            {
                textBox4.Text = counter.ToString();
                textBox5.Text = "Неверно";
            }

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4PROG2 newForm = new Form4PROG2();// Bторая форма называется Form2, поэтому сначала мы создаем объект данного класса, а потом для его отображения на экране вызываем метод Show
            newForm.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5PROG2 newForm = new Form5PROG2();// Bторая форма называется Form2, поэтому сначала мы создаем объект данного класса, а потом для его отображения на экране вызываем метод Show
            newForm.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
