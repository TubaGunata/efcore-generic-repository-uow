using GenericRepositoryAndUoW.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericRepositoryAndUoW.DAL.Repositories.Abstract
{
    public interface IPersonelRepository:IRepository<Personel>
    {
        IQueryable<Personel> GetPersonelsWithDepartment();
    }
}
