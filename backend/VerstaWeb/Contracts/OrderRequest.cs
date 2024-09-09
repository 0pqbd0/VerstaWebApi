namespace VerstaWeb.Contracts
{
    public record OrderRequest(
      string SenderCity,
      string SenderAddress,
      string RecipientCity,
      string RecipientAddress,
      double Weight,
      DateTime PickUpDate);
}
