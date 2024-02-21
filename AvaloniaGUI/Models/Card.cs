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
    }
}
