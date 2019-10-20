using System;

using epam.Pronin.SummerPractice.BLL.Interface;
using epam.Pronin.SummerPractice.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace epam.Pronin.SummerPractice
{
    public partial class GetUserLot : Form
    {
        private int _id1;
        private IUserLogic _userLogic = DependencyResolver.UserLogic;
        private ILotLogic _lotLogic = DependencyResolver.LotLogic;
        public GetUserLot()
        {
            InitializeComponent();
        }



        private void GetUserLot_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "summerPracticeDataSet.GetAllLots". При необходимости она может быть перемещена или удалена.
            this.getAllLotsTableAdapter.Fill(this.summerPracticeDataSet.GetAllLots);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "summerPracticeDataSet.GetAllUsers". При необходимости она может быть перемещена или удалена.
            this.getAllUsersTableAdapter.Fill(this.summerPracticeDataSet.GetAllUsers);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _lotLogic.AddUserLot(int.Parse(comboBox1.Text),int.Parse(comboBox2.Text));
            Hide();
        }
    }
}
