using FruitAPI.DTO;
using FruitAPI.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace FruitAPI.JWTService
{
    public interface IAuth
    {
        Task<APIResponse> LoginAsync(Login loginModel);
        JwtSecurityToken GetToken(List<Claim> authClaims);

    }
}
