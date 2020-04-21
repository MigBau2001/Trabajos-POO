﻿// Implementación de proyecto Musicos con clases abstractas.

using System;
using System.Collections.Generic;



namespace MusicosAbstractos
{
    abstract class Musico
    {
       protected string nombre;

       public Musico(string n)
       {
           nombre = n;
       }

        public abstract void afina();
        

        public abstract void toca();
       
       public abstract void saluda();
      
    }

    class Baterista: Musico
    {
        protected string bateria;

        public Baterista(string nombre, string b):base(nombre)
        {
            bateria = b;
        }

        public override void saluda()
       {
           Console.WriteLine("Hola soy  el baterista {0}, y mi pila es una {1}", nombre,bateria);
       }

       public override void afina()
        {
            Console.WriteLine(nombre + " está probando su bateria.");
        }

           public override void toca()
        {
            Console.WriteLine(nombre + " está tocando la bateria.");
        }
    }

    class Bajista: Musico
    {
        protected string bajo;

        public Bajista(string nombre, string b):base(nombre)
        {
            bajo = b;
        }

        public override void saluda()
       {
           Console.WriteLine("Hola soy  el bajista {0}, y mi bajo es un {1}", nombre,bajo);
       }

       public override void afina()
        {
            Console.WriteLine(nombre + " está afinando su bajo.");
        }

           public override void toca()
        {
            Console.WriteLine(nombre + " está tocando su bajo.");
        }
    }


    class Guitarrista: Musico
    {
        protected string guitarra;

        public Guitarrista(string nombre, string g):base(nombre)
        {
            guitarra = g;
        }

        public override void saluda()
       {
           Console.WriteLine("Hola soy  el guitarrista {0}, y mi guitarra es un {1}", nombre,guitarra);
       }

       public override void afina()
        {
            Console.WriteLine(nombre + " está afinando su guitarra");
        }

           public override void toca()
        {
            Console.WriteLine(nombre + " está tocando su guitarra");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Baterista carlos = new Baterista("Carlos", "Tama");
            Bajista pedro = new Bajista("Pedro", "Gibson");
            Guitarrista miguel = new Guitarrista("Miguel", "Valencia");

            

            List<Musico> musicos = new List<Musico>();

            musicos.Add(carlos);
            musicos.Add(pedro);
            musicos.Add(miguel);
            musicos.Add(new Bajista("Aldo", "Apex"));

            foreach(var m in musicos)
            {
                m.saluda();
                m.afina();
                m.toca();
                Console.WriteLine("");
            }

        }
    }
}
