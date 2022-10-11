using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WebWallet.Entities
{
    public interface IBaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        ObjectId? Id { get; set; }

         DateTime UpdatedOn => DateTime.Now;
         DateTime CreatedOn => DateTime.Now;
        DateTime DeletedOn { get; set; }
        bool isDeleted { get; set; }
    }
}
