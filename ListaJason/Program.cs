using ListaJason;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ListaNumeros = new List<int>() { 1, 2, 3, 4, 5 };

            Nomes nomes = new Nomes();

            Console.WriteLine("Digite um numero a ser excluido");
            int excluir = int.Parse(Console.ReadLine());

            nomes.Remover(ListaNumeros, excluir);

            Console.WriteLine(ListaNumeros);
        }
    }
}