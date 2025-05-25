using ListaJason;
using ListaJason.Entities;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorVeiculos ger = new GerenciadorVeiculos();

            ger.Imprimir();
        }
    }
}