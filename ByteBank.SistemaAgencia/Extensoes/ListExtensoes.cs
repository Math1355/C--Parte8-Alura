using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        public static void TesteGenerico<T2>(this string texto)
        {

        }

        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(14);
            idades.Add(26);
            idades.Add(60);

            idades.AdicionarVarios(1, 2, 3, 4);

            string matheus = "Matheus";

            matheus.TesteGenerico<int>();

            //ListExtensoes<int>.AdicionarVarios(idades, 2, 3, 4);

            List<string> nomes = new List<string>();

            nomes.Add("Matheus");

            //ListExtensoes<string>.AdicionarVarios(nomes, "lucas", "Bia");

            nomes.AdicionarVarios("lucas", "Bia");
        }
    }
}
