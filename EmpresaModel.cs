using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Automobile
{
    internal class EmpresaModel
    {


        public List<User> Users { get; set; }

        public List<object> VeiculosDisponiveis { get; } = new List<object>();
        public List<object> VeiculosReservados { get; } = new List<object>();
        public List<object> VeiculosAlugados { get; } = new List<object>();
        public List<object> VeiculosEmManutencao { get; } = new List<object>();



        public EmpresaModel()
        {


            Users = new List<User>();


            CriarListaDefaultUsers();
            CriarListaVeiculosDefault();

            EmpresaController.DataAtual = DateTime.Today.Date;

        }

        public void AdicionarUser(User newUser)
        {

            if (Users.Any(user => user.Id == newUser.Id))
            {
                throw new UserDuplicadoException(newUser.Id);

            }
            else if (Users.Any(user => user.Password == newUser.Password))
            {
                throw new ArgumentException("Password já existe");
            }
            else
            {
                Users.Add(newUser);
            }
        }
        public bool ValidarLogin(string username, string password)
        {
            User userRequerido = Users.Find(user => user.UserName == username);

            if (userRequerido == null)
            {
                throw new ArgumentException($"Username \"{username}\" inválido");
            }
            else if (userRequerido.Password != password)
            {
                throw new ArgumentException("Password inválida");
            }
            else
            {
                return true;

            }

        }
        private void CriarListaDefaultUsers()
        {

            User func1 = new User("#", "Gonçalo", "atec123");
            User func2 = new User("#", "Rodrigo", "atec123");
            User func3 = new User("#", "Francisco", "atec123");
            User func4 = new User("#", "Julio", "atec123");
            User func5 = new User("#", "admin", ""); //ADMIN

            Users.Add(func1);
            Users.Add(func2);
            Users.Add(func3);
            Users.Add(func4);
            Users.Add(func5);

        }
        private void CriarListaVeiculosDefault()
        {

            Carro veiculo1 = new Carro("AA-01-BC", "Toyota Corolla", "90", new Estado(Estado.Tipo.Disponivel, DateTime.Today.Date, DateTime.MaxValue), "5", "manual");
            Mota veiculo2 = new Mota("AB-02-CD", "Honda CBR600RR", "45", new Estado(Estado.Tipo.Disponivel, DateTime.Today.Date, DateTime.MaxValue), "300");
            Camiao veiculo3 = new Camiao("AC-03-DE", "Volvo FH16", "175", new Estado(Estado.Tipo.Disponivel, DateTime.Today.Date, DateTime.MaxValue), "44000");
            Camioneta veiculo4 = new Camioneta("AD-04-EF", "Ford Explorer", "515", new Estado(Estado.Tipo.Disponivel, DateTime.Today.Date, DateTime.MaxValue), "2", "5");
            Carro veiculo5 = new Carro("BC-23-DE", "Volkswagen Golf", "45", new Estado(Estado.Tipo.Disponivel, DateTime.Today.Date, DateTime.MaxValue), "5", "manual");
            Mota veiculo6 = new Mota("DE-45-FG", "Harley-Davidson Sportster", "55.80", new Estado(Estado.Tipo.Disponivel, DateTime.Today.Date, DateTime.MaxValue), "300");
            Camiao veiculo7 = new Camiao("EF-56-GH", "Scania R500", "170", new Estado(Estado.Tipo.Disponivel, DateTime.Today.Date, DateTime.MaxValue), "44000");
            Camioneta veiculo8 = new Camioneta("5678-DEF", "Chevrolet Tahoe", "500.99", new Estado(Estado.Tipo.Disponivel, DateTime.Today.Date, DateTime.MaxValue), "2", "5");

            Carro veiculo9 = new Carro("GH-78-IJ", "Mustang shelby GT350", "135", new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), "5", "manual");
            Mota veiculo10 = new Mota("HI-89-JK", "Yamaha MT-07", "55", new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), "300");
            //Camiao veiculo11 = new Camiao("3456-JKL", "Mercedes-Benz Actros", "210", new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), "44000");
            //Camioneta veiculo12 = new Camioneta("JK-01-LM", "Jeep Grand Cherokee", "500", new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), "2", "5");
            //Carro veiculo13 = new Carro("KL-12-MN", "Fiat 500", "90", new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), "5", "manual");
            //Mota veiculo14 = new Mota("LM-23-NO", "Kawasaki Ninja 650", "55", new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), "300");
            //Camiao veiculo15 = new Camiao("LM-23-NO", "Kawasaki Ninja 650", "100", new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), "44000");
            //Camioneta veiculo16 = new Camioneta("NO-45-PQ", "Toyota Land Cruiser", "500", new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), "2", "5");

            //Carro veiculo17 = new Carro("OP-56-QR", "Renault Megane", "88.70", new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(1)), "5", "manual");
            //Mota veiculo18 = new Mota("PQ-67-RS", "Suzuki V-Strom 650", "55.80", new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(1)), "300");
            //Camiao veiculo19 = new Camiao("QR-78-ST", "Iveco Stralis", "150.99", new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(1)), "44000");
            //Camioneta veiculo20 = new Camioneta("RS-89-TU", "Nissan Pathfinder", "500.99", new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(1)), "2", "5");
            //Carro veiculo21 = new Carro("ST-90-UV", "Hyundai Elantra", "88.70", new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(1)), "5", "manual");
            //Mota veiculo22 = new Mota("TU-01-VW", "Ducati Monster 821", "55", new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(1)), "300");
            //Camiao veiculo23 = new Camiao("UV-12-WX", "Kenworth W990", "150", new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(1)), "44000");
            //Camioneta veiculo24 = new Camioneta("VW-23-XY", "Subaru Outback", "500.99", new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(1)), "2", "5");

            Carro veiculo25 = new Carro("XYZ 123", "Chevrolet Camaro", "88.70", new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), "5", "manual");
            Mota veiculo26 = new Mota("CD-90-EF", "BMW S1000RR", "55.80", new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), "300");
            //Camiao veiculo27 = new Camiao("DE-01-FG", "Peterbilt 389", "150", new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), "44000");
            //Camioneta veiculo28 = new Camioneta("EF-12-GH", "Ford F-150", "500", new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), "2", "5");
            //Carro veiculo29 = new Carro("9012-GHI", "Audi A3", "88.70", new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), "5", "manual");
            //Mota veiculo30 = new Mota("HI-12-JK", "Triumph Bonneville", "55.50", new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), "300");
            //Camiao veiculo31 = new Camiao("3456-JKL", "Freightliner Cascadia", "150", new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), "44000");
            //Camioneta veiculo32 = new Camioneta("LM-678-MN", "Mitsubishi Outlander", "500", new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), "2", "5");


            VeiculosDisponiveis.Add(veiculo1);
            VeiculosDisponiveis.Add(veiculo2);
            VeiculosDisponiveis.Add(veiculo3);
            VeiculosDisponiveis.Add(veiculo4);
            VeiculosDisponiveis.Add(veiculo5);
            VeiculosDisponiveis.Add(veiculo6);
            VeiculosDisponiveis.Add(veiculo7);
            VeiculosDisponiveis.Add(veiculo8);

            VeiculosAlugados.Add(veiculo9);
            VeiculosAlugados.Add(veiculo10);
            //VeiculosAlugados.Add(veiculo11);
            //VeiculosAlugados.Add(veiculo12);
            //VeiculosAlugados.Add(veiculo13);
            //VeiculosAlugados.Add(veiculo14);
            //VeiculosAlugados.Add(veiculo15);
            //VeiculosAlugados.Add(veiculo16);

            //VeiculosReservados.Add(veiculo17);
            //VeiculosReservados.Add(veiculo18);
            //VeiculosReservados.Add(veiculo19);
            //VeiculosReservados.Add(veiculo20);
            //VeiculosReservados.Add(veiculo21);
            //VeiculosReservados.Add(veiculo22);
            //VeiculosReservados.Add(veiculo23);
            //VeiculosReservados.Add(veiculo24);

            VeiculosEmManutencao.Add(veiculo25);
            VeiculosEmManutencao.Add(veiculo26);
            //VeiculosEmManutencao.Add(veiculo27);
            //VeiculosEmManutencao.Add(veiculo28);
            //VeiculosEmManutencao.Add(veiculo29);
            //VeiculosEmManutencao.Add(veiculo30);
            //VeiculosEmManutencao.Add(veiculo31);
            //VeiculosEmManutencao.Add(veiculo32);


        }


        public void AdicionarVeiculo(Veiculo objeto)
        {

            Veiculo veiculo = (Veiculo)objeto;

            string matriculaRequerida = veiculo.VeiculoMatricula;

            //faz o casting antes de testar a matricula
            if (VeiculosDisponiveis.Any(v => ((Veiculo)v).VeiculoMatricula == matriculaRequerida))
            //[ carro , mota, camiao]
            {
                throw new VeiculoDuplicadoException(matriculaRequerida);
            }               //ArgumentException()

            VeiculosDisponiveis.Add(objeto);
        }


        public bool ValidarListaVeiculosDoTipo(string tipoRequerido, string status, DateTime dataAtual)
        {

            switch (status)
            {
                case "Disponivel":
                    return ExisteVeiculoNesseStatus(tipoRequerido, VeiculosDisponiveis, dataAtual);

                case "Alugado":
                    return ExisteVeiculoNesseStatus(tipoRequerido, VeiculosAlugados, dataAtual);

                case "Reservado":
                    return ExisteVeiculoNesseStatus(tipoRequerido, VeiculosReservados, dataAtual);

                case "EmManutencao":
                    return ExisteVeiculoNesseStatus(tipoRequerido, VeiculosEmManutencao, dataAtual);

                default:
                    throw new ArgumentException("Status do veiculo mal especificado");

            }



        }

        private bool ExisteVeiculoNesseStatus(string tipoRequerido, List<object> lista, DateTime dataAtual)
        {
            if (lista.Count == 0)
            {
                throw new ArgumentException("Lista de veiculos vazia");

            }
            else if (lista.Any(v => v.GetType().Name == tipoRequerido))
            {

                if (lista.Any(v => ((Veiculo)v).VeiculoStatus.DataFim.Date >= dataAtual))
                {
                    return true;
                }
                else
                {
                    throw new ArgumentException($"Veiculos nessa data não estão presentes nessa lista");
                }
            }
            else
            {
                throw new ArgumentException($"Veiculos desse tipo não estão presentes nessa lista");
            }
        }

        public List<object> GetListaVeciulosVeiculosReservadosDoTipo(string tipoRequerido)
        {

            if (VeiculosReservados.Any(r => ((Carro)r).GetType().Name == tipoRequerido))
            {

                return VeiculosReservados.FindAll(r => ((Carro)r).GetType().Name == tipoRequerido);

            }
            else if (VeiculosReservados.Any(r => ((Mota)r).GetType().Name == tipoRequerido))

            {
                return VeiculosReservados.FindAll(r => ((Mota)r).GetType().Name == tipoRequerido);

            }
            else if (VeiculosReservados.Any(r => ((Camiao)r).GetType().Name == tipoRequerido))
            {

                return VeiculosReservados.FindAll(r => ((Camiao)r).GetType().Name == tipoRequerido);

            }
            else if (VeiculosReservados.Any(r => ((Camioneta)r).GetType().Name == tipoRequerido))
            {

                return VeiculosReservados.FindAll(r => ((Camioneta)r).GetType().Name == tipoRequerido);

            }
            else
            {
                throw new ArgumentException("Tipo de veículo não encontrado!");
            }
        }

        public object GetVeiculo(string id, List<object> listaStatus)
        {
            if (!listaStatus.Any(v => ((Veiculo)v).VeiculoMatricula == id))
            {
                throw new ArgumentException($"O veiculo com a matricula \"{id}\" não está presente nessa lista");
            }
            return listaStatus.Find(v => ((Veiculo)v).VeiculoMatricula == id);
        }

        public void ExportarParaCsv(string caminho, string caminhoVeiculos, string caminhoUsers, DateTime dataAtual)
        {

            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }

            Directory.CreateDirectory(caminhoVeiculos);
            Directory.CreateDirectory(caminhoUsers);


            foreach (var lista in new string[] { "VeiculosDisponiveis", "VeiculosAlugados", "VeiculosReservados", "VeiculosEmManutencao" })
            {
                string caminhoStatus = Path.Combine(caminhoVeiculos, lista);
                Directory.CreateDirectory(caminhoStatus);
                SalvarDadosNoCsv(caminhoStatus, lista, dataAtual.Date);
            }

            SalvarDadosNoCsv(caminhoUsers, "Users", dataAtual.Date);
        }
        private void SalvarDadosNoCsv(string folderPath, string nomeLista, DateTime dataAtual)
        {


            switch (nomeLista)
            {

                case "VeiculosDisponiveis":


                    foreach (var tipo in new string[] { "Carro", "Mota", "Camioneta", "Camiao" })
                    {

                        try
                        {
                            if (ValidarListaVeiculosDoTipo(tipo, "Disponivel", dataAtual))
                            {
                                EscreveNoCsvDadosDaLista(folderPath, VeiculosDisponiveis, tipo, nomeLista);
                            }
                        }
                        catch
                        {
                            continue;
                        }


                    }
                    break;

                case "VeiculosAlugados":



                    foreach (var tipo in new string[] { "Carro", "Mota", "Camioneta", "Camiao" })
                    {

                        try
                        {
                            if (ValidarListaVeiculosDoTipo(tipo, "Alugado", dataAtual))
                            {
                                EscreveNoCsvDadosDaLista(folderPath, VeiculosAlugados, tipo, nomeLista);
                            }
                        }
                        catch
                        {
                            continue;
                        }


                    }
                    break;

                case "VeiculosReservados":



                    foreach (var tipo in new string[] { "Carro", "Mota", "Camioneta", "Camiao" })
                    {

                        try
                        {
                            if (ValidarListaVeiculosDoTipo(tipo, "Reservado", dataAtual))
                            {
                                EscreveNoCsvDadosDaLista(folderPath, VeiculosReservados, tipo, nomeLista);
                            }
                        }
                        catch
                        {
                            continue;
                        }


                    }
                    break;

                case "VeiculosEmManutencao":

                    foreach (var tipo in new string[] { "Carro", "Mota", "Camioneta", "Camiao" })
                    {

                        try
                        {
                            if (ValidarListaVeiculosDoTipo(tipo, "EmManutencao", dataAtual))
                            {
                                EscreveNoCsvDadosDaLista(folderPath, VeiculosEmManutencao, tipo, nomeLista);
                            }
                        }
                        catch
                        {
                            continue;
                        }


                    }
                    break;

                case "Users":

                    if (Users.Count == 0)
                    {
                        throw new ArgumentException($"Não existe Users na \"{nomeLista}\" para salvar.");
                    }
                    else
                    {
                        EscreveNoCsvDadosDaLista(folderPath, Users, "Users", nomeLista);
                    }

                    break;

                default:

                    throw new ArgumentException("Lista não encontrada");

            }


        }

        //Usando o tipo genérico é uma estrutura flexivel - permite que classes,metodos,interfaces trabalhem  com tipos especificos em tempo de compilação em vez de tipos fixos.
        //O tempo de compilação é quando o código é traduzido e analisado pelo compilador antes da execução, enquanto o tempo de execução é quando o código é realmente executado e produz resultados.
        private void EscreveNoCsvDadosDaLista<T>(string folderPath, List<T> lista, string tipo, string nomeDaLista)
        {

            StreamWriter Escritor = null;
            try
            {
                //false sobrescrever, true escrever ao final do arquivo
                Escritor = new StreamWriter(Path.Combine(folderPath, GetCaminhoRelativoPeloNomeDaLista(tipo, nomeDaLista)), false, Encoding.UTF8);

                string colunas;
                string linha;
                switch (tipo)
                {
                    case "Carro":

                        colunas = (nomeDaLista == "VeiculosDisponiveis") ? ColunasDoCsvPorTipo(tipo) : ColunasDoCsvPorTipo(tipo) + ";Inicio;Fim";
                        Escritor.WriteLine(colunas);

                        foreach (var item in lista)
                        {
                            Carro carro = item as Carro;
                            if (carro != null)
                            {
                                linha = (nomeDaLista == "VeiculosDisponiveis") ? LinhaDoCsvPorTipo(tipo, item) : LinhaDoCsvPorTipo(tipo, item) + ";" + carro.VeiculoStatus.DataInicio.ToString("dd/MM/yyyy") + ";" + carro.VeiculoStatus.DataFim.ToString("dd/MM/yyyy");
                                Escritor.WriteLine(linha);
                            }
                        }
                        break;

                    case "Mota":

                        colunas = (nomeDaLista == "VeiculosDisponiveis") ? ColunasDoCsvPorTipo(tipo) : ColunasDoCsvPorTipo(tipo) + $";Inicio;Fim";
                        Escritor.WriteLine(colunas);

                        foreach (var item in lista)
                        {
                            Mota mota = item as Mota;
                            if (mota != null)
                            {
                                linha = (nomeDaLista == "VeiculosDisponiveis") ? LinhaDoCsvPorTipo(tipo, item) : LinhaDoCsvPorTipo(tipo, item) + ";" + mota.VeiculoStatus.DataInicio.ToString("dd/MM/yyyy") + ";" + mota.VeiculoStatus.DataFim.ToString("dd/MM/yyyy");
                                Escritor.WriteLine(linha);
                            }
                        }
                        break;

                    case "Camioneta":

                        colunas = (nomeDaLista == "VeiculosDisponiveis") ? ColunasDoCsvPorTipo(tipo) : ColunasDoCsvPorTipo(tipo) + $";Inicio;Fim";
                        Escritor.WriteLine(colunas);

                        foreach (var item in lista)
                        {
                            Camioneta camioneta = item as Camioneta;
                            if (camioneta != null)
                            {
                                linha = (nomeDaLista == "VeiculosDisponiveis") ? LinhaDoCsvPorTipo(tipo, item) : LinhaDoCsvPorTipo(tipo, item) + ";" + camioneta.VeiculoStatus.DataInicio.ToString("dd/MM/yyyy") + ";" + camioneta.VeiculoStatus.DataFim.ToString("dd/MM/yyyy");
                                Escritor.WriteLine(linha);
                            }
                        }
                        break;

                    case "Camiao":

                        colunas = (nomeDaLista == "VeiculosDisponiveis") ? ColunasDoCsvPorTipo(tipo) : ColunasDoCsvPorTipo(tipo) + $";Inicio;Fim";
                        Escritor.WriteLine(colunas);

                        foreach (var item in lista)
                        {
                            Camiao camiao = item as Camiao;
                            if (camiao != null)
                            {
                                linha = (nomeDaLista == "VeiculosDisponiveis") ? LinhaDoCsvPorTipo(tipo, item) : LinhaDoCsvPorTipo(tipo, item) + ";" + camiao.VeiculoStatus.DataInicio.ToString("dd/MM/yyyy") + ";" + camiao.VeiculoStatus.DataFim.ToString("dd/MM/yyyy");
                                Escritor.WriteLine(linha);
                            }
                        }
                        break;

                    case "Users":

                        colunas = ColunasDoCsvPorTipo(tipo);
                        Escritor.WriteLine(colunas);

                        foreach (var item in lista)
                        {
                            User user = item as User;

                            if (user.Name == "admin")
                            {
                                continue;
                            }
                            linha = $"{user.Id};{user.Name};{user.UserName};{EncripitarSenha(user.Password)}";
                            Escritor.WriteLine(linha);
                        }
                        break;

                    default:
                        throw new ArgumentException("tipo desconhecido.");

                }


            }
            catch (IOException ex)
            {
                throw new IOException("Erro de E/S ao salvar dados: " + ex.Message);
            }
            finally
            {
                Escritor?.Close();
            }
        }

        private string LinhaDoCsvPorTipo(string tipo, object item)
        {
            switch (tipo)
            {
                case "Carro":
                    Carro carro = item as Carro;
                    if (carro != null)
                    {
                        return $"{carro.VeiculoMatricula};" +
                               $"{carro.VeiculoModelo};" +
                               $"{carro.NumeroPortas};" +
                               $"{carro.TipoCaixa};" +
                               $"{carro.VeiculoPreco} €;" +
                               $"{carro.VeiculoStatus.Nome}";
                    }
                    return "";

                case "Mota":
                    Mota mota = item as Mota;
                    if (mota != null)
                    {
                        return $"{mota.VeiculoMatricula};" +
                               $"{mota.VeiculoModelo};" +
                               $"{mota.Cilindrada} cc;" +
                               $"{mota.VeiculoPreco} €;" +
                               $"{mota.VeiculoStatus.Nome}";
                    }
                    return "";

                case "Camioneta":
                    Camioneta camioneta = item as Camioneta;
                    if (camioneta != null)
                    {
                        return $"{camioneta.VeiculoMatricula};" +
                               $"{camioneta.VeiculoModelo};" +
                               $"{camioneta.NumeroEixos};" +
                               $"{camioneta.NumeroPassageiros};" +
                               $"{camioneta.VeiculoPreco} €;" +
                               $"{camioneta.VeiculoStatus.Nome}";
                    }
                    return ""; ;

                case "Camiao":
                    Camiao camiao = item as Camiao;
                    if (camiao != null)
                    {
                        return $"{camiao.VeiculoMatricula};" +
                               $"{camiao.VeiculoModelo};" +
                               $"{camiao.PesoMaximo} kg;" +
                               $"{camiao.VeiculoPreco} €;" +
                               $"{camiao.VeiculoStatus.Nome}";
                    }
                    return "";

                default:
                    return "";

            }
        }

        private string ColunasDoCsvPorTipo(string tipo)
        {
            switch (tipo)
            {
                case "Carro":

                    return $"Matrícula;Modelo;Nº Portas;Tipo de Caixa;Preço/hora(€);Status";

                case "Mota":

                    return $"Matrícula;Modelo;Cilindrada(cc);Preço/hora(€);Status";

                case "Camioneta":
                    return $"Matrícula;Modelo;Nº de Eixos;Nº Máx. Passageiros;Preço/hora(€);Status";

                case "Camiao":
                    return $"Matrícula;Modelo;Peso Máx. Suportado;Preço/hora(€);Status";

                case "Users":
                    return $"Id;Nome;Usuario;Senha";


                default:
                    return "";

            }



        }
        private string GetCaminhoRelativoPeloNomeDaLista(string tipo, string nomeLista)
        {
            switch (tipo)
            {
                case "Carro":

                    return $"{nomeLista}(carros).csv";

                case "Mota":

                    return $"{nomeLista}(motas).csv";

                case "Camioneta":

                    return $"{nomeLista}(camionetas).csv";

                case "Camiao":

                    return $"{nomeLista}(camioes).csv";

                case "Users":

                    return "users.csv";

                default:
                    throw new ArgumentException("Lista desconhecida.");
            }
        }


        public void AdicionarVeiculoReservado(Veiculo objeto)
        {

            Veiculo veiculo = (Veiculo)objeto;

            string matriculaRequerida = veiculo.VeiculoMatricula;

            //faz o casting antes de testar a matricula
            if (VeiculosReservados.Any(v => ((Veiculo)v).VeiculoMatricula == matriculaRequerida))
            //[ carro , mota, camiao]
            {
                throw new VeiculoDuplicadoException(matriculaRequerida);
            }

            VeiculosReservados.Add(objeto);
        }

        private string EncripitarSenha(string senha)
        {

            StringBuilder senhaCriptografada = new StringBuilder();


            foreach (char caractere in senha)
            {

                if (char.IsLetter(caractere))
                {

                    char inicio = char.IsUpper(caractere) ? 'A' : 'a';

                    char caractereCriptografado = (char)(((caractere + 1 - inicio) % 26) + inicio);

                    senhaCriptografada.Append(caractereCriptografado);
                }
                else
                {

                    senhaCriptografada.Append(caractere);
                }
            }

            char[] senhaInversa = senhaCriptografada.ToString().ToCharArray();
            Array.Reverse(senhaInversa);

            string senhaEncriptada = new string(senhaInversa);

            return senhaEncriptada;
        }



        public void RemoveVeiculoDaLista(object veiculo, string status)
        {
            switch (status)
            {
                case "Disponivel":

                    VeiculosDisponiveis.Remove(veiculo);
                    break;

                case "Alugado":

                    VeiculosAlugados.Remove(veiculo);
                    break;

                case "Reservado":

                    VeiculosReservados.Remove(veiculo);
                    break;

                case "EmManutencao":

                    VeiculosEmManutencao.Remove(veiculo);
                    break;

                default:
                    break;
            }
        }
        public void AdicionarVeiculoNaLista(object veiculo, string status)
        {
            switch (status)
            {
                case "Disponivel":

                    VeiculosDisponiveis.Add(veiculo);
                    break;

                case "Alugado":

                    VeiculosAlugados.Add(veiculo);
                    break;

                case "Reservado":

                    VeiculosReservados.Add(veiculo);
                    break;

                case "EmManutencao":

                    VeiculosEmManutencao.Add(veiculo);
                    break;

                default:
                    break;
            }
        }

        public void ValidarReserva(string matricula, DateTime inicio)
        {
            Veiculo veiculo = (Veiculo)VeiculosReservados.Find(v => ((Veiculo)v).VeiculoMatricula == matricula);

            if (veiculo != null)
            {
                if (inicio.Date < veiculo.VeiculoStatus.DataFim.Date)
                {
                    throw new ArgumentException($" O veiculo da matricula {matricula} na data {inicio} já está reservado");

                }
            }


        }
        public void ValidarAluguer(string matricula, DateTime dataInicio)
        {
            Veiculo veiculo = (Veiculo)VeiculosAlugados.Find(v => ((Veiculo)v).VeiculoMatricula == matricula);

            if (veiculo != null)
            {
                if (dataInicio.Date < veiculo.VeiculoStatus.DataFim.Date)
                {
                    throw new ArgumentException($" O veiculo da matricula {matricula} na data {dataInicio.Date} já está Alugado");
                }
            }
        }
    }

}





