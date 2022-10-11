using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WebWallet.Entities
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId? Id { get; set; }

        public DateTime UpdatedOn { get; set; } = DateTime.Now;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime DeletedOn { get; set; } 
        public bool isDeleted { get; set; }

    }
}
