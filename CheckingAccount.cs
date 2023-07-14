using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    class CheckingAccount : BankAccount, ITransaction
    {
        public CheckingAccount(string account_no, string account_holder, double balance) : base(account_no, account_holder, balance)
        { }

        public override double Withdraw(double Withdraw)
        {
            double value = 0;
            if (Withdraw > acc_bal)
            {
                Console.WriteLine($"{acc_name}'s account: The amount exceeds your current balance.");
                value = 0;
            }
            else value = acc_bal - Withdraw;
            return value;
        }
        public override void DisplayAccountInfo()
        {
            Console.WriteLine("Account Holder: " + acc_name + "\nAccount No.: " + acc_no + "\nBalance: " + acc_bal);
        }
        public override double CalculateInterest(double deposit, double interest_rate)
        {
            return 0;
        }
        public void ExecuteTransaction(decimal amount)
        {

        }
        public void PrintTransaction()
        {

        }
    }
}
