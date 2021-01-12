using MundialClubes.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MundialClubes.Core.Interfaces
{
    public interface ITeamRepository
    {
        Task<bool> DeleteTeam(int id);
        Task<Team> GetTeamById(int id);
        Task<IEnumerable<Team>> GetTeams();
        Task InsertTeam(Team team);
        Task<bool> UpdateTeam(Team team);
    }
}