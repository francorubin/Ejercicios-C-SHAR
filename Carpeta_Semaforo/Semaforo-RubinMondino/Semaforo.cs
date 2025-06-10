using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaforo_RubinMondino
{
    public class Semaforo
    {
        private int fase; 
        private int segundosRestantes;
        private bool intermitente;
        private bool mostrarAmarillo;

        public Semaforo(string colorInicial)
        {
            intermitente = false;
            mostrarAmarillo = true;
            switch (colorInicial)
            {
                case "Rojo":
                    fase = 0;
                    segundosRestantes = 30;
                    break;
                case "Rojo-Amarillo":
                case "RojoAmarillo":
                    fase = 1;
                    segundosRestantes = 2;
                    break;
                case "Verde":
                    fase = 2;
                    segundosRestantes = 20;
                    break;
                case "Amarillo":
                    fase = 3;
                    segundosRestantes = 2;
                    break;
                default:
                    fase = 0;
                    segundosRestantes = 30;
                    break;
            }
        }

        public void pasoDelTiempo(int segundos)
        {
            if (intermitente)
            {
                for (int i = 0; i < segundos; i++)
                {
                    mostrarAmarillo = !mostrarAmarillo;
                }
                return;
            }

            segundosRestantes -= segundos;
            while (segundosRestantes <= 0)
            {
                int exceso = -segundosRestantes;
                fase = (fase + 1) % 4;
                switch (fase)
                {
                    case 0: segundosRestantes = 30; break;
                    case 1: segundosRestantes = 2; break;
                    case 2: segundosRestantes = 20; break;
                    case 3: segundosRestantes = 2; break;
                }
                segundosRestantes -= exceso;
            }
        }

        public string mostrarColor()
        {
            if (intermitente)
            {
                return mostrarAmarillo ? "Amarillo" : "Apagado";
            }
            switch (fase)
            {
                case 0: return "Rojo";
                case 1: return "Rojo-Amarillo";
                case 2: return "Verde";
                case 3: return "Amarillo";
                default: return "";
            }
        }

        public void ponerEnIntermitente()
        {
            intermitente = true;
            mostrarAmarillo = true;
        }

        public void sacarDeIntermitente()
        {
            intermitente = false;
            fase = 0;
            segundosRestantes = 30;
        }
    }
}
