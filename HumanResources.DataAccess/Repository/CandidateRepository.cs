using HumanResources.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.DataAccess.Repository
{
    public class CandidateRepository : IRepository<Candidate>
    {
        private ApplicationDbContext context;

        public CandidateRepository()
        {
            context = new ApplicationDbContext();
        }
        public async Task<IEnumerable<Candidate>> GetAllAsync()
        {
            return await context.Candidates.ToListAsync();
        }
    }
}
