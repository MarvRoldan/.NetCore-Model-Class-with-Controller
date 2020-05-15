using System;
using System.ComponentModel.DataAnnotations;

namespace FightingGames.Models
{
    public class FGDetails
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string SubGenre { get; set; }
        [Required]
        public string Difficulty { get; set; }
    }
}