using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; } // Уникальный идентификатор поставщика
        public string Name { get; set; } // Название или имя поставщика
        public string ContactInfo { get; set; } // Контактная информация
        public string Address { get; set; } // Адрес поставщика
    }
}
