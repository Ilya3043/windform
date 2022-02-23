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
    public partial class Form5PROG2 : Form
    {
        public static string A;
        public static string B;
        public static string t;
        public static string t1;
        public static char n;
        public static char n1;
        public static int i;
        public static int l5;
        public static int k;
        public static long r;

        public Form5PROG2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3PROG newForm = new Form3PROG();// Bторая форма называется Form2, поэтому сначала мы создаем объект данного класса, а потом для его отображения на экране вызываем метод Show
            newForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4PROG2 newForm = new Form4PROG2();// Bторая форма называется Form2, поэтому сначала мы создаем объект данного класса, а потом для его отображения на экране вызываем метод Show
            newForm.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                t = textBox1.Text;
                t1 = textBox2.Text;
                byte[] n = Encoding.ASCII.GetBytes(t);
                byte[] result1;

                //Оператор цикла foreach предназначен для перебора элементов коллекции или массива. 

                textBox3.Text = (System.Text.Encoding.GetEncoding(1251).GetString((new byte[127] )));


            }
        }
    }
}
