using Eleicao.Dominio.Eleicao.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao.Data.Mappings.Eleicao
{
    internal sealed class EleicaoMapping : IEntityTypeConfiguration<EleicaoEntity>
    {
        public void Configure(EntityTypeBuilder<EleicaoEntity> builder)
        {
            builder.ToTable("TB_ELEICAO", "eleicao");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_ELEICAO");
            builder.Property(p => p.NmEleicao).HasColumnName("NM_ELEICAO");
            builder.Property(p => p.DtInicioEleicao).HasColumnName("DT_INICO_ELEICAO");
            builder.Property(p => p.DtTerminoEleicao).HasColumnName("DT_TERMINO_ELEICAO");
        }
    }
}
