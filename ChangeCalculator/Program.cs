using System;
using System.Collections.Generic;
using System.Linq;
using ChangeCalculator.Calculator;

namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var changeReturn = new ChangeReturn(new Currency()
            {
                Symbol = "£",
                Suffix = "p",
                Denomination = new List<string>() { "50", "20", "10", "5", "2", "1" }
            });
            Console.WriteLine("Please enter product price: ");
            changeReturn.ProductCost = Console.ReadLine();
            Console.WriteLine("Please enter payment amount : ");
            changeReturn.PaymentAmount = Console.ReadLine();
            Display(changeReturn.SetChangeAmount() ?
                changeReturn.Calculate()
                : changeReturn.ErrorMessage.ToList());
            Console.ReadKey();
        }
        
        static void Display(IList<string> result)
        {
            result.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
