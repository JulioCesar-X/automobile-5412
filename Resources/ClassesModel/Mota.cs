namespace Automobile
{
    public class Mota : Veiculo
    {
        private string _cilindrada;
        public string Cilindrada
        {
            get
            {

                return _cilindrada;
            }
            set
            {
                if (value.Contains("cc"))
                {
                    string[] cilindradaFull = value.Split('c');
                    value = cilindradaFull[0].Trim();

                }
                if (!int.TryParse(value, out int cilindrada) || (cilindrada != 50 && cilindrada != 125 && cilindrada != 300))
                {
                    throw new CilindradaInvalidaException(value);

                }
                _cilindrada = value;


            }
        }

        public Mota(string veiculoMatricula, string veiculoModelo, string veiculoPreco, Estado veiculoStatus, string cilindrada) : base(veiculoMatricula, veiculoModelo, veiculoPreco, veiculoStatus)
        {
            Cilindrada = cilindrada;
        }

        public override string ToString()
        {
            return base.ToString() + $" Cilindrada: {Cilindrada} cc\t";
        }


    }
}
