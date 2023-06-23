using Moazeb.BLL.DTOs.User;
using Moazeb.BLL.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.BLL.IService
{
    public interface IAuthService
    {
        Task<AuthResponse> LoginAsync(LoginDto dto);
    }
}
