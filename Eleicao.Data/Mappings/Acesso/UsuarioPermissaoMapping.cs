using Eleicao.Dominio.Acesso.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eleicao.Data.Mappings.Acesso
{
    internal sealed class UsuarioPermissaoMapping : IEntityTypeConfiguration<UsuarioPermissaoEntity>
    {
        public void Configure(EntityTypeBuilder<UsuarioPermissaoEntity> builder)
        {
            builder.ToTable("TB_USUARIO_PERMISSAO", "acesso");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_USUARIO_PERMISSAO");
            builder.Property(p => p.IdUsuario).HasColumnName("ID_USUARIO");
            builder.Property(p => p.IdPermissao).HasColumnName("ID_PERMISSAO");

            builder.HasOne(p => p.Permissao)
                   .WithMany()
                   .HasForeignKey(p => p.IdPermissao);
        }
    }
}
