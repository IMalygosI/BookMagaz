using Avalonia.Controls;
using BooksMagazin.Models;
using System.Collections.Generic;
using System.Linq;

namespace BooksMagazin
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Enterpr(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        { 
            var user = Helper.Base.Users.FirstOrDefault(o => o.Login == login.Text && o.Password == password.Text);

            if (user != null)
            {
                Glav_Okko glav_Okko = new Glav_Okko(user);
                glav_Okko.Show();
                Close();
            }
            else 
            {
                string Warning = "ÎØÈÁÊÀ! Íåâåðíûé ËÎÃÈÍ ÈËÈ ÏÀÐÎËÜ!";
                Error error = new Error(Warning);
                error.ShowDialog(this);
            }
        }
        private void Button_Click_Guest(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var user = Helper.Base.Users.FirstOrDefault(o => o.Login == login.Text && o.Password == password.Text);
            Glav_Okko glav_Okko = new Glav_Okko(user);
            glav_Okko.Show();
            Close();
        }
    }
}