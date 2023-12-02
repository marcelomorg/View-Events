using System;
using Microsoft.EntityFrameworkCore;
using ViewEvents.Domain.Models;

namespace ViewEvents.Persistence.Contexts
{
	public class ViewEventContext: DbContext
	{
		public ViewEventContext(DbContextOptions<ViewEventContext> options) : base(options) {}

		public DbSet<Event> Events { get; set; }
	}
}
