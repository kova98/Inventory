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
        IMainForm mainForm;
        public ItemListForm(IMainForm form)
        {
            InitializeComponent();

            mainForm = form;
        }

        private void ItemListForm_Load(object sender, EventArgs e)
        {
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
                WireUpLists(item);
                //ResetForm();
            }
        }

        private void ResetForm()
        {
            nameTextBox.Text = "";
            companyTextBox.Text = "";
            priceTextBox.Text = "";
            itemNameLabel.Text = "";

            if (categoryDropDown.Items.Count != 0)
            {
                categoryDropDown.SelectedItem = categoryDropDown.Items[0];
            }

            itemsListBox.SelectedItem = null;
        }

        private void WireUpLists(Item itemToSelect = null)
        {
            var itemSelected = (Item)itemsListBox.SelectedItem;

            if (itemToSelect != null)
            {
                var index = itemsListBox.Items.IndexOf(itemToSelect);
                itemsListBox.SelectedItem = itemsListBox.Items[index];
            }

            categoryDropDown.DataSource = null;
            categoryDropDown.DataSource = DatabaseConnector.Categories;
            categoryDropDown.DisplayMember = "Name";

            itemsListBox.DataSource = null;
            itemsListBox.DataSource = DatabaseConnector.Items;
            itemsListBox.DisplayMember = "Name";

            mainForm.UpdateItemList();
        }

        private bool IsFormValid()
        {
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a name.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                return false;
            }

            if (priceTextBox.Text.Length == 0 || !decimal.TryParse(priceTextBox.Text, out var num))
            {
                MessageBox.Show("Invalid price. \nPlease enter a valid value.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            var item = (Item)itemsListBox.SelectedItem;
            if (item != null)
            {
                var confirm = MessageBox.Show("Are you sure you want to remove the selected item? \n" +
                                          "This will permanently delete it from the database.",
                                          "Delete item",
                                          MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    DatabaseConnector.DeleteItem(item);
                    WireUpLists();
                }
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
                    categoryDropDown.SelectedItem = GetCategoryById(categoryDropDown, item.Category.Id);
                }
            }
        }

        private object GetCategoryById(ComboBox box, int id)
        {
            foreach (object obj in box.Items)
            {
                var category = (ItemCategory)obj;
                if (category.Id == id)
                {
                    return category;
                }
            }

            return null;
        }

        private void createNewItemButton_Click(object sender, EventArgs e)
        {
            var item = new Item
            {
                Name = "New Item",
                Category = DatabaseConnector.Categories.FirstOrDefault(),
                Company = "",
                Price = 0
            };

            DatabaseConnector.AddItem(item);

            ResetForm();
            WireUpLists();

            int lastIndex = itemsListBox.Items.Count - 1;
            itemsListBox.SelectedItem = itemsListBox.Items[lastIndex];
        }
    }
}
