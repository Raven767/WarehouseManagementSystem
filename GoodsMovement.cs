using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Models
{
    public class GoodsMovement
    {
        public int MovementID { get; set; } // Уникальный идентификатор перемещения
        public string ProductID { get; set; } // Идентификатор товара
        public int Quantity { get; set; } // Количество перемещаемого товара
        public string SourceUnitID { get; set; } // Исходная ячейка
        public string TargetUnitID { get; set; } // Целевая ячейка
        public string EmployeeID { get; set; } // Сотрудник, который выполнил перемещение
        public DateTime MovementDate { get; set; } // Дата и время перемещения
    }
}
