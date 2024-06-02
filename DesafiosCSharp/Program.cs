using System;

namespace DesafiosCSharp {

    class Program {

        public static void Main(string[] args){

            Console.WriteLine("/*********** 1) PROJETO PIRÂMIDE ***********/\n");

            Piramide pir = new Piramide(6);
            pir.Desenha();

            Console.WriteLine("\n/*********** 2) PROJETO VÉRTICE ***********/\n");

            Vertice ver = new Vertice(4, 0);
            Vertice ver2 = new Vertice(0, 0);
            Vertice ver3 = new Vertice(0, 4);
            Console.WriteLine("Antes de mover");
            Console.WriteLine($"X: {ver.X}");
            Console.WriteLine($"Y: {ver.Y}");
            ver.Move(5, 6);
            Console.WriteLine("Depois de mover");
            Console.WriteLine($"X: {ver.X}");
            Console.WriteLine($"Y: {ver.Y}");
            Console.WriteLine($"Distância entre os vértices: {ver.Distancia(ver2)}");
            ver.VerificaVerticeIgual(ver2);


            Console.WriteLine("\n/*********** 3) PROJETO TRIÂNGULO ***********/\n");

            Triangulo triangulo = new Triangulo(ver, ver2, ver3);
            Console.WriteLine($"Vértice A: ({triangulo.VerticeA.X}, {triangulo.VerticeA.Y})");
            Console.WriteLine($"Vértice B: ({triangulo.VerticeB.X}, {triangulo.VerticeB.Y})");
            Console.WriteLine($"Vértice C: ({triangulo.VerticeC.X}, {triangulo.VerticeC.Y})");
            Console.WriteLine($"Aresta A: {triangulo.VerticeA.Distancia(triangulo.VerticeB)}");
            Console.WriteLine($"Aresta B: {triangulo.VerticeB.Distancia(triangulo.VerticeC)}");
            Console.WriteLine($"Aresta C: {triangulo.VerticeC.Distancia(triangulo.VerticeA)}");
            Console.WriteLine($"Área: {triangulo.Area}");
            Console.WriteLine($"Tipo: {triangulo.Tipo}");
            Console.WriteLine($"Perímetro: {triangulo.Perimetro}");

            Triangulo triangulo2 = new Triangulo(new Vertice(0, 4), new Vertice(0, 5), new Vertice(5, 2));

            Console.WriteLine("\n/*********** 4) PROJETO POLÍGONO ***********/\n");

            Poligono poligono = new Poligono(ver, ver2, ver3);
            poligono.VerVertices();
            poligono.AddVertice(new Vertice(8, 5));
            poligono.AddVertice(new Vertice(2, 4));
            Console.WriteLine("Quantidade de Vértices: {0}", poligono.QuantVertices);
            Console.WriteLine("Perímetro");
            poligono.Perimetro();
            poligono.RemoveVertice(ver);
            poligono.RemoveVertice(ver2);
            poligono.RemoveVertice(ver3);
            poligono.VerVertices();

            Console.WriteLine("\n/*********** 5) PROJETO INTERVALO ***********/\n");

            Intervalo intervalo = new Intervalo(new DateTime(2020, 1, 1, 20, 00, 00), new DateTime(2020, 1, 5, 15, 0, 0));
            Intervalo intervalo2 = new Intervalo(new DateTime(2020, 1, 2, 20, 00, 00), new DateTime(2020, 1, 4, 15, 0, 0));
            Console.WriteLine(intervalo.Duracao.Ticks);
            Console.WriteLine(intervalo2.Duracao.Ticks);
            intervalo.VerificaIntervalosIguais(intervalo2);
            Console.WriteLine("Tem interseção? {0}", intervalo.TemIntersecao(intervalo2) ? "Sim" : "Não");

            Console.WriteLine("\n/*********** 6) PROJETO LISTA INTERVALO ***********/\n");

            ListaIntervalo list = new ListaIntervalo(new Intervalo(new DateTime(2020, 1, 1, 20, 00, 00), new DateTime(2020, 1, 5, 15, 0, 0)));
            list.VerIntervalos();
            list.Add(new Intervalo(new DateTime(2020, 2, 1, 20, 00, 00), new DateTime(2020, 2, 4, 15, 0, 0)));
            list.VerIntervalos();

            Console.WriteLine("\n/*********** 7) PROJETO ARMSTRONG ***********/\n");

            int number = 54748;
            number.IsArmstrong();

            Console.WriteLine("\n/*********** 8) PROJETO LISTA INTERVALO ***********/\n");

            ValidacaoDados.Executar();

            Console.WriteLine("\n/*********** 9) PROJETO CARRO ***********/\n");

            Carro carro = new Carro("MOA-459", "Celta", new Motor(1.6));
            Console.WriteLine("Placa: {0}", carro.Placa);
            Console.WriteLine("Modelo: {0}", carro.Modelo);
            Console.WriteLine("Motor: {0}", carro.Motor.Cilindrada);
            Console.WriteLine("Motor instalado?: {0}", carro.StatusMotor);
            carro.VelocidadeMaxima();
            carro.TrocarMotor(new Motor(2.2));
            carro.VelocidadeMaxima();
            carro.MotorInstalado(true);


            Console.WriteLine(" ");

            Carro carro2 = new Carro("NFJ-896", "Civic", new Motor(1.0));
            Console.WriteLine("Placa: {0}", carro2.Placa);
            Console.WriteLine("Modelo: {0}", carro2.Modelo);
            Console.WriteLine("Motor: {0}", carro2.Motor.Cilindrada);
            carro2.VelocidadeMaxima();
            carro2.TrocarMotor(new Motor(2.2));
            carro2.VelocidadeMaxima();

            Console.WriteLine("\n/*********** 10) PROJETO LISTA INTERVALO ***********/\n");

            List<String> lista = ["Oi", "Tchau", "Legal", "Beleza", "Oi"];
            Console.WriteLine(lista.RemoveRepetidos());

        }
    }
}