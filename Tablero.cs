using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_tablero_ajedrez
{
    internal class Tablero
    {
        private string[,] tablero;
        private int longitud;
        private string color1 = "R"; // representa al color rojo
        private string color2 = "A"; // representa al color azul

        public Tablero(int longitud) 
        {
            this.longitud = longitud;
            this.tablero = new string[longitud,longitud];

        }

        


        //metodo principal para rellenar el tablero con el patron de colores
        public void RellenarTablero()
        {
            for (int fila = 0; fila < longitud; fila++)
            {
                int ContadorEspaciosRojos = 1;
                for (int columna = 0; columna < longitud; columna++)
                {
                    //crea un tablero de ajedrez con una escalera de Rojos
                    //evitando al mismo tiempo que dos filas o columnas tengan la misma cantidad de espacios rojos
                    if (fila+1 >= ContadorEspaciosRojos) tablero[fila, columna] =  color1;
                    else tablero[fila, columna] = color2;

                    ContadorEspaciosRojos++; //aumentamos el contado
                }

            }
        }



        // Método para mostrar el tablero en la consola
        public void MostrarTablero() 
        {
            for (int fila = 0; fila < this.tablero.GetLength(0); fila++)
            {
                for (int columna = 0; columna < this.tablero.GetLength(1); columna++)
                {
                    Console.Write(tablero[fila, columna]+" ");
                }
                Console.WriteLine();
            }
        }



    }
}
