namespace Automobile
{
    public class Veiculo
    {
        private string _veiculoMatricula;
        private string _veiculoModelo;
        private string _veiculoStatus;
        private decimal _veiculoPreco;

        public string VeiculoMatricula
        {
            get
            {

                return _veiculoMatricula;
            }
            set
            {

                //TODO: Checar na empresa se ja tem algum veiculo com esse id registrado antes de trocar
                _veiculoMatricula = value;
            }

        }
        public string VeiculoModelo
        {
            get
            {

                return _veiculoModelo;

            }
            set
            {
                _veiculoModelo = value;
            }

        }
        public string VeiculoStatus
        {

            get
            {

                return _veiculoStatus;

            }
            set
            {
                _veiculoStatus = value;

            }


        }
        public decimal VeiculoPreco
        {

            get
            {
                return _veiculoPreco;
            }

            set
            {

                //TODO: Validar se o preço inserido é superior a zero e se não é letra
                _veiculoPreco = value;

            }


        }

        public Veiculo(string veiculoMatricula, string veiculoModelo, decimal veiculoPreco, string veiculoStatus)
        {
            VeiculoMatricula = veiculoMatricula;
            VeiculoModelo = veiculoModelo;
            VeiculoPreco = veiculoPreco;
            VeiculoStatus = veiculoStatus;

        }

        public override string ToString()
        {

            return $"ID: {VeiculoMatricula}\t Modelo: {VeiculoModelo}\t Preço de Aluguer: {VeiculoPreco} €\t STATUS: {VeiculoStatus}\t";
        }

    }
}
