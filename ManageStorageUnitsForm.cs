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
    public partial class ManageStorageUnitsForm : Form
    {
        private List<StorageUnit> _storageUnits; // Список складских ячеек
        public ManageStorageUnitsForm()
        {
            InitializeComponent();
            _storageUnits = new List<StorageUnit>();
            AddSampleStorageUnits(); // Добавляем примеры ячеек
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridViewStorageUnits.AutoGenerateColumns = false;
            dataGridViewStorageUnits.Columns.Add("StorageUnitID", "ID");
            dataGridViewStorageUnits.Columns.Add("Location", "Местоположение");
            dataGridViewStorageUnits.Columns.Add("Capacity", "Вместимость");
            dataGridViewStorageUnits.Columns.Add("CurrentFill", "Текущее заполнение");

            dataGridViewStorageUnits.Columns["StorageUnitID"].DataPropertyName = "StorageUnitID";
            dataGridViewStorageUnits.Columns["Location"].DataPropertyName = "Location";
            dataGridViewStorageUnits.Columns["Capacity"].DataPropertyName = "Capacity";
            dataGridViewStorageUnits.Columns["CurrentFill"].DataPropertyName = "CurrentFill";

            dataGridViewStorageUnits.DataSource = _storageUnits;
        }

        private void AddSampleStorageUnits()
        {
            _storageUnits.Add(new StorageUnit
            {
                StorageUnitID = 1,
                Location = "Ряд A, Полка 1",
                Capacity = 100,
                CurrentFill = 50
            });
            _storageUnits.Add(new StorageUnit
            {
                StorageUnitID = 2,
                Location = "Ряд B, Полка 3",
                Capacity = 200,
                CurrentFill = 120
            });
        }


        private void storageUnitadd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var storageUnit = new StorageUnit
            {
                StorageUnitID = _storageUnits.Count + 1,
                Location = txtLocation.Text.Trim(),
                Capacity = int.Parse(txtCapacity.Text.Trim()),
                CurrentFill = int.Parse(txtCurrentFill.Text.Trim())
            };

            _storageUnits.Add(storageUnit);
            RefreshDataGridView();
            ClearFields();
        }

        private void storageUnitedit_Click(object sender, EventArgs e)
        {
            if (dataGridViewStorageUnits.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите ячейку для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFields())
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowIndex = dataGridViewStorageUnits.SelectedRows[0].Index;
            var storageUnit = _storageUnits[rowIndex];

            storageUnit.Location = txtLocation.Text.Trim();
            storageUnit.Capacity = int.Parse(txtCapacity.Text.Trim());
            storageUnit.CurrentFill = int.Parse(txtCurrentFill.Text.Trim());

            RefreshDataGridView();
            ClearFields();
        }

        private void storageUnitdelete_Click(object sender, EventArgs e)
        {

            if (dataGridViewStorageUnits.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите ячейку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowIndex = dataGridViewStorageUnits.SelectedRows[0].Index;
            _storageUnits.RemoveAt(rowIndex);

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridViewStorageUnits.DataSource = null;
            dataGridViewStorageUnits.DataSource = _storageUnits;
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtCapacity.Text) || !int.TryParse(txtCapacity.Text, out _))
                return false;
            if (string.IsNullOrWhiteSpace(txtCurrentFill.Text) || !int.TryParse(txtCurrentFill.Text, out _))
                return false;

            return true;
        }

        private void ClearFields()
        {
            txtLocation.Text = string.Empty;
            txtCapacity.Text = string.Empty;
            txtCurrentFill.Text = string.Empty;
        }
    }
}
