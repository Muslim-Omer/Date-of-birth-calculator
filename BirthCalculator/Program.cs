using System;

namespace DateOfBirthCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("                            Year Of Birth Calculator                       ");
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.Write("-> Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());

            int currentYear = DateTime.Now.Year;

            int yearOfBirth = currentYear - age;

            Console.WriteLine("-> Your Year of Birth is: " + yearOfBirth);

            Console.WriteLine();
        }
    }
}
