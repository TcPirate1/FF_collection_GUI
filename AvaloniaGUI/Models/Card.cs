using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AvaloniaGUI.Models
{
    public class Card
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Card_name")]
        public string Name { get; private set; }

        [BsonElement("Type")]
        public string Type { get; private set; }

        [BsonElement("Cost")]
        public int Cost { get; private set; }

        [BsonElement("Special_icons")]
        public string[] SpecialIcons { get; private set; }

        [BsonElement("Elements")]
        public string[] Elements { get; private set; }

        [BsonElement("Card_code")]
        public string Code { get; private set; }

        [BsonElement("Copies")]
        public int Copies { get; private set; }

        [BsonElement("Foil?")]
        public bool IsFoil { get; private set; }

        [BsonElement("Foil_copies")]
        public int FoilCopies { get; private set; }
    }
}
