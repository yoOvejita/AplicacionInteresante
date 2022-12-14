using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionInteresante
{
    public partial class PepeTron
    {
        string[] memoria = new string[100];//Nueva longitud iría hasta cubrir el numero FF
        int indice = 0;
        double linea = 0; //de int a double R
        string acumulador = "";
        
        public void VolcarMemoria()
        {
            Console.ForegroundColor = ConsoleColor.Green;//Cambiando el color de las letras
            Console.WriteLine("** Volcado de memoria  **\n** Maquina interesante **");
            for (int i = 0; i < memoria.Length; i++)
            {
                //Hacemos control por nulo también
                if (memoria[i]!= null && !memoria[i].Equals(""))
                {
                    Console.WriteLine("Memoria [" + i + "] " + "Valor "+ memoria[i]);
                }
            }
            Console.ResetColor();
            //Conversion letra - numero

            char c = Convert.ToChar(122);
            Console.WriteLine(c);
            char[] cc;
            String cadena = Console.ReadLine();
            cc = cadena.ToCharArray();
            for (int i = 0; i < cc.Length; i++)
                Console.WriteLine((int)cc[i]);

            //lo convierto a hexadecimal
            for (int i = 0; i < cc.Length; i++)
            {
                int decimale = (int)cc[i];
                string hexadecimal = decimale.ToString("X");
                Console.WriteLine(hexadecimal);
                Console.WriteLine(int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber));
            }


           

        }
        public void VolcarMemoriaHexaPrueba()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            string espacio = "Hola Mundo!";
            char[] valores = espacio.ToCharArray();
            foreach (char letra in valores)
            {       
                int valor = Convert.ToInt32(letra);         
                Console.WriteLine($"El valor Hexadecimal de {letra} es {valor:X}");
            }

        }
    }
}
