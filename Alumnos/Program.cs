using System;

namespace Alumnos
{

    class Alumno
    {
        protected string nombre;
        protected int semestre;

        public Alumno(string nom, int sem)
        {
            nombre = nom;
            sem = semestre;

        }

        public void Actividad()
        {
            Console.WriteLine("El alumno esta realizando una actividad");
        }
    }

    class Licenciatura: Alumno
    {
        public Licenciatura(string nombre, int semestre):base(nombre, semestre)
        {

        }

        public new void Actividad()
        {
            Console.WriteLine("El alumno" + nombre + " está ralizando servicio social y residencia");
        }

    }

    class Posgrado:Alumno
    {
        public Posgrado(string nombre, int semestre):base(nombre, semestre)
        {

        }

        public new void Actividad()
        {
            Console.WriteLine("El alumno" + nombre + " tiene un tema de investigación");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Licenciatura claudia = new Licenciatura("Claudia", 9);
            Posgrado martin = new Posgrado("Martin", 10);
            claudia.Actividad();
            martin.Actividad();
        }
    }
}
