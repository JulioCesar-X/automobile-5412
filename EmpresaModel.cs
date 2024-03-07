﻿using System;
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
            Carro veiculo1 = new Carro("01", "Corsa", 88.70m, new Estado(), 5, "manual");
            Mota veiculo2 = new Mota("02", "XTZ", 55.80m, new Estado(), 300);
            Camiao veiculo3 = new Camiao("03", "BUGVERDE", 150.99m, new Estado(), 44000);
            Camioneta veiculo4 = new Camioneta("04", "Venom", 500.99m, new Estado(), 2, 5);
            Carro veiculo5 = new Carro("05", "Corsa", 88.70m, new Estado(), 5, "manual");
            Mota veiculo6 = new Mota("06", "XTZ", 55.80m, new Estado(), 300);
            Camiao veiculo7 = new Camiao("07", "BUGVERDE", 150.99m, new Estado(), 44000);
            Camioneta veiculo8 = new Camioneta("08", "Venom", 500.99m, new Estado(), 2, 5);

            Carro veiculo9 = new Carro("09", "Corsa", 88.70m, new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), 5, "manual");
            Mota veiculo10 = new Mota("10", "XTZ", 55.80m, new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), 300);
            Camiao veiculo11 = new Camiao("11", "BUGVERDE", 150.99m, new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), 44000);
            Camioneta veiculo12 = new Camioneta("12", "Venom", 500.99m, new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), 2, 5);
            Carro veiculo13 = new Carro("13", "Corsa", 88.70m, new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), 5, "manual");
            Mota veiculo14 = new Mota("14", "XTZ", 55.80m, new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), 300);
            Camiao veiculo15 = new Camiao("15", "BUGVERDE", 150.99m, new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), 44000);
            Camioneta veiculo16 = new Camioneta("16", "Venom", 500.99m, new Estado(Estado.Tipo.Alugado, DateTime.Today, DateTime.Today.AddDays(1)), 2, 5);

            Carro veiculo17 = new Carro("17", "Corsa", 88.70m, new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(5)), 5, "manual");
            Mota veiculo18 = new Mota("18", "XTZ", 55.80m, new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(5)), 300);
            Camiao veiculo19 = new Camiao("19", "BUGVERDE", 150.99m, new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(1)), 44000);
            Camioneta veiculo20 = new Camioneta("20", "Venom", 500.99m, new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(1)), 2, 5);
            Carro veiculo21 = new Carro("21", "Corsa", 88.70m, new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(1)), 5, "manual");
            Mota veiculo22 = new Mota("22", "XTZ", 55.80m, new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(1)), 300);
            Camiao veiculo23 = new Camiao("23", "BUGVERDE", 150.99m, new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(1)), 44000);
            Camioneta veiculo24 = new Camioneta("24", "Venom", 500.99m, new Estado(Estado.Tipo.Reservado, DateTime.Today, DateTime.Today.AddDays(1)), 2, 5);

            Carro veiculo25 = new Carro("25", "Corsa", 88.70m, new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), 5, "manual");
            Mota veiculo26 = new Mota("26", "XTZ", 55.80m, new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), 300);
            Camiao veiculo27 = new Camiao("27", "BUGVERDE", 150.99m, new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), 44000);
            Camioneta veiculo28 = new Camioneta("28", "Venom", 500.99m, new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), 2, 5);
            Carro veiculo29 = new Carro("29", "Corsa", 88.70m, new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), 5, "manual");
            Mota veiculo30 = new Mota("30", "XTZ", 55.80m, new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), 300);
            Camiao veiculo31 = new Camiao("31", "BUGVERDE", 150.99m, new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), 44000);
            Camioneta veiculo32 = new Camioneta("32", "Venom", 500.99m, new Estado(Estado.Tipo.EmManutencao, DateTime.Today, DateTime.Today.AddDays(1)), 2, 5);

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
            VeiculosAlugados.Add(veiculo11);
            VeiculosAlugados.Add(veiculo12);
            VeiculosAlugados.Add(veiculo13);
            VeiculosAlugados.Add(veiculo14);
            VeiculosAlugados.Add(veiculo15);
            VeiculosAlugados.Add(veiculo16);

            VeiculosReservados.Add(veiculo17);
            VeiculosReservados.Add(veiculo18);
            VeiculosReservados.Add(veiculo19);
            VeiculosReservados.Add(veiculo20);
            VeiculosReservados.Add(veiculo21);
            VeiculosReservados.Add(veiculo22);
            VeiculosReservados.Add(veiculo23);
            VeiculosReservados.Add(veiculo24);

            VeiculosEmManutencao.Add(veiculo25);
            VeiculosEmManutencao.Add(veiculo26);
            VeiculosEmManutencao.Add(veiculo27);
            VeiculosEmManutencao.Add(veiculo28);
            VeiculosEmManutencao.Add(veiculo29);
            VeiculosEmManutencao.Add(veiculo30);
            VeiculosEmManutencao.Add(veiculo31);
            VeiculosEmManutencao.Add(veiculo32);


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


        public void ValidarListaVeiculosDoTipo(string tipoRequerido, string status)
        {

            switch (status)
            {
                case "Disponivel":
                    ExisteVeiculoNesseStatus(tipoRequerido, VeiculosDisponiveis);
                    break;
                case "Alugado":
                    ExisteVeiculoNesseStatus(tipoRequerido, VeiculosAlugados);
                    break;
                case "Reservado":
                    ExisteVeiculoNesseStatus(tipoRequerido, VeiculosReservados);
                    break;
                case "Em Manuntenção":
                    ExisteVeiculoNesseStatus(tipoRequerido, VeiculosEmManutencao);
                    break;

                default:
                    throw new ArgumentException("Status do veiculo mal especificado");

            }



        }

        private bool ExisteVeiculoNesseStatus(string tipoRequerido, List<object> lista)
        {
            if (lista.Count == 0)
            {
                throw new ArgumentException("Lista de veiculos vazia");

            }
            else if (lista.Any(v => v.GetType().Name == tipoRequerido))
            {
                return true;
            }
            else
            {
                throw new ArgumentException($"Veiculo desse tipo não está presente nessa lista");
            }
        }



        public void AdicionarReserva(string matricula, DateTime inicio, DateTime fim)
        {
            Veiculo veiculo = (Veiculo)VeiculosDisponiveis.Find(v => ((Veiculo)v).VeiculoMatricula == matricula);

            if (inicio < veiculo.VeiculoStatus.DataFim)
            {
                throw new ArgumentException($" O veiculo da matricula {matricula} na data {inicio} já está reservado");

            }
            else if (veiculo != null)
            {
                veiculo.Reservar(inicio, fim);
                VeiculosReservados.Add(veiculo);
            }
            else
            {
                throw new ArgumentException($" O veiculo da matricula {matricula} não foi encontrado");
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


        /* Ainda estou refatorando*/
        public void SalvarDadosNoCsv(string folderPath, string nomeLista)
        {


            switch (nomeLista)
            {

                case "VeiculosDisponiveis":


                    foreach (var tipo in new string[] { "Carro", "Mota", "Camioneta", "Camiao" })
                    {
                        //Para cada tipo de objeto especificado vamos verificar  e criar o csv
                        ValidarListaVeiculosDoTipo(tipo, "Disponivel");

                        if (VeiculosDisponiveis.Count > 0)
                        {
                            EscreveNoCsvDadosDaLista(folderPath, VeiculosDisponiveis, tipo, nomeLista);
                        }

                    }
                    break;

                case "VeiculosAlugados":



                    foreach (var tipo in new string[] { "Carro", "Mota", "Camioneta", "Camiao" })
                    {
                        //Para cada tipo de objeto especificado vamos verificar  e criar o csv
                        ValidarListaVeiculosDoTipo(tipo, "Alugado");

                        if (VeiculosAlugados.Count > 0)
                        {
                            EscreveNoCsvDadosDaLista(folderPath, VeiculosAlugados, tipo, nomeLista);
                        }

                    }
                    break;

                case "VeiculosReservados":



                    foreach (var tipo in new string[] { "Carro", "Mota", "Camioneta", "Camiao" })
                    {
                        //Para cada tipo de objeto especificado vamos verificar  e criar o csv
                        ValidarListaVeiculosDoTipo(tipo, "Reservado");

                        if (VeiculosReservados.Count > 0)
                        {
                            EscreveNoCsvDadosDaLista(folderPath, VeiculosReservados, tipo, nomeLista);
                        }

                    }
                    break;

                case "VeiculosEmManutencao":



                    foreach (var tipo in new string[] { "Carro", "Mota", "Camioneta", "Camiao" })
                    {
                        //Para cada tipo de objeto especificado vamos verificar  e criar o csv
                        ValidarListaVeiculosDoTipo(tipo, "Em Manuntenção");

                        if (VeiculosEmManutencao.Count > 0)
                        {
                            EscreveNoCsvDadosDaLista(folderPath, VeiculosEmManutencao, tipo, nomeLista);
                        }

                    }
                    break;

                case "Users":

                    if (Users.Count == 0)
                    {
                        throw new ArgumentException($"Não há itens na \"{nomeLista}\" para salvar.");
                    }

                    EscreveNoCsvDadosDaLista(folderPath, Users, "Users", nomeLista);

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

                switch (tipo)
                {
                    case "Carro":

                        foreach (var item in lista)
                        {
                            Carro carro = item as Carro;
                            Escritor.WriteLine($"{carro.VeiculoMatricula};{carro.VeiculoModelo};{carro.NumeroPortas};{carro.TipoCaixa};{carro.VeiculoPreco} €;{carro.VeiculoStatus}");
                        }
                        break;

                    case "Mota":

                        foreach (var item in lista)
                        {
                            Mota mota = item as Mota;
                            Escritor.WriteLine($"{mota.VeiculoMatricula};{mota.VeiculoModelo};{mota.Cilindrada} cc;{mota.VeiculoPreco} €;{mota.VeiculoStatus}");
                        }
                        break;

                    case "Camioneta":

                        foreach (var item in lista)
                        {
                            Camioneta camioneta = item as Camioneta;
                            Escritor.WriteLine($"{camioneta.VeiculoMatricula};{camioneta.VeiculoModelo};{camioneta.NumeroEixos};{camioneta.NumeroPassageiros};{camioneta.VeiculoPreco} €;{camioneta.VeiculoStatus}");
                        }
                        break;

                    case "Camiao":

                        foreach (var item in lista)
                        {
                            Camiao camiao = item as Camiao;
                            Escritor.WriteLine($"{camiao.VeiculoMatricula};{camiao.VeiculoModelo};{camiao.PesoMaximo} kg;{camiao.VeiculoPreco} €;{camiao.VeiculoStatus}");

                        }
                        break;

                    case "Users":

                        foreach (var item in lista)
                        {
                            User user = item as User;
                            Escritor.WriteLine($"{user.Id};{user.Name};{user.UserName};{user.Password}");

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
                if (Escritor != null)
                {
                    Escritor.Close();
                }
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


        //public void CarregarDadosDoCsv(string folderPath, string nomeLista)
        //{
        //    // Simulando uma exceção caso o arquivo CSV não exista
        //    if (!File.Exists(Path.Combine(folderPath, GetCaminhoPeloNomeDaLista(nomeLista))))
        //    {
        //        throw new FileNotFoundException("Arquivo CSV não encontrado.");
        //    }

        //    StreamReader leitor = null;
        //    try
        //    {
        //        leitor = new StreamReader(Path.Combine(folderPath, GetCaminhoPeloNomeDaLista(nomeLista)));

        //        string linha;
        //        while ((linha = leitor.ReadLine()) != null)
        //        {
        //            // Processar cada linha do arquivo CSV
        //            // Por exemplo, você pode converter a linha de volta para o objeto e adicioná-lo à tipo.
        //        }
        //    }
        //    catch (IOException ex)
        //    {
        //        throw new IOException("Erro de E/S ao carregar dados: " + ex.Message);
        //    }
        //    finally
        //    {
        //        if (leitor != null)
        //        {
        //            leitor.Close();
        //        }
        //    }
        //}  // ainda estou  refatorando
    }

}





