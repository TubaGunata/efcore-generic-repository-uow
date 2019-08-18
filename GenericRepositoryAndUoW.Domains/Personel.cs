using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepositoryAndUoW.Domains
{
    public class Personel:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
