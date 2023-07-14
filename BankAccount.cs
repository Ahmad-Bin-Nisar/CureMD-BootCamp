using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
        public abstract class BankAccount
        {
            private string Account_No;
            private string Account_Holder;
            private double Balance;

            public BankAccount(string account_no, string account_holder, double balance)
            {
                Account_No = account_no;
                Account_Holder = account_holder;
                Balance = balance;
            }

            public virtual double Deposit(double Deposit)
            {
                Balance += Deposit;
                return Balance;
            }

            public virtual double Withdraw(double Withdraw)
            {
                Balance -= Withdraw;
                return Balance;
            }

            public string acc_name
            {
                get { return Account_Holder; }
                set
                {
                    acc_name = Account_Holder;
                }
            }
            public string acc_no
            {
                get { return Account_No; }
                set
                {
                    acc_no = Account_No;
                }
            }
            public double acc_bal
            {
                get { return Balance; }
                set
                {
                    acc_bal = Balance;
                }
            }

        public abstract void DisplayAccountInfo();
        public virtual double CalculateInterest(double deposit , double interest_rate)
        {
            double interest = 0;
            interest = interest_rate * deposit;
            return interest;
        }

        }
}
