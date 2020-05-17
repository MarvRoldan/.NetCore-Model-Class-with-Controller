using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FightingGames.Controllers
{
    public class FGController : Controller
    {
        private readonly IFGamesService _fGamesService;

        public FGController(IFGamesService fGamesService)
        {
            _fGamesService = fGamesService;
        }

        public IActionResult Index()
        {
            var model = new FGViewModel()
            {
                FightingGames = fightinggames
            };

            return View(model);        
        }
    }
}