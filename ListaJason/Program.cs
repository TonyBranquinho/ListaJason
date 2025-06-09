using ListaJason;
using ListaJason.Entities;
using System;
using System.Globalization;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");


            // INSTANCIA UM OBJETO
            GerenciadorVeiculos ger = new GerenciadorVeiculos();


            // BUSCA LISTA JSON
            ger.BuscaDados();


            // SÓ UM TESTE PRA VER SE O JSON TA FUNCIONANDO
            Console.WriteLine($"Total de veículos carregados: {ger.ListaCarros.Count}");


            // CHAMA O METODO E IMPRIME A LISTA INTEIRA
            Console.WriteLine();
            List<Veiculo> ListaParaImprimir = ger.ListaCarros;

            ger.ImprimirLista(ListaParaImprimir);


            // SALVA O MODELO DO CARRO A SER VERIFICADO NA LISTA
            Console.WriteLine("");
            Console.Write("Digite um modelo de carro e veremos se ele consta na lista: ");
            string verifica = Console.ReadLine();


            // ATRIBUI O RETORNO DO METODO A VARIAVEL
            Veiculo teste = ger.Verificar(verifica);


            // TESTA SE O RETORNO DO METODO É NULO E IMPRIME
            if (teste != null)
            {
                Console.WriteLine();
                Console.WriteLine("Tem esse modelo cadastrado, aqui estao suas especificaçoes:");
                Console.WriteLine(teste);
            }
            else
            {
                Console.WriteLine("Nao tem esse modelo na lista.");
            }

            // ADICIONA MODELOS DE VEICULOS
            Console.WriteLine();
            Console.Write("Aperte ENTER para cadastrar novos veiculos ou digite PULAR: ");
            Console.WriteLine();
            string cadastro = Console.ReadLine();

            if (cadastro.Trim().ToUpper() != "PULAR")
            {
                while (cadastro.Trim().ToUpper() != "PULAR")
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

                    Veiculo veiculo = new Veiculo(placa, marca, modelo, ano, cor, massa, potencia, tipoCombustivel, valorMercado);

                    ger.Cadastro(veiculo);
                    ger.SalvaDados();

                    Console.WriteLine();
                    Console.Write("Cadastre mais um carro ou digite PULAR: ");
                    cadastro = Console.ReadLine();
                }
            }

            //Console.WriteLine();
            //ger.ImprimirLista(ListaParaImprimir);

            // CRIA UMA LISTA EM ORDEM CRESCENTE E A IMPRIME
            List<Veiculo> ordenadoPorPreco = ger.ListaCarros.OrderByDescending(v => v.ValorMercado).ToList();

            ListaParaImprimir = ordenadoPorPreco;

            Console.WriteLine();
            Console.WriteLine("LISTA DE CARROS EM ORDEM DECRECENTE PELO PREÇO:");

            ger.ImprimirLista(ListaParaImprimir);


            // IMPRIME O CARRO MAIS PESADO DA LISTA
            Console.WriteLine();
            Console.WriteLine("ESSE É O CARRO MAIS PESADO DA LISTA: ");

            Veiculo maisPesadoDeTodos = ger.ListaCarros.OrderByDescending(v => v.Massa).First();

            Console.WriteLine(maisPesadoDeTodos.ToString());


            // IMPRIME O CARRO MAIS ANTIGO DA LISTA
            Console.WriteLine();
            Console.WriteLine("ESSE É O CARRO MAIS ANTIGO DA LISTA: ");

            Veiculo maisAntigo = ger.ListaCarros.OrderByDescending(v => v.Ano).Last();

            Console.WriteLine(maisAntigo);


            // IMPRIME A MEDIA DE PREÇO DOS VEICULOS DA LISTA
            Console.WriteLine();

            double media = ger.ListaCarros.Average(v => v.ValorMercado);

            Console.Write("O VALOIR MEDIO DOS VEICULOS CADASTRADOS É: R$");
            Console.WriteLine(media.ToString("N2", new CultureInfo("pt-BR")));


            // ATUALIZA DADOS DO VEICULO
            Console.WriteLine();
            Console.Write("DESEJA ALTERAR OS DADOS DE ALGUM VEICULO? ");
            string simOuNao = Console.ReadLine();

            if (simOuNao.Trim().ToLower() == "sim")
            {
                Console.Write("DIGITE A PLACA DO VEICULO A SER ATUALIZADO:");
                string buscaPlaca = Console.ReadLine();

                Veiculo placaDoVeiculo = ger.BuscaPlaca(buscaPlaca);

                Console.Write("Digite a placa do veiculo: ");
                placaDoVeiculo.Placa = Console.ReadLine().ToUpper();
                Console.Write("Digite o MODELO: ");
                placaDoVeiculo.Modelo = Console.ReadLine();
                Console.Write("Digite a MARCA: ");
                placaDoVeiculo.Marca = Console.ReadLine();
                Console.Write("Digite o ANO: ");
                placaDoVeiculo.Ano = int.Parse(Console.ReadLine());
                Console.Write("Digite a COR: ");
                placaDoVeiculo.Cor = Console.ReadLine();
                Console.Write("Digite a MASSA: ");
                placaDoVeiculo.Massa = int.Parse(Console.ReadLine());
                Console.Write("Digite a POTENCIA: ");
                placaDoVeiculo.PotenciaCV = int.Parse(Console.ReadLine());
                Console.Write("Digite o TIPO DE COMBUSTIVEL: ");
                placaDoVeiculo.Combustivel = Console.ReadLine();
                Console.Write("Digite o PREÇO: ");
                placaDoVeiculo.ValorMercado = double.Parse(Console.ReadLine());
                Console.WriteLine();
                
                Console.WriteLine("Esse veiculo foi alterado na lista:");
                Console.WriteLine(string.Join(", ", placaDoVeiculo.ToString()));

                ger.SalvaDados();
            }

            ger.BuscaDados();

            ListaParaImprimir = ger.ListaCarros;

            Console.WriteLine();
            ger.ImprimirLista(ListaParaImprimir);


            //REMOVE VEICULO DA LISTA
            Console.WriteLine();
            Console.Write("Quer remover algum veiculo da lista? ");
            simOuNao = Console.ReadLine();

            if (simOuNao.Trim().ToLower() == "sim")
            {
                Console.Write("Qual a placa do veiculo que voce deseja remover da lsita? ");
                string buscaPlaca = Console.ReadLine();

                Veiculo veiculoAExcluir = ger.BuscaPlaca(buscaPlaca);

                ger.ListaCarros.Remove(veiculoAExcluir);

                Console.WriteLine();
                Console.WriteLine("Esse veiculo foi removido da lista:");
                Console.WriteLine(string.Join(", ", veiculoAExcluir.ToString()));

                ger.SalvaDados();
            }

            Console.WriteLine();
            Console.WriteLine($"Total de veículos carregados: {ger.ListaCarros.Count}");

            ListaParaImprimir = ger.ListaCarros;

            ger.ImprimirLista(ListaParaImprimir);
        }
    }
}