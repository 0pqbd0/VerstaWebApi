using System.Collections.Specialized;

namespace VerstaWeb.Contracts
{
    public record OrderResponse(
        Guid id,
        string SenderCity,
        string SenderAddress,
        string RecipientCity,
        string RecipientAddress,
        double Weight,
        DateTime PickUpDate);
}
