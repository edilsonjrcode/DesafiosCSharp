using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp {
    public static class Extensions {

        public static bool IsArmstrong(this int number) {

            int somaNumeros = 0;

            Console.WriteLine("Números de Armstrong de 1 até 10000");

            for (int i = 1; i < 10000; i++) {
                for (int j = 0; j < i.ToString().Length; j++) {
                    int numCorte = int.Parse(i.ToString()[j].ToString());
                    int numElevado = numCorte;
                    for (int k = 1; k < i.ToString().Length; k++) {
                        numElevado *= numCorte;
                    }
                    somaNumeros += numElevado;
                }
                if (somaNumeros == i) {
                    Console.WriteLine(i);
                }
                somaNumeros = 0;
            }

            for (int i = 0; i < number.ToString().Length; i++) {
                int numCorte = int.Parse(number.ToString()[i].ToString());
                int numElevado = numCorte;
                for (int j = 1;  j < number.ToString().Length; j++) {
                    numElevado *= numCorte;
                }
                somaNumeros += numElevado;
            }

            if (somaNumeros == number) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} é um número de armstrong!", number);
                Console.ResetColor();
                return true;
            } else {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} não é um número de armstrong!", number);
                Console.ResetColor();
                return false;
            }
        }
        
    }
}
