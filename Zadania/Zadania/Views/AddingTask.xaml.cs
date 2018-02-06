﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Zadania.Models;

namespace Zadania.Views
{
    /// <summary>
    /// Interaction logic for AddingTask.xaml
    /// </summary>
    public partial class AddingTask : Window
    {
        OperacjeDb actionsOnDatabase;
        public AddingTask()
        {
            InitializeComponent();
            actionsOnDatabase = new OperacjeDb();
        }

        private void chBSwitch_Checked(object sender, RoutedEventArgs e)
        {
            if (((CheckBox)sender).IsChecked == true)
            {
                gdZero.Children.Remove(((CheckBox)sender));
                cldData.Visibility = Visibility.Visible;
            }
        }

        private void btnZapisz_Click(object sender, RoutedEventArgs e)
        {
            //Nie musze sprawdzac dropboxow czyli -Priortytet -Status,Kalendarza też nie trzeba -Calndar gdyż uwzględniłem nulleable,
            //Jedyne co trzeba zweryfikować to string z +opis + Temat
            if (Weryfikacja.Zweryfikuj(txtTemat.Text, txtOpis.Text))
            {
                Zadanie zadanie = new Zadanie(txtTemat.Text, cBPriorytet.SelectedValue.ToString(), Convert.ToString(cldData.SelectedDate.Value.ToShortDateString()), cBStatus.SelectedValue.ToString(), txtOpis.Text);
                actionsOnDatabase.update(zadanie);

                //This window
                this.Close();

                //Main Windows
                MainWindow.canRefresh = true;
                MainWindow.win.Show();
            }
            else
            {
                MessageBox.Show("Prosze wprowadzic dane!\nTemat lub opis są puste");
            }
        }
    }
}
