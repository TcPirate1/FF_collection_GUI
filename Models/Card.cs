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
        public string? Code;

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
