using AutoMapper;
using Bll.Interface;
using Dal.models;
using DTO_Enteties_PICO;
using DTO_Enteties_PICO.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.function
{

    public class emloyeeBll : iEmployeeBll
    {
        iEmployeeBll bll;
        MapperProfile map;

        public emloyeeBll(iEmployeeBll bll)
        {
            this.bll = bll;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();
            });

            map =(MapperProfile?) config.CreateMapper();

        }
        public  Task<bool> AddAsync(Employee Employee)
        {
            try
            {
                
                return Dal.function.employee.AddAsync(myEmployee);
            }
            catch
            {

            }
            throw new NotImplementedException();
        }

    }
}
