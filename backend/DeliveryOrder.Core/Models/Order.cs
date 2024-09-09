namespace DeliveryOrder.Core.Models
{
    public class Order
    {
        private Order (Guid id, string senderCity, string senderAddress, 
            string recipientCity, string recipientAddress, double weight, DateTime pickUpDate)
        {
            Id = id;
            SenderCity = senderCity;
            SenderAddress = senderAddress;
            RecipientCity = recipientCity;
            RecipientAddress = recipientAddress;
            Weight = weight;
            PickUpDate = pickUpDate;
        }

        public Guid Id { get; }
        public string SenderCity { get; }
        public string SenderAddress { get; }
        public string RecipientCity { get; }
        public string RecipientAddress { get; }
        public double Weight { get; }
        public DateTime PickUpDate { get; }

        public static Order Create(Guid id, string senderCity, string senderAddress,
            string recipientCity, string recipientAddress, double weight, DateTime pickUpDate)
        {
            var order = new Order(id, senderCity, senderAddress, recipientCity, recipientAddress, weight, pickUpDate);
            return order;
        }
    }
}
