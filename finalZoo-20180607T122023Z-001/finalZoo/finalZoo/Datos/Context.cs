using System;
using finalZoo.Animales;
using finalZoo.Enfermeria;

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace finalZoo.Datos
{
    public class Context : DbContext
    {
        public Context()
            : base("name=finalZoo")
        {
            Database.SetInitializer(new Inicializador());
        }

        public DbSet<Nombre> Nombre { get; set; }
        public DbSet<Clasificacion> clasificacion1 { get; set; }
        //public DbSet<EnviarEnfermeria> EnviarEnfermeria1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clasificacion>()
                .HasMany(p => p.nombresito)
                .WithRequired(p => p.clasificacion1)
                .HasForeignKey(p => p.IdClasificación)
                .WillCascadeOnDelete(false);

            /*modelBuilder.Entity<EstadoCivil>()
                .HasMany(p => p.Pacientes)
                .WithRequired(p => p.EstadoCivil)
                .HasForeignKey(p => p.IdEstadoCivil)
                .WillCascadeOnDelete(false);*/

        }
    }
}
