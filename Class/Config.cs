using System;

namespace ConsolApp.Class
{
    class Config
    {
        public void Imprimir(string dato)
        {
            Console.WriteLine(dato);
        }

        public String Suma(int a, int b){
            int p = a + b;
            String res = Convert.ToString(p);
            String respuesta = "El Resultado de la Suma de " + a + " + " + b + " Es: " + res;
            return respuesta;
        }
    }
}
