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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryViewerForm));
            this.categoryLabel = new System.Windows.Forms.Label();
            this.restockButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editItemsButton = new System.Windows.Forms.Button();
            this.editCategoriesButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.inventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.searchGroupBox.SuspendLayout();
            this.categoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.categoryLabel.Location = new System.Drawing.Point(-1, -1);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(158, 40);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.restockButton.Size = new System.Drawing.Size(158, 74);
            this.restockButton.TabIndex = 1;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.removeButton.Location = new System.Drawing.Point(176, 22);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(149, 74);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editItemsButton
            // 
            this.editItemsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editItemsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.editItemsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.editItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editItemsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItemsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.editItemsButton.Location = new System.Drawing.Point(331, 22);
            this.editItemsButton.Name = "editItemsButton";
            this.editItemsButton.Size = new System.Drawing.Size(148, 74);
            this.editItemsButton.TabIndex = 4;
            this.editItemsButton.Text = "Edit Items";
            this.editItemsButton.UseVisualStyleBackColor = true;
            this.editItemsButton.Click += new System.EventHandler(this.editItemsButton_Click);
            // 
            // editCategoriesButton
            // 
            this.editCategoriesButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editCategoriesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.editCategoriesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.editCategoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCategoriesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCategoriesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.editCategoriesButton.Location = new System.Drawing.Point(485, 22);
            this.editCategoriesButton.Name = "editCategoriesButton";
            this.editCategoriesButton.Size = new System.Drawing.Size(143, 74);
            this.editCategoriesButton.TabIndex = 5;
            this.editCategoriesButton.Text = "Edit Categories";
            this.editCategoriesButton.UseVisualStyleBackColor = true;
            this.editCategoriesButton.Click += new System.EventHandler(this.editCategoriesButton_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchNameTextBox);
            this.searchGroupBox.Controls.Add(this.searchNameLabel);
            this.searchGroupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.searchGroupBox.Location = new System.Drawing.Point(634, 8);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(320, 88);
            this.searchGroupBox.TabIndex = 6;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
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
            this.categoryListBox.Size = new System.Drawing.Size(158, 394);
            this.categoryListBox.TabIndex = 7;
            this.categoryListBox.SelectedIndexChanged += new System.EventHandler(this.categoryListBox_SelectedIndexChanged);
            // 
            // categoryPanel
            // 
            this.categoryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPanel.Controls.Add(this.categoryListBox);
            this.categoryPanel.Controls.Add(this.categoryLabel);
            this.categoryPanel.Location = new System.Drawing.Point(12, 102);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(158, 436);
            this.categoryPanel.TabIndex = 8;
            // 
            // inventoryDataGrid
            // 
            this.inventoryDataGrid.AllowUserToAddRows = false;
            this.inventoryDataGrid.AllowUserToDeleteRows = false;
            this.inventoryDataGrid.AllowUserToResizeRows = false;
            this.inventoryDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.inventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGrid.Location = new System.Drawing.Point(176, 102);
            this.inventoryDataGrid.Name = "inventoryDataGrid";
            this.inventoryDataGrid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inventoryDataGrid.RowHeadersVisible = false;
            this.inventoryDataGrid.RowTemplate.Height = 35;
            this.inventoryDataGrid.Size = new System.Drawing.Size(778, 436);
            this.inventoryDataGrid.TabIndex = 9;
            // 
            // InventoryViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 549);
            this.Controls.Add(this.inventoryDataGrid);
            this.Controls.Add(this.categoryPanel);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.editCategoriesButton);
            this.Controls.Add(this.editItemsButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.restockButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "InventoryViewerForm";
            this.Text = "Inventory Viewer";
            this.Load += new System.EventHandler(this.InventoryViewerForm_Load);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.categoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editItemsButton;
        private System.Windows.Forms.Button editCategoriesButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.Label searchNameLabel;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.Panel categoryPanel;
        private System.Windows.Forms.DataGridView inventoryDataGrid;
    }
}

