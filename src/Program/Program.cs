using System.Runtime.InteropServices;
using Library;

namespace ConwaysGame 
{
    class Program {
        static void Main(string[] args) {
            Importador importador = new Importador(TableroPath);
                Tablero tablero = new Tablero(Importador.LoadTablero());
                
                int lines = importador.GetFileLines();
                Imprimir imprimir = new Imprimir(tablero, lines, lines);
                Imprimir.Printer();
        }
    }
}