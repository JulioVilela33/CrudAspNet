using Crud.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTeste.Models.Services
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }


        public DbSet<Cliente> Clientes { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
