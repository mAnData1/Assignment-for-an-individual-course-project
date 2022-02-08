using Data.Entities;

namespace Data.Initializers
{
    public static class Seeder
    {
        public static void Seed(OvmDbContext context)
        {
            context.Teams.Add(new Team()
            {
                Name = "BDE Team"
            });

            context.Projects.Add(new Project()
            {
                Name = "BDE Project",
                Description = "Top of the top"
            });

            context.Users.Add(new User
            {
                FirstName = "Danail",
                LastName = "Iliev",
                Password = "danail",
                Username = "danail",
                Role = new Role("CEO"),
            });

            context.Users.Add(new User()
            {
                FirstName = "Danail Dev",
                LastName = "Iliev Dev",
                Username = "danaildev",
                Password = "danaildev",
                Role = new Role("Developer")
            });

            context.Users.Add(new User()
            {
                FirstName = "Danail TeamL",
                LastName = "Iliev TeamL",
                Username = "danailteaml",
                Password = "danailteaml",
                Role = new Role("Team Lead")
            });

            context.Roles.Add(new Role("Unassigned"));

            context.SaveChanges();
        }
    }
}
