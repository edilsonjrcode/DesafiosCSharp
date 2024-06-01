using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp {
    class Vertice {

        public int X {  get; private set; }
        public int Y { get; private set; }

        public Vertice(int x, int y) {
                this.X = x;
                this.Y = y;
        }

        public double Distancia(Vertice v1) {
            double deltaX = v1.X - this.X;
            double deltaY = v1.Y - this.Y;

            double distancia = Math.Sqrt(Math.Pow((deltaX),2) + Math.Pow((deltaY), 2));

            return distancia;
        }

        public void Move(int x, int y) {
            this.X = x;
            this.Y = y;
        }

        public void VerificaVerticeIgual(Vertice v2) {
            if (this.X == v2.X & this.Y == v2.Y) {
                Console.WriteLine("Os vertices são iguais.");
            } else {
                Console.WriteLine("Os vertices são diferentes.");
            }
        }
    }
}
