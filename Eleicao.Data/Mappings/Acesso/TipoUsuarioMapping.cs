using Eleicao.Dominio.Acesso.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eleicao.Data.Mappings.Acesso
{
    internal sealed class TipoUsuarioMapping : IEntityTypeConfiguration<TipoUsuarioEntity>
    {
        public void Configure(EntityTypeBuilder<TipoUsuarioEntity> builder)
        {
            builder.ToTable("TB_TIPO_USUARIO", "acesso");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_TIPO_USUARIO");
            builder.Property(p => p.NmTipoUsuario).HasColumnName("NM_TIPO_USUARIO");

            builder.HasMany(p => p.TipoUsuarioPermissao)
                   .WithOne()
                   .HasForeignKey(p => p.IdTipoUsuario);
        }
    }
}
