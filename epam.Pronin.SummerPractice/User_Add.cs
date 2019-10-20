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
    public partial class User_add : Form
    {
        private IUserLogic userLogic = DependencyResolver.UserLogic;

        private void CheckRegistrate(TextBox a, TextBox b, TextBox c, User user)
        {
            if (String.IsNullOrEmpty(a.Text) || String.IsNullOrEmpty(b.Text) || String.IsNullOrEmpty(c.Text))
            {
                MessageBox.Show("Invalid values entered. Check the input, please");
            }
            else
            {
                userLogic.Registrate(user);
            }
        }


        public User_add()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            User user = new User(textBox1.Text, textBox2.Text, textBox3.Text);

            CheckRegistrate(textBox1, textBox2, textBox3, user);
            Hide();

        }
    }
}
