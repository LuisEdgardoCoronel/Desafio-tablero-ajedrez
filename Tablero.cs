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
            
            for (int i = 0; i < longitud; i++)
            {
                int ContadorRojo = 0;
                for (int o = 0; o < longitud; o++)
                {
                    /*if ((i+o)%2==0)tablero[i, o] = "R";  //crea un tablero de ajedrez normal
                    else tablero[i, o] = "A";*/


                    ContadorRojo++; //aumentamos el contador

                    //crea un tablero de ajedrez con una escalera de Rojos
                    //evitando al mismo tiempo que dos filas o columnas tengan la misma cantidad de espacios rojos
                    if (i >= ContadorRojo) tablero[i, o] = "R"; 
                    else tablero[i, o] = "A";


                }
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
