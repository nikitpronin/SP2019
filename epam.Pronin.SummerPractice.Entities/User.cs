using System;

namespace epam.Pronin.SummerPractice.Entities
{
    public class User
    {
        public int Id_user { get; set; }
        public string Name_user { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(string name,  string login, string pas)
        {
            Name_user = name;
            Login = login;
            Password = pas;
        }

    }
}
