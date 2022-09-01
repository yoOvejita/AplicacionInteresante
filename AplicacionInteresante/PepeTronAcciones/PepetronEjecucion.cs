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
            //int posicion=validador();
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
            const int SUMAR = 30, RESTAR = 31, MULTIPLICAR = 32, DIVIDIR = 33, POTENCIAR = 34,
                MODULAR = 35, CALCULARDOUBSum = 36, CALCULARDOUBRest = 37, CALCULARDOUBMulti = 38, CALCULARDOUBDivis = 39,
                 CALCULARDOUBMod = 94;
            const int SALTAR = 40, SALTARNEG = 41, SALTARCERO = 42, ALTO = 43;
            //int acumulador = 0;
            //int aux=0;  
            //Leer las instrucciones (las líneas) y ejecutarlas una a una

            for (int indice = 0; indice < memoria.Length; indice++)
            {
                //También hacemos un control por nulo
                if (memoria[indice]!= null && !memoria[indice].Equals("") && !memoria[indice].Equals("9999"))
                {
                    switch (Convert.ToInt32(memoria[indice].Substring(0, 2)))
                    {
                        case LEER:

                            Console.Write("Ingrese valor para Memoria :" + (memoria[indice].ToString()).Substring(2, 2) + "--> ");
                            //linea = int.Parse(Console.ReadLine());
                            linea = double.Parse(System.Console.ReadLine());

                            //Esto soluciona el error, debemos poner la declaración de hexadecimal desde acá, pues acá guarda valores en posiciones de memoria hexadecimales
                            string hexadecimal = memoria[indice].Substring(2, 2);
                            memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)] = linea+"";
                            break;
                            
                        case CARGAR:
                            //Acá también trabajamos con posiciones en hexadecimal
                            hexadecimal = memoria[indice].Substring(2, 2);
                            acumulador = memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)];
                            break;

                        case SUMAR:
                            //Ej acumulador = "12" + "70" --> "1270" 
                            //  acumulador = 12 + 70 ---> 82 --> "82"
                            // 301C --> suma lo que está en 1C
                            hexadecimal = memoria[indice].Substring(2, 2);
                            acumulador = (int.Parse(acumulador) + int.Parse(memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)])) + "";
                            break;

                        case ALMACENAR:
                            //Acá también trabajamos con posiciones en hexadecimal
                            hexadecimal = memoria[indice].Substring(2, 2);
                            memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)] = acumulador;
                            break;

                        case ESCRIBIR:
                            hexadecimal = memoria[indice].Substring(2, 2);
                            Console.WriteLine("Resultado posición  :" + (memoria[indice].ToString()).Substring(2, 2) + "-->  " + memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)]);
                            break;

                        case POTENCIAR:
                            //acumulador = "123"
                            //acumulador = "123.2"
                            Console.WriteLine("POTENCIA ");
                            Console.WriteLine("Acumulador: " + acumulador);
                            hexadecimal = memoria[indice].Substring(2, 2);
                            Console.WriteLine("Memoria: " + memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)]);
                            
                            acumulador = Math.Pow(int.Parse(acumulador), int.Parse(memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)])) + "";
                            break;

                        case MODULAR:
                            hexadecimal = memoria[indice].Substring(2, 2);
                            acumulador = (int.Parse(acumulador) % int.Parse(memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)])) + "";
            break;  

                        case MULTIPLICAR:
                            hexadecimal = memoria[indice].Substring(2, 2);
                            acumulador = (int.Parse(acumulador) * int.Parse(memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)])) + "";
                            break;

                        case RESTAR:
                            hexadecimal = memoria[indice].Substring(2, 2);
                            acumulador = (int.Parse(acumulador) - int.Parse(memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)])) + "";
                            break;

                        //Cálculo de Double/Flot

                        case CALCULARDOUBSum:

                            hexadecimal = memoria[indice].Substring(2, 2);
                            acumulador = (double.Parse(acumulador) + double.Parse(memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)])) + "";
                            break;

                        case CALCULARDOUBRest:
                            hexadecimal = memoria[indice].Substring(2, 2);
                            acumulador = (double.Parse(acumulador) - double.Parse(memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)])) + "";
                            break;

                        case CALCULARDOUBMulti:
                            hexadecimal = memoria[indice].Substring(2, 2);
                            acumulador = (double.Parse(acumulador) * double.Parse(memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)])) + "";
                            break;

                        case CALCULARDOUBDivis:
                            hexadecimal = memoria[indice].Substring(2, 2);
                            acumulador = (double.Parse(acumulador) / double.Parse(memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)])) + "";
                            break;

                        case CALCULARDOUBMod:
                            hexadecimal = memoria[indice].Substring(2, 2);
                            acumulador = (double.Parse(acumulador) % double.Parse(memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)])) + "";
                            break;



                        // 
                        case DIVIDIR:

                            try
                            {
                                hexadecimal = memoria[indice].Substring(2, 2);
                                acumulador = (int.Parse(acumulador) / int.Parse(memoria[int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber)])) + "";
                                
                            }
                            catch (Exception e)
                            {

                                Console.WriteLine(e);
                                
                            }
                            break;
                        case SALTAR:
                            //Cambiamos el valor de índice
                            hexadecimal = memoria[indice].Substring(2, 2);
                            indice = int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber);
                            indice--;//Porque al final del FOR se incrementa en 1
                            break;
                        case SALTARNEG:
                            //Cambiamos el valor de índice ... SI ELACUMULADOR TIENE UN VALOR NEGATIVO
                            hexadecimal = memoria[indice].Substring(2, 2);
                            if (int.Parse(acumulador) < 0)
                            {
                                indice = int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber);
                                indice--;//Porque al final del FOR se incrementa en 1
                            }
                            break;
                        case SALTARCERO:
                            //Cambiamos el valor de índice ... SI ELACUMULADOR TIENE UN VALOR DE CERO
                            hexadecimal = memoria[indice].Substring(2, 2);
                            if (int.Parse(acumulador) == 0)
                            {
                                indice = int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber);
                                indice--;//Porque al final del FOR se incrementa en 1
                            }
                            break;
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
        /*
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
        */
    }
}
