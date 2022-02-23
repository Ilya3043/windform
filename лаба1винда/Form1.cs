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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Лабораторная №1 windows form";// Задаем название форме
            this.StartPosition = FormStartPosition.CenterScreen; // Задаем расположение формы в центре экрана
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2CHANGE newForm = new Form2CHANGE();// Bторая форма называется Form2, поэтому сначала мы создаем объект данного класса, а потом для его отображения на экране вызываем метод Show
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
