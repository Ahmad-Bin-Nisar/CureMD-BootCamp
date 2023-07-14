using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    class SavingsAccount : BankAccount, ITransaction
    {
        double Interest_Rate;

        public SavingsAccount(string account_no, string account_holder, double balance, double interest_rate) : base(account_no, account_holder, balance)
        {
            Interest_Rate = interest_rate;
        }

        public override double Deposit(double Deposit)
        {
            double balance = acc_bal;
            balance += Interest_Rate * Deposit;
            return balance;
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine("Account Holder: " + acc_name + "\nAccount No.: " + acc_no + "\nBalance: " + acc_bal);
        }
        public override double CalculateInterest(double deposit, double interest_rate)
        {
            double interest = 0;
            interest = interest_rate * deposit;
            return interest;
        }

        public void ExecuteTransaction(decimal amount)
        {

        }
        public void PrintTransaction()
        {

        }
    }
}
