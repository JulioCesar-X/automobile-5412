using System;
using System.Globalization;

namespace Automobile
{
    public class Veiculo
    {
        private string _veiculoMatricula;
        private string _veiculoModelo;
        private string _veiculoPreco;

        public string VeiculoMatricula
        {
            get
            {

                return _veiculoMatricula;
            }
            set
            {
                _veiculoMatricula = value;
            }

        }
        public string VeiculoModelo
        {
            get
            {

                return _veiculoModelo;

            }
            set
            {
                _veiculoModelo = value;
            }

        }
        public string VeiculoPreco
        {

            get
            {
                return _veiculoPreco;
            }

            set
            {
                if (value.Contains("€"))
                {
                    string[] precoE = value.Split('€');
                    value = precoE[0].Trim();

                }

                CultureInfo culture = CultureInfo.InvariantCulture;
                if (!decimal.TryParse(value, NumberStyles.AllowDecimalPoint, culture, out decimal preco) || preco <= 0)
                {
                    throw new ArgumentException("preço invalido!");
                }
                _veiculoPreco = value;

            }


        }
        public Estado VeiculoStatus { get; set; }

        public Veiculo(string veiculoMatricula, string veiculoModelo, string veiculoPreco, Estado veiculoStatus)
        {
            VeiculoMatricula = veiculoMatricula;
            VeiculoModelo = veiculoModelo;
            VeiculoPreco = veiculoPreco;
            VeiculoStatus = veiculoStatus;

        }


        public void Reservar(DateTime dataInicio, DateTime dataFim)
        {
            VeiculoStatus = new Estado(Estado.Tipo.Reservado, dataInicio.Date, dataFim.Date);
        }
        public void Alugar(DateTime dataInicio, DateTime dataFim)
        {
            VeiculoStatus = new Estado(Estado.Tipo.Alugado, dataInicio.Date, dataFim.Date);
        }
        public void EmManutencao(DateTime dataInicio, DateTime dataFim)
        {
            VeiculoStatus = new Estado(Estado.Tipo.EmManutencao, dataInicio.Date, dataFim.Date);
        }

        public void RetornarDisponivel(DateTime dataInicio, DateTime dataFim)
        {
            VeiculoStatus = new Estado(Estado.Tipo.Disponivel, dataInicio.Date, dataFim.Date);
        }



        public override string ToString()
        {

            return $"ID: {VeiculoMatricula}\t Modelo: {VeiculoModelo}\t Preço de Aluguer: {VeiculoPreco} €\t STATUS: {VeiculoStatus.Nome}\t";
        }

    }
}
