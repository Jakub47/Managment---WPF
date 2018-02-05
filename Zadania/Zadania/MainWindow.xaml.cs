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
using Zadania.Views;

namespace Zadania
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Connect connect
        public MainWindow()
        {
            InitializeComponent();

            //string connectionString = "SERVER=localhost;DATABASE=zadania;UID=root;PASSWORD=;";
            //MySqlConnection connection = new MySqlConnection(connectionString); //Connect to our local database => Get Access
            connect = new Connect();

            MySqlCommand cmd = new MySqlCommand("select * from dane", connect.Connection);
            connect.Connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader()); //cmd.ExecuteReader() == This will execute the query. || dt.Load == Load all the result to variable
            connect.Connection.Close();

            //List<DataRow> list = dt.AsEnumerable().ToList();
            // For each row, print the values of each column.

            ListZZadaniami.ListZadan = new List<Zadanie>();
            foreach (DataRow row in dt.Rows)
            {
                Zadanie chwilowy = new Zadanie();
                foreach (DataColumn column in dt.Columns)
                {
                    if (column.ColumnName.Equals("Temat")) chwilowy.Temat = row[column].ToString();
                    if (column.ColumnName.Equals("Priorytet")) chwilowy.Priorytet = row[column].ToString();
                    if (column.ColumnName.Equals("Termin")) chwilowy.Termin = DateTime.Parse(row[column].ToString());
                    if (column.ColumnName.Equals("Status")) chwilowy.Status = row[column].ToString();
                }
                ListZZadaniami.ListZadan.Add(chwilowy);
            }

            for(int i = 0;i<ListZZadaniami.ListZadan.Count();i++)
            {
                Grid dodaj = new Grid();
                createGrid(gdZadanie, dodaj, ListZZadaniami.ListZadan.ElementAtOrDefault(i));
                ZbiorZadan.Children.Add(dodaj);
            }

        }

        private void createGrid(Grid original,Grid clone,Zadanie element)
        {
            TextBlock t = new TextBlock(); t.Text = "";
            t.Text += element.ToString(); t.Foreground = new SolidColorBrush(Colors.Blue); t.FontSize = 18;
            clone.Children.Add(t);
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            //Create a Logic for adding a new Task to the DataBase! Also remember about refreshing!!!!
            this.Hide();
            AddingTask aT = new AddingTask();  aT.Show();
        }
    }
}
