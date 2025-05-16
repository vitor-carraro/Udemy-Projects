﻿using ExercicioExcecoes.Entities.Exceptions;

namespace ExercicioExcecoes.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
                throw new NoBalanceException("Not enough balance");

            if (WithdrawLimit < amount)
                throw new WithdrawLimitExecption("The amount exceeds withdraw limit");

            WithdrawLimit -= amount; 
            Balance -= amount;
        }
    }
}
