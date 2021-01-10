using Microsoft.EntityFrameworkCore;
using netcore_mvc_example.Models;

namespace netcore_mvc_example.Context
{
    public class AppDbContext : DbContext
    {

        //Contructor: Se ùede indicar la configuracion de la base de datos de dos maneras:
        /**
         * 1 -  Inyectando la configuracion mediante un servicio en Startup.
         * 2 - Sobrescribiendo un metodo llamad onConfiguring. Mirar documentacion
         */
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        /**
         *Representacion de las tablas: Importamos los modelos
         *Se llaman igual que en la base de datos
         */
        public DbSet<Category> Category { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}
