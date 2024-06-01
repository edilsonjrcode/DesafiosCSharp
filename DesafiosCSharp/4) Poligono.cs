using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp {
    class Poligono {

        public List<Vertice> vertices;

        public Poligono(params Vertice[]v) { 
            if(v.Length < 3) {
                throw new Exception("O construtor não pode ter menos do que 3 vértices.");
            }
            vertices = new List<Vertice>(v);
        }
    }
}
