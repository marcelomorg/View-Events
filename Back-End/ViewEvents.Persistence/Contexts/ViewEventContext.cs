using Microsoft.EntityFrameworkCore;
using ViewEvents.Domain.Models;

namespace ViewEvents.Persistence.Contexts
{
    public class ViewEventContext: DbContext
	{
		public ViewEventContext(DbContextOptions<ViewEventContext> options) : base(options) {}

		public DbSet<Event> events { get; set; }
		public DbSet<Speaker> speakers { get; set; }
		public DbSet<SocialNetwork> socialnetworks { get; set; }
		public DbSet<Lot> lots { get; set; }
		public DbSet<EventSpeaker> eventspeakers { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
    	{
        	modelBuilder.Entity<EventSpeaker>().HasKey(ES => new { ES.EventId, ES.SpeakerId });

		// 	modelBuilder.Entity<Event>()
		// 		.HasMany(e => e.SocialNetworks)
		// 		.WithOne(sn => sn.Event)
		// 		.OnDelete(DeleteBehavior.Cascade);

		// 	modelBuilder.Entity<Speaker>()
		// 		.HasMany(s => s.SocialNetworks)
		// 		.WithOne(sn => sn.Speaker)
		// 		.OnDelete(DeleteBehavior.Cascade);
    	}
	}
}
