using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zadania.Models;

namespace Zadania
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<Zadanie> zd = new List<Zadanie>();

        public MainWindow()
        {
            InitializeComponent();
            string connectionString = "SERVER=localhost;DATABASE=zadania;UID=root;PASSWORD=;";

            MySqlConnection connection = new MySqlConnection(connectionString); //Connect to our local database => Get Access

            MySqlCommand cmd = new MySqlCommand("select * from dane", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader()); //cmd.ExecuteReader() == This will execute the query. || dt.Load == Load all the result to variable
            connection.Close();

            //List<DataRow> list = dt.AsEnumerable().ToList();
            // For each row, print the values of each column.
            object[] take = new object[4]; int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    if (column.ColumnName.Equals("Temat")) txtTemat.Text = row[column].ToString();
                    if (column.ColumnName.Equals("Priorytet")) txtPriorytet.Text = row[column].ToString();
                    if (column.ColumnName.Equals("Termin")) txtData.Text = row[column].ToString();
                    if (column.ColumnName.Equals("Status")) txtStatus.Text = row[column].ToString();
                }
                i = i + 1;
                Grid another = gdZadanie;
                another.Name = "gdZadanie" + i;
                Zbior.Children.Add(another);
            }
        }
    }
}
