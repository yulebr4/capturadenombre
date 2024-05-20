using System;

namespace capturadenombre
{
    class Program 
    {

        static void Main(string[] args) 
        {

            Console.WriteLine("Esto es un programa para captura nombres\n");
            string nombre;
            string apellido;
            Console.WriteLine("Introduzca su nombre\n");
            nombre=Console.ReadLine();
            apellido = Console.ReadLine();
            Console.WriteLine("El nombre completo ingresado es: " + nombre + " " + apellido);

        }
    }  
}
