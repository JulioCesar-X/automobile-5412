using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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


        public void AdicionarVeiculo(object objeto)
        {

            Veiculo veiculo = (Veiculo)objeto;
            string matriculaRequerida = veiculo.VeiculoMatricula;


            //faz o casting antes de testar a matricula
            if (Veiculos.Any(v => ((Veiculo)v).VeiculoMatricula == matriculaRequerida))
            //[ carro , mota, camiao]
            {
                throw new VeiculoDuplicadoException(matriculaRequerida);
            }               //ArgumentException()

            Veiculos.Add(objeto);
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

        public void AdicionarReserva(Reserva novaReserva)
        {
            Reservas.Add(novaReserva);
        }

        public List<object> GetListaVeciulosDoTipo(string tipoRequerido)
        {
            switch (tipoRequerido)
            {
                case "Carro":
                    return Veiculos.FindAll(v => v is Carro);

                case "Mota":
                    return Veiculos.FindAll(v => v is Mota);

                case "Camioneta":
                    return Veiculos.FindAll(v => v is Camioneta);

                case "Camiao":
                    return Veiculos.FindAll(v => v is Camiao);

                default:
                    return null;
            }

        }






        public void SalvarDadosNoCsv(string folderPath, string nomeLista)
        {
            switch (nomeLista)
            {
                case "Veiculos":

                    string[] tipos = new string[] { "Carro", "Mota", "Camioneta", "Camiao" };

                    foreach (var tipo in tipos)
                    {
                        //Para cada nomeLista de objeto especificado vamos verificar  e criar o csv
                        ValidarListaVeiculosDoTipo(tipo);

                        List<object> lista = GetListaVeciulosDoTipo(tipo);

                        if (lista.Count > 0)
                        {
                            EscreveNoCsvDadosDaLista(folderPath, lista, tipo);
                        }

                    }
                    break;

                case "Users":

                    if (Users.Count == 0)
                    {
                        throw new ArgumentException($"Não há itens na \"{nomeLista}\" para salvar.");
                    }

                    EscreveNoCsvDadosDaLista(folderPath, Users, nomeLista);

                    break;

                case "Reservas":

                    if (Reservas.Count == 0)
                    {
                        throw new ArgumentException($"Não há itens na \"{nomeLista}\" para salvar.");
                    }

                    EscreveNoCsvDadosDaLista(folderPath, Reservas, nomeLista);

                    break;

            }


        }

        //Estou trabalhando no processo de salvar em excel!

        private string GetLinhaCSV<T>(T objeto)
        {
            if (typeof(T) == typeof(object))
            {
                switch (objeto.GetType().Name)
                {
                    case "Carro":

                        Carro carro = objeto as Carro;

                        return $"{carro.VeiculoMatricula};{carro.VeiculoModelo};{carro.NumeroPortas};{carro.TipoCaixa};{carro.VeiculoPreco} €;{carro.VeiculoStatus}";


                    case "Mota":

                        Mota mota = objeto as Mota;

                        return $"{mota.VeiculoMatricula};{mota.VeiculoModelo};{mota.Cilindrada} cc;{mota.VeiculoPreco} €;{mota.VeiculoStatus}";

                    case "Camioneta":

                        Camioneta camioneta = objeto as Camioneta;

                        return $"{camioneta.VeiculoMatricula};{camioneta.VeiculoModelo};{camioneta.NumeroEixos};{camioneta.NumeroPassageiros};{camioneta.VeiculoPreco} €;{camioneta.VeiculoStatus}";

                    case "Camiao":

                        Camiao camiao = objeto as Camiao;

                        return $"{camiao.VeiculoMatricula};{camiao.VeiculoModelo};{camiao.PesoMaximo} kg;{camiao.VeiculoPreco} €;{camiao.VeiculoStatus}";

                    default:

                        return "";


                }

            }
            else if (typeof(T) == typeof(User))
            {
                // Se o objeto for do tipo User, você pode escolher quais propriedades deseja incluir na linha CSV
                User user = objeto as User;
                return $"{user.Id};{user.Name};{user.UserName};{user.Password}";
            }
            else if (typeof(T) == typeof(Reserva))
            {
                // Se o objeto for do tipo Reserva, você pode escolher quais propriedades deseja incluir na linha CSV
                Reserva reserva = objeto as Reserva;
                return $"{reserva.Id};{reserva.DataInicio};{reserva.DataFim};{reserva.Veiculo.VeiculoModelo};{reserva.Veiculo.VeiculoPreco};{reserva.Veiculo.VeiculoMatricula};";
            }
            else
            {
                // Caso o tipo do objeto não corresponda a nenhum dos tipos esperados, retorne uma string vazia
                return "";
            }
        }

        //Usando o tipo genérico é uma estrutura flexivel - permite que classes,metodos,interfaces trabalhem  com tipos especificos em tempo de compilação em vez de tipos fixos.
        //O tempo de compilação é quando o código é traduzido e analisado pelo compilador antes da execução, enquanto o tempo de execução é quando o código é realmente executado e produz resultados.
        private void EscreveNoCsvDadosDaLista<T>(string folderPath, List<T> lista, string nomeLista)
        {

            StreamWriter Escritor = null;
            try
            {
                //false sobrescrever, true escrever ao final do arquivo
                Escritor = new StreamWriter(Path.Combine(folderPath, GetCaminhoPeloNomeDaLista(nomeLista)), false, Encoding.UTF8);

                foreach (var item in lista)
                {
                    Escritor.WriteLine(GetLinhaCSV(item));
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

        private string GetCaminhoPeloNomeDaLista(string nomeLista)
        {
            switch (nomeLista)
            {
                case "Carro":

                    return "carros.csv";

                case "Mota":

                    return "motas.csv";

                case "Camioneta":

                    return "camionetas.csv";

                case "Camiao":

                    return "camioes.csv";

                case "Users":

                    return "users.csv";

                case "Reservas":

                    return "reservas.csv";

                default:
                    throw new ArgumentException("Lista desconhecida.");
            }
        }


        public void CarregarDadosDoCsv(string folderPath, string nomeLista)
        {
            // Simulando uma exceção caso o arquivo CSV não exista
            if (!File.Exists(Path.Combine(folderPath, GetCaminhoPeloNomeDaLista(nomeLista))))
            {
                throw new FileNotFoundException("Arquivo CSV não encontrado.");
            }

            StreamReader leitor = null;
            try
            {
                leitor = new StreamReader(Path.Combine(folderPath, GetCaminhoPeloNomeDaLista(nomeLista)));

                string linha;
                while ((linha = leitor.ReadLine()) != null)
                {
                    // Processar cada linha do arquivo CSV
                    // Por exemplo, você pode converter a linha de volta para o objeto e adicioná-lo à nomeLista.
                }
            }
            catch (IOException ex)
            {
                throw new IOException("Erro de E/S ao carregar dados: " + ex.Message);
            }
            finally
            {
                if (leitor != null)
                {
                    leitor.Close();
                }
            }
        }
    }

}





