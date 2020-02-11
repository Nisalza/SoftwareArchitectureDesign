using System;

namespace Lab6_Proxy
{
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string BirthDate { get; set; }

        public string Address { get; set; }
    }
}
