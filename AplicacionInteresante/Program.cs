using System;

namespace AplicacionInteresante
{
    internal class Program
    {
        //Necesitamos:
        static int[] memoria = new int[100];
        static int indice = 0;
        static int linea = 0;//2011
        static void Main(string[] args)
        {
            /* Una máquina que ejecuta código */
            PepeTron maquina = new PepeTron();
            maquina.CargarPrograma();
            maquina.VolcarMemoria();
            maquina.EjecutarPrograma();

            
        }
    }
}
