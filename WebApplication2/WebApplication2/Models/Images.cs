using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Images
    {
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonElement("id")]
        public int id { get; set; }
        [BsonElement("image")]
        public byte[] image { get; set; }
    }
}
