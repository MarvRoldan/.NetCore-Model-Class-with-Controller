using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FightingGames.Models;

namespace FightingGames.Services
{
    public class ExampleService : FGamesService
    {
        public Task<FGDetails[]> GetIncompleteItemsAsync()
        {
            var item1 = new FGDetails
            {
                Title = "Street Fighter III Third Strike",
                SubGenre = "2D",
                Difficulty = "Hard"
            };
            var item2 = new FGDetails
            {
                Title = "Granblue Fantasy Versus",
                SubGenre = "Anime 2D",
                Difficulty = "Easy"
            };
            return Task.FromResult(new[] { item1, item2 });
        }
    }
}