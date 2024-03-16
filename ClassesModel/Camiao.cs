namespace Automobile
{
    public class Camiao : Veiculo
    {
        private string _pesoMaximo;
        public string PesoMaximo
        {
            get
            {
                return _pesoMaximo;
            }
            set
            {
                if (value.Contains("kg"))
                {
                    string[] aux = value.Split('k');
                    value = aux[0].Trim();
                }

                if (!int.TryParse(value, out int pesoMax) || pesoMax <= 0 || pesoMax > 44000)
                {

                    throw new PesoMaximoInvalidoException(pesoMax);

                }
                else
                {
                    _pesoMaximo = value;
                }

            }


        }

        public Camiao(string veiculoMatricula, string veiculoModelo, string veiculoPreco, Estado veiculoStatus, string pesoMaximo) : base(veiculoMatricula, veiculoModelo, veiculoPreco, veiculoStatus)
        {

            PesoMaximo = pesoMaximo;
        }

        public override string ToString()
        {

            return base.ToString() + $"Peso Máximo suportado: {PesoMaximo} kg";
        }
    }
}
