using HumanResources.DataAccess.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HumanResources.DataAccess.Repository
{
    /// <summary>
    /// Represent repository interface.
    /// </summary>
    /// <typeparam name="T">.</typeparam>
    public interface IRepository<T>
        where T : BaseModel
    {
        /// <summary>
        /// Get list entities.
        /// </summary>
        /// <returns>List TEntity.</returns>
        Task<IEnumerable<T>> GetAllAsync();
    }
}
