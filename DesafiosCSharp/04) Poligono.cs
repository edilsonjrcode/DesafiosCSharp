using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp {
    class Poligono {

        public List<Vertice> vertices;

        public int QuantVertices { 
            get { 
                return vertices.Count;
            }
        }

        public Poligono(params Vertice[]v) { 
            if(v.Length < 3) {
                throw new Exception("O construtor não pode ter menos do que 3 vértices.");
            }
            vertices = new List<Vertice>(v);
        }

        public void Perimetro() {
            double perimetroSoma = 0;

            for (int i = 0; i < vertices.Count; i++) {
                if ((i + 1) != vertices.Count) {
                    perimetroSoma += vertices[i].Distancia(vertices[i + 1]);
                } else {
                    perimetroSoma += vertices[i].Distancia(vertices[1]);
                }
            }

            Console.WriteLine("O perímetro do polígono é: {0}", perimetroSoma);
        }

        public bool AddVertice(Vertice v) {
            foreach (var vertice in vertices) {
                if(vertice.X == v.X & vertice.Y == v.Y) {
                    Console.WriteLine("Já existe um vértice semelhante no polígono");
                    return false;
                }
           }
            vertices.Add(v);
            Console.WriteLine("Novo vértice adicionado!");
            return true;
        }

        public bool RemoveVertice(Vertice v) {
            if (vertices.Count > 3) {
                vertices.Remove(v);
                return true;
            }
            Console.WriteLine("O polígono não pode ter menos do que um vértice");
            return false;
        }

        public void VerVertices() {
            foreach (var vertice in vertices) {
                Console.WriteLine("X: {0}, Y: {1}", vertice.X, vertice.Y);
            }
        }
    }
}
