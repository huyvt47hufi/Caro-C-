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
    public partial class VD1 : Form
    {
        Panel pn;
        public VD1()
        {
            InitializeComponent();
            InitComponent();
        }

        private void InitComponent()
        {
            Button b = new Button();
            b.Name = "btn1";
            b.Text = "button 1";
            b.Size = new Size(60,40);
            b.Left = 30;
            b.Top = 30;
            this.Controls.Add(b);
            b.Click += new System.EventHandler(bt_Clicks);
        }

        private void bt_Clicks(object sender, EventArgs e)
        {
            //MessageBox.Show("Đã click");
            foreach (Control item in this.Controls)
            {
                if (this.GetType() == typeof(Button))
                {
                    MessageBox.Show( "Có button");
                }
            }
        }
    }
}
