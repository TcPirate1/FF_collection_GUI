using Amazon.Auth.AccessControlPolicy;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;
using AvaloniaGUI.Models;
using Tmds.DBus.Protocol;

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
  //      System.NullReferenceException
  //      HResult = 0x80004003
  //Message = Object reference not set to an instance of an object.
  //Source = AvaloniaGUI
  //StackTrace:
  //      at AvaloniaGUI.AddPage.AddCardButton_Click(Object sender, RoutedEventArgs e) in C: \Users\TC\source\repos\TcPirate1\FF_collection_GUI\Views\AddPage.axaml.cs:line 46

        var collection = App.Mongodbcontext?.Database.GetCollection<Card>("cards");
        collection?.InsertOne(document);
    }
}