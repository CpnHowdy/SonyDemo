namespace SonyDemo.Migrations
{
    using SonyDemo.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SonyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SonyDemo.Models.SonyDbContext";
        }

        /// <summary>
        ///     Adds/updates data in the db upon running migrations.
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(SonyDbContext context)
        {
            // Games
            context.Games.AddOrUpdate(new Game { Name = "The Witcher 3" });
        }
    }
}
