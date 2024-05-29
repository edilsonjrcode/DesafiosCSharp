using System;

namespace DesafiosCSharp {

    class Program {

        public static void Main(string[] args){

            Console.WriteLine("/*********** 1) PROJETO PIRÂMIDE ***********/\n");

            Piramide pir = new Piramide(6);
            pir.Desenha();

            Console.WriteLine("\n/*********** 2) PROJETO VÉRTICE ***********/\n");

            Vertice ver  = new Vertice(4, 0);
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

            //Poligono poligono = new Poligono(ver, ver2, ver3);
            //Console.WriteLine(poligono.vertices[0]);

            Console.WriteLine("\n/*********** 5) PROJETO INTERVALO ***********/\n");

            Intervalo intervalo = new Intervalo(new DateTime(2020, 1, 1, 20, 00, 00), new DateTime(2020, 1, 5, 15, 0, 0));
            Intervalo intervalo2 = new Intervalo(new DateTime(2020, 1, 1, 20, 00, 00), new DateTime(2020, 1, 10, 15, 0, 0));
            Console.WriteLine(intervalo.Duracao);
            Console.WriteLine(intervalo2.Duracao);
            intervalo.VerificaIntervalosIguais(intervalo2);
        }
    }
}