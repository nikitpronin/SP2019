using epam.Pronin.SummerPractice.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace epam.Pronin.SummerPractice.BLL.Interface
{
    public interface IUserLogic
    {
        int Authorizate(string log, string pass);
        IEnumerable<User> GetUser(int id);
        void DeleteUser(int id);
        void Registrate(User value);
    }
}
