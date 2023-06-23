using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.BLL.Responses
{
    public class AuthResponse : GenericResponse<object>
    {
        public string? Token { get; set; }
    }
}
