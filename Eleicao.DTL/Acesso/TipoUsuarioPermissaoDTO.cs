namespace Eleicao.DTL.Acesso
{
    public class TipoUsuarioPermissaoDTO
    {
        public Guid Id { get; set; }
        public Guid IdTipoUsuario { get; set; }
        public Guid IdPermissao { get; set; }
        public PermissaoDTO Permissao { get; set; }
    }
}
