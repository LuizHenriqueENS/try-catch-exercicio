using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCatchEx.Entites;

namespace TryCatchEx {
    class Program {
        static void Main(string[] args) {
            try {
                Account acc;
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc = new Account(number, holder, initialBalance, withdrawLimit);

                Console.Write("\nEnter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(amount);
                Console.WriteLine($"New balance: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
