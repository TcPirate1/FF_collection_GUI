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
            Name = CardNameTxtBox.Text,
            Type = CardTypeTxtBox.Text,
            Cost = int.Parse(CardCostTxtBox.Text),
            Effect = CardEffectTxtBox.Text,
            SpecialIcons = CardSpecialIconsTxtBox.Text.Split(","),
            Elements = CardElementsTxtBox.Text.Split(","),
            Code = CardCodeTxtBox.Text,
            Copies = int.Parse(CardCopiesTxtBox.Text),
            IsFoil = CardFoilCheckBox.IsChecked ?? false,
            FoilCopies = int.Parse(CardFoilCopiesTxtBox.Text)
        };
    }
}