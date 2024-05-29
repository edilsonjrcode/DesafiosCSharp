using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp {
    class Poligono {

        public ArrayList vertices;

        public Poligono(params Vertice[]v) { 
            if(v.Length < 3) {
                throw new Exception("O construtor não pode ter menos do que 3 vértices.");
            }
            vertices.Add(v);
        }

        public void QuantidadeDeVertices(params Vertice[] v) {
            
        }


    }
}
