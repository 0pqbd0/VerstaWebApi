namespace DeliveryOrder.DataAccess.Entyties
{
    public class OrderEntity
    {
        public Guid Id { get; set; }
        public string SenderCity { get; set; }
        public string SenderAddress { get; set; }
        public string RecipientCity { get; set; }
        public string RecipientAddress { get; set; }
        public double Weight { get; set; }
        public DateTime PickUpDate { get; set; }
    }
}
