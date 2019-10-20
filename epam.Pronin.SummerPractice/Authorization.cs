using System;
using System.Collections.Generic;
using epam.Pronin.SummerPractice.BLL.Interface;
using epam.Pronin.SummerPractice.Common;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace epam.Pronin.SummerPractice
{
    public partial class Authorization : Form
    {

        private IUserLogic userLogic = DependencyResolver.UserLogic;
        private int id;
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            User_add user_Add = new User_add();
            user_Add.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            id = userLogic.Authorizate(textBox1.Text, textBox2.Text);
            if(id>0)
            {
                MainForm form = new MainForm();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid login or password");
            }
        }
    }
}
