using System;

namespace SonyDemo.Models
{
    /// <summary>
    ///     Model for users
    /// </summary>
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public DateTime? ReleaseDate { get; set; } 
    }
}