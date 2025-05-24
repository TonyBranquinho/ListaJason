using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaJason
{
    internal class Nomes
    {
        public void Remover(List<int> ListaNumeros, int excluir)
        {
            for (int i = ListaNumeros.Count - 1; i >= 0; i++)
            {
                if (excluir == ListaNumeros[i])
                {
                    ListaNumeros.RemoveAt(i);
                }
            }
        }

        public void Imprimir(List<int> ListaNumeros)
        {
            foreach (int i in ListaNumeros)
            {
                Console.WriteLine(i);
            }
        }
    }
}
