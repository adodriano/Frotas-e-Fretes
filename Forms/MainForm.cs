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

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicle vehicleForm = new AddVehicle();
            vehicleForm.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewVehicles viewForm = new ViewVehicles();
            viewForm.Show();
        }

        private void btnAutonomy_Click(object sender, EventArgs e)
        {
            TravelAutonomyForm travelForm = new TravelAutonomyForm();
            travelForm.Show();
        }

        private void btnAddFuel_Click(object sender, EventArgs e)
        {
            AddFuelForm fuelForm = new AddFuelForm();
            fuelForm.Show();
        }
    }
}
