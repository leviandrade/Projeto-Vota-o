using Eleicao.Dominio.Acesso.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eleicao.Data.Mappings.Acesso
{
    internal sealed class PermissaoMapping : IEntityTypeConfiguration<PermissaoEntity>
    {
        public void Configure(EntityTypeBuilder<PermissaoEntity> builder)
        {
            builder.ToTable("TB_PERMISSAO", "acesso");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_PERMISSAO");
            builder.Property(p => p.NmClaim).HasColumnName("NM_CLAIM");
            builder.Property(p => p.ClaimValue).HasColumnName("CLAIM_VALUE");
        }
    }
}
