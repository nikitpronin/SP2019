using System;
using epam.Pronin.SummerPractice.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam.Pronin.SummerPractice.DAL.Interface
{
    public interface IUserDao
    {
        int Authorizate(string log, string pass);
        IEnumerable<User> GetUser(int id);
        void DeleteUser(int id);
        void Registrate(User value);
    }
}
