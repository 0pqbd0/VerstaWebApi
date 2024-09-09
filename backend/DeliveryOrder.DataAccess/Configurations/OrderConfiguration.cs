using DeliveryOrder.DataAccess.Entyties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeliveryOrder.DataAccess.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(b => b.SenderCity).IsRequired();
            builder.Property(b => b.SenderAddress).IsRequired();
            builder.Property(b => b.RecipientAddress).IsRequired();
            builder.Property(b => b.RecipientAddress).IsRequired();
            builder.Property(b => b.Weight).IsRequired();
            builder.Property(b => b.PickUpDate).IsRequired();
        }
    }
}
