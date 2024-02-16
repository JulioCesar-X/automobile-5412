using System;
using System.Text;

namespace Automobile
{
    public class Camiao : Veiculo
    {
        private int _pesoMaximo;
        public int PesoMaximo
        {
            get
            {
                return _pesoMaximo;
            }
            set
            {

                if (value <= 0 || value > 44000)
                {
                    throw new PesoMaximoInvalidoException(value);
                }
                else
                {
                    _pesoMaximo = value;
                }

            }


        }


        public Camiao(int veiculoId, string veiculoModelo, decimal veiculoPreco, string veiculoStatus, int pesoMaximo) : base(veiculoId, veiculoModelo, veiculoPreco, veiculoStatus)
        {

            PesoMaximo = pesoMaximo;
        }

        public override string ToString()
        {
            Console.OutputEncoding = Encoding.UTF8;

            return base.ToString() + $"Peso Máximo suportado: {PesoMaximo} kg";
        }
    }
}
