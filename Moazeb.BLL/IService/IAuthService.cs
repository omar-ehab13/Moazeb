using Moazeb.BLL.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.BLL.IService
{
    public interface IAuthService
    {
        Task<UserDto> RegisterUserAsync(RegisterUserDto registerUserDto);
        Task<UserDto> LoginAsync(LoginDto loginDto);
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserAsync(string userId);
        Task<UserDto> UpdateUserAsync(string userId, UpdateUserDto updateUserDto);
        Task DeleteUserAsync(string userId);
    }
}
