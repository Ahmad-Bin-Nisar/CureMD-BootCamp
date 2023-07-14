using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    class LoanAccount : BankAccount, ITransaction
    {
        double Interest_Rate;
        LoanAccount(string account_name, string account_no, double balance, double interest_rate) : base(account_name, account_no, balance)
        {
            Interest_Rate = interest_rate;
        }

        public override double Deposit(double Deposit)
        {
            double balance = acc_bal;
            balance += Deposit - CalculateInterest(Deposit, Interest_Rate);
            return balance;
        }

        public override double Withdraw(double Withdraw)
        {
            double value = 0;
            value = acc_bal - Withdraw;
            return value;
        }
        public override double CalculateInterest(double deposit, double interest_rate)
        {
            double interest = 0;
            interest = deposit - deposit/(1+Interest_Rate);
            return interest;
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine("Account Holder: " + acc_name + "\nAccount No.: " + acc_no + "\nBalance: " + acc_bal);
        }
        public void ExecuteTransaction(decimal amount)
        {

        }
        public void PrintTransaction()
        {

        }
    }
}
