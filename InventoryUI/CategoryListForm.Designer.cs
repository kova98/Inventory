namespace InventoryUI
{
    partial class categoryListForm
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
            this.createNewCategoryButton = new System.Windows.Forms.Button();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.editCategoryPanel = new System.Windows.Forms.Panel();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.editCategoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.categoriesListBox = new System.Windows.Forms.ListBox();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.editCategoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createNewCategoryButton
            // 
            this.createNewCategoryButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.createNewCategoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createNewCategoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createNewCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewCategoryButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewCategoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createNewCategoryButton.Location = new System.Drawing.Point(249, 351);
            this.createNewCategoryButton.Name = "createNewCategoryButton";
            this.createNewCategoryButton.Size = new System.Drawing.Size(226, 75);
            this.createNewCategoryButton.TabIndex = 18;
            this.createNewCategoryButton.Text = "Create New Category";
            this.createNewCategoryButton.UseVisualStyleBackColor = true;
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.removeSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.removeSelectedButton.Location = new System.Drawing.Point(249, 283);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(226, 62);
            this.removeSelectedButton.TabIndex = 17;
            this.removeSelectedButton.Text = "Remove Selected";
            this.removeSelectedButton.UseVisualStyleBackColor = true;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.saveChangesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.saveChangesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.saveChangesButton.Location = new System.Drawing.Point(249, 215);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(226, 62);
            this.saveChangesButton.TabIndex = 16;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            // 
            // editCategoryPanel
            // 
            this.editCategoryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editCategoryPanel.Controls.Add(this.categoryNameLabel);
            this.editCategoryPanel.Controls.Add(this.editCategoryLabel);
            this.editCategoryPanel.Controls.Add(this.nameLabel);
            this.editCategoryPanel.Controls.Add(this.nameTextBox);
            this.editCategoryPanel.Location = new System.Drawing.Point(249, 62);
            this.editCategoryPanel.Name = "editCategoryPanel";
            this.editCategoryPanel.Size = new System.Drawing.Size(226, 147);
            this.editCategoryPanel.TabIndex = 15;
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameLabel.Location = new System.Drawing.Point(3, 43);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(218, 27);
            this.categoryNameLabel.TabIndex = 5;
            this.categoryNameLabel.Text = "<category name>";
            this.categoryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editCategoryLabel
            // 
            this.editCategoryLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.editCategoryLabel.Location = new System.Drawing.Point(3, -1);
            this.editCategoryLabel.Name = "editCategoryLabel";
            this.editCategoryLabel.Size = new System.Drawing.Size(218, 44);
            this.editCategoryLabel.TabIndex = 4;
            this.editCategoryLabel.Text = "Edit Category";
            this.editCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nameLabel.Location = new System.Drawing.Point(5, 70);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 25);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(7, 98);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(206, 35);
            this.nameTextBox.TabIndex = 11;
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.ItemHeight = 30;
            this.categoriesListBox.Location = new System.Drawing.Point(20, 62);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(223, 364);
            this.categoriesListBox.TabIndex = 14;
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.categoriesLabel.Location = new System.Drawing.Point(12, 9);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(178, 47);
            this.categoriesLabel.TabIndex = 13;
            this.categoriesLabel.Text = "Categories";
            // 
            // categoryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 445);
            this.Controls.Add(this.createNewCategoryButton);
            this.Controls.Add(this.removeSelectedButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.editCategoryPanel);
            this.Controls.Add(this.categoriesListBox);
            this.Controls.Add(this.categoriesLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "categoryListForm";
            this.Text = "Categories";
            this.editCategoryPanel.ResumeLayout(false);
            this.editCategoryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewCategoryButton;
        private System.Windows.Forms.Button removeSelectedButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Panel editCategoryPanel;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.Label editCategoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ListBox categoriesListBox;
        private System.Windows.Forms.Label categoriesLabel;
    }
}