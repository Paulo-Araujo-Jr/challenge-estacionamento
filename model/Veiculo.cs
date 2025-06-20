using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Projeto1.Model
{
    public class Veiculo
    {
        public string placa { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime? dataSaida { get; set; }

        public Veiculo(string placa)
        {
                this.placa = placa;
                dataEntrada = DateTime.Now;
                dataSaida = null;
        }

        public TimeSpan CalcularTempoPermanencia()
        {
            return (dataSaida ?? DateTime.Now) - dataEntrada;
        }

        public double CalcularValor(double valorHora)
        {
            double horas = CalcularTempoPermanencia().TotalHours;
            return Math.Ceiling(horas) * valorHora; 
        }
    }
}