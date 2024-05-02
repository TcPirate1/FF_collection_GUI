using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using ReactiveUI;
using System;
using System.Text.RegularExpressions;

namespace AvaloniaGUI.Models
{
    public class Card : ReactiveObject
    {
        private readonly string codeRegex = @"^\d{1,2}-\d{3}[CRHLS]+$";
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Card_code")]
        private string? _Code;
        public string Code
        {
            get
            {
                return _Code;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.RaiseAndSetIfChanged(ref _Code, value);
                }
                else if (!Regex.IsMatch(value, codeRegex))
                {
                    throw new FormatException("Invalid card code format");
                }
                else
                {
                    throw new ArgumentNullException(nameof(Code), "Card code cannot be empty");
                }
            }
        }

        [BsonElement("Card_name")]
        public string Name { get; set; }

        [BsonElement("Type")]
        public string Type { get; set; }

        [BsonElement("Elements")]
        public string[] Elements { get; set; }
        
        [BsonElement("Effect")]
        public string Effect { get; set; }

        [BsonElement("Special_icons")]
        public string[] SpecialIcons { get; set; }

        [BsonElement("Cost")]
        public int Cost { get; set; }

        [BsonElement("Copies")]
        public int Copies { get; set; }

        [BsonElement("Foil?")]
        public bool IsFoil { get; set; }

        [BsonElement("Foil_copies")]
        public int FoilCopies { get; set; }
    }
}
