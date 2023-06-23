using AutoMapper;
using Moazeb.BLL.DTOs.User;
using Moazeb.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.BLL.Mappings
{
    public class AutoMapperMapping : Profile
    {
        public AutoMapperMapping()
        {
            CreateMap<ApplicationUser, UserDto>();
        }
    }
}
