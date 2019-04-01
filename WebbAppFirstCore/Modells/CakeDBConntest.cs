using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppFirstCore.Modells
{
    public class CakeDBContext : DbContext
    {
        public CakeDBContext(DbContextOptions<CakeDBContext>option): base(option)
        { }
        public DbSet<cake> Caked { get; set; }

    }
}
