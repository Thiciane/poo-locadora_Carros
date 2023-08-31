using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros.Entidades
{
    internal class Carros
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }

        public Carros()
        {

        }
        public Carros(string marca, string modelo, int ano, string cor)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Cor = cor;
        }
        public double Calculo(string diasString)
        {
            int dias = 0;
            if(diasString == "15 dias")
            {
                dias = 15;
            }
            else if(diasString == "1 mês")
            {
                dias = 30;
            }
            else if(diasString == "2 meses")
            {
                dias = 30*2;
            }
            else if(diasString == "3 meses")
            {
                dias = 30*3;
            }
            else if(diasString == "4 meses")
            {
                dias = 30*4;
            }
            else if(diasString == "5 meses")
            {
                dias = 30*5;
            }
            else if(diasString == "6 meses")
            {
                dias = 30*6;
            }
            this.Valor = dias * 80 ;
            return Convert.ToDouble(this.Valor.ToString("00,00"));
        }


    }
}
