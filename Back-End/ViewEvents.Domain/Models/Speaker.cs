namespace ViewEvents.Domain.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string ImgURL { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public IEnumerable<SocialNetwork> SocialNetworks { get; set; }
        public IEnumerable<EventSpeaker> EventSpeakers { get; set; }
    }
}