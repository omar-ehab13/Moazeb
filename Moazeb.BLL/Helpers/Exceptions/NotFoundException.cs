﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.BLL.Helpers.Exceptions
{
    public class NotFoundException : Exception
    {
        protected NotFoundException(string message) : base(message) { }
    }
}
