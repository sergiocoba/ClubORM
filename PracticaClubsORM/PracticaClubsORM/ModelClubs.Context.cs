﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticaClubsORM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ClubEntities : DbContext
    {
        public ClubEntities()
            : base("name=ClubEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Clubs> Clubs { get; set; }
        public virtual DbSet<Contacto> Contacto { get; set; }
        public virtual DbSet<Continentes> Continentes { get; set; }
        public virtual DbSet<Galeria> Galeria { get; set; }
        public virtual DbSet<MediaVisual> MediaVisual { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Ubicacion> Ubicacion { get; set; }
    }
}