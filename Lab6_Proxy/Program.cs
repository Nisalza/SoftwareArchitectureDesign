﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4. Доступ к персональным данным сотрудников в компании.

namespace Lab6_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            int count = GetEmployeesCount(proxy);
            string[] phoneNumbers = GetPhoneNumbers(proxy);
            Employee e1 = GetEmployee(proxy, 3);
            Employee e2 = GetEmployee(proxy, 15);
            Employee e3 = GetEmployee(proxy, 40);
            Console.ReadKey();
        }

        private static int GetEmployeesCount(Proxy proxy)
        {
            return proxy.GetEmployeesCount();
        }

        private static string[] GetPhoneNumbers(Proxy proxy)
        {
            Employee[] employees = proxy.GetEmployees();
            string[] phoneNumbers = employees.Select(x => x.PhoneNumber).ToArray();
            return phoneNumbers;
        }

        private static Employee GetEmployee(Proxy proxy, int id)
        {
            Employee employee = proxy.GetEmployee(id);
            return employee;
        }
    }
}
