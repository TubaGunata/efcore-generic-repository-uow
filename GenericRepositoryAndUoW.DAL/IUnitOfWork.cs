using GenericRepositoryAndUoW.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepositoryAndUoW.DAL
{
    public interface IUnitOfWork:IDisposable
    {
        IDepartmentRepository DepartmentRepository { get;  }
        IPersonelRepository PersonelRepository { get; }
        int Complete();
    }
}
