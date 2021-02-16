using System;

namespace ConditionsEX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("veuillez entrer age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Vous avez {0} ans, vous êtes donc mineur.e.", age);
            }
            else
            {
                Console.WriteLine("Vous avez {0} ans, vous êtes donc majeur.e.", age);
            }
        }
    }
}
