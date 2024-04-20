using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;


namespace SinemaRezervasyon
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<Seans> Seanslar { get; set; }

        public ApplicationContext() : base("name=database.db")
        {
        }
    }
}