using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.BLL.IService
{
    public interface IEmailService
    {
        Task<string> GenerateRandomEmailAsync(string name, string role, bool exist);
    }
}
