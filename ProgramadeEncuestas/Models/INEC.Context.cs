﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgramadeEncuestas.Models
{
    using ProgramadeEncuestas.Datos;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_INECEntities : DbContext
    {
        public DB_INECEntities()
            : base("name=DB_INECEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        internal IEnumerable<Encuesta> Consultar()
        {
            throw new NotImplementedException();
        }

        public virtual DbSet<DW_ENCUESTAS> DW_ENCUESTAS { get; set; }
        public virtual DbSet<V_WEB_PERSONAL_CAMPO> V_WEB_PERSONAL_CAMPO { get; set; }
    }
}
