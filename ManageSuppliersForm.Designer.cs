
namespace WarehouseManagementSystem
{
    partial class ManageSuppliersForm
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.SupplierDelete = new System.Windows.Forms.Button();
            this.SupplierEdit = new System.Windows.Forms.Button();
            this.SupplierAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(310, 19);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 15;
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(165, 19);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(100, 20);
            this.txtContactInfo.TabIndex = 14;
            // 
            // SupplierDelete
            // 
            this.SupplierDelete.Location = new System.Drawing.Point(224, 335);
            this.SupplierDelete.Name = "SupplierDelete";
            this.SupplierDelete.Size = new System.Drawing.Size(75, 23);
            this.SupplierDelete.TabIndex = 12;
            this.SupplierDelete.Text = "удалить";
            this.SupplierDelete.UseVisualStyleBackColor = true;
            this.SupplierDelete.Click += new System.EventHandler(this.delete_Click);
            // 
            // SupplierEdit
            // 
            this.SupplierEdit.Location = new System.Drawing.Point(117, 335);
            this.SupplierEdit.Name = "SupplierEdit";
            this.SupplierEdit.Size = new System.Drawing.Size(75, 23);
            this.SupplierEdit.TabIndex = 11;
            this.SupplierEdit.Text = "редактировать";
            this.SupplierEdit.UseVisualStyleBackColor = true;
            this.SupplierEdit.Click += new System.EventHandler(this.edit_Click);
            // 
            // SupplierAdd
            // 
            this.SupplierAdd.Location = new System.Drawing.Point(12, 335);
            this.SupplierAdd.Name = "SupplierAdd";
            this.SupplierAdd.Size = new System.Drawing.Size(75, 23);
            this.SupplierAdd.TabIndex = 10;
            this.SupplierAdd.Text = "добавить";
            this.SupplierAdd.UseVisualStyleBackColor = true;
            this.SupplierAdd.Click += new System.EventHandler(this.SupplierAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(483, 208);
            this.dataGridViewSuppliers.TabIndex = 8;
            // 
            // ManageSuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.SupplierDelete);
            this.Controls.Add(this.SupplierEdit);
            this.Controls.Add(this.SupplierAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.Name = "ManageSuppliersForm";
            this.Text = "ManageSuppliersForm";
            this.Load += new System.EventHandler(this.ManageSuppliersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.Button SupplierDelete;
        private System.Windows.Forms.Button SupplierEdit;
        private System.Windows.Forms.Button SupplierAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
    }
}