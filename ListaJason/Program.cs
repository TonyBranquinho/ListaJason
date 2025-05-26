using ListaJason;
using ListaJason.Entities;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIA UM OBJETO DE CADA UM DAS DUAS CLASSES
            GerenciadorVeiculos ger = new GerenciadorVeiculos();
            Veiculo vei = new Veiculo();

            // SÓ UM TESTE PRA VER SE O JSON TA FUNCIONANDO
            Console.WriteLine($"Total de veículos carregados: {ger.ListaCarros.Count}");

            // CHAMA O METODO E IMPRIME A LISTA INTEIRA
            ger.ImprimirListaToda();

            // SALVA O MODELO DO CARRO A SER VERIFICADO NA LISTA
            Console.WriteLine("");
            Console.Write("Digite um modelo de carro: ");
            string verifica = Console.ReadLine();

            // ATRIBUI O RETORNO DO METODO A VARIAVEL
            Veiculo teste = ger.Verificar(verifica);

            // TESTA SE O RETORNO DO METODO É NULO
            if (teste != null)
            {
                Console.WriteLine();
                Console.WriteLine("Tem esse modelo na lista.");
                Console.WriteLine(ger.Verificar(verifica));
            }
            else
            {
                Console.WriteLine("Nao tem esse modelo na lista.");
            }
        }
    }
}