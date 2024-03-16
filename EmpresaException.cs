using System;

namespace Automobile
{
    public class EmpresaException : Exception
    {
        public EmpresaException(string mensagem) : base(mensagem)
        {

        }
    }


    //Para users
    public class UserDuplicadoException : EmpresaException
    {
        public UserDuplicadoException(string userName) : base($"Username \"{userName}\" já existe.")
        {

        }
    }

    //public class IdUserException : EmpresaException
    //{
    //    public IdUserException(string Id) : base($"O Id \"{Id}\" não pode ser atribuido ( tente semelhante a #000 ).")
    //    {

    //    }
    //}

    //public class PasswordUserException : EmpresaException
    //{
    //    public PasswordUserException(string password) : base($"A Password não pode superar 8 caracteres.")
    //    {

    //    }
    //}






    //Para todos veiculos

    public class VeiculoDuplicadoException : EmpresaException
    {
        public VeiculoDuplicadoException(string veiculoMatricula) : base($"Um veículo com a Matrícula \"{veiculoMatricula}\" já existe na lista de veículos.")
        {

        }
    }




    //Para o camião
    public class PesoMaximoInvalidoException : EmpresaException
    {
        public PesoMaximoInvalidoException(int PesoMaximo) : base($"O Peso máximo suportado inválido: \"{PesoMaximo}\". Deve estar dentro do intervalo ( 1kg - 44000kg).")
        {

        }

    }






    //Para o Carro
    public class NumeroPortasInvalidoException : EmpresaException
    {
        public NumeroPortasInvalidoException(string numeroPortas) : base($"Número de Portas inválido: \"{numeroPortas}\". Deve ser ( 3 ou 5 ).")
        {

        }
    }
    public class TipoCaixaInvalidoException : EmpresaException
    {
        public TipoCaixaInvalidoException(string tipoCaixa) : base($"O tipo de Caixa é inválido: \"{tipoCaixa}\". Deve ser ( manual ou automática ).")
        {

        }
    }




    //Para Moto
    public class CilindradaInvalidaException : EmpresaException
    {
        public CilindradaInvalidaException(string cilindrada) : base($"Cilindrada inválida: \"{cilindrada}\". Deve ser uma das opções válidas (50cc ,125cc ou 300cc).")
        {

        }
    }



    //Para camioneta
    public class NumeroEixosInvalidoException : EmpresaException
    {
        public NumeroEixosInvalidoException(string numeroEixos) : base($"Número de Eixos inválido: \"{numeroEixos}\". Deve ser ( 2 ou 3 ).")
        {

        }
    }
    public class NumeroMaximoPassageirosInvalidoException : EmpresaException
    {
        public NumeroMaximoPassageirosInvalidoException(int NumeroMaximoPassageiros) : base($"O Numero máximo de Passageiros inválido: \"{NumeroMaximoPassageiros}\". Deve estar dentro do intervalo ( acima de zero ).")
        {

        }
    }

    //Para Reserva
    public class ReservaException : EmpresaException
    {
        public ReservaException(DateTime DataInicio) : base($"Data de Inicio inválida: \" {DataInicio.Date.ToString()}\".Pode reservar no dia atual ou depois.")
        {

        }
    }



}
