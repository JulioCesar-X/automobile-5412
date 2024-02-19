using System;
using System.Windows.Forms;

namespace Automobile
{
    internal class EmpresaController
    {
        private static EmpresaModel _empresa = new EmpresaModel();
        public static EmpresaModel Controlador
        {
            get
            {
                return _empresa;
                //teste
            }

        }

        public static string userLogado;


        public static bool CriarCaminhao(string veiculoMatricula, string veiculoModelo, decimal veiculoPreco, string veiculoStatus, int pesoMaximo)
        {
            try
            {
                Camiao caminhao = new Camiao(veiculoMatricula, veiculoModelo, veiculoPreco, veiculoStatus, pesoMaximo);
                Controlador.AdicionarVeiculo(caminhao);

                return true;
            }
            catch (PesoMaximoInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool CriarMota(string veiculoMatricula, string veiculoModelo, decimal veiculoPreco, string veiculoStatus, int cilindrada)
        {
            try
            {
                Mota novaMota = new Mota(veiculoMatricula, veiculoModelo, veiculoPreco, veiculoStatus, cilindrada);
                Controlador.AdicionarVeiculo(novaMota);


                return true;
            }
            catch (CilindradaInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool CriarCarro(string veiculoMatricula, string veiculoModelo, decimal veiculoPreco, string veiculoStatus, int numeroPortas, string tipoCaixa)
        {
            try
            {
                Carro novoCarro = new Carro(veiculoMatricula, veiculoModelo, veiculoPreco, veiculoStatus, numeroPortas, tipoCaixa);
                Controlador.AdicionarVeiculo(novoCarro);
                return true;
            }
            catch (NumeroPortasInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (TipoCaixaInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool CriarCamioneta(string VeiculoMatricula, string veiculoModelo, decimal veiculoPreco, string veiculoStatus, int numeroEixos, int numeroPassageiros)
        {
            try
            {
                Camioneta novaCamioneta = new Camioneta(VeiculoMatricula, veiculoModelo, veiculoPreco, veiculoStatus, numeroEixos, numeroPassageiros);
                Controlador.AdicionarVeiculo(novaCamioneta);
                return true;
            }
            catch (NumeroEixosInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (NumeroMaximoPassageirosInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool VerListaVeiculosDoTipo(string tipo)
        {
            try
            {
                Controlador.VerListaVeiculosDoTipo(tipo);

                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool AdicionarUser(string id, string name, string password)
        {
            try
            {
                User newUser = new User(id, name, password);
                Controlador.AdicionarUser(newUser);

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public static bool ValidarLogin(string username, string password)
        {
            try
            {
                Controlador.ValidarLogin(username, password);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
    }
}
