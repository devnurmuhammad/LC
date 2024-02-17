using Organizational.Domain.Entities;

namespace Organizational.Application.Interfaces.Repositories
{
    public interface IOutcomeRepository
    {
        public Task<bool> CreateOutcome(Outcome outcome);
        public Task<IList<Outcome>> GetAllOutcomes();
        public Task<bool> UpdateOutcome(int id);
        public Task<Outcome> GetOutcomeById(int id);
        public Task<long> GetOutcomeCount();
    }
}
