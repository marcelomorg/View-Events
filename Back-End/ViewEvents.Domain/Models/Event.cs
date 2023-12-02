namespace ViewEvents.Domain.Models
{
	public class Event
	{
		public int Id { get; set; }
		public string Local { get; set; }
		public string EventDate { get; set; }
		public string Theme { get; set; }
		public int PeopleAmount { get; set; }
		public string ImgUrl { get; set; }
		public Speaker Speaker { get; set; }
		public IEnumerable<SocialNetwork> SocialNetworks { get; set; }
		public IEnumerable<Lot> Lots { get; set; }
		public IEnumerable<EventSpeaker> EventSpeakers { get; set; } 
	}
}
