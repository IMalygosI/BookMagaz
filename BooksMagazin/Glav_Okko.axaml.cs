using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using BooksMagazin.Models;
using System.Collections.Generic;
using System.Linq;

namespace BooksMagazin;

public partial class Glav_Okko : Window
{
    User Users;
    List<Tovar> tovars = new List<Tovar>();
    public Glav_Okko()
    {
        InitializeComponent();
        Users = new User();
        Loaded();
    }
    public Glav_Okko(User user)
    {
        InitializeComponent();
        Users = user;

        if (Users != null)
        {
            LoginName.Text = Users.RoleName;
            Names.Text = Users.FioNamOt;
        }
        else 
        {
            LoginName.Text = "Гость";
            Names.Text = "Гость";
        }


        Loaded();
    }
    public void Loaded()
    {
        tovars = Helper.Base.Tovars.ToList();


    }

    private void Button_Click_LogOut(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }
}