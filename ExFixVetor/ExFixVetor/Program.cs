using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ExFixVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 10; 
            Guest[] vect = new Guest[p];
            Console.Write("How many Room do you wish to rent? ");
            int q = int.Parse(Console.ReadLine());            
            for (int i = 1; i <= q; i++)
            {
                Console.WriteLine($"\nRent #{i}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room Number: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Guest ( name, email );
            }
            Console.WriteLine("\nRoom occupied: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
