using DTO_Enteties_PICO.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Bll.Interface
{
    public interface iEmployeeBll
    {
        Task<List<EmployeeDTO>> GetAllAsync();

        Task<bool> DeleteAsync(short employeeId);

        Task<bool> AddAsync(EmployeeDTO employee);

        Task<bool> UpdateAsync(EmployeeDTO employee);

        Task<EmployeeDTO> getByIdAsync(short employeeId);


    }
}
