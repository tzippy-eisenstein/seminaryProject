using Dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Enteties_PICO.classes
{
    public class EmployeeDTO
    {
        public int Id { get; set; }

        public int? EmployeeTypeId { get; set; }

        public string? Description { get; set; }

        public string? EducationData { get; set; }

    }
}
