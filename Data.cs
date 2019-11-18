using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace Sistema_Academico.DAL.DataModels
{
  public  class Data : DbContext
    {
        public DbSet<Ciclo> Ciclos { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Notas> Notass { get; set; }
        public DbSet<Years> Yearss { get; set; }
        public DbSet<Valores> Valoress { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciclo>().ToTable("Ciclo");
            modelBuilder.Entity<Grado>().ToTable("Grado");
            modelBuilder.Entity<Materia>().ToTable("Materia");
            modelBuilder.Entity<Matricula>().ToTable("Matricula");
            modelBuilder.Entity<Notas>().ToTable("Notas");
            modelBuilder.Entity<Years>().ToTable("Years");
            modelBuilder.Entity<Valores>().ToTable("Valores");


            base.OnModelCreating(modelBuilder);
        }
    }
}
