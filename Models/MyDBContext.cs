using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
            
        }
        public DbSet<People> Peoples;
        public DbSet<House> Houses;
        public class People
        {
            private int _Id;
            private string _Name;
            private ICollection<House> _Houses;

            public int Id { get => _Id; set => _Id = value; }
            public string Name { get => _Name; set => _Name = value; }
            public ICollection<House> Houses { get => _Houses; set => _Houses = value; }
        }
        public class House
        {
            private int _Id;
            private string _Address;
            private int _PeopleId;
            private People _People;

            public int Id { get => _Id; set => _Id = value; }
            public string Address { get => _Address; set => _Address = value; }
            public int PeopleId { get => _PeopleId; set => _PeopleId = value; }
            public People People { get => _People; set => _People = value; }
        }
    }
}
