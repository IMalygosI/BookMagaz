using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace BooksMagazin;

public partial class Error : Window
{
    public Error()
    {
        InitializeComponent();
    }

    public Error(string Warnings)
    {
        InitializeComponent();

        if (Warnings == "������! �������� ����� ��� ������!")
        {
            Warning.Text = Warnings;
        }
        if (Warnings == "")
        {
            Warning.Text = Warnings;
        }
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Close();
    }
}