using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

//using System.Runtime.InteropServices;//未知物

namespace OrderSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'honeyBearDBDataSet.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.honeyBearDBDataSet.Products);
            openChildForm(new FormHome());

            //滑鼠移動視窗事件
            panelFormTitle.MouseDown += new MouseEventHandler(panelFormTitle_MouseDown);//賦予panelFormTitle一個事件(panelFormTitle_MouseDown)
            panelFormTitle.MouseUp += new MouseEventHandler(panelFormTitle_MouseUp);
            panelFormTitle.MouseMove += new MouseEventHandler(panelFormTitle_MouseMove);
        }

        /*-----------------------------------------<<Form的滑鼠拖曳>>-----------------------------------------*/
        //卡頓版
        /*private Point mouseDownLocation;//存放座標的Point
        private void panelFormTitle_MouseDown(object sender, MouseEventArgs e)
        {//當滑鼠按著panelFormTitle時會將滑鼠座標放到變數中
            mouseDownLocation = e.Location;
        }

        private void panelFormTitle_MouseUp(object sender, MouseEventArgs e)
        {//當滑鼠放開，panelFormTitle會被設定到新的位置
            int deltaX = e.Location.X - mouseDownLocation.X;
            int deltaY = e.Location.Y - mouseDownLocation.Y;
            this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
        }*/

        //滑順版
        //when hold panel1 can move all
        //variable define
        private bool isDragging = false;
        private Point MouseDownLocation;

        private void panelFormTitle_MouseDown(object sender, MouseEventArgs e)
        {//按下滑鼠時
            //detect mousedown variable
            isDragging = true;
            //catch sys location
            MouseDownLocation = e.Location;
        }
        
        private void panelFormTitle_MouseMove(object sender, MouseEventArgs e)
        {//即時移動更新
            if (isDragging)
            {
                //main alogorithm
                this.Location = new Point(this.Location.X + (e.X - MouseDownLocation.X), this.Location.Y + (e.Y - MouseDownLocation.Y));
                //視窗location + delta移動(滑鼠移動時的座標 - 按下滑鼠的location)
                //just update panelFormTitle
                this.Update();
            }
        }

        private void panelFormTitle_MouseUp(object sender, MouseEventArgs e)
        {//放開滑鼠時結束
            isDragging = false;
        }


        /*-----------------------------------------<<開啟子表單>>-----------------------------------------*/
        private Form activeForm = null;//確認表單是否開啟  //null表示還沒有子表單被開啟
        private void openChildForm(Form childForm)//開起子表單的方法
        {
            if (activeForm != null) activeForm.Close();//非null表示有子表單開啟中，要關掉
            activeForm = childForm;//指定要開啟的子表單

            childForm.TopLevel = false;//最上層視窗通常用來作為應用程式中的主要表單，故子表單不能設為最上層表單
            childForm.FormBorderStyle = FormBorderStyle.None;//設定子表單邊框為無
            childForm.Dock = DockStyle.Fill;//佇停模式：所有控制項的邊緣停駐到其內含控制項的所有邊緣，並且適當地調整大小

            panelContent.Controls.Add(childForm);//將表單加入panel顯示
            panelContent.Tag = childForm;//將標籤設為子表單名
            blbTabTitle.Text = childForm.Tag.ToString();
            childForm.BringToFront();//將表單放置到前面
            childForm.Show();//開啟子表單
        }

        private void btnHome_Click(object sender, EventArgs e)//開啟Home子表單
        {
            openChildForm(new FormHome());//呼叫開啟子表單方法，建立新表單物件
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMenu());
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            openChildForm(new FormShoppingCart());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCustomers());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEmployees());
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProductsManage());
        }

        private void btnExit_Click(object sender, EventArgs e)//關閉表單
        {
            Application.Exit();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAccountSetting());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            openChildForm(new FormLogin());
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.honeyBearDBDataSet);

        }
    }
}
