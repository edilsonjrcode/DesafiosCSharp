using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp {
    class Carro {

        public string Placa {  get; private set; }
        public string Modelo { get; private set; }
        public Motor Motor { get; private set; }

        public Carro(string placa, string modelo, Motor motor) {
            this.Placa = placa;
            this.Modelo = modelo;
            this.Motor = motor;
        }

        public void trocarMotor(Motor motor) {
            this.Motor = motor;
            Console.WriteLine("Motor alterado! Seu novo motor possui {0} cilindradas.", motor.Cilindrada);
        }

        public void velocidadeMaxima() {
            if (this.Motor.Cilindrada <= 1.0) {
                Console.WriteLine("A velocidade máxima do carro é 140km/h");
            } else if (this.Motor.Cilindrada <= 1.6) {
                Console.WriteLine("A velocidade máxima do carro é 160km/h");
            } else if (this.Motor.Cilindrada <= 2.0) {
                Console.WriteLine("A velocidade máxima do carro é 180km/h");
            } else {
                Console.WriteLine("A velocidade máxima do carro é 220km/h");
            }
        }

    }
}
