using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Moazeb.BLL.DTOs.User;
using Moazeb.BLL.Helpers;
using Moazeb.BLL.IService;
using Moazeb.BLL.Responses;
using Moazeb.DAL.DataContext;
using Moazeb.DAL.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.BLL.Services
{
    public class AuthService : IAuthService
    {
        protected readonly UserManager<ApplicationUser> _userManager;
        protected readonly IEmailService _emailService;
        protected readonly Mapper _mapper;
        protected readonly JWT _jwt;

        public AuthService(UserManager<ApplicationUser> userManager, IEmailService emailService,Mapper mapper , IOptions<JWT> options)
        {
            _userManager = userManager;
            _emailService = emailService;
            _mapper = mapper;
            _jwt = options.Value;
        }

        public async Task<AuthResponse> LoginAsync(LoginDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);

            // check from email and password
            if (user == null || !await _userManager.CheckPasswordAsync(user, dto.Password))
                return new()
                {
                    Status = 404,
                    Message = "Not Found",
                };

            // create jwt token and get user id for response
            var jwtSecurityToken = await CreateJwtToken(user);

            var userDto = _mapper.Map<UserDto>(user);

            return new()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                Success = true,
                Status = 200,
                Message = "Success",
                Data = userDto
            };
        }

        protected async Task<JwtSecurityToken> CreateJwtToken(ApplicationUser user)
        {
            #region Determine Claims for the token

            var roles = await _userManager.GetRolesAsync(user);

            var claims = new[]
            {
                new Claim("uid", user.Id),
                new Claim("roles", roles[0]),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
            };

            #endregion

            #region Determine Signing Credentials

            var key = Encoding.UTF8.GetBytes(_jwt.Key);
            var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

            #endregion

            #region Create And Return

            var jwtSecurityToken = new JwtSecurityToken(
                //issuer: _jwt.Issuer,
                //audience: _jwt.Audience,
                claims: claims,
                //expires: DateTime.Now.AddDays(_jwt.DurationInDays),
                signingCredentials: signingCredentials);

            return jwtSecurityToken;

            #endregion
        }
    }
}
