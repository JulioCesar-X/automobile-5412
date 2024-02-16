using System;

namespace Automobile
{
    public class EmpresaException : Exception
    {
        public EmpresaException(string mensagem) : base(mensagem)
        {

        }
    }




    /*----- Personalização para exceptions especificas relacionadas aos veiculos ------*/

    //Para users
    public class UserDuplicadoException : EmpresaException
    {
        public UserDuplicadoException(string userName) : base($"Username \"{userName}\" já existe.")
        {

        }
    }

    public class IdUserException : EmpresaException
    {
        public IdUserException(string Id) : base($"O Id \"{Id}\" não pode ser atribuido ( tente semelhante a #000 ).")
        {

        }
    }

    public class PasswordUserException : EmpresaException
    {
        public PasswordUserException(string password) : base($"A password deve ter no minimo 5 caracteres.")
        {

        }
    }



    //Para todos veiculos

    public class VeiculoDuplicadoException : EmpresaException
    {
        public VeiculoDuplicadoException(int veiculoId) : base($"Um veículo com o ID \"{veiculoId}\" já existe na lista de veículos.")
        {

        }
    }




    //Para o camião
    public class PesoMaximoInvalidoException : EmpresaException
    {
        public PesoMaximoInvalidoException(int PesoMaximo) : base($"O peso máximo suportado inválido: \"{PesoMaximo}\". Deve estar dentro do intervalo ( 1kg - 44000kg ).")
        {

        }
    }




    //Para o Carro
    public class NumeroPortasInvalidoException : EmpresaException
    {
        public NumeroPortasInvalidoException(int numeroPortas) : base($"Número de portas inválido: \"{numeroPortas}\". Deve ser ( 3 ou 5 ).")
        {

        }
    }
    public class TipoCaixaInvalidoException : EmpresaException
    {
        public TipoCaixaInvalidoException(string tipoCaixa) : base($"O tipo de caixa é inválido: \"{tipoCaixa}\". Deve ser ( manual ou automática ).")
        {

        }
    }




    //Para Moto
    public class CilindradaInvalidaException : EmpresaException
    {
        public CilindradaInvalidaException(int cilindrada) : base($"Cilindrada inválida: \"{cilindrada}\". Deve ser uma das opções válidas (50cc ,125cc ou 300cc).")
        {

        }
    }



    //Para camioneta
    public class NumeroEixosInvalidoException : EmpresaException
    {
        public NumeroEixosInvalidoException(int numeroEixos) : base($"Número de Eixos inválido: \"{numeroEixos}\". Deve ser ( 2 ou 3 ).")
        {

        }
    }
    public class NumeroMaximoPassageirosInvalidoException : EmpresaException
    {
        public NumeroMaximoPassageirosInvalidoException(int NumeroMaximoPassageiros) : base($"O Numero máximo de passageiros inválido: \"{NumeroMaximoPassageiros}\". Deve estar dentro do intervalo ( acima de zero ).")
        {

        }
    }

}
