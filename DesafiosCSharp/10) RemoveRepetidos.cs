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
                if (lista[i].Equals(lista[i++])) {
                    Console.WriteLine("Item {0} é igual o item {1}", lista[i], lista[i++]);
                } else {
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

            return valoresUnicos;
        }

    }
}
