namespace ViewEvents.Domain.Models
{
    public class Lot
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int Amount { get; set; }
        public int EventId { get; set; }
    }
}