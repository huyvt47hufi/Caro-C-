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
    public partial class Caro : Form
    {
        TextBox txt;
        Button bt,btcr;
        Boolean flag = true;
        int soLuongDongCot;
        public Caro()
        {
            InitializeComponent();
            InitComponent();
            this.Size = new Size(700, 500);
        }

        private void InitComponent()
        {
            bt = new Button();
            bt.Name = "Nut tao";
            bt.Text = "Tạo";
            bt.Size = new Size(50, 30);
            bt.Left = 30;
            bt.Top = 20;
            this.Controls.Add(bt);
            bt.Click += new System.EventHandler(bt_Click);

            txt = new TextBox();
            txt.Name = "O Nhap";
            txt.Text = "10";
            txt.Size = new Size(70,25);
            txt.Left = 30;
            txt.Top = 50;
            this.Controls.Add(txt);
        }
        private List<List<Button>> matrix;
        private void taoButtonCaro(String name,int w,int h,int l,int t,int tag)
        {
            btcr = new Button();
            btcr.Name = name;
            btcr.Size = new Size(w, h);
            btcr.Left = l;
            btcr.Top = t;
            this.Controls.Add(btcr);
            btcr.Click += new System.EventHandler(clickCaro);
            Tag = tag.ToString();
        }

        private void clickCaro(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text != "")
                return;
            if (flag == true)
            {
                btn.Text = "X";
                flag = false;
            } else
            if (flag == false)
            {
                btn.Text = "O";
                flag = true;
            }
            //if (isEndGame(btn))
            //{
            //    EndGame();
            //}
            int vt = Convert.ToInt32(btn.Tag);
            MessageBox.Show(btn.Name);
        }

        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        private void bt_Click(object sender, EventArgs e)
        {
            Matrix = new List<List<Button>>();
            int l = 30;
            int t = 100;
            soLuongDongCot = Convert.ToInt32(txt.Text);
            for (int i = 0; i < soLuongDongCot; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < soLuongDongCot; j++)
                {
                    string name = i + "," + j;
                    taoButtonCaro(name, 30, 30, l += 30, t, i);
                }
                l = 30;
                t += 30;
                Matrix[i].Add(btcr);
            }
            txt.Text = "";
        }

        private void EndGame()
        {
            MessageBox.Show("Ket thuc");
        }
        //private bool isEndGame(Button btn)
        //{
        //    return isEndHorizontal(btn) || isEndPrimaryDiagonal(btn) || isEndSubDiagonal(btn) || isEndVertical(btn);
        //}

        // Lay vi tri cua btn
        private Point GetChessPoint(Button btn)
        {
        
            String[] arrViTri = btn.Name.Split(',');
            int vertical = Convert.ToInt32(arrViTri[0]);
            int horizontal = Convert.ToInt32(arrViTri[1]);

            Point point = new Point(horizontal,vertical);

            return point;
        }

        //Ket thuc game o hang ngang
        //private bool isEndHorizontal(Button btn)
        //{
        //    Point point = GetChessPoint(btn);

        //    int countLeft = 0;
        //    for (int i = point.X; i>=0;  i--)
        //    {
        //        if (Matrix[point.Y][i].Text == btn.Text)
        //            countLeft++;
        //        else
        //            break;
        //    }
        //    int countRight = 0;
            
        //    for (int i = point.X+1; i<soLuongDongCot; i++)
        //    {
        //        if (Matrix[point.Y][i].Text == btn.Text)
        //            countRight++;
        //        else
        //            break;
        //    }

        //    return countLeft+countRight == 5;
        //}
        //Ket thuc game o hang doc
        private bool isEndVertical(Button btn)
        {
            return false;
        }
        //Ket thuc game o duong cheo chinh
        private bool isEndPrimaryDiagonal(Button btn)
        {
            return false;
        }
        private bool isEndSubDiagonal(Button btn)
        {
            return false;
        }
        

        
    }
}
