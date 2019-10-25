using System;
using System.IO;
using ConsolApp.Class;

namespace ConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Config p = new Config();
            String res = p.Suma(2,3);
            p.Imprimir(res);
            Console.WriteLine("Ingresa los Datos");
            String dato = Console.ReadLine();
            p.Imprimir(dato);
        }
    }
}
