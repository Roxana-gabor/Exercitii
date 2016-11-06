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
            Console.WriteLine("  Exercitiul 1: Afiseaza Hello si numele tau pe 2 linii diferite.");
            Console.WriteLine("   Hello");
            Console.WriteLine("   Gabor Roxana-Mihaela");
            
        }

        //exercitiul 2 
        public void exercitiul2()
        {
            Console.WriteLine("    Exercitiul 2: Afiseaza suma a 2 numere.");
            int a = 4, b = 7;
            int suma = 0;
            suma = a + b;
            Console.WriteLine("Suma a 2 numere este:  " + suma);
           
        }

        public void exercitiul3()
        {
            Console.WriteLine("      Exercitiul  3: Afiseaza impartirea a 2 numere. ");
            double x = 144, y = 12;
            double impartire = 0;
            impartire = x / y;
            Console.WriteLine("Rezultatul impartirii este:  " +impartire);

        }

        public void exercitiul4()
        {
            Console.WriteLine("     Exercitiul 4: Afiseaza rezultatul unor operatii specifie");
            Console.WriteLine(-1 +( 4 * 6));
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + ((-4 * 6) / 11));
            Console.WriteLine(2+ (15 / 6 * 1) - (7 % 2));
        }


    }
}
