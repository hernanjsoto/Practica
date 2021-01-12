using Microsoft.AspNetCore.Mvc;
using MundialClubes.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MundialClubes.Web.Controllers
{
    public class TeamTwoController : Controller
    {
        private readonly ITeamRepository _teamRepository;

        public TeamTwoController(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }


        public async Task<IActionResult> Index()
        {
            ViewBag.Listado = await _teamRepository.GetTeams();
            return View();
        }
    }
}
