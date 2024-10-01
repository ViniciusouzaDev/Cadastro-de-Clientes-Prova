using Microsoft.EntityFrameworkCore;
using Clientes.Models;

namespace Clientes.Context
{
    public class Appcont : DbContext
    {
        public Appcont(DbContextOptions<Appcont> options) : base(options)
        {

        }

        public DbSet<CadastroCliente> Clientes { get; set; }
    }
}

