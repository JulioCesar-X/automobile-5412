using System;

namespace Automobile
{
    internal class Reserva
    {
        private int _id;
        private object _veiculo;
        private DateTime _datainicio;
        private DateTime _datafim;

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

            }
        }

        public int Id { get; set; }

        public Reserva(int id, object veiculo, DateTime datainicio, DateTime datafim)
        {
            Id = id;
            _veiculo = veiculo;
            DataInicio = datainicio;
            DataFim = datafim;
        }

    }



}
