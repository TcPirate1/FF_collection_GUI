using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;
using AvaloniaGUI.Models;

namespace AvaloniaGUI;

public partial class AddPage : Window
{
    public AddPage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void AddPageClearTextBoxes_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        // Event handler for the clear button
        ClearTextBoxes(this);
    }

    private static void ClearTextBoxes(Visual parent)
    {
        foreach (var control in parent.GetVisualChildren())
        {
            if (control is TextBox textBox)
            {
                textBox.Text = ""; // Clear the text
            }
            else if (control is Visual nestedVisual)
            {
                // Recursively clear TextBoxes in nested controls
                ClearTextBoxes(nestedVisual);
            }
        }
    }

    private void AddCardButton_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        // Event handler for the add button
        var document = new Card
        {
            Code = CardCodeTxtBox.Text,
            Name = CardNameTxtBox.Text,
            Type = CardTypeTxtBox.Text,
            Elements = CardElementsTxtBox.Text.Split(","),
            Effect = CardEffectTxtBox.Text,
            SpecialIcons = CardSpecialIconsTxtBox.Text.Split(","),
            Cost = int.Parse(CardCostTxtBox.Text),
            Copies = int.Parse(CardCopiesTxtBox.Text),
            IsFoil = CardFoilCheckBox.IsChecked ?? false,
            FoilCopies = int.Parse(CardFoilCopiesTxtBox.Text)
        };
        var collection = App.Mongodbcontext?.Database.GetCollection<Card>("Cards");
        collection?.InsertOne(document);
    }
}