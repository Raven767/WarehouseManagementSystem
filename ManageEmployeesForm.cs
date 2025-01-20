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
    public partial class ManageEmployeesForm : Form
    {
        private List<Employee> _employees; // Список сотрудников
        public ManageEmployeesForm()
        {
            InitializeComponent();
            _employees = new List<Employee>();
            AddSampleEmployees(); // Добавляем примеры сотрудников
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridViewEmployees.AutoGenerateColumns = false;
            dataGridViewEmployees.Columns.Add("EmployeeID", "ID");
            dataGridViewEmployees.Columns.Add("Name", "Имя");
            dataGridViewEmployees.Columns.Add("Position", "Должность");
            dataGridViewEmployees.Columns.Add("ContactInfo", "Контакты");

            dataGridViewEmployees.Columns["EmployeeID"].DataPropertyName = "EmployeeID";
            dataGridViewEmployees.Columns["Name"].DataPropertyName = "Name";
            dataGridViewEmployees.Columns["Position"].DataPropertyName = "Position";
            dataGridViewEmployees.Columns["ContactInfo"].DataPropertyName = "ContactInfo";

            dataGridViewEmployees.DataSource = _employees;
        }

        private void AddSampleEmployees()
        {
            _employees.Add(new Employee
            {
                EmployeeID = 1,
                Name = "Иван Иванов",
                Position = "Менеджер склада",
                ContactInfo = "+7 999 123 45 67"
            });
            _employees.Add(new Employee
            {
                EmployeeID = 2,
                Name = "Петр Петров",
                Position = "Кладовщик",
                ContactInfo = "+7 999 987 65 43"
            });
        }

        private void employeeAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var employee = new Employee
            {
                EmployeeID = _employees.Count + 1,
                Name = txtName.Text.Trim(),
                Position = txtPosition.Text.Trim(),
                ContactInfo = txtContactInfo.Text.Trim()
            };

            _employees.Add(employee);
            RefreshDataGridView();
            ClearFields();
        }

        private void employeeEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFields())
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowIndex = dataGridViewEmployees.SelectedRows[0].Index;
            var employee = _employees[rowIndex];

            employee.Name = txtName.Text.Trim();
            employee.Position = txtPosition.Text.Trim();
            employee.ContactInfo = txtContactInfo.Text.Trim();

            RefreshDataGridView();
            ClearFields();
        }

        private void employeeDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowIndex = dataGridViewEmployees.SelectedRows[0].Index;
            _employees.RemoveAt(rowIndex);

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridViewEmployees.DataSource = null;
            dataGridViewEmployees.DataSource = _employees;
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtPosition.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtContactInfo.Text))
                return false;

            return true;
        }

        private void ClearFields()
        {
            txtName.Text = string.Empty;
            txtPosition.Text = string.Empty;
            txtContactInfo.Text = string.Empty;
        }
    }
}
