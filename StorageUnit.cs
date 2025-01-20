using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Models
{
    public class StorageUnit
    {
        public int StorageUnitID { get; set; } // Уникальный идентификатор ячейки
        public string Location { get; set; }   // Местоположение (ряд, полка)
        public int Capacity { get; set; }     // Максимальная вместимость
        public int CurrentFill { get; set; }  // Текущее количество товара

        // Метод для проверки, есть ли свободное место
        public bool HasSpace(int quantity)
        {
            return CurrentFill + quantity <= Capacity;
        }
    }
}

