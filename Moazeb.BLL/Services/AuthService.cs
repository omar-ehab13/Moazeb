using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Moazeb.BLL.DTOs.User;
using Moazeb.BLL.Helpers;
using Moazeb.BLL.IService;
using Moazeb.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.BLL.Services
{
    public class AuthService : IAuthService
    {
        private readonly IEmailService _emailService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JWT _jwt;

        public AuthService(IEmailService emailService, UserManager<ApplicationUser> userManager, IOptions<JWT> options)
        {
            _emailService = emailService;
            _userManager = userManager;
            _jwt = options.Value;
        }

        public Task DeleteUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> LoginAsync(LoginDto loginDto)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto> RegisterUserAsync(RegisterUserDto registerUserDto)
        {
            // Generate random email for the user
            var generatedEmail = await _emailService.GenerateRandomEmailAsync(registerUserDto.Name, registerUserDto.Role, exist:false);

            while (await _userManager.FindByEmailAsync(generatedEmail) is not null)
                generatedEmail = await _emailService.GenerateRandomEmailAsync(registerUserDto.Name, registerUserDto.Role, exist:true);

            // Assign image to default image

            // Add new local user

            // Create the user in DB

            // Add the user to the role

            // Return UserDto
            throw new NotImplementedException();
        }

        public Task<UserDto> UpdateUserAsync(string userId, UpdateUserDto updateUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
