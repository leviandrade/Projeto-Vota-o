using Eleicao.Dominio.Acesso.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eleicao.Data.Mappings.Acesso
{
    internal sealed class UsuarioMapping : IEntityTypeConfiguration<UsuarioEntity>
    {
        public void Configure(EntityTypeBuilder<UsuarioEntity> builder)
        {
            builder.ToTable("TB_USUARIO", "acesso");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_USUARIO");
            builder.Property(p => p.NmUsuario).HasColumnName("NM_USUARIO");
            builder.Property(p => p.NrCpf).HasColumnName("NR_CPF");
            builder.Property(p => p.Senha).HasColumnName("SENHA");
            builder.Property(p => p.IdTipoUsuario).HasColumnName("ID_TIPO_USUARIO");

            builder.HasOne(p => p.TipoUsuario)
                .WithMany()
                .HasForeignKey(p => p.IdTipoUsuario);
        }
    }
}
