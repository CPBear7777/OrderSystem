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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.honeyBearDBDataSet);

        }

        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.honeyBearDBDataSet);

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'honeyBearDBDataSet.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.honeyBearDBDataSet.Products);

        }
    }
}
