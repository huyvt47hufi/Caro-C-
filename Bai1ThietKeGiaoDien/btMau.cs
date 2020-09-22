using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1ThietKeGiaoDien
{
    public partial class btMau : Form
    {
        public btMau()
        {
            InitializeComponent();
            InitComponent();
        }

        private void InitComponent()
        {
            string[] foods = { "Grain", "Bread", "Beans", "Eggs", "Chicken", "Milk", "Fruit", "Vegetables", "Pasta", "Rice", "Fish", "Beef" };
            int topPosition = 10;
            foreach(string food in foods)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Left = 10;
                checkBox.Top = topPosition;
                topPosition += 30;
                checkBox.Text = food;
                Controls.Add(checkBox);
            }
        }
    }
}
