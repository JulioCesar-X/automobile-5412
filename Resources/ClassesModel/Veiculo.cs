using System;

namespace Automobile
{
    public class Veiculo
    {
        private string _veiculoMatricula;
        private string _veiculoModelo;
        private decimal _veiculoPreco;

        public string VeiculoMatricula
        {
            get
            {

                return _veiculoMatricula;
            }
            set
            {

                //TODO: Checar na empresa se ja tem algum veiculo com esse id registrado antes de trocar
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
        public decimal VeiculoPreco
        {

            get
            {
                return _veiculoPreco;
            }

            set
            {

                //TODO: Validar se o preço inserido é superior a zero e se não é letra
                _veiculoPreco = value;

            }


        }
        public Estado VeiculoStatus { get; set; }

        public Veiculo(string veiculoMatricula, string veiculoModelo, decimal veiculoPreco, Estado veiculoStatus)
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

        public void RetornarDisponivel()
        {
            VeiculoStatus = new Estado();
        }



        public override string ToString()
        {

            return $"ID: {VeiculoMatricula}\t Modelo: {VeiculoModelo}\t Preço de Aluguer: {VeiculoPreco} €\t STATUS: {VeiculoStatus.Nome}\t";
        }

    }
}
