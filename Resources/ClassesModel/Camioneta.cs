namespace Automobile
{
    public class Camioneta : Veiculo
    {
        private int _numeroEixos;
        private int _numeroPassageiros;


        public int NumeroEixos
        {
            get
            {
                return _numeroEixos;
            }

            set
            {
                if (value < 2 || value > 3)
                {
                    throw new NumeroEixosInvalidoException(value);
                }
                else
                {
                    _numeroEixos = value;
                }

            }

        }
        public int NumeroPassageiros
        {
            get
            {
                return _numeroPassageiros;
            }
            set
            {
                if (value <= 0)
                {
                    throw new NumeroMaximoPassageirosInvalidoException(value);
                }
                else
                {

                    _numeroPassageiros = value;
                }
            }

        }

        public Camioneta(int veiculoId, string veiculoModelo, decimal veiculoPreco, string veiculoStatus, int numeroEixos, int numeroPassageiros) : base(veiculoId, veiculoModelo, veiculoPreco, veiculoStatus)
        {
            NumeroEixos = numeroEixos;
            NumeroPassageiros = numeroPassageiros;

        }

        public override string ToString()
        {
            return base.ToString() + $"NºEixos: {NumeroEixos}\t NºPassageiros: {NumeroPassageiros}\t";
        }

    }
}
