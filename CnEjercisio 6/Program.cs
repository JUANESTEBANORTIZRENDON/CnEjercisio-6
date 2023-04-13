using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnEjercisio6
{
    internal class Program
    {
        /// <summary>
        ///nombre:Juan Esteban Ortiz Rendon
        ///Fecha:28/08/2023
        ///Descripcion:Algoritmo que permita ingresar un numero y a este numero sacarle sus primeros 10 multiplo y que solo permita cerrar el programa cuando se ingrese el digito (-1)
        ///</summary>

        static void Main(string[] args)
        {
            int Num = 0;

            Tablas(Num);
            Console.ReadKey();
        }

        static void Tablas(int Num)
        {
            while (Num != -1)
            {
                Console.WriteLine("Porfavor escriba el numero al cual le quiere realizar la tabla de multiplicar");
                Console.WriteLine("(Al ingresar el valor de -1 se cerrara el programa)");
                Num = Convert.ToInt32(Console.ReadLine());
                int Num2 = Num;

                if (Num != -1)
                {
                    for (int i = 0; i < 11; i++)
                    {
                        Console.WriteLine("{0}*{1}*{2}", Num2, i, Num2 * i);

                    }
                }


            }


        }
    }
}