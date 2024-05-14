using DynamicData;
using System;
using System.Text.RegularExpressions;

namespace AvaloniaGUI;

public class Validation
{
    private static readonly string codeRegex = @"^\d{1,2}-\d{3}[CRHLS]+$";
    private static readonly string promoRegex = @"^PR-\d{3}";

    public static void EmptyTextFields(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException(nameof(value), "This field cannot be empty");
        }
    }
    public static void ValidateCode(string code)
    {
        if (!Regex.IsMatch(code, codeRegex) || (!Regex.IsMatch(code, promoRegex)))
        {
            throw new ArgumentException("Invalid code format");
        }
    }
    public static void ValidateName(string name)
    {
        if (Regex.IsMatch(name, codeRegex) || (Regex.IsMatch(name, promoRegex)))
        {
            throw new ArgumentNullException(nameof(name), "This field cannot be empty");
        }
    }
}
