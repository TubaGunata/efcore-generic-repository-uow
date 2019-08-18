using GenericRepositoryAndUoW.DAL.Repositories.Abstract;
using GenericRepositoryAndUoW.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GenericRepositoryAndUoW.DAL.Repositories.Concrete
{
    public class PersonelRepository : Repository<Personel>, IPersonelRepository
    {
        public PersonelRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
            Table = databaseContext.Personels;
        }

        public IQueryable<Personel> GetPersonelsWithDepartment()
        {
            return DatabaseContext.Personels.Include("Department");
        }
        public DatabaseContext DatabaseContext { get { return dbContext as DatabaseContext; } }
    }
}
