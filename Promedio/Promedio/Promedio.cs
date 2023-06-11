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
        private double promedio;
        public Promedio()
        {
            valores = new double[100];
            cant_num = 0;
        }
        public void Agregar_valor(int num)
        {
            valores [cant_num]=num;
            cant_num++;
            promedio = 0;
        }

        public double Calcuar_promedio()
        {

            if (cant_num == 0)
            {
                promedio = 0;
            }

            for(int i=0; i < cant_num; i++)
            {
                promedio += valores[i];
            }
            promedio = promedio / cant_num;
            return promedio;
        }
        public double Val_sup_prom(int num)
        {
            double[] val_sup_prom = new double[100];
            int pos = 0;
            
            for (int i = 0; i < cant_num; i++)
            {
                if (valores[i] > promedio)
                {
                    val_sup_prom[pos] = valores[i];
                    pos++;
                }
            }
            return val_sup_prom[num];
        }
    }
}
