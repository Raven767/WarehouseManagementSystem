
namespace WarehouseManagementSystem
{
    partial class ManageProductsForm
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterCategory = new System.Windows.Forms.TextBox();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(13, 59);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(483, 208);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(118, 329);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 3;
            this.edit.Text = "редактировать";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(225, 329);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 4;
            this.delete.Text = "удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Reserved",
            "Available"});
            this.cmbStatus.Location = new System.Drawing.Point(445, 13);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 5;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(166, 13);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 20);
            this.txtCategory.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(311, 13);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(539, 199);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "категория";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFilterCategory
            // 
            this.txtFilterCategory.Location = new System.Drawing.Point(539, 97);
            this.txtFilterCategory.Name = "txtFilterCategory";
            this.txtFilterCategory.Size = new System.Drawing.Size(100, 20);
            this.txtFilterCategory.TabIndex = 10;
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "Available",
            "Reserved",
            "All"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(539, 143);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbFilterStatus.TabIndex = 11;
            // 
            // ManageProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbFilterStatus);
            this.Controls.Add(this.txtFilterCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "ManageProductsForm";
            this.Text = "ManageProductsForm";
            this.Load += new System.EventHandler(this.ManageProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterCategory;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
    }
}