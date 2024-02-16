namespace Automobile
{
    public class Veiculo
    {
        private int _veiculoId = -1;
        private string _veiculoModelo = "N/A";
        private string _veiculoStatus = "N/A";
        private decimal _veiculoPreco = -1;

        public int VeiculoId
        {
            get
            {

                return _veiculoId;
            }
            set
            {

                //TODO: Checar na empresa se ja tem algum veiculo com esse id registrado antes de trocar
                _veiculoId = value;
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

        public Veiculo(int veiculoId, string veiculoModelo, decimal veiculoPreco, string veiculoStatus)
        {
            VeiculoId = veiculoId;
            VeiculoModelo = veiculoModelo;
            VeiculoPreco = veiculoPreco;
            VeiculoStatus = veiculoStatus;

        }

        public override string ToString()
        {

            return $"ID: {VeiculoId}\t Modelo: {VeiculoModelo}\t Preço de Aluguer: {VeiculoPreco} €\t STATUS: {VeiculoStatus}\t";
        }

    }
}
