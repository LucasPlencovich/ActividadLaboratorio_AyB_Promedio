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
        private int tam_vec;
        private int cant_num;
        private double promedio;
        public Promedio()
        {
            valores = new double[100];
            cant_num = 0;
        }
        public int tamaño_vec
        {
            get{ return tam_vec; }
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
            double[] val_sup_prom = new double[cant_num];
            int pos = 0;
            for (int i = 0; i < cant_num; i++)
            {
                if (valores[i] > promedio)
                {
                    val_sup_prom[pos] = valores[i];
                    pos++;
                    tam_vec = pos;
                }
            }
            return val_sup_prom[num];
        }

        public double vec_ordenado(int num)
        {
            double[] val_sup_prom = new double[cant_num];
            for (int i = 0; i < cant_num; i++)
            {
                val_sup_prom[i] = Val_sup_prom(i);
            }
            double aux = 0;
            for(int i = 0; i < tam_vec; i++)
            {
                for (int j = 1; j < tam_vec; j++)
                {
                    if (val_sup_prom[i] > val_sup_prom[j])
                    {
                        aux = val_sup_prom[j];
                        val_sup_prom[j] = val_sup_prom[i];
                        val_sup_prom[i] = aux;
                    }
                }
            }
            return  val_sup_prom[num];
        }
    }
}
