using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp {
    class Intervalo {

        DateTime dataInicial { get; }
        DateTime dataFinal { get; }

        public Intervalo(DateTime dataInicial, DateTime dataFinal) {
            if (dataInicial > dataFinal) {
                throw new Exception("A data inicial não pode ser maior que a data final.");
            }
            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;
        }

        private TimeSpan duracao;
        public TimeSpan Duracao { 
            get {
                TimeSpan intervalo = this.dataFinal - this.dataInicial;
                return duracao = intervalo;
            }
        }

        public void VerificaIntervalosIguais(Intervalo intervalo) {
            int compareTime = TimeSpan.Compare(this.duracao, intervalo.duracao);
            if (compareTime == 0) Console.WriteLine("Os intervalos são iguais!");
            if (compareTime == -1) Console.WriteLine("O segundo intervalo é maior!");
            if (compareTime == 1) Console.WriteLine("O primeiro intervalo é maior!");
        }

        public bool TemIntersecao(Intervalo intervalo) {
            return true;
        }


    }
}
