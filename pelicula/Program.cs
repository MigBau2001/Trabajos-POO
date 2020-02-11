using System;

namespace pelicula
{

    class Pelicula
    {
        public string titulo;
        public Int16 año;
        public string pais;
        public string director;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula peli1 = new Pelicula();
            peli1.titulo = "Toy story 4";
            peli1.año = 2019;
            peli1.pais = "Estados unidos";
            peli1.director = "Josh Cooley";

            Pelicula peli2 = new Pelicula();
            peli2.titulo = "Parasite";
            peli2.año = 2019;
            peli2.pais = "Corea del sur";
            peli2.director = "Bong Joon-ho";

            Console.WriteLine("Titulo de la primera pelicula: " + peli1.titulo);
            Console.WriteLine("Año de la primera pelicula: " + peli1.año);
            Console.WriteLine("");
            Console.WriteLine("Titulo de la segunda pelicula: " + peli2.titulo);
            Console.WriteLine("Año de la segunda pelicula: " + peli2.año);
        }
    }
}
