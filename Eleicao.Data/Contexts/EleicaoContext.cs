using Eleicao.Data.Mappings.Acesso;
using Eleicao.Data.Mappings.Eleicao;
using Eleicao.Dominio.Acesso.Entidades;
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

        #region Acesso
        public DbSet<TipoUsuarioEntity> TipoUsuario { get; set; }
        public DbSet<UsuarioEntity> Usuario { get; set; }

        #endregion

        #region Eleicao
        public DbSet<EleicaoEntity> Eleicao { get; set; }
        public DbSet<EleicaoCandidatoEntity> EleicaoCandidato { get; set; }
        public DbSet<VotoEntity> Voto { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TipoUsuarioMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());

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
