using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    class Bank
    {
        public List<BankAccount> BankAccounts { get; set; }

        public Bank()
        {
            BankAccounts = new List<BankAccount>();
        }

        public void AddAccount(BankAccount bankAccount)
        {
            BankAccounts.Add(bankAccount);
            Console.WriteLine($"{bankAccount.acc_name} 's  account has been added to the Bank with Account No.: {bankAccount.acc_no}.");
        }

        public void DepositToAccount(BankAccount bankAccount)
        {

            double deposit;
            Console.WriteLine("Enter the deposit amount: ");
            deposit = double.Parse(Console.ReadLine());
            Console.WriteLine($"{bankAccount.acc_name}'s account: Your current balance is: {bankAccount.Deposit(deposit)}");
        }
        public void WithdrawFromAccount(BankAccount bankAccount)
        {
            double withdraw; double check = 0;
            Console.WriteLine("Enter the withdraw amount: ");
            withdraw = double.Parse(Console.ReadLine());
            check = bankAccount.Withdraw(withdraw);
            if (check != 0)
            {
                Console.WriteLine($"{bankAccount.acc_name}'s account: Your current balance is: {bankAccount.Withdraw(withdraw)}");
            }
        }
    }
}
