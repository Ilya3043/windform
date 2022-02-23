using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба1винда.Properties
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Text = "Лабораторная №1 windows form";// Задаем название форме
            this.StartPosition = FormStartPosition.CenterScreen; // Задаем расположение формы в центре экрана
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();// Bторая форма называется Form2, поэтому сначала мы создаем объект данного класса, а потом для его отображения на экране вызываем метод Show
            newForm.Show();
        }
    }
}
