using ApplicationDomain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationDomain.Repositories
{
    public interface IIngredientRepository : IGenericRepository<Ingredient>
    {
        public Task<IEnumerable<Ingredient>> GetByName(string Name);
    }
}
