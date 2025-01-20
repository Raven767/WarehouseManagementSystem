using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementSystem.Models;

namespace WarehouseManagementSystem
{
    public partial class Form1 : Form
    {
        private List<Product> products; // Список товаров
        private List<StorageUnit> storageUnits; // Список складских ячеек
        private List<Employee> employees; // Список сотрудников

        public Form1()
        {
            InitializeComponent();
            InitializeProducts();
            InitializeStorageUnits();
            InitializeEmployees();
        }

        // Примеры товаров
        private void InitializeProducts()
        {
            products = new List<Product>
            {
                new Product { ProductID = 1, Name = "Телевизор Samsung", Category = "Электроника", Quantity = 10, Status = "Available" },
                new Product { ProductID = 2, Name = "Ноутбук HP", Category = "Компьютеры", Quantity = 5, Status = "Reserved" }
            };
        }

        // Примеры складских ячеек
        private void InitializeStorageUnits()
        {
            storageUnits = new List<StorageUnit>
            {
                new StorageUnit { StorageUnitID = 1, Location = "Ряд A, Полка 1", Capacity = 100, CurrentFill = 50 },
                new StorageUnit { StorageUnitID = 2, Location = "Ряд B, Полка 3", Capacity = 200, CurrentFill = 120 }
            };
        }

        // Примеры сотрудников
        private void InitializeEmployees()
        {
            employees = new List<Employee>
            {
                new Employee { EmployeeID = 1, Name = "Иван Иванов", Position = "Менеджер", ContactInfo = "+7 999 123 45 67" },
                new Employee { EmployeeID = 2, Name = "Петр Петров", Position = "Кладовщик", ContactInfo = "+7 999 987 65 43" }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenManageStorageUnits_Click(object sender, EventArgs e)
        {
            var manageStorageUnitsForm = new ManageStorageUnitsForm();
            manageStorageUnitsForm.Show();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {   
            var manageProductsForm = new ManageProductsForm(products);
            manageProductsForm.Show();
        }

        private void btnManageSuppliers_Click(object sender, EventArgs e)
        {
            var manageSuppliersForm = new ManageSuppliersForm();
            manageSuppliersForm.Show();
        }

        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            var manageEmployeesForm = new ManageEmployeesForm();
            manageEmployeesForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
         
        }

        private void btnTrackMovements_Click(object sender, EventArgs e)
        {
            var manageGoodsMovementsForm = new ManageGoodsMovementsForm(products, storageUnits, employees);
            manageGoodsMovementsForm.Show();
        }
    }
}
