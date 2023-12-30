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
            
            int cantidadColorSeguido = 1;
            

            for (int i = 0; i < longitud; i++)
            {
                // mientras recorremos las filas, alternamos entre iniciar con color1 o color2 en cada una
                if (i%2==0)
                {
                    RellenarFila(i, cantidadColorSeguido, this.color1, this.color2);
                }
                else
                {
                    RellenarFila(i, cantidadColorSeguido, this.color2, this.color1);
                    cantidadColorSeguido++;
                }

            }
        }




        public void RellenarFila(int fila, int cantidadColorSeguido, string color, string color2) 
        {
            //almacenamos la cantidad de colores que van seguidos para no perder el valor
            int aux = cantidadColorSeguido;
            int cantidadColor2 = 0;

            //condicion para modificar el patron. NO es necesaria
            if (longitud > 5 && cantidadColorSeguido == longitud / 2) cantidadColorSeguido /= 2;

            //recorremos la fila, agregando los colores en las diferentes columnas
            for (int a = 0; a < longitud; a++)
            {
                if (cantidadColorSeguido > 0) tablero[fila, a] = color;
                else tablero[fila, a] = color2;

                cantidadColorSeguido--;

                //cuando el segundo color se aplica en igual cantidad que el primero, continua de nuevo el primer color
                if (cantidadColor2 == aux)
                {
                    cantidadColorSeguido = aux;
                    cantidadColor2 = 0;
                }

                //contamos la cantidad de cuadros que debe tener el segundo color
                if (cantidadColorSeguido <= 0) cantidadColor2++;
                

            }
        }

        // Método para mostrar el tablero en la consola
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
