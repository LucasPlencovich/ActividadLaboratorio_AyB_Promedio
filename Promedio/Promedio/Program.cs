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
            int opcion = 0, num, cont=0;
            do 
            {
                Console.Clear();
                Console.WriteLine("1. Ingresar numero");
                Console.WriteLine("2. Mostrar promedio");
                Console.WriteLine("3. Valores que superan el promedio");
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
                            cont++;
                        }break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("El promedio es: {0}", mi_promedio.Calcuar_promedio());
                            Console.ReadKey();
                        }break;
                    case 3:
                        {
                            Console.Clear();
                            for(int i=0; i < cont; i++)
                            {
                                if (mi_promedio.Val_sup_prom(i) != 0)
                                {
                                    Console.WriteLine("{0:f2}", mi_promedio.Val_sup_prom(i));
                                }
                            }
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
