using InventoryLibrary.DataAccess;
using InventoryLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI
{
    public partial class categoryListForm : Form
    {
        public categoryListForm()
        {
            InitializeComponent();
        }

        private void categoryListForm_Load(object sender, EventArgs e)
        {
            WireUpList();
        }

        private void WireUpList()
        {
            categoriesListBox.DataSource = null;
            categoriesListBox.DataSource = DatabaseConnector.Categories;
            categoriesListBox.DisplayMember = "Name";
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (categoriesListBox.SelectedItem != null && IsFormValid())
            {
                var category = (ItemCategory)categoriesListBox.SelectedItem;
                var categoryToEdit = new ItemCategory
                {
                    Id = category.Id,
                    Name = nameTextBox.Text
                };

                DatabaseConnector.TryEditCategory(categoryToEdit);
                WireUpList();
                ResetForm();
            }
        }

        private bool IsFormValid()
        {
            bool result = true;

            if (nameTextBox.Text.Length == 0)
            {
                result = false;
            }

            if (result == false)
            {
                MessageBox.Show("Invalid form. \nPlease enter valid values.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }

            return result;
        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            var category = (ItemCategory)categoriesListBox.SelectedItem;
            if (category != null)
            {
                var confirm = MessageBox.Show("Are you sure you want to remove the selected category? \n" +
                                         "This will permanently delete it from the database.",
                                         "Delete category",
                                         MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    DatabaseConnector.DeleteCategory(category);
                    WireUpList();
                }
            }       
        }

        private void createNewCategoryButton_Click(object sender, EventArgs e)
        {
            var category = new ItemCategory
            {
                Name = "New Category"
            };

            DatabaseConnector.AddCategory(category);

            ResetForm();
            WireUpList();

            int lastIndex = categoriesListBox.Items.Count - 1;
            categoriesListBox.SelectedItem = categoriesListBox.Items[lastIndex];
        }

        private void ResetForm()
        {
            nameTextBox.Text = "";
            categoryNameLabel.Text = "";

            categoriesListBox.SelectedItem = null;
        }

        private void categoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = (ItemCategory)categoriesListBox.SelectedItem;

            if (category != null)
            {
                categoryNameLabel.Text = category.Name;
                nameTextBox.Text = category.Name;
            }
        }
    }
}
