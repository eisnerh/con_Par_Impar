using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace con_Par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, entero;
            double dec;
            Console.WriteLine("Ingrese un #: ");

            n = Convert.ToInt32(Console.ReadLine());

            entero = n / 2;
            dec = (double)n / 2;
            if (entero - dec == 0)
            {
                Console.WriteLine("El numero {0} es par.", n);
            }

            else
            {
                Console.WriteLine("El numero {0} es impar.", n);

            }// fin del if

            if (Math.Pow(-1, n) == 1)

            {
                Console.WriteLine("El numero {0} es par.", n);
            }

            else
            {
                Console.WriteLine("El numero {0} es impar.", n);

            }// fin del if

            if (n % 2 == 0)

            {
                Console.WriteLine("El numero {0} es par.", n);
            }

            else
            {
                Console.WriteLine("El numero {0} es impar.", n);

            }// fin del if

            Console.ReadKey();

        }
    }
}
