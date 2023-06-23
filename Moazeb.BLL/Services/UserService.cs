using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Moazeb.BLL.DTOs.User;
using Moazeb.BLL.Helpers;
using Moazeb.BLL.IService;
using Moazeb.BLL.Responses;
using Moazeb.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.BLL.Services
{
    public class UserService : AuthService, IUserService
    {
        public UserService(UserManager<ApplicationUser> userManager, IEmailService emailService,  Mapper mapper, IOptions<JWT> options)
            : base(userManager, emailService, mapper, options)
        {
        }

        public Task DeleteUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponse<IEnumerable<UserDto>>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponse<UserDto>> GetUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<GenericResponse<UserDto>> RegisterUserAsync(RegisterUserDto registerUserDto)
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

        public Task<GenericResponse<UserDto>> UpdateUserAsync(string userId, UpdateUserDto updateUserDto)
        {
            throw new NotImplementedException();
        }

        
    }
}
