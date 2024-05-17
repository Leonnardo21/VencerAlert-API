using VencerAlert.Domain.Enums;

namespace VencerAlert.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Presentation { get; set; } = string.Empty;
        public string CodeBar { get; set; } = string.Empty;
        public string Lot { get; set; } = string.Empty;
        public DateTime FabricationDate { get; set; } 
        public DateTime ExpirationDate { get; set; } 
        public Status StatusProduct { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
}
