using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesafiosCSharp {
    class Intervalo {

        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }

        public Intervalo(DateTime dataInicial, DateTime dataFinal) {
            if (dataInicial > dataFinal) {
                throw new Exception("A data inicial não pode ser maior que a data final.");
            }
            this.DataInicial = dataInicial;
            this.DataFinal = dataFinal;
        }

        private TimeSpan duracao;
        public TimeSpan Duracao { 
            get {
                TimeSpan intervalo = this.DataFinal - this.DataInicial;
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
            if(this.DataInicial < intervalo.DataInicial & this.DataFinal > intervalo.DataFinal) {
                return true;
            }
            return false;
        }


    }
}
