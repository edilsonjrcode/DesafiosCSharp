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
        public bool StatusMotor { get; private set; }

        public Carro(string placa, string modelo, Motor motor) {
            this.Placa = placa;
            this.Modelo = modelo;
            this.Motor = motor;
            this.StatusMotor = true;
        }

        public void TrocarMotor(Motor motor) {
            this.Motor = motor;
            Console.WriteLine("Motor alterado! Seu novo motor possui {0} cilindradas.", motor.Cilindrada);
        }

        public void VelocidadeMaxima() {
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

        public void MotorInstalado(bool status) {
            if(StatusMotor == status) {
                Console.WriteLine("O motor já se encontra {0}.", status? "Instalado" : "Desinstalado");
            }
            StatusMotor = status;
            Console.WriteLine("O motor foi {0}.", status ? "Instalado" : "Desinstalado");
        }
    }
}
