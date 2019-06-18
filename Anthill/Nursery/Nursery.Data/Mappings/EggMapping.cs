using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nursery.Eggs;

namespace Nursery.Data.Mappings
{
    class EggMapping : IEntityTypeConfiguration<Egg>
    {
        public void Configure(EntityTypeBuilder<Egg> builder)
        {
            builder.ToTable("Egg");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Type).HasColumnName("Type").IsRequired();
            builder.Property(p => p.DueDate).HasColumnName("DueDate").IsRequired();
        }
    }
}
