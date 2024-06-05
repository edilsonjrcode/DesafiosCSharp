using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp {
    class ListaIntervalo {

        private Intervalo intervalo;

        private List<Intervalo> intervalos;

        public List<Intervalo> Intervalos { 
            get {
                return intervalos.OrderBy(x => x.DataInicial).ToList();
            }

            private set { intervalos = value; }
        }

        public ListaIntervalo(params Intervalo[] v) {
            intervalos = new List<Intervalo>(v);
        }

        public bool Add(Intervalo novoIntervalo) { 
            foreach (var intervalo in intervalos)
            {
                if (intervalo.TemIntersecao(novoIntervalo)) {
                    Console.WriteLine("Esse intervalos não pode ser adicionado poir faz interseção com um intervalo da lista!");
                    return false;
                } 
            }
            intervalos.Add(novoIntervalo);
            Console.WriteLine("Intervalo adicionado!");
            return true;
        }

        public void VerIntervalos() {
            foreach (var intervalo in intervalos) {
                Console.WriteLine("{0}) Data inicial: {1}", intervalos.IndexOf(intervalo), intervalo.DataInicial.ToString("d"));
                Console.WriteLine("{0}) Data final: {1}", intervalos.IndexOf(intervalo), intervalo.DataFinal.ToString("d"));
            }
        }
    }
}
