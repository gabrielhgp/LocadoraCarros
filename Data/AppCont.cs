using Microsoft.EntityFrameworkCore;
using LocadoraCarros.Models;

namespace LocadoraCarros.Data
{
    public class AppCont: DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) :base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Carro> Carro { get; set; }



    }
}
