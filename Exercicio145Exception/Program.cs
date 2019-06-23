using System;
using System.Globalization;
using Exercicio145Exception.Entities;
using Exercicio145Exception.Entities.Exceptions;

namespace Exercicio145Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados da conta");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Saldo inicial: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Limite de Saque: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, initialBalance, withDrawLimit);

                Console.Write("Entre com o montante para saque: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.WithDraw(amount);
                Console.WriteLine("Novo saldo: " + account.Balance);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Erro na operação bancaria: "+ e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Erro no formato: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro inexperado: " +e.Message);
            }




        }
    }
}
