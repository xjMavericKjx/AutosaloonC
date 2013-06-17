using System;
using System.Windows.Forms;

namespace Autosaloon
{
    public partial class MainForm : Form
    {
        public MainForm(Avtosaloon saloon)
        {
            _saloon = saloon;
            InitializeComponent();
        }

        private readonly Avtosaloon _saloon;
        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = _saloon.Name;
            foreach (var car in _saloon.GetCars())
            {
                CarsListBox.Items.Add(car);
            }
            QuantityCarsInSaloonLabel.Text = _saloon.GetCars().Count.ToString();
        }

        private void CarsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplicationListBox.Items.Clear();
            var listBox = (ListBox)sender;
            var car = (Car)listBox.SelectedItem;
            if (car==null)
            {
                return;
            }
            CarNameTextBox.Text = car.Name;
            NumberOfPassegerTextBox.Text = car.MaximumNumberOfPassengers.ToString();
            CostTextBox.Text = car.Cost.ToString();
            QuantityInStockTextBox.Text = car.QuantityInStock.ToString();
            AvailabilityValueLabel.Text = car.Availability ? "ДА" : "НЕТ";
            foreach (var application in car.GetApplications())
            {
                ApplicationListBox.Items.Add(application);
            }
        }
    }
}
