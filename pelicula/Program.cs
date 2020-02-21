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

        public Pelicula()
        {

        }

        public Pelicula(string titulo, Int16 año)
        { 
            this.titulo = titulo;
            this.año = año;
        }

        public void Imprime()
        {
            Console.WriteLine("{0}({1})", titulo, año);
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

            Console.WriteLine("{0}({1})", peli1.getTitulo(), peli1.getAño());
            Console.WriteLine("");
            Console.WriteLine("{0}({1})", peli2.getTitulo(), peli2.getAño());

            List <Pelicula> peliculas = new List<Pelicula>();
            peliculas.add("Roma", 2018);
            peliculas.add("Kung Fu Panda", 2008);
            peliculas.add("Black Panther", 2018);
            peliculas.add("Spider man 2", 2004);
            peliculas.add("50 sombras de Grey", 2015);

            foreach(Peliculas a in peliculas);

            


        }
    }
}
