using System;

using System;

using System;

namespace cronometro_RubinMondino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cron = new Cronometro();
            cron.Reiniciar();

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine();
                Console.WriteLine("1 Reiniciar cronómetro");
                Console.WriteLine("2 Sumar 1 segundo");
                Console.WriteLine("3 Mostrar tiempo");
                Console.WriteLine("4 Simular 5000 segundos (desde cero)");
                Console.WriteLine("5 Salir");
                Console.Write("Opción: ");

                var op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        cron.Reiniciar();
                        Console.WriteLine("-> Reiniciado a 0.");
                        break;

                    case "2":
                        cron.IncrementarTiempo();
                        Console.WriteLine("-> +1 segundo.");
                        break;

                    case "3":
                        Console.WriteLine("Tiempo actual: " + cron.MostrarTiempo());
                        break;

                    case "4":
                        cron.Reiniciar();              
                        for (int i = 0; i < 5000; i++)
                        {
                            cron.IncrementarTiempo();
                        }
                        Console.WriteLine("Después de 5000 s: " + cron.MostrarTiempo());
                        break;

                    case "5":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}
