using System.IO;

namespace ConwaysGame;

public class Importador {
    private string Url;
    private int FileLines = 0;

    public Importador(string url) {
        this.Url = url;
    }

    public bool[,] LoadTablero() {
        string content = File.ReadAllText(Url);
        string[] contentLines = content.Split('\n');

        this.FileLines = contentLines.Length;

        bool[,] tablero = new bool[contentLines.Length, contentLines[0].Length];
        for (int y = 0; y < contentLines.Length;y++)
        {
            for (int x = 0; x < contentLines[y].Length; x++)
            {
                if(contentLines[y][x] == '1')
                {
                    tablero[x,y] = true;
                }
            }
        }

        return tablero;
    }

    public void SetUrl(string url) {
        this.Url = url;
    }

    public string GetUrl() {
        return this.Url;
    }
    public int GetFileLines() {
        return this.FileLines;
    }
}