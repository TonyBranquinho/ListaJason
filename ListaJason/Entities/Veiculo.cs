using ListaJason.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaJason.Entities
{
    internal class Veiculo
    {
        public string Placa {  get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor {  get; set; }
        public int Massa { get; set; }
        public int Potencia { get; set;}
        public string TipoCombustivel { get; set; }
        public double ValorMercado { get; set; }

        public Veiculo() 
        {
        }

        public Veiculo(string placa, string marca, string modelo, int ano, string cor, int massa, int potencia, string tipoCombustivel, double valorMercado)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Cor = cor;
            Massa = massa;
            Potencia = potencia;
            TipoCombustivel = tipoCombustivel;
            ValorMercado = valorMercado;
        }
        public override string ToString()
        {
            return string.Format("{0,-8} {1,-13} {2,-12} {3,-4} {4,-8} {5,2}kg {6,1}cv {7,-12} R$ {8,10:N0}",
                Placa, Marca, Modelo, Ano, Cor, Massa, Potencia, TipoCombustivel, ValorMercado);
        }
    }
}
