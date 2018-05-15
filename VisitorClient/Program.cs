using System;
using VisitorPattern;

namespace VisitorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Represent an operation to be performed on the elements of an object structure. 
            // Visitor lets you define a new operation without changing the classes of the elements on which it operates.

            var person = new Person();
            person.Assets.Add(new BankAccount { Amount = 1000, MonthlyInterest = 0.01 });
            person.Assets.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.02 });
            person.Assets.Add(new RealEstate { EstimatedValue = 79000, MonthlyRent = 500 });
            person.Assets.Add(new Loan { Owed = 40000, MonthlyPayment = 40 });

            var networth = new NetworthVisitor();
            person.Accept(networth);
            Console.WriteLine($"Networth: ${networth.Total}");

            var monthlyIncome = new MonthlyIncomeVisitor();
            person.Accept(monthlyIncome);
            Console.WriteLine($"Monthly income: ${monthlyIncome.Total}");

            Console.ReadKey();
        }
    }
}
