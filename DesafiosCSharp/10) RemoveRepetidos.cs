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
                for (int j = 0; j < valoresUnicos.Count; j++) {
                    if (lista[i].Equals(valoresUnicos[j])) {
                        Console.WriteLine("O Item {0} é repetido!", lista[i]);
                        repete = true;
                        break;
                    }
                }
                    if (!repete) {
                    valoresUnicos.Add(lista[i]);
                }
            }

            foreach (var valor in valoresUnicos)
            {
                Console.Write("{0}, ", valor);
            }

            return valoresUnicos;
        }

    }
}
