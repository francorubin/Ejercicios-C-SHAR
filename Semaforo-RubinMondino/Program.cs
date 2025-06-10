using System;

namespace Semaforo_RubinMondino
{
    class Program
    {
        static void Main(string[] args)
        {
            Semaforo s = new Semaforo("Rojo");
            for (int i = 0; i < 65; i++)
            {
                Console.WriteLine(s.mostrarColor());
                s.pasoDelTiempo(1);
            }

            s.ponerEnIntermitente();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(s.mostrarColor());
                s.pasoDelTiempo(1);
            }

            s.sacarDeIntermitente();
            Console.WriteLine(s.mostrarColor());
        }
    }
}
