using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     public delegate void FullName(string fullname);
    public class Class1
    {
        public int sum;
        public string name;
        FullName taken;
        public void reg(FullName fullname)
        {

        }
        public void A(int sum, ListBox listbox)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                listbox.Items.Add($"Осталось:{ this.sum}");
            }
            else
            {
                listbox.Items.Add($"Мало денег");
            }

        }

        public void B(int sum, ListBox listBox)
        {
            this.sum += sum;
            listBox.Items.Add($"Деньги: {this.sum}");

        }
        public void FullName(int sum, string name)
        {
            this.sum = sum;
            this.name = name;
        }
        public void Delete(FullName a)
        {
            taken -= a;
        }
    }
}
