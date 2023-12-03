using MongoDB.Bson;

namespace Cupid.Model
{
    public class Profile : AbstractProfile
    {

        internal override ObjectId _id { get; set; }
        public override string Auth0Id { internal get; set; }
        public override string ProfileId { get; set; }
        public override string Name { get; set; }
        public override DateTime LastActive { get; set; }
    }
}
