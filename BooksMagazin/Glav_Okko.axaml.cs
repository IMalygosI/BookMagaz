using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using BooksMagazin.Models;
using System.Collections.Generic;

namespace BooksMagazin;

public partial class Glav_Okko : Window
{
    List<Tovar> tovars = new List<Tovar>();
    public Glav_Okko()
    {
        InitializeComponent();
        Loaded();
    }
    public void Loaded()
    {
        tovars = Helper.
    }
}