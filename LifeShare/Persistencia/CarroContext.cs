using LifeShare.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeShare.Persistencia
{
    public class CarroContext : DbContext
    {
        public DbSet<Carro> Carros { get; set; }

        public CarroContext(DbContextOptions options) : base(options)
        {

        }
    }
}
