
namespace WarehouseManagementSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnManageSuppliers = new System.Windows.Forms.Button();
            this.btnManageEmployees = new System.Windows.Forms.Button();
            this.btnTrackMovements = new System.Windows.Forms.Button();
            this.OpenManageStorageUnits = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.Location = new System.Drawing.Point(39, 67);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(185, 23);
            this.btnManageProducts.TabIndex = 0;
            this.btnManageProducts.Text = "Управление товарами";
            this.btnManageProducts.UseVisualStyleBackColor = true;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);
            // 
            // btnManageSuppliers
            // 
            this.btnManageSuppliers.Location = new System.Drawing.Point(39, 96);
            this.btnManageSuppliers.Name = "btnManageSuppliers";
            this.btnManageSuppliers.Size = new System.Drawing.Size(185, 23);
            this.btnManageSuppliers.TabIndex = 1;
            this.btnManageSuppliers.Text = "Управление поставщиками";
            this.btnManageSuppliers.UseVisualStyleBackColor = true;
            this.btnManageSuppliers.Click += new System.EventHandler(this.btnManageSuppliers_Click);
            // 
            // btnManageEmployees
            // 
            this.btnManageEmployees.Location = new System.Drawing.Point(39, 125);
            this.btnManageEmployees.Name = "btnManageEmployees";
            this.btnManageEmployees.Size = new System.Drawing.Size(185, 23);
            this.btnManageEmployees.TabIndex = 2;
            this.btnManageEmployees.Text = "Управление сотрудниками";
            this.btnManageEmployees.UseVisualStyleBackColor = true;
            this.btnManageEmployees.Click += new System.EventHandler(this.btnManageEmployees_Click);
            // 
            // btnTrackMovements
            // 
            this.btnTrackMovements.Location = new System.Drawing.Point(39, 154);
            this.btnTrackMovements.Name = "btnTrackMovements";
            this.btnTrackMovements.Size = new System.Drawing.Size(185, 23);
            this.btnTrackMovements.TabIndex = 3;
            this.btnTrackMovements.Text = "Перемещения товаров";
            this.btnTrackMovements.UseVisualStyleBackColor = true;
            this.btnTrackMovements.Click += new System.EventHandler(this.btnTrackMovements_Click);
            // 
            // OpenManageStorageUnits
            // 
            this.OpenManageStorageUnits.Location = new System.Drawing.Point(39, 183);
            this.OpenManageStorageUnits.Name = "OpenManageStorageUnits";
            this.OpenManageStorageUnits.Size = new System.Drawing.Size(185, 23);
            this.OpenManageStorageUnits.TabIndex = 4;
            this.OpenManageStorageUnits.Text = "управление складом";
            this.OpenManageStorageUnits.UseVisualStyleBackColor = true;
            this.OpenManageStorageUnits.Click += new System.EventHandler(this.OpenManageStorageUnits_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(39, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 289);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.OpenManageStorageUnits);
            this.Controls.Add(this.btnTrackMovements);
            this.Controls.Add(this.btnManageEmployees);
            this.Controls.Add(this.btnManageSuppliers);
            this.Controls.Add(this.btnManageProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnManageSuppliers;
        private System.Windows.Forms.Button btnManageEmployees;
        private System.Windows.Forms.Button btnTrackMovements;
        private System.Windows.Forms.Button OpenManageStorageUnits;
        private System.Windows.Forms.Button btnExit;
    }
}

