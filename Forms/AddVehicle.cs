namespace Frotas_e_Fretes.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Net.NetworkInformation;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Model;
   
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {
            cmbType.DataSource = Data.VEHICLE_TYPES;
            cmbFuel.DataSource = Data.FUEL_TYPES;
            txtWheels.Text = "0";
            txtKMs.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = Factory.createNewVehicle(cmbType.SelectedValue.ToString());
            

            vehicle.Brand           = txtModel.Text;
            vehicle.ModelName       = txtModelName.Text;
            vehicle.Wheels          = Convert.ToInt32(txtWheels.Text);
            vehicle.Autonomy        = Convert.ToDouble(txtKMs.Text);
            vehicle.WeightSupported = Convert.ToDouble(txtWeight.Text);
            vehicle.FuelType = cmbFuel.SelectedValue.ToString();

            string selectedFuelType = cmbFuel.SelectedValue.ToString();
            var selectedFuel = Data.FUEL_PRICES.FirstOrDefault(f => f.name.Equals(selectedFuelType, StringComparison.OrdinalIgnoreCase));
            if (selectedFuel != null)
            {
                vehicle.FuelPrice = selectedFuel.price;
            }
            else
            {
                MessageBox.Show("Favor cadastrar valor do tipo de combustível", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                AddFuelForm fuelForm = new AddFuelForm();

                DialogResult result = fuelForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    
                    selectedFuel = Data.FUEL_PRICES.FirstOrDefault(f => f.name.Equals(selectedFuelType, StringComparison.OrdinalIgnoreCase));
                    if (selectedFuel != null)
                    {
                        vehicle.FuelPrice = selectedFuel.price;
                    }

                }
            }

            Data.VEHICLES.Add(vehicle);
            this.Close();

            //vehicle.showInfo();
        }
    }
}
