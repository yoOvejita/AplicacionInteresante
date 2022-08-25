using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionInteresante
{
    public partial class PepeTron
    {
        public void CargarPrograma()
        {
            while (indice < 100)
            {
                //linea = memoria[indice];
                Console.Write(indice + "? ");
                memoria[indice++] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("** Se cargó el programa correctamente **");
        }

        /*
        Leer        10
        Escribir    11
        Cargar      20
        Almacenar   21
        Sumar       30
        Restar      31
        Multiplicar 32
        Dividir     33
        Saltar      40
        Saltarneg   41
        Saltarcero  42
        alto        43
         */
        /*
        Suma de dos numeros
        00 ? 1050
        01 ? 1051
        02 ? 2050
        03 ? 3051
        04 ? 2152
        05 ? 1152
        06 ? 4300
         */
    }
}
