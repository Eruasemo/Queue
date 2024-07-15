using System;

namespace listaEnlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nodo test = new Nodo("Hola");

            //test.Dato = "Hola, que tal.";
            //test.Siguiente = test;

            //Console.WriteLine(test.Siguiente.Dato);

            Cola miCola = new Cola("Mi Cola");

            miCola.Encolar("Manuel");
            miCola.Encolar("Isis");
            miCola.Encolar("Joel");
            Console.WriteLine(miCola.Desencolar());
            miCola.Encolar("Melanie");
            miCola.Encolar("Valeria");
            miCola.Encolar("Maximilano");
            miCola.Encolar("Barbie");

            while(!miCola.estaVacia())
            {
               Console.WriteLine(miCola.Desencolar());
            }
            

        }
    }
}
