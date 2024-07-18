using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreExample
{
	public class StudentContext : DbContext
	{
        public StudentContext()
        {
            
        }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			//Database = desired name of the database
			//Server = The server we are connecting to. LocalDB is included in VS
			//Trusted_Connection - indicates that our windows account should be used
			options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
		}

		//Tell EF Core to track students in the database
		public DbSet<Student> Students { get; set; }
	}
}
