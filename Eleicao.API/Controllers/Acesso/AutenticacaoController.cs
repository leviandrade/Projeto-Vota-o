using Eleicao.API.Extensions;
using Eleicao.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao.API.Controllers.Acesso
{
    [Route("Acesso/[controller]")]
    public class AutenticacaoController : ControllerBase
    {
        private readonly AppSettings _appSettings;

        public AutenticacaoController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [Route("Login")]
        [HttpPost]
        public async Task<string> Login(LoginViewModel login)
        {
            return await GerarJwt(login.Cpf);
        }

        private async Task<string> GerarJwt(string cpf)
        {
            var claims = new List<Claim>();

            claims.Add(new Claim(JwtRegisteredClaimNames.Sub, "1"));
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, ""));
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

            claims.Add(new Claim("Usuario", "Listar"));

            var identityClaims = new ClaimsIdentity();
            identityClaims.AddClaims(claims);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.AuthenticationKey);
            var token = tokenHandler.CreateToken(new SecurityTokenDescriptor
            {
                Subject = identityClaims,
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            });

            var encodedToken = tokenHandler.WriteToken(token);
            return encodedToken;
        }
    }
}
