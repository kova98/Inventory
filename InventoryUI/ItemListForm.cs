using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryLibrary.DataAccess;
using InventoryLibrary.Models;

namespace InventoryUI
{
    public partial class ItemListForm : Form
    {
        public ItemListForm()
        {
            InitializeComponent();
        }

        private void ItemListForm_Load(object sender, EventArgs e)
        {
            InventoryLibrary.InventoryManager.CreateDefaultCategory();

            WireUpLists();
            ResetForm();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedItem != null && IsFormValid())
            {
                var item = (Item)itemsListBox.SelectedItem;
                var itemToEdit = new Item
                {
                    Id = item.Id,
                    Name = nameTextBox.Text,
                    Category = (ItemCategory)categoryDropDown.SelectedItem,
                    Company = companyTextBox.Text,
                    Price = decimal.Parse(priceTextBox.Text)
                };

                DatabaseConnector.TryEditItem(itemToEdit);
                WireUpLists();
                ResetForm();
            }
        }

        private void ResetForm()
        {
            nameTextBox.Text = "";
            categoryDropDown.SelectedItem = categoryDropDown.Items[0];
            companyTextBox.Text = "";
            priceTextBox.Text = "";
            itemNameLabel.Text = "";
        }

        private void WireUpLists()
        {
            categoryDropDown.DataSource = null;
            categoryDropDown.DataSource = DatabaseConnector.Categories;
            categoryDropDown.DisplayMember = "Name";

            itemsListBox.DataSource = null;
            itemsListBox.DataSource = DatabaseConnector.Items;
            itemsListBox.DisplayMember = "Name";
            itemsListBox.SelectedItem = null;
        }

        private bool IsFormValid()
        {
            bool result = true;

            if (nameTextBox.Text.Length == 0)
            {
                result = false;
            }

            if (priceTextBox.Text.Length == 0)
            {
                result = false;
            }

            if (categoryDropDown.SelectedItem == null)
            {
                result = false;
            }

            if (companyTextBox.Text.Length == 0)
            {
                result = false;
            }

            if (!decimal.TryParse(priceTextBox.Text, out var num))
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
            var confirm = MessageBox.Show("Are you sure you want to remove the selected item? \n" +
                                          "This will permanently delete it from the database.",
                                          "Delete item",
                                          MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                DatabaseConnector.DeleteItem((Item)itemsListBox.SelectedItem);
                WireUpLists();
            }
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Item)itemsListBox.SelectedItem;

            if (item != null)
            { 
                itemNameLabel.Text = item.Name;
                nameTextBox.Text = item.Name;
                companyTextBox.Text = item.Company;
                priceTextBox.Text = item.Price.ToString();

                if (item.Category != null)
                {
                    var index = categoryDropDown.Items.IndexOf(item.Category);
                    categoryDropDown.SelectedItem = categoryDropDown.Items[index];
                }
            }
        }

        private void createNewItemButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                var item = new Item
                {
                    Name = nameTextBox.Text,
                    Category = (ItemCategory)categoryDropDown.SelectedItem,
                    Company = companyTextBox.Text,
                    Price = decimal.Parse(priceTextBox.Text)
                };

                DatabaseConnector.AddItem(item);

                ResetForm();
                WireUpLists();
            }  
        }
    }
}
