namespace OrderSystem
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPage_dessert = new System.Windows.Forms.TabPage();
            this.listView_Desserts = new System.Windows.Forms.ListView();
            this.tabPage_drinks = new System.Windows.Forms.TabPage();
            this.listView_Drinks = new System.Windows.Forms.ListView();
            this.tabPage_other = new System.Windows.Forms.TabPage();
            this.listView_Other = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList_Desserts = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxP_Info = new System.Windows.Forms.GroupBox();
            this.lbl_P_Element = new System.Windows.Forms.Label();
            this.lbl_P_Desc = new System.Windows.Forms.Label();
            this.lbl_P_Name = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_P_price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_OrderPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_OrderNum = new System.Windows.Forms.TextBox();
            this.btn_AddtoCart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_P_KeyType = new System.Windows.Forms.ComboBox();
            this.txt_P_KeyWord = new System.Windows.Forms.TextBox();
            this.btn_P_KeySearch = new System.Windows.Forms.Button();
            this.imageList_Drinks = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Other = new System.Windows.Forms.ImageList(this.components);
            this.tabControlMenu.SuspendLayout();
            this.tabPage_dessert.SuspendLayout();
            this.tabPage_drinks.SuspendLayout();
            this.tabPage_other.SuspendLayout();
            this.groupBoxP_Info.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名稱";
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlMenu.Controls.Add(this.tabPage_dessert);
            this.tabControlMenu.Controls.Add(this.tabPage_drinks);
            this.tabControlMenu.Controls.Add(this.tabPage_other);
            this.tabControlMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControlMenu.ItemSize = new System.Drawing.Size(105, 35);
            this.tabControlMenu.Location = new System.Drawing.Point(12, 89);
            this.tabControlMenu.Multiline = true;
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(533, 561);
            this.tabControlMenu.TabIndex = 2;
            this.tabControlMenu.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlMenu_DrawItem);
            // 
            // tabPage_dessert
            // 
            this.tabPage_dessert.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_dessert.Controls.Add(this.listView_Desserts);
            this.tabPage_dessert.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage_dessert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage_dessert.Location = new System.Drawing.Point(39, 4);
            this.tabPage_dessert.Name = "tabPage_dessert";
            this.tabPage_dessert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_dessert.Size = new System.Drawing.Size(490, 553);
            this.tabPage_dessert.TabIndex = 0;
            this.tabPage_dessert.Text = "　甜點　";
            // 
            // listView_Desserts
            // 
            this.listView_Desserts.BackColor = System.Drawing.Color.Bisque;
            this.listView_Desserts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Desserts.HideSelection = false;
            this.listView_Desserts.Location = new System.Drawing.Point(6, 6);
            this.listView_Desserts.Name = "listView_Desserts";
            this.listView_Desserts.Size = new System.Drawing.Size(517, 544);
            this.listView_Desserts.TabIndex = 2;
            this.listView_Desserts.UseCompatibleStateImageBehavior = false;
            this.listView_Desserts.ItemActivate += new System.EventHandler(this.listView_Desserts_ItemActivate);
            // 
            // tabPage_drinks
            // 
            this.tabPage_drinks.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_drinks.Controls.Add(this.listView_Drinks);
            this.tabPage_drinks.Location = new System.Drawing.Point(39, 4);
            this.tabPage_drinks.Name = "tabPage_drinks";
            this.tabPage_drinks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_drinks.Size = new System.Drawing.Size(490, 553);
            this.tabPage_drinks.TabIndex = 1;
            this.tabPage_drinks.Text = "　飲品　";
            // 
            // listView_Drinks
            // 
            this.listView_Drinks.BackColor = System.Drawing.Color.Bisque;
            this.listView_Drinks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Drinks.HideSelection = false;
            this.listView_Drinks.Location = new System.Drawing.Point(6, 6);
            this.listView_Drinks.Name = "listView_Drinks";
            this.listView_Drinks.Size = new System.Drawing.Size(517, 544);
            this.listView_Drinks.TabIndex = 1;
            this.listView_Drinks.UseCompatibleStateImageBehavior = false;
            this.listView_Drinks.ItemActivate += new System.EventHandler(this.listView_Drinks_ItemActivate);
            // 
            // tabPage_other
            // 
            this.tabPage_other.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_other.Controls.Add(this.listView_Other);
            this.tabPage_other.Location = new System.Drawing.Point(39, 4);
            this.tabPage_other.Name = "tabPage_other";
            this.tabPage_other.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_other.Size = new System.Drawing.Size(490, 553);
            this.tabPage_other.TabIndex = 2;
            this.tabPage_other.Text = "　其他　";
            // 
            // listView_Other
            // 
            this.listView_Other.BackColor = System.Drawing.Color.Bisque;
            this.listView_Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Other.HideSelection = false;
            this.listView_Other.Location = new System.Drawing.Point(6, 6);
            this.listView_Other.Name = "listView_Other";
            this.listView_Other.Size = new System.Drawing.Size(517, 544);
            this.listView_Other.TabIndex = 2;
            this.listView_Other.UseCompatibleStateImageBehavior = false;
            this.listView_Other.ItemActivate += new System.EventHandler(this.listView_Other_ItemActivate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "數量";
            // 
            // imageList_Desserts
            // 
            this.imageList_Desserts.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Desserts.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_Desserts.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBoxP_Info
            // 
            this.groupBoxP_Info.Controls.Add(this.lbl_P_Element);
            this.groupBoxP_Info.Controls.Add(this.lbl_P_Desc);
            this.groupBoxP_Info.Controls.Add(this.lbl_P_Name);
            this.groupBoxP_Info.Controls.Add(this.label12);
            this.groupBoxP_Info.Controls.Add(this.lbl_P_price);
            this.groupBoxP_Info.Controls.Add(this.label6);
            this.groupBoxP_Info.Controls.Add(this.label5);
            this.groupBoxP_Info.Controls.Add(this.label4);
            this.groupBoxP_Info.Controls.Add(this.label1);
            this.groupBoxP_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxP_Info.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxP_Info.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBoxP_Info.Location = new System.Drawing.Point(551, 12);
            this.groupBoxP_Info.Name = "groupBoxP_Info";
            this.groupBoxP_Info.Size = new System.Drawing.Size(178, 477);
            this.groupBoxP_Info.TabIndex = 6;
            this.groupBoxP_Info.TabStop = false;
            this.groupBoxP_Info.Text = "商品資訊";
            // 
            // lbl_P_Element
            // 
            this.lbl_P_Element.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_P_Element.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_P_Element.Location = new System.Drawing.Point(39, 343);
            this.lbl_P_Element.Name = "lbl_P_Element";
            this.lbl_P_Element.Size = new System.Drawing.Size(138, 102);
            this.lbl_P_Element.TabIndex = 8;
            this.lbl_P_Element.Text = "商品名稱商品名稱";
            // 
            // lbl_P_Desc
            // 
            this.lbl_P_Desc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_P_Desc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_P_Desc.Location = new System.Drawing.Point(39, 109);
            this.lbl_P_Desc.Name = "lbl_P_Desc";
            this.lbl_P_Desc.Size = new System.Drawing.Size(138, 214);
            this.lbl_P_Desc.TabIndex = 7;
            this.lbl_P_Desc.Text = "商品名稱商品名稱";
            // 
            // lbl_P_Name
            // 
            this.lbl_P_Name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_P_Name.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_P_Name.Location = new System.Drawing.Point(39, 51);
            this.lbl_P_Name.Name = "lbl_P_Name";
            this.lbl_P_Name.Size = new System.Drawing.Size(138, 20);
            this.lbl_P_Name.TabIndex = 6;
            this.lbl_P_Name.Text = "商品名稱商品名稱";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label12.Location = new System.Drawing.Point(145, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "元";
            // 
            // lbl_P_price
            // 
            this.lbl_P_price.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_P_price.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_P_price.Location = new System.Drawing.Point(54, 445);
            this.lbl_P_price.Name = "lbl_P_price";
            this.lbl_P_price.Size = new System.Drawing.Size(75, 20);
            this.lbl_P_price.TabIndex = 4;
            this.lbl_P_price.Text = "00000";
            this.lbl_P_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(6, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "成分";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(4, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "價格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "商品說明";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbl_OrderPrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_OrderNum);
            this.groupBox2.Controls.Add(this.btn_AddtoCart);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Location = new System.Drawing.Point(551, 495);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 155);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "訂購";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(142, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "個";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(142, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "元";
            // 
            // lbl_OrderPrice
            // 
            this.lbl_OrderPrice.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbl_OrderPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_OrderPrice.ForeColor = System.Drawing.Color.Bisque;
            this.lbl_OrderPrice.Location = new System.Drawing.Point(54, 74);
            this.lbl_OrderPrice.Name = "lbl_OrderPrice";
            this.lbl_OrderPrice.Size = new System.Drawing.Size(84, 22);
            this.lbl_OrderPrice.TabIndex = 9;
            this.lbl_OrderPrice.Text = "00000";
            this.lbl_OrderPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(7, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "小計";
            // 
            // txt_OrderNum
            // 
            this.txt_OrderNum.BackColor = System.Drawing.Color.SaddleBrown;
            this.txt_OrderNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_OrderNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_OrderNum.ForeColor = System.Drawing.Color.Bisque;
            this.txt_OrderNum.Location = new System.Drawing.Point(54, 30);
            this.txt_OrderNum.Name = "txt_OrderNum";
            this.txt_OrderNum.Size = new System.Drawing.Size(84, 22);
            this.txt_OrderNum.TabIndex = 7;
            this.txt_OrderNum.Text = "1";
            this.txt_OrderNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_AddtoCart
            // 
            this.btn_AddtoCart.BackColor = System.Drawing.Color.Bisque;
            this.btn_AddtoCart.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.btn_AddtoCart.FlatAppearance.BorderSize = 0;
            this.btn_AddtoCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddtoCart.Location = new System.Drawing.Point(13, 109);
            this.btn_AddtoCart.Name = "btn_AddtoCart";
            this.btn_AddtoCart.Size = new System.Drawing.Size(146, 32);
            this.btn_AddtoCart.TabIndex = 6;
            this.btn_AddtoCart.Text = "加入購物車";
            this.btn_AddtoCart.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_P_KeyType);
            this.groupBox1.Controls.Add(this.txt_P_KeyWord);
            this.groupBox1.Controls.Add(this.btn_P_KeySearch);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 71);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品查詢";
            // 
            // combo_P_KeyType
            // 
            this.combo_P_KeyType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo_P_KeyType.FormattingEnabled = true;
            this.combo_P_KeyType.Location = new System.Drawing.Point(331, 28);
            this.combo_P_KeyType.Name = "combo_P_KeyType";
            this.combo_P_KeyType.Size = new System.Drawing.Size(121, 29);
            this.combo_P_KeyType.TabIndex = 8;
            // 
            // txt_P_KeyWord
            // 
            this.txt_P_KeyWord.BackColor = System.Drawing.Color.SaddleBrown;
            this.txt_P_KeyWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_P_KeyWord.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_P_KeyWord.ForeColor = System.Drawing.Color.Bisque;
            this.txt_P_KeyWord.Location = new System.Drawing.Point(45, 29);
            this.txt_P_KeyWord.Name = "txt_P_KeyWord";
            this.txt_P_KeyWord.Size = new System.Drawing.Size(280, 26);
            this.txt_P_KeyWord.TabIndex = 7;
            this.txt_P_KeyWord.Text = "關鍵字";
            this.txt_P_KeyWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_P_KeySearch
            // 
            this.btn_P_KeySearch.BackColor = System.Drawing.Color.Bisque;
            this.btn_P_KeySearch.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.btn_P_KeySearch.FlatAppearance.BorderSize = 0;
            this.btn_P_KeySearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_P_KeySearch.Location = new System.Drawing.Point(458, 28);
            this.btn_P_KeySearch.Name = "btn_P_KeySearch";
            this.btn_P_KeySearch.Size = new System.Drawing.Size(69, 28);
            this.btn_P_KeySearch.TabIndex = 6;
            this.btn_P_KeySearch.Text = "搜尋";
            this.btn_P_KeySearch.UseVisualStyleBackColor = false;
            // 
            // imageList_Drinks
            // 
            this.imageList_Drinks.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Drinks.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_Drinks.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList_Other
            // 
            this.imageList_Other.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Other.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_Other.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(740, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxP_Info);
            this.Controls.Add(this.tabControlMenu);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.Tag = "Menu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPage_dessert.ResumeLayout(false);
            this.tabPage_drinks.ResumeLayout(false);
            this.tabPage_other.ResumeLayout(false);
            this.groupBoxP_Info.ResumeLayout(false);
            this.groupBoxP_Info.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPage_dessert;
        private System.Windows.Forms.TabPage tabPage_drinks;
        private System.Windows.Forms.ListView listView_Drinks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList_Desserts;
        private System.Windows.Forms.ListView listView_Desserts;
        private System.Windows.Forms.GroupBox groupBoxP_Info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_AddtoCart;
        private System.Windows.Forms.TextBox txt_OrderNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_OrderPrice;
        private System.Windows.Forms.Label lbl_P_Element;
        private System.Windows.Forms.Label lbl_P_Desc;
        private System.Windows.Forms.Label lbl_P_Name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_P_price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage_other;
        private System.Windows.Forms.ListView listView_Other;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combo_P_KeyType;
        private System.Windows.Forms.TextBox txt_P_KeyWord;
        private System.Windows.Forms.Button btn_P_KeySearch;
        private System.Windows.Forms.ImageList imageList_Drinks;
        private System.Windows.Forms.ImageList imageList_Other;
    }
}