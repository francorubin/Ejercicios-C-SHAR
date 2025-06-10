using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace cronometro_RubinMondino
{
    public class Cronometro
    {
        private int segundos;
        private int minutos;

        public void Reiniciar()
        {
            segundos = 0;
            minutos = 0;
        }

        public void IncrementarTiempo()
        {
            segundos++;
            if (segundos >= 60)
            {
                segundos -= 60;
                minutos++;
            }
        }

        public string MostrarTiempo()
        {
            return $"{minutos} minutos, {segundos} segundos";
        }
    }
}
