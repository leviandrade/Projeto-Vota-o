using Eleicao.Dominio.Acesso.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eleicao.Data.Mappings.Acesso
{
    internal sealed class TipoUsuarioPermissaoMapping : IEntityTypeConfiguration<TipoUsuarioPermissaoEntity>
    {
        public void Configure(EntityTypeBuilder<TipoUsuarioPermissaoEntity> builder)
        {
            builder.ToTable("TB_TIPO_USUARIO_PERMISSAO", "acesso");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_TIPO_USUARIO_PERMISSAO");
            builder.Property(p => p.IdTipoUsuario).HasColumnName("ID_TIPO_USUARIO");
            builder.Property(p => p.IdPermissao).HasColumnName("ID_PERMISSAO");

            builder.HasOne(p => p.Permissao)
                   .WithMany()
                   .HasForeignKey(p => p.IdPermissao);
        }
    }
}
