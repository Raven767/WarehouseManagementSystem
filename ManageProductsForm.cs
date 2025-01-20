using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WarehouseManagementSystem.Models;

namespace WarehouseManagementSystem
{
    public partial class ManageProductsForm : Form
    {
        private List<Product> _products; // Список товаров
        private List<Product> _filteredProducts; // Отфильтрованный список товаров


        public ManageProductsForm(List<Product> products)
        {
            InitializeComponent();
            _products = products;
            _filteredProducts = new List<Product>();
            AddSampleData(); // Добавляем примеры данных
            InitializeDataGridView();
        }

        private void AddSampleData()
        {
            _products.Add(new Product
            {
                ProductID = 1,
                Name = "Телевизор Samsung",
                Category = "Электроника",
                Quantity = 10,
                Status = "Available"
            });
            _products.Add(new Product
            {
                ProductID = 2,
                Name = "Холодильник LG",
                Category = "Бытовая техника",
                Quantity = 5,
                Status = "Available"
            });
            _products.Add(new Product
            {
                ProductID = 3,
                Name = "Ноутбук HP",
                Category = "Компьютеры",
                Quantity = 8,
                Status = "Reserved"
            });
            _products.Add(new Product
            {
                ProductID = 4,
                Name = "Смартфон Apple iPhone",
                Category = "Мобильные устройства",
                Quantity = 15,
                Status = "Available"
            });
        }

        private void ManageProductsForm_Load(object sender, EventArgs e)
        {

        }
        private void InitializeDataGridView()
        {
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.Columns.Add("ProductID", "ID");
            dataGridViewProducts.Columns.Add("Name", "Название");
            dataGridViewProducts.Columns.Add("Category", "Категория");
            dataGridViewProducts.Columns.Add("Quantity", "Количество");
            dataGridViewProducts.Columns.Add("Status", "Статус");

            dataGridViewProducts.Columns["ProductID"].DataPropertyName = "ProductID";
            dataGridViewProducts.Columns["Name"].DataPropertyName = "Name";
            dataGridViewProducts.Columns["Category"].DataPropertyName = "Category";
            dataGridViewProducts.Columns["Quantity"].DataPropertyName = "Quantity";
            dataGridViewProducts.Columns["Status"].DataPropertyName = "Status";

            dataGridViewProducts.DataSource = _products;
        }

        private void RefreshDataGridView()
        {
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = _products;
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            // Заполнение полей при выборе товара
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var rowIndex = dataGridViewProducts.SelectedRows[0].Index;
                var product = _products[rowIndex];

                txtName.Text = product.Name;
                txtCategory.Text = product.Category;
                txtQuantity.Text = product.Quantity.ToString();
                cmbStatus.SelectedItem = product.Status;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание нового товара
            var product = new Product
            {
                ProductID = _products.Count + 1,
                Name = txtName.Text.Trim(),
                Category = txtCategory.Text.Trim(),
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                Status = cmbStatus.SelectedItem.ToString()
            };

            _products.Add(product);
            RefreshDataGridView();

            // Очистка полей после добавления
            ClearFields();
        }
        //Метод проверки заполненности полей
        private bool ValidateFields()
        {
            // Проверка заполненности всех обязательных полей
            if (string.IsNullOrWhiteSpace(txtName.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out _))
                return false;
            if (cmbStatus.SelectedItem == null)
                return false;

            return true;
        }
        //метод для очистки полей после успешного добавления товара
        private void ClearFields()
        {
            txtName.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            cmbStatus.SelectedIndex = -1; // Сбрасываем выбор
        }

        private void edit_Click(object sender, EventArgs e)
        {

            // Проверка, выбран ли товар
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка заполненности полей
            if (!ValidateFields())
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед редактированием.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Редактирование выбранного товара
            var rowIndex = dataGridViewProducts.SelectedRows[0].Index;
            var product = _products[rowIndex];

            product.Name = txtName.Text.Trim();
            product.Category = txtCategory.Text.Trim();
            product.Quantity = int.Parse(txtQuantity.Text.Trim());
            product.Status = cmbStatus.SelectedItem.ToString();

            RefreshDataGridView();
            ClearFields(); // Очистка полей после редактирования

            MessageBox.Show("Товар успешно отредактирован.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void delete_Click(object sender, EventArgs e)
        {
            // Удаление выбранного товара
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var rowIndex = dataGridViewProducts.SelectedRows[0].Index;
                _products.RemoveAt(rowIndex);
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Выберите товар для удаления.");
            }
        }
        //Реализация метода поиска
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var categoryFilter = txtFilterCategory.Text.Trim();
            var statusFilter = cmbFilterStatus.SelectedItem?.ToString();

            _filteredProducts = _products.FindAll(p =>
                 (string.IsNullOrEmpty(categoryFilter) ||
                  p.Category.IndexOf(categoryFilter, StringComparison.OrdinalIgnoreCase) >= 0) &&
                 (statusFilter == "All" || p.Status == statusFilter)
             );

            RefreshFilteredDataGridView();
        }
        //Метод для обновления DataGridView с отфильтрованными данными
        private void RefreshFilteredDataGridView()
        {
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = _filteredProducts;
        }
        //Обновление списка после фильтрации
        private void ResetFilters()
        {
            txtFilterCategory.Text = string.Empty;
            cmbFilterStatus.SelectedIndex = cmbFilterStatus.Items.IndexOf("All");
            _filteredProducts = new List<Product>(_products);
            RefreshFilteredDataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}