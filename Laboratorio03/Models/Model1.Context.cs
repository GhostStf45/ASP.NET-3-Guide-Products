﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laboratorio03.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Negocios2017Entities2 : DbContext
    {
        public Negocios2017Entities2()
            : base("name=Negocios2017Entities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_categorias> tb_categorias { get; set; }
        public virtual DbSet<tb_clientes> tb_clientes { get; set; }
        public virtual DbSet<tb_empleados> tb_empleados { get; set; }
        public virtual DbSet<tb_paises> tb_paises { get; set; }
        public virtual DbSet<tb_pedidoscabe> tb_pedidoscabe { get; set; }
        public virtual DbSet<tb_productos> tb_productos { get; set; }
        public virtual DbSet<tb_proveedores> tb_proveedores { get; set; }
        public virtual DbSet<tb_pedidosdeta> tb_pedidosdeta { get; set; }
    }
}
