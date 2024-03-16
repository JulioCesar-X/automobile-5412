namespace Automobile
{
    public class Carro : Veiculo
    {
        private string _numeroPortas;
        private string _tipoCaixa;

        public string NumeroPortas
        {
            get
            {
                return _numeroPortas;
            }
            set
            {
                if (!int.TryParse(value, out int numPortas) || numPortas != 3 && numPortas != 5)
                {

                    throw new NumeroPortasInvalidoException(value);

                }
                else
                {
                    _numeroPortas = value;
                }

            }

        }
        public string TipoCaixa
        {
            get
            {
                return _tipoCaixa;
            }
            set
            {
                if (value.ToUpper() == "MANUAL" || value.ToUpper() == "AUTOMÁTICA")
                {
                    _tipoCaixa = value;
                }
                else
                {
                    throw new TipoCaixaInvalidoException(value);
                }
            }
        }

        public Carro(string veiculoMatricula, string veiculoModelo, string veiculoPreco, Estado veiculoStatus, string numeroPortas, string tipoCaixa) : base(veiculoMatricula, veiculoModelo, veiculoPreco, veiculoStatus)
        {
            NumeroPortas = numeroPortas;
            TipoCaixa = tipoCaixa;
        }

        public override string ToString()
        {
            return base.ToString() + $"NºPortas: {NumeroPortas}\t Tipo Caixa: {TipoCaixa}\t";
        }
    }
}
