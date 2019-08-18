using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepositoryAndUoW.Domains
{
    public class BaseEntity
    {
        public DateTime? UpdateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
