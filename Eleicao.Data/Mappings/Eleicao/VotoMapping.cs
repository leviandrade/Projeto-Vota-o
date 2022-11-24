using Eleicao.Dominio.Eleicao.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eleicao.Data.Mappings.Eleicao
{
    internal sealed class VotoMapping : IEntityTypeConfiguration<VotoEntity>
    {
        public void Configure(EntityTypeBuilder<VotoEntity> builder)
        {
            builder.ToTable("TB_VOTO", "eleicao");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_VOTO");
            builder.Property(p => p.IdEleicaoCandidato).HasColumnName("ID_ELEICAO_CANDIDATO");
            builder.Property(p => p.IdUsuario).HasColumnName("ID_USUARIO");
        }
    }
}
