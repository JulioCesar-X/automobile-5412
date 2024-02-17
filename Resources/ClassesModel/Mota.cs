namespace Automobile
{
    public class Mota : Veiculo
    {
        private int _cilindrada;
        public int Cilindrada
        {
            get
            {

                return _cilindrada;
            }
            set
            {
                if (value == 50 || value == 125 || value == 300)
                {
                    _cilindrada = value;

                }
                else
                {
                    throw new CilindradaInvalidaException(value);

                }

            }
        }

        public Mota(string veiculoMatricula, string veiculoModelo, decimal veiculoPreco, string veiculoStatus, int cilindrada) : base(veiculoMatricula, veiculoModelo, veiculoPreco, veiculoStatus)
        {
            Cilindrada = cilindrada;
        }

        public override string ToString()
        {
            return base.ToString() + $" Cilindrada: {Cilindrada} cc\t";
        }


    }
}
