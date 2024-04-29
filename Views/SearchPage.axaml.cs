using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;

namespace AvaloniaGUI;

public partial class SearchPage : Window
{
    public SearchPage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void SearchPageClearTextBoxes_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        // Event handler for the button click
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
}