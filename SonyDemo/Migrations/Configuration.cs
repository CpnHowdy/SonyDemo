namespace MovieDemo.Migrations
{
    using MovieDemo.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MovieDemo.Models.MovieDbContext";
        }

        /// <summary>
        ///     Adds/updates data in the db upon running migrations.
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(MovieDbContext context)
        {
            // Games
            context.Movies.AddOrUpdate(new Movie { ImdbId = "tt3896198" });
        }
    }
}
