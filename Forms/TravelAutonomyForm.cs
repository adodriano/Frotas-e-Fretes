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
    using Frotas_e_Fretes.Model;

    public partial class TravelAutonomyForm : Form
    {
        public TravelAutonomyForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double distance = Convert.ToDouble(txtDistance.Text);
            double cargoWeight = Convert.ToDouble(txtWeight.Text);

            Vehicle idealVehicle = FindIdealVehicle(distance, cargoWeight);

            if (idealVehicle != null)
            {
                double deliveryCost = idealVehicle.CalculateDeliveryCost(distance, cargoWeight);

                lblVehicleInfo.Text = $"Tipo de Veículo: {idealVehicle.Type()}\nMarca: {idealVehicle.Brand}\nModelo: {idealVehicle.ModelName}";
                lblDeliveryCost.Text = $"Custo do Frete: R$ {deliveryCost:F2}";
            }
            else
            {

                lblVehicleInfo.Text = "Nenhum veículo adequado encontrado.";
                lblDeliveryCost.Text = "";
            }
        }

        private Vehicle FindIdealVehicle(double distance, double cargoWeight)
        {
            double minCost = double.MaxValue;
            Vehicle idealVehicle = null;

            foreach (var vehicle in Data.VEHICLES)
            {
                double cost = vehicle.CalculateDeliveryCost(distance, cargoWeight);

                if (cost < minCost)
                {
                    minCost = cost;
                    idealVehicle = vehicle;
                }
            }

            return idealVehicle;
        }
    }
}
