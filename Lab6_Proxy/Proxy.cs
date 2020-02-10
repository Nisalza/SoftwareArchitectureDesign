using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Proxy
{
    public class Proxy : IEmployeesLoader
    {
        private EmployeesList _employeesList;
        
        public Employee GetEmployee(int id)
        {
            TestEmployeeList();
            Employee emp = _employeesList.GetEmployee(id);
            return emp;
        }

        public int GetEmployeesCount()
        {
            TestEmployeeList();
            int count = _employeesList.GetEmployeesCount();
            return count;
        }

        public Employee[] GetEmployees()
        {
            TestEmployeeList();
            Employee[] employees = _employeesList.GetEmployees();
            return employees;
        }

        private void TestEmployeeList()
        {
            if (_employeesList == null)
            {
                _employeesList = new EmployeesList();
            }
        }
    }
}
