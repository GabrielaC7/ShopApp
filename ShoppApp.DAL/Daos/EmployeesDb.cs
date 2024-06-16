using ShoppApp.DAL.Context;
using ShoppApp.DAL.Interfaces;
using ShoppApp.DAL.Models;

namespace ShoppApp.DAL.Daos
{
    public class EmployeesDb : IEmployeesDB

    {
        private readonly ShopContext context;

        public EmployeesDb(ShopContext context) { this.context = context; }
        public EmployeesModel GetEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public List<EmployeesModel> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(EmployeesRemovesModel employeeAdd)
        {
            throw new NotImplementedException();
        }

        public void SaveEmployee(EmployeesAddModel employeeAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(EmployeesUpdateModel employeeAdd)
        {
            throw new NotImplementedException();
        }
    }
}
