using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class FormShoppingCart : Form
    {
        public FormShoppingCart()
        {
            InitializeComponent();
        }

        private void FormShoppingCart_Load(object sender, EventArgs e)
        {
            Panel NewPanel = new Panel();
            //NewPanel = panel2;
            NewPanel.Location = new Point(200,80);
            NewPanel.Size = panel2.Size;
            //panel2.;

            this.Controls.Add(NewPanel);

        }

        /*-----------------------------------------<<dataGridView Row自動編號>>-----------------------------------------*/
        private void dataGV_CartView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGV_CartView.RowHeadersWidth - 4, e.RowBounds.Height);//指定範圍

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGV_CartView.RowHeadersDefaultCellStyle.Font, rectangle, dataGV_CartView.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);//繪製表格：(圖形物件,字體,圖形範圍,字體顏色,文字對齊)

        }
    }
}
