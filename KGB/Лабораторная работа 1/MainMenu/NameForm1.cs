using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа_1
{
    public partial class NameForm1 : Form
    {
        public NameForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm(); // создаем объект типа Form2
            if (f.ShowDialog() == DialogResult.OK) ; // вызов диалогового окна формы  Form2
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainForm f = new MainForm(); // создаем объект типа Form2
            if (f.ShowDialog() == DialogResult.OK) ; // вызов диалогового окна формы  Form2
        }
    }
}
