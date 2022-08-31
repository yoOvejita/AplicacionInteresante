using System;

namespace AplicacionInteresante
{
   internal class Program
    {
        //Necesitamos:
        static int[] memoria = new int[memoria.Length];
        static int indice = 0;
        static int linea = 0;//2011

        //string hex = linea.ToString("X");

        static void Main(string[] args)
        {
            /* Una máquina que ejecuta código */
            PepeTron maquina = new PepeTron();
            maquina.CargarPrograma(args[0]);
            //maquina.VolcarMemoria();
            maquina.EjecutarPrograma();
            maquina.VolcarMemoriaHexaPrueba();
            maquina.VolcarMemoria();
            
        }
    }
}
