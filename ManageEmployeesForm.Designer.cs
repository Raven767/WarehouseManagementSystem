
namespace WarehouseManagementSystem
{
    partial class ManageEmployeesForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.employeeEdit = new System.Windows.Forms.Button();
            this.employeeDelete = new System.Windows.Forms.Button();
            this.employeeAdd = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Контакты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Должность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Имя";
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(280, 35);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(100, 20);
            this.txtContactInfo.TabIndex = 16;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(151, 35);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 20);
            this.txtPosition.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(24, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 14;
            // 
            // employeeEdit
            // 
            this.employeeEdit.Location = new System.Drawing.Point(243, 318);
            this.employeeEdit.Name = "employeeEdit";
            this.employeeEdit.Size = new System.Drawing.Size(75, 23);
            this.employeeEdit.TabIndex = 13;
            this.employeeEdit.Text = "изменить";
            this.employeeEdit.UseVisualStyleBackColor = true;
            this.employeeEdit.Click += new System.EventHandler(this.employeeEdit_Click);
            // 
            // employeeDelete
            // 
            this.employeeDelete.Location = new System.Drawing.Point(116, 318);
            this.employeeDelete.Name = "employeeDelete";
            this.employeeDelete.Size = new System.Drawing.Size(75, 23);
            this.employeeDelete.TabIndex = 12;
            this.employeeDelete.Text = "удалить ";
            this.employeeDelete.UseVisualStyleBackColor = true;
            this.employeeDelete.Click += new System.EventHandler(this.employeeDelete_Click);
            // 
            // employeeAdd
            // 
            this.employeeAdd.Location = new System.Drawing.Point(24, 318);
            this.employeeAdd.Name = "employeeAdd";
            this.employeeAdd.Size = new System.Drawing.Size(75, 23);
            this.employeeAdd.TabIndex = 11;
            this.employeeAdd.Text = "добавить";
            this.employeeAdd.UseVisualStyleBackColor = true;
            this.employeeAdd.Click += new System.EventHandler(this.employeeAdd_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(24, 117);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewEmployees.TabIndex = 10;
            // 
            // ManageEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.employeeEdit);
            this.Controls.Add(this.employeeDelete);
            this.Controls.Add(this.employeeAdd);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "ManageEmployeesForm";
            this.Text = "ManageEmployeesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button employeeEdit;
        private System.Windows.Forms.Button employeeDelete;
        private System.Windows.Forms.Button employeeAdd;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
    }
}