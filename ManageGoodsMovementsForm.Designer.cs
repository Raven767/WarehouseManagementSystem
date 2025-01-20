
namespace WarehouseManagementSystem
{
    partial class ManageGoodsMovementsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeeEdit = new System.Windows.Forms.Button();
            this.employeeDelete = new System.Windows.Forms.Button();
            this.employeeAdd = new System.Windows.Forms.Button();
            this.dataGridViewGoodsMovements = new System.Windows.Forms.DataGridView();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dateTimePickerMovementDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSourceUnit = new System.Windows.Forms.ComboBox();
            this.cmbTargetUnit = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoodsMovements)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeEdit
            // 
            this.employeeEdit.Location = new System.Drawing.Point(117, 327);
            this.employeeEdit.Name = "employeeEdit";
            this.employeeEdit.Size = new System.Drawing.Size(75, 23);
            this.employeeEdit.TabIndex = 17;
            this.employeeEdit.Text = "изменить";
            this.employeeEdit.UseVisualStyleBackColor = true;
            this.employeeEdit.Click += new System.EventHandler(this.employeeEdit_Click);
            // 
            // employeeDelete
            // 
            this.employeeDelete.Location = new System.Drawing.Point(198, 327);
            this.employeeDelete.Name = "employeeDelete";
            this.employeeDelete.Size = new System.Drawing.Size(75, 23);
            this.employeeDelete.TabIndex = 16;
            this.employeeDelete.Text = "удалить ";
            this.employeeDelete.UseVisualStyleBackColor = true;
            this.employeeDelete.Click += new System.EventHandler(this.employeeDelete_Click);
            // 
            // employeeAdd
            // 
            this.employeeAdd.Location = new System.Drawing.Point(27, 327);
            this.employeeAdd.Name = "employeeAdd";
            this.employeeAdd.Size = new System.Drawing.Size(75, 23);
            this.employeeAdd.TabIndex = 15;
            this.employeeAdd.Text = "добавить";
            this.employeeAdd.UseVisualStyleBackColor = true;
            this.employeeAdd.Click += new System.EventHandler(this.employeeAdd_Click);
            // 
            // dataGridViewGoodsMovements
            // 
            this.dataGridViewGoodsMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoodsMovements.Location = new System.Drawing.Point(27, 126);
            this.dataGridViewGoodsMovements.Name = "dataGridViewGoodsMovements";
            this.dataGridViewGoodsMovements.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewGoodsMovements.TabIndex = 14;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(286, 126);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(121, 21);
            this.cmbProduct.TabIndex = 18;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(27, 24);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 19;
            // 
            // dateTimePickerMovementDate
            // 
            this.dateTimePickerMovementDate.Location = new System.Drawing.Point(329, 45);
            this.dateTimePickerMovementDate.Name = "dateTimePickerMovementDate";
            this.dateTimePickerMovementDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerMovementDate.TabIndex = 20;
            // 
            // cmbSourceUnit
            // 
            this.cmbSourceUnit.FormattingEnabled = true;
            this.cmbSourceUnit.Location = new System.Drawing.Point(413, 126);
            this.cmbSourceUnit.Name = "cmbSourceUnit";
            this.cmbSourceUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbSourceUnit.TabIndex = 21;
            // 
            // cmbTargetUnit
            // 
            this.cmbTargetUnit.FormattingEnabled = true;
            this.cmbTargetUnit.Location = new System.Drawing.Point(540, 126);
            this.cmbTargetUnit.Name = "cmbTargetUnit";
            this.cmbTargetUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbTargetUnit.TabIndex = 22;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(667, 126);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(121, 21);
            this.cmbEmployee.TabIndex = 23;
            // 
            // ManageGoodsMovementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.cmbTargetUnit);
            this.Controls.Add(this.cmbSourceUnit);
            this.Controls.Add(this.dateTimePickerMovementDate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.employeeEdit);
            this.Controls.Add(this.employeeDelete);
            this.Controls.Add(this.employeeAdd);
            this.Controls.Add(this.dataGridViewGoodsMovements);
            this.Name = "ManageGoodsMovementsForm";
            this.Text = "ManageGoodsMovementsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoodsMovements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button employeeEdit;
        private System.Windows.Forms.Button employeeDelete;
        private System.Windows.Forms.Button employeeAdd;
        private System.Windows.Forms.DataGridView dataGridViewGoodsMovements;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dateTimePickerMovementDate;
        private System.Windows.Forms.ComboBox cmbSourceUnit;
        private System.Windows.Forms.ComboBox cmbTargetUnit;
        private System.Windows.Forms.ComboBox cmbEmployee;
    }
}