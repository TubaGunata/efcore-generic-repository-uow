using System;
using System.Collections.Generic;
using System.Text;
using GenericRepositoryAndUoW.DAL.Repositories.Abstract;
using GenericRepositoryAndUoW.DAL.Repositories.Concrete;

namespace GenericRepositoryAndUoW.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext _databaseContext;
        public UnitOfWork(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            DepartmentRepository = new DepartmentRepository(_databaseContext);
            PersonelRepository = new PersonelRepository(_databaseContext);
        }
        public IDepartmentRepository DepartmentRepository { get; private set; }

        public IPersonelRepository PersonelRepository { get; private set; }

        public int Complete()
        {
            return _databaseContext.SaveChanges();
        }

        public void Dispose()
        {
            _databaseContext.Dispose();
        }
    }
}
