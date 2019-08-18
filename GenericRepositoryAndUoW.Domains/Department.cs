using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepositoryAndUoW.Domains
{
    public class Department :BaseEntity
    {
        public Department()
        {
            Personels = new List<Personel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Personel> Personels { get; set; }
    }
}
