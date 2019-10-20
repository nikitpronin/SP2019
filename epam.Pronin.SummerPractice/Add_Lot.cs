using System;
using epam.Pronin.SummerPractice.BLL.Interface;
using epam.Pronin.SummerPractice.Common;
using epam.Pronin.SummerPractice.Entities;
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
    public partial class Add_Lot : Form
    {
        private int id1;
        private ILotLogic lotLogic = DependencyResolver.LotLogic;

        public Add_Lot()
        {
            InitializeComponent();
        }

        private void CheckAdd(TextBox a, Lot lot)
        {
            if (String.IsNullOrEmpty(a.Text))
            {
                MessageBox.Show("Invalid values entered. Check the input, please");
            }
            else
            {
                lotLogic.Add(lot);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Lot lot = new Lot(textBox1.Text);
            CheckAdd(textBox1,lot);

            Close();
        }
    }
}
