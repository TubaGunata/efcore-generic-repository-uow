using GenericRepositoryAndUoW.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepositoryAndUoW.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Personel> Personels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=GenericRepoAndUoW_DB;Trusted_Connection=True;");
        }
    }
}
