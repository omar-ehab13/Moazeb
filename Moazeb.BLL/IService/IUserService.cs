using Moazeb.BLL.DTOs.User;
using Moazeb.BLL.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.BLL.IService
{
    public interface IUserService
    {
        Task<GenericResponse<UserDto>> RegisterUserAsync(RegisterUserDto registerUserDto);
        Task<GenericResponse<IEnumerable<UserDto>>> GetAllUsersAsync();
        Task<GenericResponse<UserDto>> GetUserAsync(string userId);
        Task<GenericResponse<UserDto>> UpdateUserAsync(string userId, UpdateUserDto updateUserDto);
        Task DeleteUserAsync(string userId);
    }
}
