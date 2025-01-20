using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; } // Уникальный идентификатор сотрудника
        public string Name { get; set; }   // Имя сотрудника
        public string Position { get; set; } // Должность
        public string ContactInfo { get; set; } // Контактная информация
    }
}
