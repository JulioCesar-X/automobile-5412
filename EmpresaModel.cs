using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Automobile
{
    internal class EmpresaModel
    {

        public List<object> Veiculos { get; set; }

        public List<User> Users { get; set; }

        public List<Reserva> Reservas { get; set; }






        public EmpresaModel()
        {
            Veiculos = new List<object>();
            Users = new List<User>();
            Reservas = new List<Reserva>();

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
            User func5 = new User("#", "", ""); //ADMIN

            Users.Add(func1);
            Users.Add(func2);
            Users.Add(func3);
            Users.Add(func4);
            Users.Add(func5);

        }

        private void CriarListaVeiculosDefault()
        {
            Carro veiculo1 = new Carro("01", "Corsa", 88.70m, "Disponivel", 5, "manual");
            Mota veiculo2 = new Mota("02", "XTZ", 55.80m, "Disponivel", 300);
            Camiao veiculo3 = new Camiao("03", "BUGVERDE", 150.99m, "Disponivel", 44000);
            Camioneta veiculo4 = new Camioneta("04", "Venom", 500.99m, "Disponivel", 2, 5);
            Carro veiculo5 = new Carro("05", "Corsa", 88.70m, "Disponivel", 5, "manual");
            Mota veiculo6 = new Mota("06", "XTZ", 55.80m, "Disponivel", 300);
            Camiao veiculo7 = new Camiao("07", "BUGVERDE", 150.99m, "Disponivel", 44000);
            Camioneta veiculo8 = new Camioneta("08", "Venom", 500.99m, "Disponivel", 2, 5);

            Carro veiculo9 = new Carro("09", "Corsa", 88.70m, "Alugado", 5, "manual");
            Mota veiculo10 = new Mota("10", "XTZ", 55.80m, "Alugado", 300);
            Camiao veiculo11 = new Camiao("11", "BUGVERDE", 150.99m, "Alugado", 44000);
            Camioneta veiculo12 = new Camioneta("12", "Venom", 500.99m, "Alugado", 2, 5);
            Carro veiculo13 = new Carro("13", "Corsa", 88.70m, "Alugado", 5, "manual");
            Mota veiculo14 = new Mota("14", "XTZ", 55.80m, "Alugado", 300);
            Camiao veiculo15 = new Camiao("15", "BUGVERDE", 150.99m, "Alugado", 44000);
            Camioneta veiculo16 = new Camioneta("16", "Venom", 500.99m, "Alugado", 2, 5);

            Carro veiculo17 = new Carro("17", "Corsa", 88.70m, "Reservado", 5, "manual");
            Mota veiculo18 = new Mota("18", "XTZ", 55.80m, "Reservado", 300);
            Camiao veiculo19 = new Camiao("19", "BUGVERDE", 150.99m, "Reservado", 44000);
            Camioneta veiculo20 = new Camioneta("20", "Venom", 500.99m, "Reservado", 2, 5);
            Carro veiculo21 = new Carro("21", "Corsa", 88.70m, "Reservado", 5, "manual");
            Mota veiculo22 = new Mota("22", "XTZ", 55.80m, "Reservado", 300);
            Camiao veiculo23 = new Camiao("23", "BUGVERDE", 150.99m, "Reservado", 44000);
            Camioneta veiculo24 = new Camioneta("24", "Venom", 500.99m, "Reservado", 2, 5);

            Carro veiculo25 = new Carro("25", "Corsa", 88.70m, "Em manutenção", 5, "manual");
            Mota veiculo26 = new Mota("26", "XTZ", 55.80m, "Em manutenção", 300);
            Camiao veiculo27 = new Camiao("27", "BUGVERDE", 150.99m, "Em manutenção", 44000);
            Camioneta veiculo28 = new Camioneta("28", "Venom", 500.99m, "Em manutenção", 2, 5);
            Carro veiculo29 = new Carro("29", "Corsa", 88.70m, "Em manutenção", 5, "manual");
            Mota veiculo30 = new Mota("30", "XTZ", 55.80m, "Em manutenção", 300);
            Camiao veiculo31 = new Camiao("31", "BUGVERDE", 150.99m, "Em manutenção", 44000);
            Camioneta veiculo32 = new Camioneta("32", "Venom", 500.99m, "Em manutenção", 2, 5);

            Veiculos.Add(veiculo1);
            Veiculos.Add(veiculo2);
            Veiculos.Add(veiculo3);
            Veiculos.Add(veiculo4);
            Veiculos.Add(veiculo5);
            Veiculos.Add(veiculo6);
            Veiculos.Add(veiculo7);
            Veiculos.Add(veiculo8);

            Veiculos.Add(veiculo9);
            Veiculos.Add(veiculo10);
            Veiculos.Add(veiculo11);
            Veiculos.Add(veiculo12);
            Veiculos.Add(veiculo13);
            Veiculos.Add(veiculo14);
            Veiculos.Add(veiculo15);
            Veiculos.Add(veiculo16);

            Veiculos.Add(veiculo17);
            Veiculos.Add(veiculo18);
            Veiculos.Add(veiculo19);
            Veiculos.Add(veiculo20);
            Veiculos.Add(veiculo21);
            Veiculos.Add(veiculo22);
            Veiculos.Add(veiculo23);
            Veiculos.Add(veiculo24);

            Veiculos.Add(veiculo25);
            Veiculos.Add(veiculo26);
            Veiculos.Add(veiculo27);
            Veiculos.Add(veiculo28);
            Veiculos.Add(veiculo29);
            Veiculos.Add(veiculo30);
            Veiculos.Add(veiculo31);
            Veiculos.Add(veiculo32);


        }


        public void AdicionarVeiculo(object veiculo)
        {


            //do veiculo que quero adicionar
            string matriculaRequerida = GetMatricula(veiculo);

            // Verifica se há um veículo na minha lista com a mesma Matricula usando a reflexão
            if (Veiculos.Any(v => GetMatricula(v) == matriculaRequerida))
            //[ carro , mota, camiao]
            {
                throw new VeiculoDuplicadoException(matriculaRequerida);
            }               //ArgumentException()

            Veiculos.Add(veiculo);
        }

        public string GetMatricula(object veiculo)
        {
            PropertyInfo propriedadeMatricula = veiculo.GetType().GetProperty("VeiculoMatricula");

            return propriedadeMatricula.GetValue(veiculo).ToString();
        }
        public string GetModelo(object veiculo)
        {
            PropertyInfo propriedadeModelo = veiculo.GetType().GetProperty("VeiculoModelo");

            return propriedadeModelo.GetValue(veiculo).ToString();
        }

        public string GetNumPortas(object veiculo)
        {
            PropertyInfo propriedadeNumPortas = veiculo.GetType().GetProperty("NumeroPortas");

            return propriedadeNumPortas.GetValue(veiculo).ToString();
        }
        public string GetTipoDeCaixa(object veiculo)
        {
            PropertyInfo propriedadeTipoDeCaixa = veiculo.GetType().GetProperty("TipoCaixa");

            return propriedadeTipoDeCaixa.GetValue(veiculo).ToString();
        }
        public string GetPrecoPorDia(object veiculo)
        {
            PropertyInfo propriedadePrecoPorDia = veiculo.GetType().GetProperty("VeiculoPreco");

            return propriedadePrecoPorDia.GetValue(veiculo).ToString();
        }
        public string GetStatus(object veiculo)
        {
            PropertyInfo propriedadeStatus = veiculo.GetType().GetProperty("VeiculoStatus");

            return propriedadeStatus.GetValue(veiculo).ToString();
        }

        public bool ValidarListaVeiculosDoTipo(string tipoRequerido)
        {


            if (Veiculos.Count == 0)
            {
                throw new ArgumentException("Lista de veiculos vazia");

            }
            else if (ExisteVeiculoDesseTipo(tipoRequerido))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Veiculo desse tipo esgotado");
            }

        }

        public bool ExisteVeiculoDesseTipo(string tipoRequerido)
        {

            return Veiculos.Any(v => v.GetType().Name == tipoRequerido);

        }

        public void AdicionarReserva(Reserva novareserva)
        {
            Reservas.Add(novareserva);
        }

        public List<object> ListaVeciulosDoTipo(string tipoRequerido)
        {
            var listaFiltrada = new List<object>();

            foreach (var veiculo in Veiculos) //veiculo é do tipo object
            {
                if (veiculo.GetType().Name == tipoRequerido)
                {
                    listaFiltrada.Add(veiculo);
                }
            }

            return listaFiltrada;

        }

        internal object GetCilindrada(object veiculo)
        {
            PropertyInfo propriedadeCilindrada = veiculo.GetType().GetProperty("Cilindrada");

            return propriedadeCilindrada.GetValue(veiculo).ToString();
        }

        internal object GetNumMaxPassageiros(object veiculo)
        {
            PropertyInfo propriedadeNumeroPassageiros = veiculo.GetType().GetProperty("NumeroPassageiros");

            return propriedadeNumeroPassageiros.GetValue(veiculo).ToString();
        }

        internal object GetNumEixos(object veiculo)
        {
            PropertyInfo propriedadeNumeroEixos = veiculo.GetType().GetProperty("NumeroEixos");

            return propriedadeNumeroEixos.GetValue(veiculo).ToString();
        }

        internal object GetPesoMaxSuportado(object veiculo)
        {
            PropertyInfo propriedadePesoMaximo = veiculo.GetType().GetProperty("PesoMaximo");

            return propriedadePesoMaximo.GetValue(veiculo).ToString();
        }
    }




}
