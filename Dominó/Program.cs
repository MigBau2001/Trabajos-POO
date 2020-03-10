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

        public int Suma()
        {
           return Espacio1 + Espacio2;
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Suma;
            Domino ficha1 = new Domino(5,6);
            Domino ficha2 = new Domino(2,3);

            Suma = ficha1.Suma() + ficha2.Suma();

            Console.WriteLine("La suma de ambas piezas es: " + Suma);
        }
    }
}
