using AutoMapper;
using Dal.function;
using Dal.models;
using DTO_Enteties_PICO.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Enteties_PICO
{
    public class MapperProfile :Profile
    {
        public  MapperProfile()
        {
            CreateMap<EmployeeDTO, Employee>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }

    }
}
