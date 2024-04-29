using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace AvaloniaGUI.Models
{
    public class Card
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Card_name")]
        public string Name { get; set; }

        [BsonElement("Type")]
        public string Type { get; set; }

        [BsonElement("Cost")]
        public int Cost { get; set; }
        [BsonElement("Effect")]
        public string Effect { get; set; }

        [BsonElement("Special_icons")]
        public string[] SpecialIcons { get; set; }

        [BsonElement("Elements")]
        public string[] Elements { get; set; }

        [BsonElement("Card_code")]
        public string Code { get; set; }

        [BsonElement("Copies")]
        public int Copies { get; set; }

        [BsonElement("Foil?")]
        public bool IsFoil { get; set; }

        [BsonElement("Foil_copies")]
        public int FoilCopies { get; set; }
    }
}
