namespace Automobile
{
    public class Camioneta : Veiculo
    {
        private string _numeroEixos;
        private string _numeroPassageiros;


        public string NumeroEixos
        {
            get
            {
                return _numeroEixos;
            }

            set
            {
                if (!int.TryParse(value, out int numEixos) || numEixos < 2 || numEixos > 3)
                {
                    throw new NumeroEixosInvalidoException(value);
                }
                else
                {
                    _numeroEixos = value;
                }

            }

        }
        public string NumeroPassageiros
        {
            get
            {
                return _numeroPassageiros;
            }
            set
            {
                if (!int.TryParse(value, out int NumeroPassageiros) || NumeroPassageiros <= 0)
                {

                    throw new NumeroMaximoPassageirosInvalidoException(NumeroPassageiros);

                }
                else
                {
                    _numeroPassageiros = value;
                }

            }

        }

        public Camioneta(string VeiculoMatricula, string veiculoModelo, string veiculoPreco, Estado veiculoStatus, string numeroEixos, string numeroPassageiros) : base(VeiculoMatricula, veiculoModelo, veiculoPreco, veiculoStatus)
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
