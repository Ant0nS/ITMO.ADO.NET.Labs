using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
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
        //static string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DataBasePractice;Data Source=LAPTOP\SQLEXPRESS";
        OleDbConnection connection = new OleDbConnection();
        ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;



        public Form1()
        {
            InitializeComponent();
            OleDbConnection connection = new OleDbConnection(testConnect);

        }

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }

        string testConnect = GetConnectionStringByName("DBConnect.DataBasePracticeConnectionString");
        private void dBConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }

        }

        private void dBDisconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }
        private void connection_StateChange(object sender, StateChangeEventArgs e)
        {
            dBConnectToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            dBDisconnectToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Open);
        }

        private void listConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    MessageBox.Show("name = " + cs.Name);
                    MessageBox.Show("providerName = " + cs.ProviderName);
                    MessageBox.Show("connectionString = " + cs.ConnectionString);
                }
            }

        }
    }
}
