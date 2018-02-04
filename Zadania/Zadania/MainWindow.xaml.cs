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
                    //1) Proba
            //Grid newOne = new Grid(); createGrid(gdZadanie, newOne);
            //Grid w = new Grid(); createGrid(gdZadanie, w);
            //ZbiorZadan.Children.Add(newOne);
            //ZbiorZadan.Children.Add(w);
                    
                    //2)Proba
            ///Stworz z tego metode i tworzy nowe Gridy pozniej dodawaj je do StackPanela
            //ColumnDefinition q = new ColumnDefinition(); q.Width = GridLength.Auto;
            //ColumnDefinition c = new ColumnDefinition(); c.Width = GridLength.Auto;
            //Grid k = new Grid(); k.ColumnDefinitions.Add(q); k.ColumnDefinitions.Add(c);

            //RowDefinition w = new RowDefinition(); w.Height = GridLength.Auto;
            //RowDefinition h = new RowDefinition(); h.Height = GridLength.Auto;
            //k.RowDefinitions.Add(w); k.RowDefinitions.Add(h);
            //TextBlock s = new TextBlock(); s.Text = "as";
            //k.Children.Add(s);
        }

        private void createGrid(Grid original,Grid clone,Zadanie element)
        {
            TextBlock t = new TextBlock(); t.Text = "";
            t.Text += element.ToString(); t.Foreground = new SolidColorBrush(Colors.Blue); t.FontSize = 18;
            clone.Children.Add(t);
        }
    }
}
