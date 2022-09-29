using Excepcion_Forma_T_Exception;

namespace Excepcion_Forma_T_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int valorUno = 0, valorDos = 0, resultado;

            try
            {
                Console.Write("Numero 1: ");
            valorUno = int.Parse(Console.ReadLine());
            Console.Write("Numero 2: ");
            valorDos = int.Parse(Console.ReadLine());
            } catch(FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }

            try
            {
                resultado = valorUno / valorDos;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException dbzex)
            {
                Console.WriteLine(dbzex.Message);
            }
        }
    }
}
            */


            int[] numeros = new int[3]; 

            for (int a = 0; a<5;  a++)
            {
                try
                {
                    numeros[a] = a * 3;
                    Console.WriteLine(numeros[a]);
                } catch (IndexOutOfRangeException iorex)
                {
                    Console.WriteLine(iorex.Message);
                }
            }

            Console.WriteLine("Final");
            Console.WriteLine();
        }
    }
}