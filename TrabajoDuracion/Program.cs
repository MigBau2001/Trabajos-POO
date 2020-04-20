using System;

namespace TrabajoDuracion
{
    
    class Duracion
    {
        private int horas;
        private int minutos;
        private int segundos;

        public Duracion(int h, int m, int s)
        {
          / horas = h;
            minutos = m;
            segundos = s;
        
        }

        public Duracion(int segundos) : this(min, hor, seg)
        {
            int min = segundos / 60;
            if(min > 60)
            {
                int hor = minutos/60;
            }
            int seg = (segundos%60) * 60;
        }

        
        public void Imprimir()
        {
            Console.WriteLine("{0}h:{1}m:{2}s", horas, minutos, segundos);
        }

         public static int operator +(Duracion prim, Duracion seg)
        {
            int sumaDuraciones= prim + seg;
            
            return sumaDuraciones;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duracion primero = new Duracion(542);  
            Duracion segundo = new Duracion(100); 
            int suma = primero + segundo;
            primero.Imprimir();
            segundo.Imprimir();
            Console.WriteLine("La suma de ambas duraciones en segundo es: " + suma);
        }
    }
}
