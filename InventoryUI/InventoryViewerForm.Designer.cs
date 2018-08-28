namespace InventoryUI
{
    partial class InventoryViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryViewerForm));
            this.categoryLabel = new System.Windows.Forms.Label();
            this.restockButton = new System.Windows.Forms.Button();
            this.inventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.editItemsButton = new System.Windows.Forms.Button();
            this.editCategoriesButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchCategoryTextBox = new System.Windows.Forms.TextBox();
            this.searchCategoryLabel = new System.Windows.Forms.Label();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGrid)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.categoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.categoryLabel.Location = new System.Drawing.Point(1, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(133, 40);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category";
            // 
            // restockButton
            // 
            this.restockButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.restockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.restockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.restockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restockButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.restockButton.Location = new System.Drawing.Point(12, 22);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(139, 113);
            this.restockButton.TabIndex = 1;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = true;
            // 
            // inventoryDataGrid
            // 
            this.inventoryDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.inventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.nameColumn,
            this.categoryColumn,
            this.companyColumn,
            this.priceColumn,
            this.stockColumn});
            this.inventoryDataGrid.GridColor = System.Drawing.Color.Silver;
            this.inventoryDataGrid.Location = new System.Drawing.Point(157, 141);
            this.inventoryDataGrid.Name = "inventoryDataGrid";
            this.inventoryDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.inventoryDataGrid.RowHeadersVisible = false;
            this.inventoryDataGrid.Size = new System.Drawing.Size(797, 436);
            this.inventoryDataGrid.TabIndex = 2;
            // 
            // removeButton
            // 
            this.removeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.removeButton.Location = new System.Drawing.Point(157, 22);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(139, 113);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // editItemsButton
            // 
            this.editItemsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editItemsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.editItemsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.editItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editItemsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItemsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.editItemsButton.Location = new System.Drawing.Point(302, 22);
            this.editItemsButton.Name = "editItemsButton";
            this.editItemsButton.Size = new System.Drawing.Size(139, 113);
            this.editItemsButton.TabIndex = 4;
            this.editItemsButton.Text = "Edit Items";
            this.editItemsButton.UseVisualStyleBackColor = true;
            // 
            // editCategoriesButton
            // 
            this.editCategoriesButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editCategoriesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.editCategoriesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.editCategoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCategoriesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCategoriesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.editCategoriesButton.Location = new System.Drawing.Point(447, 22);
            this.editCategoriesButton.Name = "editCategoriesButton";
            this.editCategoriesButton.Size = new System.Drawing.Size(181, 113);
            this.editCategoriesButton.TabIndex = 5;
            this.editCategoriesButton.Text = "Edit Categories";
            this.editCategoriesButton.UseVisualStyleBackColor = true;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchCategoryTextBox);
            this.searchGroupBox.Controls.Add(this.searchCategoryLabel);
            this.searchGroupBox.Controls.Add(this.searchNameTextBox);
            this.searchGroupBox.Controls.Add(this.searchNameLabel);
            this.searchGroupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.searchGroupBox.Location = new System.Drawing.Point(634, 8);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(320, 127);
            this.searchGroupBox.TabIndex = 6;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // searchCategoryTextBox
            // 
            this.searchCategoryTextBox.Location = new System.Drawing.Point(108, 84);
            this.searchCategoryTextBox.Name = "searchCategoryTextBox";
            this.searchCategoryTextBox.Size = new System.Drawing.Size(206, 35);
            this.searchCategoryTextBox.TabIndex = 4;
            // 
            // searchCategoryLabel
            // 
            this.searchCategoryLabel.AutoSize = true;
            this.searchCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.searchCategoryLabel.Location = new System.Drawing.Point(6, 84);
            this.searchCategoryLabel.Name = "searchCategoryLabel";
            this.searchCategoryLabel.Size = new System.Drawing.Size(96, 30);
            this.searchCategoryLabel.TabIndex = 3;
            this.searchCategoryLabel.Text = "Category";
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(108, 43);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(206, 35);
            this.searchNameTextBox.TabIndex = 2;
            // 
            // searchNameLabel
            // 
            this.searchNameLabel.AutoSize = true;
            this.searchNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.searchNameLabel.Location = new System.Drawing.Point(6, 43);
            this.searchNameLabel.Name = "searchNameLabel";
            this.searchNameLabel.Size = new System.Drawing.Size(69, 30);
            this.searchNameLabel.TabIndex = 1;
            this.searchNameLabel.Text = "Name";
            // 
            // categoryListBox
            // 
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.ItemHeight = 30;
            this.categoryListBox.Location = new System.Drawing.Point(-1, 49);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(139, 394);
            this.categoryListBox.TabIndex = 7;
            // 
            // categoryPanel
            // 
            this.categoryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPanel.Controls.Add(this.categoryListBox);
            this.categoryPanel.Controls.Add(this.categoryLabel);
            this.categoryPanel.Location = new System.Drawing.Point(12, 141);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(139, 436);
            this.categoryPanel.TabIndex = 8;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdColumn.Width = 40;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // categoryColumn
            // 
            this.categoryColumn.HeaderText = "Category";
            this.categoryColumn.Name = "categoryColumn";
            this.categoryColumn.ReadOnly = true;
            // 
            // companyColumn
            // 
            this.companyColumn.HeaderText = "Company";
            this.companyColumn.Name = "companyColumn";
            this.companyColumn.ReadOnly = true;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // stockColumn
            // 
            this.stockColumn.HeaderText = "Stock";
            this.stockColumn.Name = "stockColumn";
            this.stockColumn.ReadOnly = true;
            // 
            // InventoryViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 591);
            this.Controls.Add(this.categoryPanel);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.editCategoriesButton);
            this.Controls.Add(this.editItemsButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.inventoryDataGrid);
            this.Controls.Add(this.restockButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "InventoryViewerForm";
            this.Text = "Inventory Viewer";
            this.Load += new System.EventHandler(this.InventoryViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGrid)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.categoryPanel.ResumeLayout(false);
            this.categoryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.DataGridView inventoryDataGrid;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editItemsButton;
        private System.Windows.Forms.Button editCategoriesButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox searchCategoryTextBox;
        private System.Windows.Forms.Label searchCategoryLabel;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.Label searchNameLabel;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.Panel categoryPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockColumn;
    }
}

