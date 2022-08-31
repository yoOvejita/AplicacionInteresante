using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AplicacionInteresante
{
    public partial class PepeTron
    {
        public void EjecutarPrograma()
        {
            //Completen lo qu falta
            //int acumulador=0;
            Console.Clear();
            int posicion=validador();
            selectorOperacion();//ejecutar el programa

            /*
            if (memoria[98] == 0)
            {
                selectorOperacion();
            }
            else
            {
                switch (memoria[98])
                {
                    case 10:
                    Console.WriteLine("Eror de Longitud en instruccion Posicion: " + "[" + posicion +"] -->" + memoria[posicion]);
                    break;

                    case 11:
                        Console.WriteLine("Falta asignacion de Fin");
                        break;
                }     
            }
           */
        }
        private void selectorOperacion() {
            /*
            Descomposición de números
            in: 1234 
            out: 12
            1234 / 10 = 123
            1234 / 100 = 12

            in: 1234
            out: 34
            1234 % 10 = 4
            1234 % 100 = 34

             */
            const int LEER = 10, ESCRIBIR = 11, LEERCAD = 12;
            const int CARGAR = 20, ALMACENAR = 21;
            const int SUMAR = 30, RESTAR = 31, MULTIPLICAR = 32, DIVIDIR = 33, POTENCIAR = 34, MODULAR = 35;
            const int SALTAR = 40, SALTARNEG = 41, SALTARCERO = 42, ALTO = 43;
            //int acumulador = 0;
            //int aux=0;  
            //Leer las instrucciones (las líneas) y ejecutarlas una a una

            for (int indice = 0; indice < memoria.Length; indice++)
            {
                if (memoria[indice]>0 && memoria[indice] <= 9999)
                {
                    switch (Convert.ToInt32((memoria[indice].ToString()).Substring(0, 2)))
                    {
                        case LEER:

                            Console.Write("Ingrese valor para Memoria :" + (memoria[indice].ToString()).Substring(2, 2) + "--> ");
                            linea = int.Parse(Console.ReadLine());
                            memoria[Convert.ToInt32((memoria[indice].ToString()).Substring(2, 2))] = linea;
                            break;
                            
                        case CARGAR:
                            acumulador = memoria[Convert.ToInt32((memoria[indice].ToString()).Substring(2, 2))];
                            break;

                        case SUMAR:
                            acumulador = acumulador + memoria[Convert.ToInt32((memoria[indice].ToString()).Substring(2, 2))];
                            break;

                        case ALMACENAR:
                            memoria[Convert.ToInt32((memoria[indice].ToString()).Substring(2, 2))] = acumulador;
                            break;

                        case ESCRIBIR:
                            Console.WriteLine("Resultado posición  :" + (memoria[indice].ToString()).Substring(2, 2) + "--> " + memoria[Convert.ToInt32((memoria[indice].ToString()).Substring(2, 2))]);
                            break;

                        //case POTENCIAR:
                        //    acumulador = acumulador = Math.Pow(acumulador, memoria[Convert.ToInt32((memoria[indice].ToString()).Substring(2, 2)))];
                        //    break;

                        case MODULAR:
                            acumulador = acumulador % memoria[Convert.ToInt32((memoria[indice].ToString()).Substring(2, 2))];
                            break;  

                        case MULTIPLICAR:
                            acumulador = acumulador * memoria[Convert.ToInt32((memoria[indice].ToString()).Substring(2, 2))];
                            break;

                        case RESTAR:
                            acumulador = acumulador - memoria[Convert.ToInt32((memoria[indice].ToString()).Substring(2, 2))];
                            break;
                        case DIVIDIR:

                            try
                            {
                                acumulador = acumulador / memoria[Convert.ToInt32((memoria[indice].ToString()).Substring(2, 2))];
                                
                            }
                            catch (Exception e)
                            {

                                Console.WriteLine(e);
                                
                            }
                            break;
                        case ALTO:
                            Console.WriteLine("Fin de instrucción");
                            indice = 97;
                            break;                    
                    }
                }
                else
                {
                    Console.WriteLine("Error de Longitud en instrucción");
                    break;
                }              
            }
        }
        public int validador()
        {
            //Reservamos posicion 99 para acumulador
            //Reservamos posicion 98 para error
            const int E_LONGITUD = 10;
            const int E_FIN = 11; 
            int posicion = 0;

            for (int i = 0;i <97; i++)
            {

                // error de longitud
                if ((memoria[i] > 0 && memoria[i] < 1000) || memoria[i] > 10000)
                {
                    
                    memoria[98]=E_LONGITUD;
                    posicion = i;   // Console.Write("Validacion de longitud: " + memoria[indice]);
                    break;
                }
                // validamos que exista fin de linea
                memoria[98]=E_FIN;
                if (memoria[i]==4300)
                {
                    memoria[98] = 0;
                    break;
                }
                //validamos 
                
            }        
            return posicion;            
        }
    }
}
