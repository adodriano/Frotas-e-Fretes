namespace Frotas_e_Fretes.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Model;
    public partial class AddFuelForm : Form
    {
        public AddFuelForm()
        {
            InitializeComponent();
        }

        private void AddFuelForm_Load(object sender, EventArgs e)
        {
            cmbFuel.DataSource = Data.FUEL_TYPES;
            txtPrice.Text = "0";

            this.buildListView();
        }

        private void btnAddFuel_Click(object sender, EventArgs e)
        {
            Fuel fuel = new Fuel();

            fuel.name = cmbFuel.SelectedValue.ToString();
            fuel.price = Convert.ToDouble(txtPrice.Text);

            Fuel.AddToList(fuel);

            this.buildListView();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        protected void buildListView()
        {
            listFuel.Clear();
            listFuel.View = View.Details;

            listFuel.Columns.Add("Tipo");
            listFuel.Columns.Add("Preço");

            listFuel.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (var item in Data.FUEL_PRICES)
            {
                listFuel.Items.Add(new ListViewItem(new string[] { item.name, item.price.ToString() }));
            }

            listFuel.Columns[0].Width = -1;
        }
    }
}
