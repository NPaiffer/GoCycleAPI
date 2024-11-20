using GoCycleAPI.Data;
using GoCycleAPI.Models;
using GoCycleAPI.Repositories.Interfaces;

namespace GoCycleAPI.Repositories.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context) { }

    }
}
