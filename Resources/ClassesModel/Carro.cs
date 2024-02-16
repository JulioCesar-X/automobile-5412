namespace Automobile
{
    public class Carro : Veiculo
    {
        private int _numeroPortas;
        private string _tipoCaixa;

        public int NumeroPortas
        {
            get
            {
                return _numeroPortas;
            }
            set
            {
                if (value < 3 || value > 5)
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

        public Carro(int veiculoId, string veiculoModelo, decimal veiculoPreco, string veiculoStatus, int numeroPortas, string tipoCaixa) : base(veiculoId, veiculoModelo, veiculoPreco, veiculoStatus)
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
