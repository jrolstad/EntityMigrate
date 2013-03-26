namespace EntityMigrate.EntityFramework.Migrations
{
    using System.Data.Entity.Migrations;

    public class EntityMigrationConfiguration : DbMigrationsConfiguration<EntityMigrateDatabaseContext>
    {
        public EntityMigrationConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityMigrateDatabaseContext context)
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
        }
    }
}
