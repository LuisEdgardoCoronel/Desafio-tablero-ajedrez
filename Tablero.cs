using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_tablero_ajedrez
{
    internal class Tablero
    {
        private string[,] tablero;
        private int longitud; 

        public Tablero(int longitud) 
        {
            this.longitud = longitud;
            this.tablero = new string[longitud,longitud];
        }

        public void RellenarTablero()
        {
            //Creamos una lista de filas
            List<int> filas = new List<int>();

            //rellenamos el tablero de azul
            for (int i = 0; i < longitud; i++)
            {
                filas.Add(i);
                for (int o = 0; o < longitud; o++)
                {
                    tablero[i, o] = "A";

                }
            }

            //agregamos los rojos en espacios aleatorios
            Random randy = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int indice = filas[randy.Next(filas.Count)];
                for (int o = 0; o <= indice; o++)
                {
                    bool incompleto = true;
                    while (incompleto)
                    {
                        int posicion = randy.Next(longitud);
                        if(tablero[i, posicion] != "R")
                        {
                            tablero[i, posicion] = "R";
                            incompleto = false;
                        }
                    }
                }
                filas.Remove(indice);
            }
        }



        public void MostrarTablero() 
        {
            for (int i = 0; i < this.tablero.GetLength(0); i++)
            {
                for (int o = 0; o < this.tablero.GetLength(1); o++)
                {
                    Console.Write(tablero[i, o]+" ");
                }
                Console.WriteLine();
            }
        }



    }
}
