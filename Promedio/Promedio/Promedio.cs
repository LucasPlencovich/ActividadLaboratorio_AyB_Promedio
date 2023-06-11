using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Promedio
    {
        private double valores;
        private int cant_num;
        public Promedio()
        {
        }
        public void Agregar_valor(int num)
        {
            valores += num;
            cant_num++;
        }

        public double Calcuar_promedio()
        {
            double resultado = 0;

            if (cant_num == 0)
            {
                resultado = 0;
            }

            resultado = valores / cant_num;
            return resultado;
        }
    }
}
