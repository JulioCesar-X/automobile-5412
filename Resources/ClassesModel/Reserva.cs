using System;

namespace Automobile
{
    internal class Reserva
    {
        private int _id;
        private Veiculo _veiculo;
        private DateTime _datainicio;
        private DateTime _datafim;
        private double _valorTotal;

        public DateTime DataInicio
        {
            get
            {
                return _datainicio;
            }
            set
            {
                DateTime hoje = DateTime.Today;
                if (DataInicio < hoje)
                {
                    throw new ReservaException(value);
                }
                _datainicio = value;
            }
        }
        public DateTime DataFim
        {
            get
            {
                return _datafim;
            }
            set
            {
                if (_datafim == null)
                {
                    throw new ArgumentNullException("Data final deve ser especificada");
                }

                _datafim = value;
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }

        }
        public Veiculo Veiculo
        {
            get
            {
                return _veiculo;
            }
            set
            {
                _veiculo = value;
            }

        }
        public double ValorTotal
        {
            get
            {
                return _valorTotal;
            }
            set
            {

                _valorTotal = value;
            }

        }

        public Reserva(int id, Veiculo veiculo, DateTime datainicio, DateTime datafim)
        {
            Id = id;
            Veiculo = veiculo;
            DataInicio = datainicio;
            DataFim = datafim;

            // Calcula a diferença entre as datas em horas
            TimeSpan duracao = DataFim - DataInicio;
            double duracaoEmHoras = duracao.TotalHours;

            // Calcula o ValorTotal baseado na duração em horas e no preço do veículo por hora
            ValorTotal = duracaoEmHoras * (double)Veiculo.VeiculoPreco;


        }

    }



}
