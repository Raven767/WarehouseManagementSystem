
namespace WarehouseManagementSystem
{
    partial class ManageStorageUnitsForm
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
            this.dataGridViewStorageUnits = new System.Windows.Forms.DataGridView();
            this.storageUnitadd = new System.Windows.Forms.Button();
            this.storageUnitdelete = new System.Windows.Forms.Button();
            this.storageUnitedit = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtCurrentFill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorageUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStorageUnits
            // 
            this.dataGridViewStorageUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStorageUnits.Location = new System.Drawing.Point(27, 112);
            this.dataGridViewStorageUnits.Name = "dataGridViewStorageUnits";
            this.dataGridViewStorageUnits.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewStorageUnits.TabIndex = 0;
            // 
            // storageUnitadd
            // 
            this.storageUnitadd.Location = new System.Drawing.Point(27, 313);
            this.storageUnitadd.Name = "storageUnitadd";
            this.storageUnitadd.Size = new System.Drawing.Size(75, 23);
            this.storageUnitadd.TabIndex = 1;
            this.storageUnitadd.Text = "добавить";
            this.storageUnitadd.UseVisualStyleBackColor = true;
            this.storageUnitadd.Click += new System.EventHandler(this.storageUnitadd_Click);
            // 
            // storageUnitdelete
            // 
            this.storageUnitdelete.Location = new System.Drawing.Point(119, 313);
            this.storageUnitdelete.Name = "storageUnitdelete";
            this.storageUnitdelete.Size = new System.Drawing.Size(75, 23);
            this.storageUnitdelete.TabIndex = 2;
            this.storageUnitdelete.Text = "удалить ";
            this.storageUnitdelete.UseVisualStyleBackColor = true;
            this.storageUnitdelete.Click += new System.EventHandler(this.storageUnitdelete_Click);
            // 
            // storageUnitedit
            // 
            this.storageUnitedit.Location = new System.Drawing.Point(246, 313);
            this.storageUnitedit.Name = "storageUnitedit";
            this.storageUnitedit.Size = new System.Drawing.Size(75, 23);
            this.storageUnitedit.TabIndex = 3;
            this.storageUnitedit.Text = "изменить";
            this.storageUnitedit.UseVisualStyleBackColor = true;
            this.storageUnitedit.Click += new System.EventHandler(this.storageUnitedit_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(27, 30);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 4;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(154, 30);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtCapacity.TabIndex = 5;
            // 
            // txtCurrentFill
            // 
            this.txtCurrentFill.Location = new System.Drawing.Point(283, 30);
            this.txtCurrentFill.Name = "txtCurrentFill";
            this.txtCurrentFill.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentFill.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Местоположение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Вместимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Текущее заполнение";
            // 
            // ManageStorageUnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurrentFill);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.storageUnitedit);
            this.Controls.Add(this.storageUnitdelete);
            this.Controls.Add(this.storageUnitadd);
            this.Controls.Add(this.dataGridViewStorageUnits);
            this.Name = "ManageStorageUnitsForm";
            this.Text = "ManageStorageUnitsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorageUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStorageUnits;
        private System.Windows.Forms.Button storageUnitadd;
        private System.Windows.Forms.Button storageUnitdelete;
        private System.Windows.Forms.Button storageUnitedit;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtCurrentFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}