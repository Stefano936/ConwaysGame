using System;
using System.Text;
using System.Threading;
using Library;

namespace ConwaysGame;
public class Imprimir
{
    private Tablero Tablero;
    private int Width;
    private int Height;

    public Imprimir(Tablero tablero, int width, int height) {
        this.Tablero = tablero;
        this.Width = width;
        this.Height = height;
    }

    public void Print() {
        while (true)
        {   
            Console.Clear();

            StringBuilder s = new StringBuilder();
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if(Tablero.GetTablero()[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            
            Tablero.SetTablero(new LogicaDeJuego(Tablero.GetTablero()).Game());
            Thread.Sleep(300);
        }
    }

    public void SetWidth(int width) {
        this.Width = width;
    }
    public void SetHeight(int height) {
        this.Height = height;
    }

    public int GetWidth() {
        return this.Width;
    }
    public int GetHeight() {
        return this.Height;
    }
}