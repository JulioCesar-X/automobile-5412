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



        public EmpresaModel()
        {
            Veiculos = new List<object>();
            Users = new List<User>();
            CriarListaDefaultUsers();
        }




        public void AdicionarUser(User newUser)
        {

            if (Users.Any(user => user.Id == newUser.Id))
            {
                throw new ArgumentException($"Id \"{newUser.Id}\" inválido");

            }
            else if (Users.Any(user => user.Password == newUser.Password))
            {
                throw new ArgumentException("Password inválido");
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
            User func5 = new User("#", "", "atec"); //ADMIN

            Users.Add(func1);
            Users.Add(func2);
            Users.Add(func3);
            Users.Add(func4);
            Users.Add(func5);

        }



        public void AdicionarVeiculo(object veiculo)
        {
            var tipoVeiculo = veiculo.GetType();

            // pego de um tipo de dado object seu tipo natural e a propriedade "veiculoId", usando a reflexão
            PropertyInfo propriedadeVeiculoId = tipoVeiculo.GetProperty("VeiculoId");
            //passo para variavel novoveiculo o valor que é (int) da propriedade veiculo id desse veiculo
            int novoVeiculoId = (int)propriedadeVeiculoId.GetValue(veiculo);

            // Verifica se há um veículo com o mesmo ID na lista usando a reflexão
            if (Veiculos.Any(v => (int)propriedadeVeiculoId.GetValue(v) == novoVeiculoId))
            {
                throw new VeiculoDuplicadoException(novoVeiculoId);
            }

            Veiculos.Add(veiculo);
        }
        public void VerListaVeiculos(string tipoRequerido)
        {
            Console.OutputEncoding = Encoding.UTF8;

            if (Veiculos.Count == 0)
            {
                throw new ArgumentException("Lista vazia");
            }
            else if (tipoRequerido != null)
            {
                if (Veiculos.Any(v => v.GetType().Name == tipoRequerido))
                {
                    foreach (var item in Veiculos)
                    {
                        string tipoVeiculo = item.GetType().Name;

                        if (tipoVeiculo == tipoRequerido)
                        {
                            Console.WriteLine(item);
                        }

                    }
                }
            }
            else
            {

                foreach (var item in Veiculos)
                {
                    Console.WriteLine(item);
                }

            }

        }


    }




}
