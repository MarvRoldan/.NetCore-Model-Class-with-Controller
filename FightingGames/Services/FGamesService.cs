using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FightingGames.Models;

namespace FightingGames.Services
{
    public interface IFGamesService
    {
        Task<FGDetails[]> GetIncompleteItemsAsync();
    }
}