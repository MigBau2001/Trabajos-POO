using System;
using System.Collections.Generic;
 

namespace IlustradorInter
{
    interface IFigura
    {
        int x {get; set;}
        int y {get; set;}
        string color{get; set;}

        void dibuja();
        void printColor();

    }

    public class Circulo: IFigura
    {
        public Circulo(int x, int y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
        public int x {get; set;}
        public int y {get; set;}
        public string color{get; set;}
        public void dibuja()
        {
            Console.WriteLine("Se dibuja un circulo en coordenadas ({0},{1})", x,y);
        }

        public void printColor()
        {
            Console.WriteLine("El color del circulo es: " + color);
        }
    }

    class Rect: IFigura
    {        
        public Rect(int x, int y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
        public int x {get; set;}
        public int y {get; set;}
        public string color{get; set;}

        public void dibuja()
        {
            Console.WriteLine("Se dibuja un rectangulo en coordenadas ({0},{1})", x,y);
        }

        public void printColor()
        {
            Console.WriteLine("El color del rectangulo es: " + color);
        }
    }

    class Program
    {
           static void Main(string[] args)
        {
            List<IFigura> figuras = new List<IFigura>();
            figuras.Add(new Circulo(12,13,"Verde"));
            figuras.Add(new Rect(12,13,"azul"));
            figuras.Add(new Rect(12,13,"rojo"));
            figuras.Add(new Circulo(12,13,"rojo"));
            foreach (var item in figuras){
                item.dibuja();
                item.printColor();
            }    
            
        }    
    }   
}

