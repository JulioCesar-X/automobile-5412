using System;
using System.IO;
using System.Windows.Forms;

namespace Automobile
{
    internal class EmpresaController
    {
        private static readonly EmpresaModel _empresa = new EmpresaModel();

        public static string userLogado;

        private static DateTime _dataAtual;
        public static DateTime DataAtual
        {

            get
            {
                return _dataAtual;
            }
            set
            {
                _dataAtual = value;
            }

        }

        public static EmpresaModel Controlador
        {
            get
            {
                return _empresa;

            }

        }



        public static bool CriarCamiao(string veiculoMatricula, string veiculoModelo, string veiculoPreco, string pesoMaximo)
        {
            try
            {
                Camiao camiao = new Camiao(veiculoMatricula, veiculoModelo, veiculoPreco, new Estado(Estado.Tipo.Disponivel, DataAtual.Date, DateTime.MaxValue), pesoMaximo);
                Controlador.AdicionarVeiculo(camiao);
                MessageBox.Show($"O veiculo \"{camiao.VeiculoModelo}\" com matricula \"{camiao.VeiculoMatricula}\" foi criado com sucesso!");
                return true;
            }
            catch (PesoMaximoInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public static bool CriarMota(string veiculoMatricula, string veiculoModelo, string veiculoPreco, string cilindrada)
        {
            try
            {
                Mota novaMota = new Mota(veiculoMatricula, veiculoModelo, veiculoPreco, new Estado(Estado.Tipo.Disponivel, DataAtual.Date, DateTime.MaxValue), cilindrada);
                Controlador.AdicionarVeiculo(novaMota);
                MessageBox.Show($"O veiculo \"{novaMota.VeiculoModelo}\" com matricula \"{novaMota.VeiculoMatricula}\" foi criado com sucesso!");

                return true;
            }
            catch (CilindradaInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public static bool CriarCarro(string veiculoMatricula, string veiculoModelo, string veiculoPreco, string numeroPortas, string tipoCaixa)
        {
            try
            {
                Carro novoCarro = new Carro(veiculoMatricula, veiculoModelo, veiculoPreco, new Estado(Estado.Tipo.Disponivel, DataAtual.Date, DateTime.MaxValue), numeroPortas, tipoCaixa);
                Controlador.AdicionarVeiculo(novoCarro);
                MessageBox.Show($"O veiculo \"{novoCarro.VeiculoModelo}\" com matricula \"{novoCarro.VeiculoMatricula}\" foi criado com sucesso!");
                return true;
            }
            catch (VeiculoDuplicadoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (NumeroPortasInvalidoException ex2)
            {
                MessageBox.Show(ex2.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (TipoCaixaInvalidoException ex3)
            {
                MessageBox.Show(ex3.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool CriarCamioneta(string VeiculoMatricula, string veiculoModelo, string veiculoPreco, string numeroEixos, string numeroPassageiros)
        {
            try
            {
                Camioneta novaCamioneta = new Camioneta(VeiculoMatricula, veiculoModelo, veiculoPreco, new Estado(Estado.Tipo.Disponivel, DataAtual.Date, DateTime.MaxValue), numeroEixos, numeroPassageiros);
                Controlador.AdicionarVeiculo(novaCamioneta);
                MessageBox.Show($"O veiculo \"{novaCamioneta.VeiculoModelo}\" com matricula \"{novaCamioneta.VeiculoMatricula}\" foi criado com sucesso!");
                return true;
            }
            catch (NumeroMaximoPassageirosInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            catch (NumeroEixosInvalidoException ex2)
            {
                MessageBox.Show(ex2.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ValidarListaVeiculosDoTipo(string tipo, string status)
        {
            try
            {
                Controlador.ValidarListaVeiculosDoTipo(tipo, status, DataAtual.Date);
                return true;

            }
            catch (ArgumentException ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public static bool ValidarReserva(string id, DateTime DataInicio)
        {
            try
            {

                Controlador.ValidarReserva(id, DataInicio);

                return true;
            }
            catch (ReservaException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static bool ExportarParaCsv(string caminho)
        {
            string caminhoVeiculos = Path.Combine(caminho, $"Veiculos {DataAtual:_dd_MM_yyyy}");
            string caminhoUsers = Path.Combine(caminho, $"Users {DataAtual:_dd_MM_yyyy}");
            try
            {
                Controlador.ExportarParaCsv(caminho, caminhoVeiculos, caminhoUsers, DataAtual.Date);
                MessageBox.Show("Dados salvos com sucesso em arquivos CSV.");
                return true;

            }
            catch
            {
                return false;
            }
        }

        ////importação em andamento .........
        //public static (string atributoErrado, string erro, string[] linhaDeDados) ImportarDoCsv(string caminho)
        //{
        //    string[] linhaDeDados = null;
        //    try
        //    {
        //        var dados = LerLinhasDoCSV(caminho);
        //        string tipo = DescobreTipoDeObjetoPeloNomeDoArquivo(caminho);

        //        TentaConstruirObjetoPeloTipo(tipo, dados, out linhaDeDados);

        //        return ("Dados carregados com sucesso.", null, null);
        //    }
        //    catch (Automobile.NumeroPortasInvalidoException ex)
        //    {
        //        return (linhaDeDados[2], ex.Message, linhaDeDados);
        //    }
        //    catch (Automobile.TipoCaixaInvalidoException ex)
        //    {
        //        return (linhaDeDados[3], ex.Message, linhaDeDados);
        //    }
        //    catch (Automobile.CilindradaInvalidaException ex)
        //    {
        //        return (linhaDeDados[2], ex.Message, linhaDeDados);
        //    }
        //    catch (Automobile.PesoMaximoInvalidoException ex)
        //    {
        //        return (linhaDeDados[2], ex.Message, linhaDeDados);
        //    }
        //    catch (Automobile.NumeroMaximoPassageirosInvalidoException ex)
        //    {
        //        return (linhaDeDados[3], ex.Message, linhaDeDados);
        //    }
        //    catch (Automobile.NumeroEixosInvalidoException ex)
        //    {
        //        return (linhaDeDados[2], ex.Message, linhaDeDados);
        //    }
        //    catch (Automobile.VeiculoDuplicadoException ex)
        //    {
        //        return (linhaDeDados[0], ex.Message, linhaDeDados);
        //    }
        //    catch (Automobile.UserDuplicadoException ex)
        //    {
        //        return (linhaDeDados[0], ex.Message, linhaDeDados);
        //    }

        //}


        //private static string DescobreTipoDeObjetoPeloNomeDoArquivo(string caminhoArquivo)
        //{
        //    // Extrai apenas o nome do arquivo do caminho completo
        //    string nomeLista = Path.GetFileNameWithoutExtension(caminhoArquivo);

        //    // Verifica se o nome do arquivo contém um tipo de veículo conhecido
        //    switch (nomeLista)
        //    {
        //        case "VeiculosDisponiveis(carros)":

        //            return "Carro";

        //        case "VeiculosDisponiveis(motas)":

        //            return "Mota";

        //        case "VeiculosDisponiveis(camionetas)":

        //            return "Camioneta";

        //        case "VeiculosDisponiveis(camioes)":

        //            return "Camiao";
        //        case "VeiculosAlugados(carros)":

        //            return "Carro";

        //        case "VeiculosAlugados(motas)":

        //            return "Mota";

        //        case "VeiculosAlugados(camionetas)":

        //            return "Camioneta";

        //        case "VeiculosAlugados(camioes)":

        //            return "Camiao";
        //        case "VeiculosReservados(carros)":

        //            return "Carro";

        //        case "VeiculosReservados(motas)":

        //            return "Mota";

        //        case "VeiculosReservados(camionetas)":

        //            return "Camioneta";

        //        case "VeiculosReservados(camioes)":

        //            return "Camiao";
        //        case "VeiculosEmManutencao(carros)":

        //            return "Carro";

        //        case "VeiculosEmManutencao(motas)":

        //            return "Mota";

        //        case "VeiculosEmManutencao(camionetas)":

        //            return "Camioneta";

        //        case "VeiculosEmManutencao(camioes)":

        //            return "Camiao";

        //        case "users":

        //            return "User";

        //        default:
        //            throw new ArgumentException("Lista desconhecida.");
        //    }
        //}

        //private static void TentaConstruirObjetoPeloTipo(string tipo, List<string[]> dados, out string[] linha)
        //{
        //    linha = null;

        //    switch (tipo)
        //    {
        //        case "Carro":
        //            foreach (var linhaDados in dados)
        //            {

        //                linha = linhaDados;
        //                CarregarCarro(linhaDados[0], linhaDados[1], linhaDados[2], linhaDados[3], linhaDados[4], linhaDados[5]);

        //            }
        //            break;


        //        case "Mota":
        //            foreach (var linhaDados in dados)
        //            {
        //                linha = linhaDados;
        //                CarregarMota(linhaDados[0], linhaDados[1], linhaDados[2], linhaDados[3], linhaDados[4]);
        //            }
        //            break;

        //        case "Camioneta":
        //            foreach (var linhaDados in dados)
        //            {
        //                linha = linhaDados;
        //                CarregarCamioneta(linhaDados[0], linhaDados[1], linhaDados[2], linhaDados[3], linhaDados[4], linhaDados[5]);
        //            }
        //            break;

        //        case "Camiao":
        //            foreach (var linhaDados in dados)
        //            {
        //                linha = linhaDados;
        //                CarregarCamiao(linhaDados[0], linhaDados[1], linhaDados[2], linhaDados[3], linhaDados[4]);
        //            }
        //            break;

        //        case "Users":
        //            foreach (var linhaDados in dados)
        //            {
        //                linha = linhaDados;
        //                CarregarUser(linhaDados[0], linhaDados[1], linhaDados[2], linhaDados[3]);
        //            }
        //            break;

        //        default:
        //            throw new ArgumentException("Tipo desconhecido.");
        //    }

        //}
        //private static void CarregarCarro(string matricula, string modelo, string numPortas, string tipoCaixa, string preco, string status, DateTime inicio = default, DateTime fim = default)
        //{

        //    if (inicio == default)
        //    {
        //        inicio = DataAtual.Date;
        //    }
        //    if (fim == default)
        //    {
        //        fim = DateTime.MaxValue.Date;
        //    }

        //    try
        //    {
        //        Carro novoCarro = new Carro(matricula, modelo, preco, new Estado(status, inicio, fim), numPortas, tipoCaixa);
        //        Controlador.AdicionarVeiculo(novoCarro);
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        throw new ArgumentException($"Erro ao carregar carro: {ex.Message}");
        //    }




        //}


        //private static void CarregarCamiao(string matricula, string modelo, string pesoMaximo, string preco, string status, DateTime inicio = default, DateTime fim = default)
        //{

        //    if (inicio == default)
        //    {
        //        inicio = DataAtual.Date;
        //    }
        //    if (fim == default)
        //    {
        //        fim = DateTime.MaxValue.Date;
        //    }
        //    Camiao camiao = new Camiao(matricula, modelo, preco, new Estado(status, inicio, fim), pesoMaximo);
        //    Controlador.AdicionarVeiculo(camiao);



        //}

        //private static void CarregarCamioneta(string matricula, string modelo, string numeroEixos, string numeroPassageiros, string preco, string status, DateTime inicio = default, DateTime fim = default)
        //{

        //    if (inicio == default)
        //    {
        //        inicio = DataAtual.Date;
        //    }
        //    if (fim == default)
        //    {
        //        fim = DateTime.MaxValue.Date;
        //    }
        //    Camioneta novaCamioneta = new Camioneta(matricula, modelo, preco, new Estado(status, inicio, fim), numeroEixos, numeroPassageiros);
        //    Controlador.AdicionarVeiculo(novaCamioneta);



        //}

        //private static void CarregarMota(string matricula, string modelo, string cilindrada, string preco, string status, DateTime inicio = default, DateTime fim = default)
        //{

        //    if (inicio == default)
        //    {
        //        inicio = DataAtual.Date;
        //    }
        //    if (fim == default)
        //    {
        //        fim = DateTime.MaxValue.Date;
        //    }



        //    Mota novaMota = new Mota(matricula, modelo, preco, new Estado(status, inicio, fim), cilindrada);
        //    Controlador.AdicionarVeiculo(novaMota);


        //}


        //private static void CarregarUser(string id, string nome, string username, string password)
        //{
        //    try
        //    {
        //        throw new NotImplementedException();
        //    }
        //    catch
        //    {

        //        throw;
        //    }
        //}
        //private static List<string[]> LerLinhasDoCSV(string caminhoArquivo)
        //{
        //    List<string[]> linhas = new List<string[]>(); // Lista para armazenar as linhas do CSV
        //    StreamReader leitor = null;

        //    try
        //    {
        //        leitor = new StreamReader(caminhoArquivo);
        //        string linha;
        //        bool primeiraLinha = true; // Flag para identificar a primeira linha

        //        // Lê cada linha do arquivo até o final
        //        while ((linha = leitor.ReadLine()) != null)
        //        {
        //            // Ignora a primeira linha (cabeçalhos)
        //            if (primeiraLinha)
        //            {
        //                primeiraLinha = false;
        //                continue;
        //            }

        //            // Divide a linha em colunas usando o separador ";"
        //            string[] colunas = linha.Split(';');

        //            // Adiciona as colunas como uma linha ao vetor de linhas
        //            linhas.Add(colunas);
        //        }
        //    }
        //    finally
        //    {
        //        if (leitor != null)
        //        {
        //            leitor.Close(); // Fecha o recurso StreamReader
        //        }
        //    }

        //    return linhas;
        //}

    }
}
