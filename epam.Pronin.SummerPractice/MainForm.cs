using System;
using epam.Pronin.SummerPractice.BLL.Interface;
using epam.Pronin.SummerPractice.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace epam.Pronin.SummerPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "summerPracticeDataSet.GetAllLotsAndUsers". При необходимости она может быть перемещена или удалена.
            this.getAllLotsAndUsersTableAdapter.Fill(this.summerPracticeDataSet.GetAllLotsAndUsers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "summerPracticeDataSet.GetAllLots". При необходимости она может быть перемещена или удалена.
            this.getAllLotsTableAdapter.Fill(this.summerPracticeDataSet.GetAllLots);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Add_Lot add_Lot = new Add_Lot();
            add_Lot.Show();
            Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Delete_Lot delete_Lot = new Delete_Lot();
            delete_Lot.Show();
            Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           this.getAllLotsTableAdapter.Fill(this.summerPracticeDataSet.GetAllLots);
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            this.getAllLotsAndUsersTableAdapter.Fill(this.summerPracticeDataSet.GetAllLotsAndUsers);
        }
    }
}
