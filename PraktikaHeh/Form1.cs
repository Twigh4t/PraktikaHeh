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
using static ClassLibrary1.AccountBank;

namespace PraktikaHeh
{
    public partial class Form1 : Form
    {
        AccountBank account;
       
        void DisplayMessage(AccountBank send, AccountEventArgs e)
        {
            MessageBox.Show($"Сумма {e.sum} {e.message}");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account = new AccountBank(Convert.ToInt32(textBox2.Text), textBox1.Text);
            account.Notify += DisplayMessage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            account.Add(Convert.ToInt32(textBox3.Text), listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Account.B(Convert.ToInt32(textBox3.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
