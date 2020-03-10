using System;

namespace PasoParametros
{

class ConvertidorAlCuadrado
{
      
    public void Cuadrado(int num)
    {
        num = num*num;

        Console.WriteLine("El número al cuadrado es: " + num);
    }

    public void Cuadrado_ref(ref int num)
    {
        num = num*num;

        Console.WriteLine("El número al cuadrado es: " + num);
    }

    public void Cuadrado_out(int num, out int resultado)
    {
        resultado = num*num;
    } 

    public void Cuadrado_in(in int num)
    {
        num = num*num;
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            // Paso de parametro por valor.
            ConvertidorAlCuadrado convertidor = new ConvertidorAlCuadrado();
            int num = 3;
            convertidor.Cuadrado(num);
            Console.WriteLine("Valor de a: " + num);
            
           // Ejemplificación con ref
            convertidor.Cuadrado_ref(ref num);
            Console.WriteLine("Valor de a: " + num);
            
           // Ejemplificación con out 
            num = 4;
            int resultado; // variable no inicilizada
            convertidor.Cuadrado_out(num, out resultado); // Se inicializa en el metodo llamado
            Console.WriteLine("El resultado de elevar al cuadrado es: " + resultado);

           // Ejemplificación con in
            num = 5;
            convertidor.Cuadrado_in(in num); // La variable solo se puede leer, no modificar.
            // Por lo tanto, nos dará un error.
        }
    }
}
