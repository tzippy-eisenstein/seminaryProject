using Dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Interface
{
    public interface IemployeeDal
    {
        Task <List<Employee>> GetAllAsync();

        Task<bool> DeleteAsync(short employeeId);

        Task<bool> AddAsync(Employee employee);

        Task<bool> UpdateAsync(Employee employee);

        Task<Employee> getByIdAsync(short employeeId);
            
    }
}
