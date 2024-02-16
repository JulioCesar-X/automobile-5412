using System;


namespace Automobile
{
    public class VeiculoException : Exception
    {
        public VeiculoException(string mensagem) : base(mensagem)
        {

        }
    }




    /*----- Personalização para exceptions especificas relacionadas aos veiculos ------*/

    //Para todos

    public class VeiculoDuplicadoException : VeiculoException
    {
        public VeiculoDuplicadoException(int veiculoId) : base($"Um veículo com o ID \"{veiculoId}\" já existe na lista de veículos.")
        {

        }
    }




    //Para o camião
    public class PesoMaximoInvalidoException : VeiculoException
    {
        public PesoMaximoInvalidoException(int PesoMaximo) : base($"O peso máximo suportado inválido: \"{PesoMaximo}\". Deve estar dentro do intervalo ( 1kg - 44000kg ).")
        {

        }
    }




    //Para o Carro
    public class NumeroPortasInvalidoException : VeiculoException
    {
        public NumeroPortasInvalidoException(int numeroPortas) : base($"Número de portas inválido: \"{numeroPortas}\". Deve ser ( 3 ou 5 ).")
        {

        }
    }
    public class TipoCaixaInvalidoException : VeiculoException
    {
        public TipoCaixaInvalidoException(string tipoCaixa) : base($"O tipo de caixa é inválido: \"{tipoCaixa}\". Deve ser ( manual ou automática ).")
        {

        }
    }




    //Para Moto
    public class CilindradaInvalidaException : VeiculoException
    {
        public CilindradaInvalidaException(int cilindrada) : base($"Cilindrada inválida: \"{cilindrada}\". Deve ser uma das opções válidas (50cc ,125cc ou 300cc).")
        {

        }
    }



    //Para camioneta
    public class NumeroEixosInvalidoException : VeiculoException
    {
        public NumeroEixosInvalidoException(int numeroEixos) : base($"Número de Eixos inválido: \"{numeroEixos}\". Deve ser ( 2 ou 3 ).")
        {

        }
    }
    public class NumeroMaximoPassageirosInvalidoException : VeiculoException
    {
        public NumeroMaximoPassageirosInvalidoException(int NumeroMaximoPassageiros) : base($"O Numero máximo de passageiros inválido: \"{NumeroMaximoPassageiros}\". Deve estar dentro do intervalo ( acima de zero ).")
        {


        }
    }

}
