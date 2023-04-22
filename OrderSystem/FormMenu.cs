using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OrderSystem
{
    public partial class FormMenu : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public int selectID = 0;

        List<int> list_P_Id = new List<int>();
        List<string> list_P_Name = new List<string>();
        List<string> list_P_Decs = new List<string>();
        List<string> list_P_Elem = new List<string>();
        List<int> list_P_Price = new List<int>();
        List<int> list_P_Quantity = new List<int>();
        List<int> list_P_SoldQuan = new List<int>();
        List<string> list_P_Type = new List<string>();
        List<string> list_P_Image = new List<string>();
        List<ListView> list_ListViews = new List<ListView>();
        List<ImageList> list_ImageList = new List<ImageList>();


        //string strDBConnectionString = "";
        public FormMenu()
        {
            InitializeComponent();
        }

         /*-----------------------------------------<<連線到資料庫>>-----------------------------------------*/
        private void FormMenu_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "HoneyBearDB";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            Console.WriteLine(GlobalVar.strDBConnectionString);

            list_ListViews.Add(listView_Desserts);
            list_ListViews.Add(listView_Drinks);
            list_ListViews.Add(listView_Other);

            list_ImageList.Add(imageList_Desserts);
            list_ImageList.Add(imageList_Drinks);
            list_ImageList.Add(imageList_Other);

            ReadProductDB();
            ShowPicture();
        }


        /*-----------------------------------------<<讀取商品資料庫>>-----------------------------------------*/
        void ReadProductDB()
        {
            SqlConnection scon = new SqlConnection(GlobalVar.strDBConnectionString);
            scon.Open();
            string strSQL = "select * from Products;";
            SqlCommand cmd = new SqlCommand(strSQL,scon);//(Sql指令, Sql連接字串)
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;

            while(reader.Read() == true)
            {
                //從資料庫先調取本次需要的資料即可
                list_P_Id.Add((int)reader["p_ID"]);
                list_P_Name.Add((string)reader["p_Name"]);
                list_P_Price.Add((int)reader["p_Price"]);
                list_P_Type.Add((string)reader["p_Type"]);
                //匯入圖片
                string picPath = Application.StartupPath + "\\P_image" + "\\" + (reader["p_Image"]);//直接指定專案資料夾內的路徑
                Image Image_P = Image.FromFile(picPath);
                //依照分類放到個別的imageList
                if ((string)reader["p_Type"] == "PType01") { imageList_Desserts.Images.Add(Image_P); }
                else if ((string)reader["p_Type"] == "PType02") { imageList_Drinks.Images.Add(Image_P); }
                else if ((string)reader["p_Type"] == "PType03") { imageList_Other.Images.Add(Image_P); }

                count ++;
            }
            reader.Close();
            scon.Close();
            Console.WriteLine($"讀取{count}筆資料");
        }

       

        /*-----------------------------------------<<顯示圖片>>-----------------------------------------*/
        void ShowPicture()
        {
            //1.放圖片
            for (int i = 0; i < list_ListViews.Count; i++)
            {
                list_ListViews[i].Items.Clear();//清空listView
                list_ListViews[i].View = View.LargeIcon;//指定顯示大或小圖示
                list_ImageList[i].ImageSize = new Size(120, 120);//圖片尺寸
                list_ListViews[i].LargeImageList = list_ImageList[i];//把圖片放到listView內
            }

            //2.根據ImageList，逐一放入文字
            int count = 0;

            for (int i = 0; i < list_ImageList.Count; i++)
            {
                for (int j = 0; j < list_ImageList[i].Images.Count; j++)
                {
                    ListViewItem item = new ListViewItem();//新增一個Item實體
                    item.ImageIndex = j;//指定item的index
                    item.Text = $"{list_P_Name[count]} {list_P_Price[count]}元";//把資訊放到item內
                    item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);//調整字體
                    item.Tag = list_P_Id[j];
                    list_ListViews[i].Items.Add(item);

                    count++;
                }
            }
        }

        

        /*-----------------------------------------<<Menu tabControl樣式設定>>-----------------------------------------*/
        private void tabControlMenu_DrawItem(object sender, DrawItemEventArgs e)
        {
            //標籤
            //設定文字樣式
            StringFormat StrFormat = new StringFormat();
            StrFormat.LineAlignment = StringAlignment.Center;//垂直置中
            StrFormat.Alignment = StringAlignment.Center;//水平置中   
            Font New_Font = new System.Drawing.Font("微軟正黑體", 16F,FontStyle.Bold);//標籤字體
            //SolidBrush筆刷，用於填選顏色
            SolidBrush Brush_Font = new SolidBrush(Color.Bisque);//標籤字體顏色
            SolidBrush Brush_Tab = new SolidBrush(Color.SaddleBrown);//標籤預設顏色(尚未被選的標籤)

            //繪置元件背景
            Bitmap Bitmap_TabControl = new Bitmap(tabControlMenu.Width, tabControlMenu.Height);//創建一個Bitmap點陣圖，指定其畫布尺寸
            Graphics Graphics_TabControl = Graphics.FromImage(Bitmap_TabControl);//讓點陣圖是可以被編輯繪製的
            Graphics_TabControl.FillRectangle(new SolidBrush(Color.SaddleBrown), 0, 0, tabControlMenu.Width, tabControlMenu.Height);
            e.Graphics.DrawImage(Bitmap_TabControl, 0, 0, tabControlMenu.Width, tabControlMenu.Height);
            //把image放到tabControl的圖形介面中(Graphics)內，採用DrawImage的方法

            //繪製所有標籤背景
            for (int i = 0; i < tabControlMenu.TabPages.Count; i++)
            {
                Rectangle recChild = tabControlMenu.GetTabRect(i);//獲取標籤區域
                e.Graphics.FillRectangle(Brush_Tab, recChild);//設定標籤顏色要實現的區域
                //設定標籤文字&顏色
                e.Graphics.DrawString(tabControlMenu.TabPages[i].Text, New_Font, Brush_Font, recChild, StrFormat);
                tabControlMenu.TabPages[i].BackColor = Color.Bisque;
            }
            //繪製被選取的標籤背景
            if (e.Index == tabControlMenu.SelectedIndex)
            {
                Rectangle recChild = tabControlMenu.GetTabRect(tabControlMenu.SelectedIndex);
                Brush_Tab = new SolidBrush(Color.Bisque);
                Brush_Font = new SolidBrush(Color.SaddleBrown);//標籤字體顏色
                e.Graphics.FillRectangle(Brush_Tab, recChild);
                e.Graphics.DrawString(tabControlMenu.TabPages[tabControlMenu.SelectedIndex].Text, New_Font, Brush_Font, recChild, StrFormat);
            }
        }

        private void listView_Desserts_ItemActivate(object sender, EventArgs e)
        {
            selectID = (int)listView_Desserts.SelectedItems[0].Tag;


        }

        private void listView_Drinks_ItemActivate(object sender, EventArgs e)
        {

        }

        private void listView_Other_ItemActivate(object sender, EventArgs e)
        {

        }



        //無效 待研究
        /*-----------------------------------------<<Menu tabControl樣式設定>>-----------------------------------------*/
        /*private void groupBoxP_Info_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(SystemColors.Control);
            e.Graphics.DrawString(groupBoxP_Info.Text, groupBoxP_Info.Font,Brushes.SaddleBrown, 8,20);
        }*/



    }
}
