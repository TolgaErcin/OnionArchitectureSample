using ANK_9.DAL.Abstract;
using ANK_9.DAL.Base.EntityFramework;
using ANK_9.DAL.Concrete.Context;
using ANK_9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.DAL.Concrete.Repositories
{
    public class MealRepository:EFRepositoryBase<Meal, ANK_9DiyetDbContext>, IMealDAL
    {
        public MealRepository(ANK_9DiyetDbContext options):base(options)
        {

        }
    }
}
