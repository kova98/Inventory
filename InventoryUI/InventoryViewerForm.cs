using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryLibrary;
using InventoryLibrary.DataAccess;
using InventoryLibrary.Models;

namespace InventoryUI
{
    public partial class InventoryViewerForm : Form, IMainForm
    {
        const string categoryName = "CategoryName";
        List<Item> filtered = new List<Item>();

        public InventoryViewerForm()
        {
            InitializeComponent();
        }

        private void InventoryViewerForm_Load(object sender, EventArgs e)
        {
            WireUpDataGrid();

            filtered = DatabaseConnector.Items;

            PopulateCategoryList();
        }

        private void WireUpDataGrid()
        {
            inventoryDataGrid.DataSource = null;
            inventoryDataGrid.DataSource = DatabaseConnector.Items;

            SetDataGridSettings();
        }

        private void SetDataGridSettings()
        {
            inventoryDataGrid.Columns["Name"].Width = 240;
            inventoryDataGrid.Columns["Category"].Width = 190;
            inventoryDataGrid.Columns["Id"].Width = 50;

            inventoryDataGrid.Columns["Category"].DataPropertyName = categoryName;
            inventoryDataGrid.Columns.Remove("CategoryName");

            inventoryDataGrid.Columns["Amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void PopulateCategoryList()
        {
            categoryListBox.Items.Clear();

            categoryListBox.Items.Add(new ItemCategory { Name = "All Categories" });

            foreach (var cat in DatabaseConnector.Categories)
            {
                categoryListBox.Items.Add(cat);
            }

            categoryListBox.DisplayMember = "Name";
        }

        private void editCategoriesButton_Click(object sender, EventArgs e)
        {
            var form = new categoryListForm(this);
            form.Show();
        }

        private void editItemsButton_Click(object sender, EventArgs e)
        {
            var form = new ItemListForm(this);
            form.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var form = new RemoveForm(this);
            form.Show();
        }

        private void restockButton_Click(object sender, EventArgs e)
        {
            var form = new RestockForm(this);
            form.Show();
        }

        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = (ItemCategory)categoryListBox.SelectedItem;

            if (category.Name != "All Categories")
            {
                filtered = DatabaseConnector.Items.Where(x => x.CategoryName == category.Name).ToList();

                inventoryDataGrid.DataSource = null;
                inventoryDataGrid.Columns.Clear();
                inventoryDataGrid.DataSource = filtered;

                SetDataGridSettings();
            }
            else
            {
                inventoryDataGrid.Columns.Clear();
                inventoryDataGrid.DataSource = DatabaseConnector.Items;
                filtered = DatabaseConnector.Items;
                SetDataGridSettings();
            }   
        }

        public void UpdateCategoryList()
        {
            PopulateCategoryList();
        }

        public void UpdateItemList()
        {
            WireUpDataGrid();
        }

        private void searchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var text = searchNameTextBox.Text;
            var filteredWithText = filtered.Where(x => x.Name.Contains(text)).ToList();

            inventoryDataGrid.DataSource = null;
            inventoryDataGrid.Columns.Clear();
            inventoryDataGrid.DataSource = filteredWithText;

            SetDataGridSettings();
        }
    }
}
