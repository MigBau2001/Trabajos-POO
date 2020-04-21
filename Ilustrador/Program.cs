using System;
using System.Collections.Generic;

namespace Ilustrador
{
    abstract class Figura  // Se puede pensar como un template para las subclases que hereden de esta base
    {
        protected int x;
        protected int y;
        protected string color;

        public Figura(int x, int y, string c){
            this.x = x; this.y = y; color = c;
        }

       public abstract void dibuja();

        public abstract void printColor();
    }

    class Circulo : Figura {
        public Circulo(int x, int y, string c):base(x , y, c){
        }

        public override void dibuja(){
            Console.WriteLine("Se dibuja un circulo en coordenadas ({0},{1})", x,y);
        }

        public override void printColor()
        {
            Console.WriteLine("El color del circulo es: " + color);
        }
    }

    class Rect : Figura {
        public Rect(int x, int y, string c):base(x , y, c){
            }

        public override void dibuja()
        {
            Console.WriteLine("Se dibuja un rectangulo en coordenadas ({0},{1})", x,y);
        }

        public override void printColor()
        {
            Console.WriteLine("El color del rectangulo es: " + color);
        }
    }
    class Program{
        static void Main(string[] args){
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo(12,13,"Verde"));
            figuras.Add(new Rect(12,13,"azul"));
            figuras.Add(new Rect(12,13,"rojo"));
            figuras.Add(new Circulo(12,13,"rojo"));
            foreach (var item in figuras){
                item.dibuja();
                item.printColor();
            }    
            Circulo r = new Circulo(10,10,"rojo");   
            r.dibuja();
            }
        }
}
