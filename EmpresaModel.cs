using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Automobile
{
    internal class EmpresaModel
    {

        public List<object> Veiculos { get; set; }

        public List<User> Users { get; set; }

        //sgagaag




        public EmpresaModel()
        {
            Veiculos = new List<object>();
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

            Veiculos.Add(veiculo1);
            Veiculos.Add(veiculo2);
            Veiculos.Add(veiculo3);
            Veiculos.Add(veiculo4);
            Veiculos.Add(veiculo5);
            Veiculos.Add(veiculo6);
            Veiculos.Add(veiculo7);
            Veiculos.Add(veiculo8);

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

            Veiculos.Add(veiculo);// realmente a mota está salva
        }

        public string GetMatricula(object veiculo)
        {
            PropertyInfo propriedadeMatricula = veiculo.GetType().GetProperty("VeiculoMatricula");

            return propriedadeMatricula.GetValue(veiculo).ToString();
        }

        public bool VerListaVeiculosDoTipo(string tipoRequerido)
        {
            Console.OutputEncoding = Encoding.UTF8;

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


    }




}
