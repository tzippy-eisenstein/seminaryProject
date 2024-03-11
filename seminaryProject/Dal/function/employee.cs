using Dal.Interface;
using Dal.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dal.function.employee;

namespace Dal.function
{
    public class employee : IemployeeDal
    {
        IemployeeDal iEmployee;



        private readonly SeminarDrContext db;

        public employee(SeminarDrContext db)
        {
            this.db = db;
        }

        //הוספת משפחה
        public async Task<bool> AddAsync(Employee employee)
        {
            var employeeId = employee.EmployeeTypeId;
            var employeeType = await db.TypesOfOccupations.FirstOrDefaultAsync(x => x.Id == employeeId);
            if (employeeType == null)
            {
                return false;
            }
            try
            {
                db.Employees.Add(employee);
                await db.SaveChangesAsync();
                return true;
            }

            catch (Exception ex)
            {

                return false;
            }
        }

        //מחיקת משפחה
        public async Task<bool> DeleteAsync(short employeeId)
        {
            var e1 = await db.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);
            if (e1 == null)
                return false;
            try
            {
                db.Employees.Remove(e1);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //החזרת כל המשפחות
        public async Task<List<Employee>> GetAllAsync()
        {
            var empoyees = await db.Employees.ToListAsync();
            try
            {
                return empoyees;
            }
            catch (Exception ex)
            {
                return new List<Employee>();
            }
        }

        //החזרת לפי קוד
        public async Task<Employee> getByIdAsync(short id)
        {
            var employee = await db.Employees.FirstOrDefaultAsync(x => x.Id == id);
            try
            {
                return employee;
            }
            catch (Exception ex)
            {
                return null;

            }
        }
        //לבדוק אם אין דרך אחרת לעדכן לא ידני
        //עדכון משפחה
        public async Task<bool> UpdateAsync(Employee employee)
        {
            var employeeType = await db.TypesOfOccupations.FirstOrDefaultAsync(x => x.Id == employee.EmployeeTypeId);
            var employeeID = await db.Employees.FirstOrDefaultAsync(x => x.Id == employee.Id);

            if (employeeType == null || employeeID == null)
            {
                return false;
            }
            try
            {
                //family1.StreetId = family.StreetId;
                //family1.Note = family.Note;
                //family1.FamilyType = familyType;
                //family1.FamilyName = family.FamilyName;
                //family1.FatherIdentityPassport = family.FatherIdentityPassport;
                //family1.MotherIdentityPassport = family.MotherIdentityPassport;
                //family1.HomePhone = family.HomePhone;
                //family1.HouseNumber = family.HouseNumber;
                employeeID.Description = employee.Description;
                employeeID.EducationData = employee.EducationData;
                employeeID.EmployeeTypeId = employeeType.Id;
                db.SaveChanges();
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static Task<bool> AddAsync(Employee employee, object myEmployee)
        {
            throw new NotImplementedException();
        }
    }
}
