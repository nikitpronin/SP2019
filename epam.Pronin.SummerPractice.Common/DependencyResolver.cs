using epam.Pronin.SummerPractice.BLL;
using epam.Pronin.SummerPractice.BLL.Interface;
using epam.Pronin.SummerPractice.DAL;
using epam.Pronin.SummerPractice.DAL.Interface;

namespace epam.Pronin.SummerPractice.Common
{
    public class DependencyResolver
    {
        private static ILotDao _lotDao;
        public static ILotDao LotDao => _lotDao ?? (_lotDao = new LotDao());

        private static IUserDao _userDao;
        public static IUserDao UserDao => _userDao ?? (_userDao = new UserDao());


        private static ILotLogic _lotLogic;
        public static ILotLogic LotLogic => _lotLogic ?? (_lotLogic = new LotLogic(LotDao));

        public static IUserLogic _userLogic;
        public static IUserLogic UserLogic => _userLogic ?? (_userLogic = new UserLogic(UserDao));
    }
}
