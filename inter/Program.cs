using System;
using System.Collections.Generic;

namespace inter
{

    interface IPluma
    {
        string Color {get; set;}
        bool Abrir();
        bool Cerrar();
        void Escribir(string text);
    }

    class Gis
    {

        public Gis(string color)
        {
            Color = color;
        }
        string Color {get; set;}
        public void Escribir(string text)
        {
            Console.WriteLine("Escribe el texto {0} en color {1}", texto, Color);
        }
    }

    class Bic : IPluma
    {
        public string Color {get => throw new NotImplementedException(); } 

        private bool tieneTapon = true;
        public bool Abrir()
        {
            tieneTapon = false;
            return tieneTapon;
        }

        public bool Cerrar()
        {
            tieneTapon = true;
            return tieneTapon;
        }

        public void Escribir(string text)
        {
            if(!tieneTapon)
            {
                Console.WriteLine("Escribe el texto: {0} en color {1}", texto, Color);
            } else
            {
                Console.WriteLine("No escribe nada");
            }

        }

    }

    class Cello:IPluma


    class Program
    {
        static void Main(string[] args)
        {
            Cello pluma_cello = new Cello("Rojo");
            Bic pluma_bic = new Bic("Azul");
            Gis gis1 = new Gis("Blanco");

            List<IPluma> plumas = new List<IPluma>();
            plumas.Add(pluma_cello);
            plumas.Add(pluma_bic);
            plumas.Add(gis1);

            foreach(var objeto in plumas)
            {
                if(objeto is IPluma)
                {
                    Console.WriteLine("El objeto implementa IPluma");
                    (objeto as IPluma).Abrir();
                    
                }
                else
                {
                    var gis1 = objeto as Gis;
                }
                
            }
            /*    
            pluma_cello.Abrir();
            pluma_cello.Escribir("Hola");
            pluma_bic.Abrir();
            pluma_bic.Escribir(Hola);
            gis1.Escribir("Hola")
            */
        }
    }
}
