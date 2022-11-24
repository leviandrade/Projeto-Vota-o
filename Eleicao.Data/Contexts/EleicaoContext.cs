using Eleicao.Data.Mappings.Eleicao;
using Eleicao.Dominio.Eleicao.Entidades;
using Eleicao.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eleicao.Data.Contexts
{
    public sealed class EleicaoContext : DbContext, IUnitOfWork<EleicaoContext>
    {
        public EleicaoContext(DbContextOptions<EleicaoContext> options) : base(options)
        {

        }

        public DbSet<EleicaoEntity> Eleicao { get; set; }
        public DbSet<EleicaoCandidatoEntity> EleicaoCandidato { get; set; }
        public DbSet<VotoEntity> Voto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EleicaoMapping());
            modelBuilder.ApplyConfiguration(new EleicaoCandidatoMapping());
            modelBuilder.ApplyConfiguration(new VotoMapping());


            base.OnModelCreating(modelBuilder);
        }
        public async Task CommitAsync()
        {
            await SaveChangesAsync();
        }
    }
}
