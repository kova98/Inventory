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
using InventoryLibrary.Models;

namespace InventoryUI
{
    public partial class InventoryViewerForm : Form
    {
        public InventoryViewerForm()
        {
            InitializeComponent();
        }

        private void InventoryViewerForm_Load(object sender, EventArgs e)
        {
            searchNameTextBox.TextChanged += SearchBox_OnTextChanged;
            searchCategoryTextBox.TextChanged += SearchBox_OnTextChanged;
        }

        private void SearchBox_OnTextChanged(object sender, EventArgs e)
        {
            // TODO: Filter items based on the name and category in the boxes.
        }

        private void editCategoriesButton_Click(object sender, EventArgs e)
        {
            // TODO: Open the Edit Categories form.
        }

        private void editItemsButton_Click(object sender, EventArgs e)
        {
            // TODO: Open the Edit Items form.
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // TODO: Open the Remove form.
        }

        private void restockButton_Click(object sender, EventArgs e)
        {
            // TODO: Open the Restock form.
        }
    }
}
