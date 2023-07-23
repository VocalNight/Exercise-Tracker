using Exercise_Tracker.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker
{
    public class ExerciseTrackerContext : DbContext
    {
        // Declare the tables with DbSet
        DbSet<Pushup> Pushups { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            SqlConnectionStringBuilder builder = new();

            builder.DataSource = "(localdb)\\mssqllocaldb";
            builder.InitialCatalog = "ExerciseTracker";
            builder.IntegratedSecurity = true;
            builder.TrustServerCertificate = true;
            builder.MultipleActiveResultSets = true;
            builder.ConnectTimeout = 3;

            string? connection = builder.ConnectionString;

            optionsBuilder.UseSqlServer( connection );
        }
    }
}
