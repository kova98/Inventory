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
            
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                MessageBox.Show("The form is valid.");
            }
            else
            {
                MessageBox.Show("The form is invalid.");
            }
        }

        private bool IsFormValid()
        {
            if (nameTextBox.Text.Length == 0)
            {
                return false;
            }

            if (priceTextBox.Text.Length == 0)
            {
                return false;
            }

            if (categoryDropDown.SelectedItem == null)
            {
                return false;
            }

            if (companyTextBox.Text.Length == 0)
            {
                return false;
            }

            if (!decimal.TryParse(priceTextBox.Text, out var num))
            {
                return false;
            }

            return true;
        }

    }
}
