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
    public partial class Form2CHANGE : Form
    {
        public Form2CHANGE()
        {
            InitializeComponent();
            Text = "Лабораторная №1 windows form";// Задаем название форме
            this.StartPosition = FormStartPosition.CenterScreen; // Задаем расположение формы в центре экрана
        }

        private void Form2CHANGE_Load(object sender, EventArgs e)
        {

        }

        
        void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {

                // приводим отправителя к элементу типа RadioButton
                RadioButton radioButton = (RadioButton)sender;
                Form3PROG newForm = new Form3PROG();// Bторая форма называется Form2, поэтому сначала мы создаем объект данного класса, а потом для его отображения на экране вызываем метод Show
                newForm.Show();
                this.Close();
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                // приводим отправителя к элементу типа RadioButton
                RadioButton radioButton = (RadioButton)sender;
                Form4PROG2 newForm = new Form4PROG2();// Bторая форма называется Form2, поэтому сначала мы создаем объект данного класса, а потом для его отображения на экране вызываем метод Show
                newForm.Show();
                this.Close();
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                // приводим отправителя к элементу типа RadioButton
                RadioButton radioButton = (RadioButton)sender;
                Form5PROG2 newForm = new Form5PROG2();// Bторая форма называется Form2, поэтому сначала мы создаем объект данного класса, а потом для его отображения на экране вызываем метод Show
                newForm.Show();
                this.Close();
            }
        }
    }
}
