namespace OrderSystem
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelFormTitle = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNavIndicator = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.blbTabTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.honeyBearDBDataSet = new OrderSystem.HoneyBearDBDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new OrderSystem.HoneyBearDBDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new OrderSystem.HoneyBearDBDataSetTableAdapters.TableAdapterManager();
            this.panelFormTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honeyBearDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormTitle
            // 
            this.panelFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelFormTitle.Controls.Add(this.button3);
            this.panelFormTitle.Controls.Add(this.btnLogin);
            this.panelFormTitle.Controls.Add(this.btnExit);
            this.panelFormTitle.Controls.Add(this.pictureBox1);
            this.panelFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormTitle.Location = new System.Drawing.Point(0, 0);
            this.panelFormTitle.Name = "panelFormTitle";
            this.panelFormTitle.Size = new System.Drawing.Size(940, 60);
            this.panelFormTitle.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(810, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 60);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(849, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(38, 60);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(891, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 60);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pnlNavIndicator);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.btnPM);
            this.panel2.Controls.Add(this.btnEmployees);
            this.panel2.Controls.Add(this.btnCustomers);
            this.panel2.Controls.Add(this.btnShoppingCart);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 718);
            this.panel2.TabIndex = 1;
            // 
            // pnlNavIndicator
            // 
            this.pnlNavIndicator.Location = new System.Drawing.Point(0, 402);
            this.pnlNavIndicator.Name = "pnlNavIndicator";
            this.pnlNavIndicator.Size = new System.Drawing.Size(2, 92);
            this.pnlNavIndicator.TabIndex = 5;
            // 
            // btnSetting
            // 
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetting.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(0, 663);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(200, 55);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "Account Setting";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button10.ForeColor = System.Drawing.Color.IndianRed;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(0, 473);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(200, 55);
            this.button10.TabIndex = 7;
            this.button10.Text = "System Manage";
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btnPM
            // 
            this.btnPM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPM.FlatAppearance.BorderSize = 0;
            this.btnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPM.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPM.ForeColor = System.Drawing.Color.IndianRed;
            this.btnPM.Image = ((System.Drawing.Image)(resources.GetObject("btnPM.Image")));
            this.btnPM.Location = new System.Drawing.Point(0, 418);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(200, 55);
            this.btnPM.TabIndex = 6;
            this.btnPM.Text = "Products Manage";
            this.btnPM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmployees.ForeColor = System.Drawing.Color.IndianRed;
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.Location = new System.Drawing.Point(0, 363);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(200, 55);
            this.btnEmployees.TabIndex = 5;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCustomers.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.Location = new System.Drawing.Point(0, 308);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(200, 55);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customer\'s";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShoppingCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShoppingCart.FlatAppearance.BorderSize = 0;
            this.btnShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingCart.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShoppingCart.ForeColor = System.Drawing.Color.IndianRed;
            this.btnShoppingCart.Image = ((System.Drawing.Image)(resources.GetObject("btnShoppingCart.Image")));
            this.btnShoppingCart.Location = new System.Drawing.Point(0, 253);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(200, 55);
            this.btnShoppingCart.TabIndex = 3;
            this.btnShoppingCart.Text = "Shopping Cart";
            this.btnShoppingCart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnShoppingCart.UseVisualStyleBackColor = true;
            this.btnShoppingCart.Click += new System.EventHandler(this.btnShoppingCart_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMenu.ForeColor = System.Drawing.Color.IndianRed;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, 198);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 55);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHome.ForeColor = System.Drawing.Color.IndianRed;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 143);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 55);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 143);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 3);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 72);
            this.label5.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(59, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(82, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Designer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(80, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "CP Bear";
            // 
            // blbTabTitle
            // 
            this.blbTabTitle.AutoSize = true;
            this.blbTabTitle.BackColor = System.Drawing.Color.Transparent;
            this.blbTabTitle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.blbTabTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.blbTabTitle.Location = new System.Drawing.Point(15, 12);
            this.blbTabTitle.Name = "blbTabTitle";
            this.blbTabTitle.Size = new System.Drawing.Size(85, 31);
            this.blbTabTitle.TabIndex = 0;
            this.blbTabTitle.Text = "Home";
            this.blbTabTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.blbTabTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(200, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(740, 56);
            this.panel4.TabIndex = 2;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.webView21);
            this.panelContent.Location = new System.Drawing.Point(200, 116);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(740, 662);
            this.panelContent.TabIndex = 3;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(81, 50);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(75, 23);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // honeyBearDBDataSet
            // 
            this.honeyBearDBDataSet.DataSetName = "HoneyBearDBDataSet";
            this.honeyBearDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.honeyBearDBDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = OrderSystem.HoneyBearDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(940, 778);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelFormTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honeyBearDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label blbTabTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel pnlNavIndicator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private HoneyBearDBDataSet honeyBearDBDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private HoneyBearDBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private HoneyBearDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

