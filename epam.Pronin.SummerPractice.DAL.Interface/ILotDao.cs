using System;
using epam.Pronin.SummerPractice.Entities;
using System.Collections.Generic;
using System.Text;

namespace epam.Pronin.SummerPractice.DAL.Interface
{
    public interface ILotDao
    {
        void Add(Lot value);
        IEnumerable<Lot> GetAll();
        void Delete(int id_lot);
        Lot GetById(int id_lot);
        Lot GetByName(string name_lot);
        void AddUserLot(int id_u, int id_l);
        IEnumerable<Lot> GetUserLot(int id_u);
        void DeleteUserLot(int id_u, int id_l);
    }
}
