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
    public partial class ManageSuppliersForm : Form
    {
        private List<Supplier> _suppliers; // Список поставщиков

        public ManageSuppliersForm()
        {
            InitializeComponent();
            _suppliers = new List<Supplier>();
            AddSampleSuppliers(); // Добавляем примеры поставщиков
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridViewSuppliers.AutoGenerateColumns = false;
            dataGridViewSuppliers.Columns.Add("SupplierID", "ID");
            dataGridViewSuppliers.Columns.Add("Name", "Название");
            dataGridViewSuppliers.Columns.Add("ContactInfo", "Контакты");
            dataGridViewSuppliers.Columns.Add("Address", "Адрес");

            dataGridViewSuppliers.Columns["SupplierID"].DataPropertyName = "SupplierID";
            dataGridViewSuppliers.Columns["Name"].DataPropertyName = "Name";
            dataGridViewSuppliers.Columns["ContactInfo"].DataPropertyName = "ContactInfo";
            dataGridViewSuppliers.Columns["Address"].DataPropertyName = "Address";

            dataGridViewSuppliers.DataSource = _suppliers;
        }

        private void AddSampleSuppliers()
        {
            _suppliers.Add(new Supplier
            {
                SupplierID = 1,
                Name = "Samsung Electronics",
                ContactInfo = "contact@samsung.com",
                Address = "Сеул, Южная Корея"
            });
            _suppliers.Add(new Supplier
            {
                SupplierID = 2,
                Name = "LG Electronics",
                ContactInfo = "contact@lg.com",
                Address = "Сеул, Южная Корея"
            });
        }

        private void SupplierAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var supplier = new Supplier
            {
                SupplierID = _suppliers.Count + 1,
                Name = txtName.Text.Trim(),
                ContactInfo = txtContactInfo.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            _suppliers.Add(supplier);
            RefreshDataGridView();
            ClearFields();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите поставщика для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFields())
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowIndex = dataGridViewSuppliers.SelectedRows[0].Index;
            var supplier = _suppliers[rowIndex];

            supplier.Name = txtName.Text.Trim();
            supplier.ContactInfo = txtContactInfo.Text.Trim();
            supplier.Address = txtAddress.Text.Trim();

            RefreshDataGridView();
            ClearFields();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите поставщика для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowIndex = dataGridViewSuppliers.SelectedRows[0].Index;
            _suppliers.RemoveAt(rowIndex);

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridViewSuppliers.DataSource = null;
            dataGridViewSuppliers.DataSource = _suppliers;
        }

        private void dataGridViewSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                var rowIndex = dataGridViewSuppliers.SelectedRows[0].Index;
                var supplier = _suppliers[rowIndex];

                txtName.Text = supplier.Name;
                txtContactInfo.Text = supplier.ContactInfo;
                txtAddress.Text = supplier.Address;
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtContactInfo.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
                return false;

            return true;
        }

        private void ClearFields()
        {
            txtName.Text = string.Empty;
            txtContactInfo.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        private void ManageSuppliersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
