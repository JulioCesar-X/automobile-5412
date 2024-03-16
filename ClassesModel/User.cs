using System;

namespace Automobile
{
    internal class User
    {
        private string _id;
        private string _name;
        private string _password;
        private string _username;



        public string Id
        {
            get
            {
                return _id;
            }

            set
            {

                //string[] idRepartido = value.Split('#');
                //string digitos = idRepartido[1];
                //string hashtag = idRepartido[0];

                //if (digitos.Length != 3 || hashtag.Length != 1)
                //{
                //    throw new ArgumentException($"o ID \"{value}\" não é válido.");
                //}
                //else
                //{
                //    _id = value;

                //}
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;

            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length <= 8)
                {
                    _password = value;
                }
                else
                {
                    throw new ArgumentException("Password deverá ter no máximo 8 caracteres");
                }
            }
        }



        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                _username = _id + _name;
            }
        }

        public User(string id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
            UserName = id + name;
        }



    }
}