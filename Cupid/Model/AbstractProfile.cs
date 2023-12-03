using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Cupid.Model
{
    [BsonKnownTypes(typeof(Profile))]
    public abstract class AbstractProfile
    {
        [BsonId]
        internal abstract ObjectId _id { get; set; }
        public abstract string Auth0Id { internal get; set; }
        public abstract string ProfileId { get; set; }

        [StringLength(50, ErrorMessage = "Name length cannot be more than 50 characters long.")]
        public abstract string Name { get; set; }

        [DataType(DataType.DateTime)]
        public abstract DateTime LastActive { get; set; }
    }
}
