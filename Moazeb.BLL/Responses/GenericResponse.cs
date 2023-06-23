using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.BLL.Responses
{
    public class GenericResponse<T> where T : class
    {
        public bool Success { get; set; } = false;

        public int Status { get; set; } = 404;

        public string Message { get; set; } = "Bad Request";

        public T? Data { get; set; } = null;
    }
}
