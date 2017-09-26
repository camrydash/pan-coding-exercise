namespace PANCodingExercise.Data.Migrations
{
    using PANCodingExercise.Data.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PANCodingExercise.Data.ItemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PANCodingExercise.Data.ItemDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Set<Item>().AddOrUpdate(new Item()
            {
                Id = 1,
                Name = "Item one",
                Description = "Description of item one",
                CreatedOn = DateTime.Now,
                DisplayName = "Item one"
            }, new Item()
            {
                Id = 2,
                Name = "Item two",
                Description = "Description of item two",
                CreatedOn = DateTime.Now,
                DisplayName = "Item two"
            });
        }
    }
}
