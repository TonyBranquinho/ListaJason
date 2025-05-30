using ListaJason;
using ListaJason.Entities;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIA UM OBJETO
            GerenciadorVeiculos ger = new GerenciadorVeiculos();

            // BUSCA LISTA JSON
            ger.BuscaDados();

            // SÓ UM TESTE PRA VER SE O JSON TA FUNCIONANDO
            Console.WriteLine($"Total de veículos carregados: {ger.ListaCarros.Count}");

            // CHAMA O METODO E IMPRIME A LISTA INTEIRA
            Console.WriteLine();
            ger.ImprimirListaToda();

            // SALVA O MODELO DO CARRO A SER VERIFICADO NA LISTA
            Console.WriteLine("");
            Console.Write("Digite um modelo de carro: ");
            string verifica = Console.ReadLine();

            // ATRIBUI O RETORNO DO METODO A VARIAVEL
            Veiculo teste = ger.Verificar(verifica);

            // TESTA SE O RETORNO DO METODO É NULO E IMPRIME
            if (teste != null)
            {
                Console.WriteLine();
                Console.WriteLine("Tem esse modelo cadastrado, aqui estao suas especificaçoes");
                Console.WriteLine(ger.Verificar(verifica));
            }
            else
            {
                Console.WriteLine("Nao tem esse modelo na lista.");
            }

            // ADICIONA MODELOS DE

            Console.WriteLine();
            Console.WriteLine("Cadastre novos veiculos ou digite ENCERRAR");
            string cadastro = Console.ReadLine();

            if (cadastro.Trim().ToUpper() != "ENCERRAR")
            {
                while (cadastro.Trim().ToUpper() != "ENCERRAR")
                {
                    Console.Write("Digite a placa do veiculo: ");
                    string placa = Console.ReadLine().ToUpper();
                    Console.Write("Digite o MODELO: ");
                    string modelo = Console.ReadLine();
                    Console.Write("Digite a MARCA: ");
                    string marca = Console.ReadLine();
                    Console.Write("Digite o ANO: ");
                    int ano = int.Parse(Console.ReadLine());
                    Console.Write("Digite a COR: ");
                    string cor = Console.ReadLine();
                    Console.Write("Digite a MASSA: ");
                    int massa = int.Parse(Console.ReadLine());
                    Console.Write("Digite a POTENCIA: ");
                    int potencia = int.Parse(Console.ReadLine());
                    Console.Write("Digite o TIPO DE COMBUSTIVEL: ");
                    string tipoCombustivel = Console.ReadLine();
                    Console.Write("Digite o PREÇO: ");
                    double valorMercado = double.Parse(Console.ReadLine());

                    Veiculo dados = new Veiculo(placa, marca, modelo, ano, cor, massa, potencia, tipoCombustivel, valorMercado);

                    ger.Cadastro(dados);
                    ger.SalvaDados();

                    Console.WriteLine();
                    Console.Write("Cadastre mais um carro ou dite ENCERRAR: ");
                    cadastro = Console.ReadLine();
                }
                Console.WriteLine();
                ger.ImprimirListaToda();
            }
        }
    }
}