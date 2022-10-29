using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace PraktikaHeh
{
    public partial class Form1 : Form
    {
        FullName a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new FullName(Convert.ToInt32(textBox2.Text), textBox1.Text);
            listBox1.Items.Add($"Имя:{a.name}");
            listBox1.Items.Add($"Сумма:{a.sum}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.Add(Convert.ToInt32(textBox3.Text), listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FullName.B(Convert.ToInt32(textBox3.Text));
        }
    }
}
