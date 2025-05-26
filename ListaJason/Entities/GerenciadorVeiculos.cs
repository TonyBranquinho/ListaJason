using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace ListaJason.Entities
{
    internal class GerenciadorVeiculos
    {
        public List<Veiculo> ListaCarros { get; private set; }

        public GerenciadorVeiculos()
        {
            string caminho = "bancoVeiculos.json";
            string conteudo = File.ReadAllText(caminho);
            ListaCarros = JsonSerializer.Deserialize<List<Veiculo>>(conteudo);
        }

        public void ImprimirListaToda()
        {
            foreach (Veiculo v in ListaCarros)
            {
                Console.WriteLine(v.ToString());
            }
        }

        public Veiculo Verificar(string verifica)
        {
            foreach (Veiculo v in ListaCarros)
            {
                if (verifica.Trim().ToUpper() == v.Modelo.Trim().ToUpper())
                {
                    return v;
                }
            }
            return null;
        }
    }
}
