using System.Data.Entity;

namespace MovieDemo.Models
{
    /// <summary>
    ///     Database context for Movie Demo project
    /// </summary>
    public class MovieDbContext : DbContext
    {
        /// <summary>
        ///     Specify name of connection string in web.config
        /// </summary>
        public MovieDbContext() : base("MovieDb") { }

        /// <summary>
        ///     Getter/setter for Movies in db
        /// </summary>
        public DbSet<Movie> Movies { get; set; } 
    }
}