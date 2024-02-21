using System;

namespace Automobile
{
    internal class Reserva
    {
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


        public Reserva(object veiculo, DateTime datainicio, DateTime datafim)
        {
            _veiculo = veiculo;
            _datainicio = datainicio;
            _datafim = datafim;
        }

    }



}
