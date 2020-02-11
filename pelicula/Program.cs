using System;

namespace pelicula
{

    class Pelicula
    {
        private string titulo;
        private Int16 año;
        public string pais;
        public string director;

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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula peli1 = new Pelicula();
            peli1.setTitulo("Toy story 4");
            peli1.setAño(2019);
            peli1.pais = "Estados unidos";
            peli1.director = "Josh Cooley";

            Pelicula peli2 = new Pelicula();
            peli2.setTitulo("Parasite");
            peli2.setAño(2019);
            peli2.pais = "Corea del sur";
            peli2.director = "Bong Joon-ho";

            Console.WriteLine("Titulo de la primera pelicula: " + peli1.getTitulo());
            Console.WriteLine("Año de la primera pelicula: " + peli1.getAño());
            Console.WriteLine("");
            Console.WriteLine("Titulo de la segunda pelicula: " + peli2.getTitulo());
            Console.WriteLine("Año de la segunda pelicula: " + peli2.getAño());
        }
    }
}
