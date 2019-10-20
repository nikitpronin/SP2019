using epam.Pronin.SummerPractice.Entities;
using epam.Pronin.SummerPractice.BLL.Interface;
using epam.Pronin.SummerPractice.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace epam.Pronin.SummerPractice.BLL
{
    public class LotLogic : ILotLogic
    {
        private readonly ILotDao _lotDao;

        public LotLogic(ILotDao lotDao)
        {
            _lotDao = lotDao;
        }

        public void Add(Lot value)
        {
            _lotDao.Add(value);
        }

        public IEnumerable<Lot> GetAll()
        {
            return _lotDao.GetAll();
        }

        public void Delete(int id)
        {
            _lotDao.Delete(id);
        }

        public Lot GetById(int id)
        {
            return _lotDao.GetById(id);
        }

        public Lot GetByName(string name)
        {
            return _lotDao.GetByName(name);
        }

        public void AddUserLot(int id_u, int id_l)
        {
            _lotDao.AddUserLot(id_u, id_l);
        }
        public IEnumerable<Lot> GetUserLot(int id_u)
        {
            return _lotDao.GetUserLot(id_u);
        }
        public void DeleteUserLot(int id_u, int id_l)
        {
            _lotDao.DeleteUserLot(id_u, id_l);
        }
    }
}
