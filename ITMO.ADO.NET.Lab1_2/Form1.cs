using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Lab1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void dBConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string testConnect = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DataBasePractice1111;Data Source=.";
            using (OleDbConnection connection = new OleDbConnection())
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных выполнено успешно");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dBDisconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DataBasePractice;Data Source=LAPTOP\SQLEXPRESS";
            OleDbConnection connection = new OleDbConnection(testConnect);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }
    }
}
