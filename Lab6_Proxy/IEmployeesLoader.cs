using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Proxy
{
    public interface IEmployeesLoader
    {
        Employee GetEmployee(int id);

        int GetEmployeesCount();

        Employee[] GetEmployees();
    }
}
