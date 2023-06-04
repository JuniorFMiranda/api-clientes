using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiClientes.Models;
 
namespace ApiClientes.Context
{
    public class ClienteDbContext : DbContext
    {
        public ClienteDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}