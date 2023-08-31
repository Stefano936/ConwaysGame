using System.Runtime.InteropServices;
using Library;

namespace ConwaysGame 
{
    class Program {
        static void Main(string[] args) {
            string tableroPath = "../../assets/board.txt";
            Importador importador = new Importador(tableroPath);
            Tablero tablero = new Tablero(importador.LoadTablero());
                
            int lines = importador.GetFileLines();
            Imprimir imprimir = new Imprimir(tablero, lines, lines);
            imprimir.Print();
        }
    }
}