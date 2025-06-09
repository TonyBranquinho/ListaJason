using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using ListaJason.Entities;
using System.Runtime.ConstrainedExecution;


namespace ListaJason.Entities
{
    internal class GerenciadorVeiculos
    {
        // INSTANCIA A LISTA
        public List<Veiculo> ListaCarros { get; private set; }

        // METODO PARA INSTANCIAÇAO, E INICIALIZA A LISTA
        public GerenciadorVeiculos()
        {
            ListaCarros = new List<Veiculo>();
        }

        // BUSCA OS DADOS JSON E SALVA NA LISTA
        public void BuscaDados()
        {
            string caminho = "bancoVeiculos.json";
            string conteudo = File.ReadAllText(caminho);
            ListaCarros = JsonSerializer.Deserialize<List<Veiculo>>(conteudo);
        }

        // SALVA O CONTEUDO DA LISTA DENTRO DO ARQUIVO JSON
        public void SalvaDados()
        {
            string caminho = "bancoVeiculos.json";
            string conteudo = JsonSerializer.Serialize(ListaCarros, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminho, conteudo);
        }

        // IMPRIME A LISTA
        public void ImprimirLista(List<Veiculo> ListaImprimir)
        {
            foreach (Veiculo v in ListaImprimir)
            {
                Console.WriteLine(v.ToString());
            }
        }

        // VERIFICA SE TEM O MODELO DO CARRO NA LISTA
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

        // CADASTRA VEICULOS
        public void Cadastro(Veiculo veiculo)
        {
            ListaCarros.Add(veiculo);
        }

        // BUSCA PLACA
        public Veiculo BuscaPlaca(string buscaPlaca)
        {
            Veiculo placaDoVeiculo = ListaCarros.FirstOrDefault(v => v.Placa.ToUpper() == buscaPlaca.ToUpper());

            if (placaDoVeiculo != null)
            {
                return placaDoVeiculo;
            }
            return null;
        }
    }
}
