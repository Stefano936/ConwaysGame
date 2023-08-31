using System.Diagnostics.CodeAnalysis;

namespace Library
{
    public class LogicaDeJuego
    {
        private bool[,] GameTablero {get; set;}
        public LogicaDeJuego(bool[,] gb) {
            this.GameTablero = gb;
        }

        public void SetGameTablero(bool[,] gb) {
            this.GameTablero = gb;
        }

        public bool[,] GetGameTablero() {
            return GameTablero;
        }

        public bool[,] Game() {
            int tableroWidth = GameTablero.GetLength(0);
            int tableroHeight = GameTablero.GetLength(1);

            bool[,] clonetablero = new bool[tableroWidth, tableroHeight];
            for (int x = 0; x < tableroWidth; x++)
            {
                for (int y = 0; y < tableroHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i <= x + 1; i++)
                    {
                        for (int j = y-1; j <= y + 1; j++)
                        {
                            if(i>=0 && i < tableroWidth && j >= 0 && j < tableroHeight && GameTablero[i,j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(GameTablero[x,y])
                    {
                        aliveNeighbors--;
                    }
                    if (GameTablero[x,y] && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población
                        clonetablero[x,y] = false;
                    }
                    else if (GameTablero[x,y] && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación
                        clonetablero[x,y] = false;
                    }
                    else if (!GameTablero[x,y] && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción
                        clonetablero[x,y] = true;
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        clonetablero[x,y] = GameTablero[x,y];
                    }
                }
            }
            return clonetablero;
        }
    }
}