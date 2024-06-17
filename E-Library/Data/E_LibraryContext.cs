using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using E_Library.Models;

namespace E_Library.Data
{
	public class E_LibraryContext : DbContext
	{
		public E_LibraryContext(DbContextOptions<E_LibraryContext> options)
			: base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Students;Integrated Security=SSPI;");
		}

		public DbSet<Book> Books { get; set; }
		public DbSet<Instructor> Instructors { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<StudentBorrowBooks> StudentBorrowBooks { get; set; }
	}
}
