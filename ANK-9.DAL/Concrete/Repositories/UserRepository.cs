using ANK_9.DAL.Abstract;
using ANK_9.DAL.Base.EntityFramework;
using ANK_9.DAL.Concrete.Context;
using ANK_9.Entities;

namespace ANK_9.DAL.Concrete.Repositories
{
    public class UserRepository : EFRepositoryBase<User, ANK_9DiyetDbContext>, IUserDAL
    {
        public UserRepository(ANK_9DiyetDbContext context) : base(context)
        {
        }
    }
}
