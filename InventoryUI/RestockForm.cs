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
    public partial class RestockForm : Form
    {
        public RestockForm()
        {
            InitializeComponent();
        }

        private void RestockForm_Load(object sender, EventArgs e)
        {
            WireUpList();
        }

        private void itemDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Item)itemDropDown.SelectedItem;

            itemAmountLabel.Text = item.Amount.ToString();
        }

        private void restockButton_Click(object sender, EventArgs e)
        {
            var item = (Item)itemDropDown.SelectedItem;
            int amount = (int)amountUpDown.Value;

            if (item != null)
            {
                item.Amount += amount;

                DatabaseConnector.TryEditItem(item);

                itemAmountLabel.Text = item.Amount.ToString();
            }
        }

        private void WireUpList()
        {
            itemDropDown.DataSource = null;
            itemDropDown.DataSource = DatabaseConnector.Items;
            itemDropDown.DisplayMember = "Name";
        }
    }
}
