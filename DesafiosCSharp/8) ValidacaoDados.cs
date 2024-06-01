using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp {
    class ValidacaoDados {

        public static void Executar() {

            int count = 1;

            string nome = "";
            long cpf = 0;
            DateTime dataDeNascimento = new DateTime(0);
            float rendaMensal = 0;
            char estadoCivil = 'A';
            int dependentes = 0;

            while (count < 6) {

                if (count == 1) {
                    Console.Write("Insira seu nome: ");
                    nome = Console.ReadLine();
                    if (nome?.Length < 5) {
                        printError("O nome precisa ter mais do que 5 caracteres");
                        continue;
                    }
                    count++;
                }

                if (count == 2) {
                    Console.Write("Insira seu cpf: ");
                    string cpfLido = Console.ReadLine();
                    try {
                        cpf = long.Parse(cpfLido);
                    } catch (Exception e) {
                        printError(e.Message);
                        continue;
                    }
                    if (cpfLido.Length != 11) {
                        printError("O CPF precisa ter 11 caracteres");
                        continue;
                    }
                    count++;
                }

                Console.Write("Insira sua data de nascimento: ");
                if (count == 3) {
                    String dataDeNascimentoLido = Console.ReadLine();
                    try {
                        dataDeNascimento = DateTime.Parse(dataDeNascimentoLido);
                    }
                    catch (Exception e){
                        printError(e.Message);
                        continue;
                    }
                    if ((DateTime.Today.Year - dataDeNascimento.Year) < 18) {
                        printError("O usuário precisa ter mais de 18 anos");
                        continue;
                    }
                    count++;
                }

                if (count == 4) {
                    Console.Write("Insira sua renda mensal: ");
                    string rendaMensalLido = Console.ReadLine();
                    try {
                        rendaMensal = float.Parse(rendaMensalLido);
                    } catch (Exception e) {
                        printError(e.Message);
                        continue;
                    }
                    if (float.Parse(rendaMensalLido) <= 0) {
                        printError("A sua renda precisa ser maior ou igual a zero.");
                        continue;
                    }
                    count++;
                }

                if (count == 5) {
                    Console.Write("Qual o seu estado civil? Digite 'C' = Casado, 'S' = Solteiro, 'V' = Viúvo, 'D' = Divorciado: ");
                    string estadoCivilLido = Console.ReadLine().ToUpper();
                    try {
                        estadoCivil = char.Parse(estadoCivilLido);
                    } catch (Exception e) {
                        printError(e.Message);
                        continue;
                    }
                    if (estadoCivilLido.Length != 1 || (estadoCivilLido != "C" & estadoCivilLido != "S" & estadoCivilLido != "D" & estadoCivilLido != "V")) {
                        printError("Estado civil inválido.");
                        continue;
                    }
                    count++;
                }

                if (count == 6) {
                    Console.Write("Insira a quantidade de dependentes que possui: ");
                    string dependentesLido = Console.ReadLine();
                    try {
                        dependentes = int.Parse(dependentesLido);
                    } catch (Exception e) {
                        printError(e.Message);
                        continue;
                    }
                    if (int.Parse(dependentesLido) < 0 | int.Parse(dependentesLido) > 10) {
                        printError("A sua quantidade de dependentes precisa ser maior ou igual a 0 e menor ou igual a 10.");
                        continue;
                    }
                    count++;
                }
            }
            //.ToString("dd/MM/yyyy")
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n********** DADOS DO USUÁRIO **********\n");
            Console.ResetColor();
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Cpf: {0}", cpf);
            Console.WriteLine("Data de Nascimento: {0}", dataDeNascimento);
            Console.WriteLine("Renda Mensal: R${0}", rendaMensal);
            Console.WriteLine("Estado Civil: {0}", estadoCivil);
            Console.WriteLine("Dependentes: {0} dependentes", dependentes);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n**************************************\n");
            Console.ResetColor();

            void printError(String msg) {
                Exception e = new Exception(msg);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nOcorreu um erro: {0}\n", e.Message);
                Console.ResetColor();
            }
        }
    }
}
