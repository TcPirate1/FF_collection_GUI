using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
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

    private void AddPageClearTextBoxes_Click(object sender, RoutedEventArgs e)
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
}