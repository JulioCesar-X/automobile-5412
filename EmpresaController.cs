using System;
using System.Windows.Forms;

namespace Automobile
{
    internal class EmpresaController
    {
        private static readonly EmpresaModel _empresa = new EmpresaModel();

        public static string userLogado;

        public static EmpresaModel Controlador
        {
            get
            {
                return _empresa;

            }

        }



        public static bool CriarCamiao(string veiculoMatricula, string veiculoModelo, decimal veiculoPreco, int pesoMaximo)
        {
            try
            {
                Camiao caminhao = new Camiao(veiculoMatricula, veiculoModelo, veiculoPreco, new Estado(), pesoMaximo);
                Controlador.AdicionarVeiculo(caminhao);
                MessageBox.Show($"O veiculo \"{caminhao.VeiculoModelo}\" com matricula \"{caminhao.VeiculoMatricula}\" foi criado com sucesso!");
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
        public static bool CriarMota(string veiculoMatricula, string veiculoModelo, decimal veiculoPreco, int cilindrada)
        {
            try
            {
                Mota novaMota = new Mota(veiculoMatricula, veiculoModelo, veiculoPreco, new Estado(), cilindrada);
                Controlador.AdicionarVeiculo(novaMota);
                MessageBox.Show($"O veiculo \"{novaMota.VeiculoModelo}\" com matricula \"{novaMota.VeiculoMatricula}\" foi criado com sucesso!");

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

        public static bool CriarCarro(string veiculoMatricula, string veiculoModelo, decimal veiculoPreco, int numeroPortas, string tipoCaixa)
        {
            try
            {
                Carro novoCarro = new Carro(veiculoMatricula, veiculoModelo, veiculoPreco, new Estado(), numeroPortas, tipoCaixa);
                Controlador.AdicionarVeiculo(novoCarro);
                MessageBox.Show($"O veiculo \"{novoCarro.VeiculoModelo}\" com matricula \"{novoCarro.VeiculoMatricula}\" foi criado com sucesso!");
                return true;
            }
            catch (VeiculoDuplicadoException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
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

        public static bool CriarCamioneta(string VeiculoMatricula, string veiculoModelo, decimal veiculoPreco, int numeroEixos, int numeroPassageiros)
        {
            try
            {
                Camioneta novaCamioneta = new Camioneta(VeiculoMatricula, veiculoModelo, veiculoPreco, new Estado(), numeroEixos, numeroPassageiros);
                Controlador.AdicionarVeiculo(novaCamioneta);
                MessageBox.Show($"O veiculo \"{novaCamioneta.VeiculoModelo}\" com matricula \"{novaCamioneta.VeiculoMatricula}\" foi criado com sucesso!");
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

        public static bool ValidarListaVeiculosDoTipo(string tipo, string status)
        {
            try
            {
                Controlador.ValidarListaVeiculosDoTipo(tipo, status);

                return true;

            }
            catch (ArgumentException ex)
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

        public static bool CriarReserva(string id, DateTime DataInicio, DateTime DataFim)
        {
            try
            {

                Controlador.AdicionarReserva(id, DataInicio, DataFim);
                return true;
            }
            catch (ReservaException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public static bool SalvarDadosNoCsv(string folderPath, string nome)
        {
            try
            {
                Controlador.SalvarDadosNoCsv(folderPath, nome);

                return true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return false;
            }
        }

        public static bool GetListaVeciulosReservados(string tipo)
        {
            try
            {
                Controlador.GetListaVeciulosVeiculosReservadosDoTipo(tipo);
                return true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return false;
            }
        }


    }
}
