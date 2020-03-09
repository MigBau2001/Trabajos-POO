﻿using System;
using System.Collections.Generic;

namespace pelicula
{

    class Actor // Clase de la cual haremos la lista de actores
    {
       private string nombreActor;
        private int año;

        public Actor(string nom, int año1) // Constructor de la clase
        {
            nombreActor = nom;
            año = año1;
        }

        // Metodos set y get de los atributos de la clase.
        public void setNombreActor(string nombreA) 
        {
            nombreActor = nombreA;
        }

        public string getNombreActor()
        {
            return nombreActor;
        }

        public void setAñoActor(int año)
        {
            this.año = año;
        }

        public int getAñoActor()
        {
            return año;
        }
        
    }

    class Pelicula
    {
        private string titulo;
        private Int16 año;
        public string pais;
        public string director;
        List <Actor> Actores =  new List<Actor>();

        public Pelicula(string titulo, Int16 año)
        { 
            this.titulo = titulo;
            this.año = año;
        }
        public void setTitulo(string titulo1)
        {
            titulo = titulo1;
        }

        public string getTitulo()
        {
            return titulo;
        }

        public void setAño(Int16 año1)
        {
            año = año1;
        }

        public Int16 getAño()
        {
            return año;
        }

        public void Imprime()
        {
            Console.WriteLine("{0}({1})", titulo, año);
            
        }

        public void AgregarActor(Actor actor)
        {
            Actores.Add(actor);
        }


        public void ImprimeActores()
        {
            foreach (Actor a in Actores)
            Console.WriteLine(a.getNombreActor() + "(" + a.getAñoActor() + ")");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /* Pelicula peli1 = new Pelicula();
            peli1.setTitulo("Toy story 4");
            peli1.setAño(2019);
            peli1.pais = "Estados unidos";
            peli1.director = "Josh Cooley";

            Pelicula peli2 = new Pelicula();
            peli2.setTitulo("Parasite");
            peli2.setAño(2019);
            peli2.pais = "Corea del sur";
            peli2.director = "Bong Joon-ho";
            */

            /*Console.WriteLine("{0}({1})", peli1.getTitulo(), peli1.getAño());
            Console.WriteLine("");
            Console.WriteLine("{0}({1})", peli2.getTitulo(), peli2.getAño());
            */
            List <Pelicula> peliculas = new List<Pelicula>();
            peliculas.Add(new Pelicula("Roma", 2018));
            peliculas.Add(new Pelicula("Kung Fu Panda", 2008));
            peliculas.Add(new Pelicula("Black Panther", 2018));
            peliculas.Add(new Pelicula("Spider man 2", 2004));
            peliculas.Add(new Pelicula("50 sombras de Grey", 2015));

            foreach(Pelicula a in peliculas)
            a.Imprime();

            Console.WriteLine();
            // implementación de actividad ACTORES
            Pelicula Sonic = new Pelicula("Sonic", 2020);
           
            Sonic.AgregarActor(new Actor("Jim carrey", 1962));
            Sonic.AgregarActor(new Actor("James Marsden", 1973));
            Sonic.AgregarActor(new Actor("Ben Schwartz", 1981));
            Sonic.AgregarActor(new Actor("Neal McDonough", 1966));

            Sonic.ImprimeActores();




        }
    }
}
