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
                return intervalos;
                //return intervalos.OrderBy(x => x.DataInicial).ToList();
            }

            private set { intervalos = value; }
        }

        public ListaIntervalo(Intervalo intervalo) {
            this.intervalo = intervalo;
            //intervalos = new List<Intervalo>(intervalo);
        }

        public void Add(Intervalo novoIntervalo) { 
            foreach (var intervalo in intervalos)
            {
                if (intervalo.TemIntersecao(novoIntervalo)) {
                    break;
                } 
            }
            intervalos.Add(novoIntervalo);
            Console.WriteLine("Intervalo adicionado!");
        }

    }
}
