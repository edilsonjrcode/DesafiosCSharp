namespace DesafiosCSharp {
    class Piramide {

        private int n;

        public int N {
            get {
                return n;
            }

            set {
                if (value >= 1) {
                    n = value;
                } else {
                    throw new Exception("N não pode ser menor do que 1");
                }
            }
        }

        public Piramide(int n) {
            this.N = n;
        }

        public void Desenha() {
            for (int i = 1; i <= this.N; i++) {
                for (int esp = i; esp != this.n; esp++) {
                        Console.Write(" ");
                }
                for (int j = 1; j < i; j++) {
                    Console.Write(j);
                }
                Console.Write($"{i}");
                for (int k = i; k > 0; k--) {
                    if (k != i) {
                        Console.Write(k);
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }
}

