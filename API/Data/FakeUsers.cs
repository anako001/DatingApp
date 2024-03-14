using API.Entities;
using Bogus;

namespace API.Data
{
    public class FakeUsers
    {
        public List<AppUser> GetAppUsers()
        {
            var userId = 1;
            var userName = string.Empty;
            var userFaker = new Faker<AppUser>()
            .RuleFor(u => u.Id, _ => userId++)
            .RuleFor(u => u.UserName, f => f.Internet.UserName());

            var users = userFaker.Generate(100);
            return users;
        }
    }
}
