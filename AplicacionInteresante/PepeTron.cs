using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionInteresante
{
    public partial class PepeTron
    {
        int[] memoria = new int[100];
        int indice = 0;
        int linea = 0;

        
        public void VolcarMemoria()
        {
            Console.WriteLine("** Volcado de memoria  **\n** Maquina interesante **");
            for (int i = 0; i < 100; i++)
            {
                if (memoria[i] > 0)
                {
                    Console.WriteLine("Memoria [" + i + "] " + "Valor "+ memoria[i]);
                }
            }
           
           
        }
    }
}
