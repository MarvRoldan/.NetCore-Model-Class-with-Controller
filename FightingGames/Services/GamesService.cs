using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightingGame.Data;
using FightingGame.Models;
using Microsoft.EntityFrameworkCore;

namespace FightingGame.Services
{
    public class GamesService : IFGamesService
    {
        private readonly ApplicationDbContext _context;
        public GamesService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<FGDetails[]> GetIncompleteItemsAsync()
        {
            return await _context.Items
            .Where(x => x.IsDone == false)
            .ToArrayAsync();
        }
    }
}