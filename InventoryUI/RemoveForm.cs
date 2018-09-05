using InventoryLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryLibrary.Models;

namespace InventoryUI
{
    public partial class RemoveForm : Form
    {
        IMainForm mainForm;

        public RemoveForm(IMainForm form)
        {
            InitializeComponent();

            mainForm = form;
        }

        private void RemoveForm_Load(object sender, EventArgs e)
        {
            WireUpList();
        }

        private void WireUpList()
        {
            itemDropDown.DataSource = null;
            itemDropDown.DataSource = DatabaseConnector.Items;
            itemDropDown.DisplayMember = "Name";

            mainForm.UpdateItemList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var item = (Item)itemDropDown.SelectedItem;
            int amount = (int)amountUpDown.Value;

            if (item != null)
            {
                DatabaseConnector.RemoveItem(item, amount);

                WireUpList();
                itemAmountLabel.Text = item.Amount.ToString();
            }

        }

        private void itemDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Item)itemDropDown.SelectedItem;

            itemAmountLabel.Text = item.Amount.ToString();
        }
    }
}
