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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(); // создаем объект типа Form2
            if (f.ShowDialog() == DialogResult.OK) ; // вызов диалогового окна формы  Form2

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
