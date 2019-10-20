using epam.Pronin.SummerPractice.Entities;
using epam.Pronin.SummerPractice.BLL.Interface;
using epam.Pronin.SummerPractice.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace epam.Pronin.SummerPractice.BLL
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserDao _userDao;

        public UserLogic(IUserDao userDao)
        {
            _userDao = userDao;
        }
        public int Authorizate(string log, string pass)
        {
            return _userDao.Authorizate(log, pass);
        }
        public IEnumerable<User> GetUser(int id)
        {
            return _userDao.GetUser(id);
        }

        public void DeleteUser(int id)
        {
            _userDao.DeleteUser(id);
        }

        public void Registrate(User user)
        {
            _userDao.Registrate(user);
        }

    }
}
