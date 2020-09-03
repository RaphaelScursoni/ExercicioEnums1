using System;

namespace EnumsEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name: ");
            string Department = Console.ReadLine();
            Console.WriteLine("Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Level (Junior/ MidLevel/ Senior)");
            string Level = Console.ReadLine();
            Console.WriteLine("Base Salary: ");
            double BaseSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("How many contracts of this worker? ");
            int NContraos = int.Parse(Console.ReadLine());


            for (int i = 0; i < NContraos; i++) { 
                
            }
        }
    }
}
