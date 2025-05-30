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
        // ATRIBUTOS
        public string Placa {  get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor {  get; set; }
        public int Massa { get; set; }
        public int PotenciaCV { get; set;}
        public string Combustivel { get; set; }
        public double ValorMercado { get; set; }

        // CONSTRUTOR VAZIO
        public Veiculo() 
        {
        }

        // CONSTRUTOR COM PARAMETROS
        public Veiculo(string placa, string marca, string modelo, int ano, string cor, int massa, int potenciaCV, string combustivel, double valorMercado)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Cor = cor;
            Massa = massa;
            PotenciaCV = potenciaCV;
            Combustivel = combustivel;
            ValorMercado = valorMercado;
        }

        // CONFIGURA A IMPRESSAO DOS DADOS
        public override string ToString()
        {
            return string.Format("{0,-8} {1,-13} {2,-12} {3,-4} {4,-10} {5,0}kg {6,4}cv {7,-10} R$ {8,-7:N0}",
                Placa, Marca, Modelo, Ano, Cor, Massa, PotenciaCV, Combustivel, ValorMercado);
        }
    }
}
