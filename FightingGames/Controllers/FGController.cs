using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FightingGames.Services;
using FightingGames.Models;

namespace FightingGames.Controllers
{
    public class FGController : Controller
    {
        private readonly IFGamesService _fGamesService;

        public FGController(IFGamesService fGamesService)
        {
            _fGamesService = fGamesService;
        }

        public async Task<IActionResult> Index()
        {
            var item = await _fGamesService.GetIncompleteItemsAsync();

            var model = new FGViewModel()
            {
                FightingGames = item
            };

            return View(model);        
        }
    }
}