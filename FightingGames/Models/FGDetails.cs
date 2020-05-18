using System;
using System.ComponentModel.DataAnnotations;

namespace FightingGames.Models
{
    public class FGDetails
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string SubGenre { get; set; }

        public string Difficulty { get; set; }
    }
}