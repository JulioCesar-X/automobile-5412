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


        public Camiao(string veiculoMatricula, string veiculoModelo, decimal veiculoPreco, string veiculoStatus, int pesoMaximo) : base(veiculoMatricula, veiculoModelo, veiculoPreco, veiculoStatus)
        {

            PesoMaximo = pesoMaximo;
        }

        public override string ToString()
        {

            return base.ToString() + $"Peso Máximo suportado: {PesoMaximo} kg";
        }
    }
}
