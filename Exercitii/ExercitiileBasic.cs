using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii
{
    class ExercitiileBasic
    {
        // exercitiul 1 C# Basic Declaration
        public void exercitiul1()
        {
            System.Console.WriteLine("  Exercitiul 1: Afiseaza Hello si numele tau pe 2 linii diferite.");
            System.Console.WriteLine("   Hello");
            System.Console.WriteLine("   Gabor Roxana-Mihaela");
            
        }

        //exercitiul 2 
        public void exercitiul2()
        {
            System.Console.WriteLine("    Exercitiul 2: Afiseaza suma a 2 numere.");
            int a = 4, b = 7;
            int suma = 0;
            suma = a + b;
            System.Console.WriteLine("Suma a 2 numere este:  " + suma);
           
        }

        public void exercitiul3()
        {
            Console.WriteLine("      Exercitiul  3: Afiseaza impartirea a 2 numere. ");
            double x = 144, y = 12;
            double impartire = 0;
            impartire = x / y;
            Console.WriteLine("Rezultatul impartirii este:  " +impartire);

        }


    }
}
