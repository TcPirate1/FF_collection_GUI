using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using ReactiveUI;
using System;
using System.Text.RegularExpressions;
using AvaloniaGUI.Utils;

namespace AvaloniaGUI.Models
{
    public class Card : ReactiveObject
    {
        private string _validationErrorMsg;
        public string ValidationErrorMsg
        {
            get => _validationErrorMsg;
            set => this.RaiseAndSetIfChanged(ref _validationErrorMsg, value);
        }
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Card_code")]
        private string? _code;
        public string? Code
        {
            get => _code;
            set
            {
                Validation.EmptyTextFields(value);
                Validation.ValidateCode(value);
                this.RaiseAndSetIfChanged(ref _code, value);
            }
        }

        [BsonElement("Card_name")]
        private string? _name;
        public string? Name
        {
            get => _name;
            set
            {
                Validation.EmptyTextFields(value);
                Validation.ValidateName(value);
                this.RaiseAndSetIfChanged(ref _name, value);
            }
        }

        [BsonElement("Type")]
        private string? _type;
        public string? Type
        {
            get => _type;
            set
            {
                Validation.EmptyTextFields(value);
                Validation.ValidateType(value);
                this.RaiseAndSetIfChanged(ref _type, value);
            }
        }

        [BsonElement("Elements")]
        public string[]? Elements { get; set; }
        
        [BsonElement("Effect")]
        public string? Effect { get; set; }

        [BsonElement("Special_icons")]
        public string[]? SpecialIcons { get; set; }

        [BsonElement("Cost")]
        private int? _cost;
        public int? Cost
        {
            get => _cost;
            set
            {
                Validation.ValidateCost(value.Value);
                this.RaiseAndSetIfChanged(ref _cost, value);
            }
        }

        [BsonElement("Copies")]
        private int? _copies;
        public int? Copies
        {
            get => _copies;
            set
            {
                Validation.ValidateCopies(value.Value);
                this.RaiseAndSetIfChanged(ref _copies, value);
            }
        }

        [BsonElement("Foil?")]
        public bool? IsFoil { get; set; }

        [BsonElement("Foil_copies")]
        public int? FoilCopies { get; set; }
    }
}
