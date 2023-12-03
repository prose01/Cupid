using Cupid.Interfaces;
using Cupid.Model;
using MongoDB.Driver;

namespace Cupid.Data
{
    public class ProfilesQueryRepository : IProfilesQueryRepository
    {
        private readonly Context _context = null;

        public ProfilesQueryRepository()
        {
            _context = new Context();
        }


        private ProjectionDefinition<Profile> GetProjection()
        {
            ProjectionDefinition<Profile> projection = "{ " +
                "_id: 0, " +
                "Admin: 0, " +
                "Name: 0, " +
                "CreatedOn: 0, " +
                "UpdatedOn: 0, " +
                "LastActive: 0, " +
                "Countrycode: 0, " +
                "Age: 0, " +
                "Height: 0, " +
                "Contactable: 0, " +
                "Description: 0, " +
                "Images: 0, " +
                "Tags: 0, " +
                "Body: 0, " +
                "SmokingHabits: 0, " +
                "HasChildren: 0, " +
                "WantChildren: 0, " +
                "HasPets: 0, " +
                "LivesIn: 0, " +
                "Education: 0, " +
                "EducationStatus: 0, " +
                "EmploymentStatus: 0, " +
                "SportsActivity: 0, " +
                "EatingHabits: 0, " +
                "ClotheStyle: 0, " +
                "BodyArt: 0, " +
                "Gender: 0, " +
                "Seeking: 0, " +
                "Bookmarks: 0, " +
                "ChatMemberslist: 0, " +
                "ProfileFilter: 0, " +
                "IsBookmarked: 0, " +
                "Languagecode: 0, " +
                "Visited: 0, " +
                "Likes: 0, " +
                "Groups: 0, " +
                "}";

            return projection;
        }
    }
}
