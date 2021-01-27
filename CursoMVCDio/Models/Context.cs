﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVCDio.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString:@"Server=(localdb)\mssqllocaldb;Database=Cursomvcdio;Integrated Security=True");
        }
    }
}
