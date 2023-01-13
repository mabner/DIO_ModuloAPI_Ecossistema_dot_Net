using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ModuloAPI.Models;

namespace ModuloAPI.Context
{
	// AgendaContext is responsible for accessing the database
	public class AgendaContext : DbContext
	{
		// Receives the DB connection and send it to base (DbContext) 
		public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
		{

		}
		// Represents the Contato table through DbSet
		public DbSet<Contato> Contatos { get; set; }
	}
}