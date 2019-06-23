using System;
using System.Collections.Generic;
using System.Text;
using Exercicio145Exception.Entities.Exceptions;

namespace Exercicio145Exception.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        // metodo para depositar
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        // metodo para sacar
        public void WithDraw(double amount)
        {
            // se não tiver saldo na conta, instancia a classe DamainException, passando a mensagem a ser exibida no catch.
            if (amount > WithDrawLimit)
            {
                throw new DomainException("Saque superior ao limite da conta!");
            }

            if ((amount > Balance))
            {
                throw new DomainException("Saldo insuficiente para realizar qualquer tipo de saque!");
            }

            Balance -= amount;
        }
    }
}
