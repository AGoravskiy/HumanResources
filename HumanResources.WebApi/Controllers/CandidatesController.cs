using HumanResources.DataAccess.Model;
using HumanResources.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace HumanResources.WebApi.Controllers
{
    [RoutePrefix("api/candidates")]
    public class CandidatesController : ApiController
    {
        private readonly IRepository<Candidate> _candidateRepository;   

        public CandidatesController(IRepository<Candidate> candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetCandidatesAsync()
        {
            var candidates = await _candidateRepository.GetAllAsync();

            if (candidates == null)
            {
                return NotFound();
            }

            return Ok(candidates);
        }
    }
}