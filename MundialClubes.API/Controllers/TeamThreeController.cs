using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MundialClubes.Core.Interfaces;
using MundialClubes.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MundialClubes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamThreeController : ControllerBase
    {
        private readonly ITeamRepository _teamRepository;

        public TeamThreeController(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Teams() {

            var teams = await _teamRepository.GetTeams();
            return Ok(teams);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Teams(int id)
        {
            var team = await _teamRepository.GetTeamById(id);
            return Ok(team);
        }

        [HttpPost]
        public async Task<IActionResult> Teams(Team team)
        {
            await _teamRepository.InsertTeam(team);
            return Ok("");

        }




    }
}
