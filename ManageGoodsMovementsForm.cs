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
    public partial class ManageGoodsMovementsForm : Form
    {
        private List<GoodsMovement> _goodsMovements;
        private List<Product> _products; // Список товаров
        private List<StorageUnit> _storageUnits; // Список ячеек
        private List<Employee> _employees; // Список сотрудников

        public ManageGoodsMovementsForm(List<Product> products, List<StorageUnit> storageUnits, List<Employee> employees)
        {
            InitializeComponent();
            _goodsMovements = new List<GoodsMovement>();
            _products = products;
            _storageUnits = storageUnits;
            _employees = employees;

            InitializeDataGridView();
            InitializeDropdowns();
        }

        private void InitializeDataGridView()
        {
            dataGridViewGoodsMovements.AutoGenerateColumns = false;
            dataGridViewGoodsMovements.Columns.Add("MovementID", "ID");
            dataGridViewGoodsMovements.Columns.Add("ProductID", "Товар");
            dataGridViewGoodsMovements.Columns.Add("Quantity", "Количество");
            dataGridViewGoodsMovements.Columns.Add("SourceUnitID", "Исходная ячейка");
            dataGridViewGoodsMovements.Columns.Add("TargetUnitID", "Целевая ячейка");
            dataGridViewGoodsMovements.Columns.Add("EmployeeID", "Сотрудник");
            dataGridViewGoodsMovements.Columns.Add("MovementDate", "Дата перемещения");

            dataGridViewGoodsMovements.Columns["MovementID"].DataPropertyName = "MovementID";
            dataGridViewGoodsMovements.Columns["ProductID"].DataPropertyName = "ProductID";
            dataGridViewGoodsMovements.Columns["Quantity"].DataPropertyName = "Quantity";
            dataGridViewGoodsMovements.Columns["SourceUnitID"].DataPropertyName = "SourceUnitID";
            dataGridViewGoodsMovements.Columns["TargetUnitID"].DataPropertyName = "TargetUnitID";
            dataGridViewGoodsMovements.Columns["EmployeeID"].DataPropertyName = "EmployeeID";
            dataGridViewGoodsMovements.Columns["MovementDate"].DataPropertyName = "MovementDate";

            dataGridViewGoodsMovements.DataSource = _goodsMovements;
        }

        public void UpdateDataSources(List<Product> products, List<StorageUnit> storageUnits, List<Employee> employees)
        {
            _products = products;
            _storageUnits = storageUnits;
            _employees = employees;

            InitializeDropdowns(); // Обновляем выпадающие списки
        }
        
        private void InitializeDropdowns()
        {
            // Заполняем ComboBox для товаров
            cmbProduct.DataSource = _products;
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "ProductID";

            // Заполняем ComboBox для исходной ячейки
            cmbSourceUnit.DataSource = _storageUnits;
            cmbSourceUnit.DisplayMember = "Location";
            cmbSourceUnit.ValueMember = "StorageUnitID";

            // Заполняем ComboBox для целевой ячейки
            cmbTargetUnit.DataSource = _storageUnits;
            cmbTargetUnit.DisplayMember = "Location";
            cmbTargetUnit.ValueMember = "StorageUnitID";

            // Заполняем ComboBox для сотрудников
            cmbEmployee.DataSource = _employees;
            cmbEmployee.DisplayMember = "Name";
            cmbEmployee.ValueMember = "EmployeeID";
        }
        

        private void employeeAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем выбранные объекты из ComboBox
            var selectedProduct = cmbProduct.SelectedItem as Product;
            var selectedSourceUnit = cmbSourceUnit.SelectedItem as StorageUnit;
            var selectedTargetUnit = cmbTargetUnit.SelectedItem as StorageUnit;
            var selectedEmployee = cmbEmployee.SelectedItem as Employee;

            if (selectedProduct == null || selectedSourceUnit == null || selectedTargetUnit == null || selectedEmployee == null)
            {
                MessageBox.Show("Ошибка при выборе значений.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создаем новую запись о перемещении
            var goodsMovement = new GoodsMovement
            {
                MovementID = _goodsMovements.Count + 1,
                ProductID = selectedProduct.Name, // Используем название товара
                Quantity = int.Parse(txtQuantity.Text),
                SourceUnitID = selectedSourceUnit.Location, // Используем местоположение склада
                TargetUnitID = selectedTargetUnit.Location,
                EmployeeID = selectedEmployee.Name, // Используем имя сотрудника
                MovementDate = dateTimePickerMovementDate.Value
            };

            _goodsMovements.Add(goodsMovement);
            RefreshDataGridView();
            

        }

        private void employeeEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewGoodsMovements.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowIndex = dataGridViewGoodsMovements.SelectedRows[0].Index;
            var goodsMovement = _goodsMovements[rowIndex];

            goodsMovement.ProductID = cmbProduct.SelectedItem.ToString();
            goodsMovement.Quantity = int.Parse(txtQuantity.Text);
            goodsMovement.SourceUnitID = cmbSourceUnit.SelectedItem.ToString();
            goodsMovement.TargetUnitID = cmbTargetUnit.SelectedItem.ToString();
            goodsMovement.EmployeeID = cmbEmployee.SelectedItem.ToString();
            goodsMovement.MovementDate = dateTimePickerMovementDate.Value;

            RefreshDataGridView();
        }

        private void employeeDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewGoodsMovements.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowIndex = dataGridViewGoodsMovements.SelectedRows[0].Index;
            _goodsMovements.RemoveAt(rowIndex);

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridViewGoodsMovements.DataSource = null;
            dataGridViewGoodsMovements.DataSource = _goodsMovements;
        }

        private bool ValidateFields()
        {
            return cmbProduct.SelectedValue != null &&
                   cmbSourceUnit.SelectedValue != null &&
                   cmbTargetUnit.SelectedValue != null &&
                   cmbEmployee.SelectedValue != null &&
                   int.TryParse(txtQuantity.Text, out _);
        }
    }
}
