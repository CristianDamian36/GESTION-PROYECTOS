using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GestiónDeProyectos.Areas.Users.Models;
using GestiónDeProyectos.Models;

namespace GestiónDeProyectos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Proyecto> Proyecto { get; set; }
        public DbSet<Tarea> Tarea { get; set; }
        public DbSet<Recurso> Recurso { get; set; }

        public DbSet<Rol> Rol { get; set; }

        public DbSet<TareaRecurso> TareaRecurso { get; set; }

    }
}
