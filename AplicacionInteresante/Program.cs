using System;

namespace AplicacionInteresante
{
   internal class Program
    {
        //Necesitamos:
        static int[] memoria = new int[memoria.Length];
        static int indice = 0;
        static double linea = 0;//2011 //  de int a double R

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
