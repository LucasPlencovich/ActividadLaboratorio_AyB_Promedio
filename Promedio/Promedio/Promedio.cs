using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Promedio
    {
        private double [] valores;
        private int cant_num;
        public Promedio()
        {
            valores = new double[100];
            cant_num = 0;
        }
        public void Agregar_valor(int num)
        {
            valores [cant_num]=num;
            cant_num++;
        }

        public double Calcuar_promedio()
        {
            double resultado = 0;

            if (cant_num == 0)
            {
                resultado = 0;
            }

            for(int i=0; i < cant_num; i++)
            {
                resultado += valores[i];
            }
            resultado = resultado / cant_num;
            return resultado;
        }
    }
}
