using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Promedio mi_promedio = new Promedio();
            int opcion = 0, num;
            do 
            {
                Console.Clear();
                Console.WriteLine("1. Ingresar numero");
                Console.WriteLine("2. Mostrar promedio");
                Console.WriteLine("Otro. salir");
                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Ingrese un numero: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            mi_promedio.Agregar_valor(num);
                        }break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("El promedio es: {0}", mi_promedio.Calcuar_promedio());
                            Console.ReadKey();
                        }break;

                    default:
                        {
                            opcion = 0;
                        }break;
                }

            } while (opcion != 0);
        }
    }
}
