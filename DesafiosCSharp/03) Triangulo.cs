using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp {
    class Triangulo {

        public Vertice VerticeA { get; private set; }
        public Vertice VerticeB { get; private set; }
        public Vertice VerticeC { get; private set; }

         public Triangulo(Vertice verticeA, Vertice verticeB, Vertice verticeC) {
            if(verticeA.Distancia(verticeB) + verticeB.Distancia(verticeC) > verticeC.Distancia(verticeA) 
                & verticeB.Distancia(verticeC) + verticeC.Distancia(verticeA) > verticeA.Distancia(verticeB)
                & verticeC.Distancia(verticeA) + verticeA.Distancia(verticeB) > verticeB.Distancia(verticeC)) {
                    VerticeA = verticeA;
                    VerticeB = verticeB;
                    VerticeC = verticeC;
            } else {
                throw new Exception("Os vértices não formam um triângulo");
            }
        }   

        public enum TipoTriangulo {equilatero, isosceles, escaleno}

        private double perimetro;
        public double Perimetro { 
            get {
                return perimetro = VerticeA.Distancia(VerticeB) + VerticeB.Distancia(VerticeC) + VerticeC.Distancia(VerticeA);   
            } 
        }
        private TipoTriangulo tipo;
        public TipoTriangulo Tipo { 
            get {
                if (VerticeA.Distancia(VerticeB) == VerticeB.Distancia(VerticeC) & VerticeB.Distancia(VerticeC) == VerticeC.Distancia(VerticeA)) {
                    return tipo = TipoTriangulo.equilatero;
                } else if (VerticeA.Distancia(VerticeB) == VerticeB.Distancia(VerticeC) | VerticeB.Distancia(VerticeC) == VerticeC.Distancia(VerticeA)) {
                    return tipo = TipoTriangulo.isosceles;
                } else {
                    return tipo = TipoTriangulo.escaleno;
                }
            }
        }

        private double area;
        public double Area {
            get {
                double S = Perimetro / 2;
                return area = Math.Sqrt(S * (S - VerticeA.Distancia(VerticeB)) * (S - VerticeB.Distancia(VerticeC)) * (S - VerticeC.Distancia(VerticeA)));
            }
        }

        public void TriangulosIguais(Triangulo triangulo) {
            if (VerticeA.Distancia(VerticeB) == triangulo.VerticeA.Distancia(VerticeB) & VerticeB.Distancia(VerticeC) == triangulo.VerticeB.Distancia(VerticeC)) 
                Console.WriteLine("Os triângulos são iguais!");
            else
                Console.WriteLine("Os triângulos são diferentes!");
        }
    }
}
