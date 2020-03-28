using System;

namespace Dominó
{

    class Domino
    {
        private int Espacio1;
        private int Espacio2;

        public Domino(int Espacio1, int Espacio2)
        {
            this.Espacio1 = Espacio1;
            this.Espacio2 = Espacio2;
        }

        public static int operator +(Domino ficha1, Domino ficha2)
        {
            int puntosFicha1 = ficha1.Espacio1 + ficha1.Espacio2;
            int puntosFicha2 = ficha2.Espacio1 + ficha2.Espacio2;
            int suma = puntosFicha1 + puntosFicha2;
            return suma;
        }

        


    }
    class Program
    {
        static void Main(string[] args)
        {

            Domino ficha1 = new Domino(5,6);
            Domino ficha2 = new Domino(2,3);
            int suma = ficha1 + ficha2;
            Console.WriteLine("La suma de los puntos de ambas piezas es: " + suma);
        }
    }
}

