namespace Library
{
    public class Tablero
    {
        private bool[,] B;
        public Tablero(bool[,] b) {
            this.B = b;
        }

        public void SetTablero(bool[,] b) {
            this.B = b;
        }

        public bool[,] GetTablero() {
            return this.B;
        }
    }
}