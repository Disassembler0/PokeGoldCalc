using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PokeGoldCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            foreach (KeyValuePair<int, string> item in ItemCalc.Items)
                comboBoxItem.Items.Add(new Item(item.Key, item.Value));
        }

        private void CountItem(object sender, EventArgs e)
        {
            if (comboBoxItem.SelectedItem != null)
                textBoxResult.Text = ItemCalc.CountItem(((Item)comboBoxItem.SelectedItem).Id, (int)numericUpDownSlot.Value, (int)numericUpDownQty.Value);
        }
    }
}
