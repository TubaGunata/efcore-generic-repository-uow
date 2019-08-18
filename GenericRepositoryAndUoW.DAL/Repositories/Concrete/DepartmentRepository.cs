using GenericRepositoryAndUoW.DAL.Repositories.Abstract;
using GenericRepositoryAndUoW.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericRepositoryAndUoW.DAL.Repositories.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
        public IQueryable<Department> GetDepartmentWithPersonel()
        {
            return DatabaseContext.Departments.Include("Personel");
        }

        public IQueryable<Department> GetTopDepartment(int count)
        {
            return DatabaseContext.Departments.Take(count);
        }

        public DatabaseContext DatabaseContext { get { return dbContext as DatabaseContext; } }
    }
}
