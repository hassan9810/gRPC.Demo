using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gRPC.Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace gRPC.Demo.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        public DbSet<Item> Items => Set<Item>();
    }
}