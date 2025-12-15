using System;
using Microsoft.Maui.Controls;

namespace MotywatorCodzienny;

public partial class MainPage : ContentPage
{
    private int licznik = 0;

    private readonly string[] motywacje =
    {
        "Każdy dzień to okazja, aby zrobić krok do przodu.",
        "Konsekwencja jest ważniejsza niż motywacja.",
        "Działanie buduje pewność siebie.",
        "Nie musisz być idealny, wystarczy że będziesz wytrwały.",
        "Postęp jest ważniejszy niż perfekcja.",
        "Dyscyplina tworzy wolność.",
        "Twoje cele są warte wysiłku."
    };

    private readonly Random random = new Random();

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnMotivateClicked(object sender, EventArgs e)
    {
        licznik++;

        if (licznik % 10 == 0)
        {
            MotivationLabel.Text = "Wykazujesz się dużą konsekwencją. Tak buduje się nawyki.";
        }
        else
        {
            int index = random.Next(motywacje.Length);
            MotivationLabel.Text = motywacje[index];
        }

        CounterLabel.Text = $"Ilość otrzymanych motywacji: {licznik}";
    }
}
