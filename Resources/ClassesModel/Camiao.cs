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

                if (int.TryParse(value.ToString(), out int result))
                {
                    throw new PesoMaximoInvalidoException(result);
                }
                else if (result <= 0 || result > 44000)
                {
                    throw new PesoMaximoInvalidoException(result);
                }
                else
                {
                    _pesoMaximo = value;
                }

            }


        }


        public Camiao(string veiculoMatricula, string veiculoModelo, decimal veiculoPreco, Estado veiculoStatus, int pesoMaximo) : base(veiculoMatricula, veiculoModelo, veiculoPreco, veiculoStatus)
        {

            PesoMaximo = pesoMaximo;
        }

        public override string ToString()
        {

            return base.ToString() + $"Peso Máximo suportado: {PesoMaximo} kg";
        }
    }
}
