using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp {
    public static class ExtensionRemove {

        public static List<T> RemoveRepetidos<T>(this List<T> lista) {

            List<T> valoresUnicos = new List<T>();

            for (int i = 0; i < lista.Count; i++) {
                bool repete = false;
                for (int j = 0; j < lista.Count; j++) {
                    if(i != j) {
                        if (lista[i].Equals(lista[j])) {
                            Console.WriteLine("Item {0} é igual o item {1}", lista[i], lista[j]);
                            repete = true;
                            break;
                        } 
                    }
                }
                if (!repete) {
                    valoresUnicos.Add(lista[i]);
                }
            }

            //for (int i = 0; i < vertices.Count; i++) {
            //    if ((i + 1) != vertices.Count) {
            //        perimetroSoma += vertices[i].Distancia(vertices[i + 1]);
            //    } else {
            //        perimetroSoma += vertices[i].Distancia(vertices[1]);
            //    }
            //}

            foreach (var valor in valoresUnicos)
            {
                Console.Write("{0}, ", valor);
            }

            return valoresUnicos;
        }

    }
}
