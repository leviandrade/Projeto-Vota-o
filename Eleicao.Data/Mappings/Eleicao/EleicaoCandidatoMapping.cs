using Eleicao.Dominio.Eleicao.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eleicao.Data.Mappings.Eleicao
{
    internal sealed class EleicaoCandidatoMapping : IEntityTypeConfiguration<EleicaoCandidatoEntity>
    {
        public void Configure(EntityTypeBuilder<EleicaoCandidatoEntity> builder)
        {
            builder.ToTable("TB_ELEICAO_CANDIDATO", "eleicao");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_ELEICAO_CANDIDATO");
            builder.Property(p => p.IdEleicao).HasColumnName("ID_ELEICAO");
            builder.Property(p => p.IdCandidato).HasColumnName("ID_CANDIDATO");
        }
    }
}
