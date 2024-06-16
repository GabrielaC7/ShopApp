using ShoppApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppApp.DAL.Interfaces
{
    public interface IEmployeesDB
    {
        List<EmployeesModel> GetEmployees();

        EmployeesModel GetEmployee(int employeeId);
        void SaveEmployee(EmployeesAddModel employeeAdd);
        void UpdateEmployee(EmployeesUpdateModel employeeAdd);
        void RemoveEmployee(EmployeesRemovesModel employeeAdd);
    }
}
