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
    public partial class btMaub : Form
    {
        public btMaub()
        {
            InitializeComponent();
            InitComponent();

        }

        private void InitComponent()
        {
            string[] texts = { "textBox1", "textBox2", "textBox3", "textBox4" };
            int topPosit = 10;
            foreach(string text in texts)
            {
                TextBox tb = new TextBox();
                tb.Left = 10;
                tb.Top = topPosit;
                topPosit += 30;
                tb.Text = text;
                Controls.Add(tb);
            }
            createButton();
        }
        private void createButton()
        {
            Button bt = new Button();
            bt.Text = "Process Text Boxes";
            bt.Left = 10;
            bt.Top = 200;
            Controls.Add(bt);
            bt.Click += new System.EventHandler(bt_Click);
        }

        private void bt_Click(object sender, EventArgs e)
        {
            foreach(Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = string.Empty;
                }
            }
        }
    }
}
