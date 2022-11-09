using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     
    public class AccountBank
    {
        public delegate void AccountHand(AccountBank send, AccountEventArgs e);
        public event AccountHand Notify;

        public int sum;
        public string name;
        AccountHand taken;

        public void reg(AccountHand account, AccountEventArgs e)
        {
            taken = account;
        }
        public void Add(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                Notify?.Invoke(this, new AccountEventArgs($"На счет пришло {sum}, на балансе:", this.sum));
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs($"Мало {sum}, на балансе:", this.sum));
            }

        }

        public void Delete(int sum)
        {
            this.sum += sum;
            Notify?.Invoke(this, new AccountEventArgs($"Пришло {sum}. Баланс", this.sum));

        }
        public void Account(int sum, string name)
        {
            this.name = name;
            this.sum = sum;
        }
        public void Delete(AccountHand a)
        {
            taken -= account;
        }
        
        class AccountEventArgs
        {
            public string Message { get; }
            public int Sum { get; }

            public AccountEventArgs(string mes, int sum)
            {
                public string mes;
            }
        }
    }
}
