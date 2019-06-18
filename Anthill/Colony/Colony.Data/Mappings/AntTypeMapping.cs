using Colony.Ants.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Colony.Data.Mappings
{
    class AntTypeMapping : IEntityTypeConfiguration<AntType>
    {
        public void Configure(EntityTypeBuilder<AntType> builder)
        {
            builder.ToTable("AntType");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Type).HasColumnName("Type").IsRequired();
        }
    }
}
