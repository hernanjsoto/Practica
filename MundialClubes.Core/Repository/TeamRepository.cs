using Microsoft.EntityFrameworkCore;
using MundialClubes.Core.Interfaces;
using MundialClubes.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundialClubes.Core.Repository
{
    public class TeamRepository : ITeamRepository
    {
        private readonly MCContext _context;

        public TeamRepository(MCContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Team>> GetTeams()
        {
            var teams = await _context.Teams.ToListAsync();
            return teams;
        }

        public async Task<Team> GetTeamById(int id)
        {
            var team = await _context.Teams.FirstOrDefaultAsync(x => x.Id == id);
            return team;
        }

        public async Task InsertTeam(Team team)
        {
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateTeam(Team team)
        {
            var currentTeam = await GetTeamById(team.Id);

            currentTeam.Description = team.Description;
            currentTeam.Country = team.Country;
            currentTeam.Titles = team.Titles;

            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }

        public async Task<bool> DeleteTeam(int id)
        {
            var team = await _context.Teams.FirstOrDefaultAsync(x => x.Id == id);
            _context.Teams.Remove(team);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }








    }
}
