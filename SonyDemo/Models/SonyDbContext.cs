using System.Data.Entity;

namespace SonyDemo.Models
{
    /// <summary>
    ///     Database context for Sony Demo project
    /// </summary>
    public class SonyDbContext : DbContext
    {
        /// <summary>
        ///     Specify name of connection string in web.config
        /// </summary>
        public SonyDbContext() : base("SonyDb") { }

        /// <summary>
        ///     Getter/setter for Games in db
        /// </summary>
        public DbSet<Game> Games { get; set; } 
    }
}