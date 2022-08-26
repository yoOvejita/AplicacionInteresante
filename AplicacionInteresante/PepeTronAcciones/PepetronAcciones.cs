using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionInteresante
{
    public partial class PepeTron
    {
        
        public void CargarPrograma()
        {
            while (indice < 100 )
            {
                //linea = memoria[indice];
                Console.Write(indice + "? ");
                linea = int.Parse(Console.ReadLine());
                if (linea == 9999)
                    break;
                memoria[indice++] = linea;
            }
            Console.WriteLine("** Se cargó el programa correctamente **");
        }

        public void CargarPrograma(string ubicacionArchivo)
        {
            //C:\Users\pepe\Desktop\programa.lmpp
            System.IO.StreamReader archivo = new System.IO.StreamReader(ubicacionArchivo);
            indice = 0;
            string lineaAux;
            while ((lineaAux = archivo.ReadLine()) != null) {
                memoria[indice++] = int.Parse(lineaAux);
            }
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
