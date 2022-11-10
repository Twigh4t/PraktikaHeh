using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AccountEventArgs
    {
        public string Message { get; }
        public int Sum { get; }

        public AccountEventArgs(string mes, int sum)
        {
            Message = mes;
            Sum = sum;
        }
    }

    public class AccountBank
    {
        public delegate void AccountHand(AccountBank send, AccountEventArgs e);
        public event AccountHand Notify;

        public int Sum;
        public string Name;
        AccountHand taken;
        public AccountBank(int sum, string name)
        {
            Name = name;
            Sum = sum;
        }
        public void reg(AccountHand account, AccountEventArgs e)
        {
            taken = account;
        }
        public void Add(int sum)
        {
            if (this.Sum >= sum)
            {
                this.Sum -= sum;
                Notify?.Invoke(this, new AccountEventArgs($"На счет пришло {sum}, на балансе:", this.Sum));
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs($"Мало {sum}, на балансе:", this.Sum));
            }

        }

        public void Delete(int sum)
        {
            this.Sum += sum;
            Notify?.Invoke(this, new AccountEventArgs($"Пришло {sum}. Баланс", this.Sum));

        }
        public void Account(int sum, string name)
        {
            this.Name = name;
            this.Sum = sum;
        }
        public void Delete(AccountHand a)
        {
            
        }
    }
}

