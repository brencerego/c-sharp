using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        protected string name;
        protected int Accountno;
        protected double balance = 5000;

        public BankAccount()
        {

        }
        public BankAccount(string name, int AccountNo)
        {
            this.name = name;
            this.Accountno = AccountNo;

        }

        public BankAccount(string name, int AccountNo, int balance)
        {
            this.name = name;
            this.Accountno = AccountNo;
            this.balance = balance;

        }

        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount}");
        }
        public void GetBalance()
        {
            Console.WriteLine($"Balance is {balance}");
        }
        public void Withdraw(int amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Currrent Balance is {balance} after deducting {amount}");
            }

        }
    }
    class SavingsAcc : BankAccount
    {
        double Interest = 0;
        public SavingsAcc()
        {

        }
        public SavingsAcc(string name, int AccountNo)
        {
            this.name = name;
            this.Accountno = AccountNo;

        }

        public SavingsAcc(string name, int AccountNo, int balance)
        {
            this.name = name;
            this.Accountno = AccountNo;
            this.balance = balance;

        }

        public void CalcInterest(double rate, int time)
        {
            Interest = balance * (rate / 100) * time;
        }
        public void DisplayInterest()
        {
            Console.WriteLine($"The interest is {Interest}");
        }
        public void AddInterest()
        {
            if (Interest <= 0)
            {
                Console.WriteLine("No Interest Calculated.");
            }
            else
            {
                balance += Interest;
                Console.WriteLine($"Added {Interest} to Balance.");
            }
        }
    }

}
