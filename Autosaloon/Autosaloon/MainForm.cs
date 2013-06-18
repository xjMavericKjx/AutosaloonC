using System;
using System.Windows.Forms;

namespace Autosaloon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Avtosaloon _saloon;
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CarsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWindow();
        }

        private void UpdateWindow()
        {
            Text = _saloon.Name;
            QuantityCarsInSaloonLabel.Text = _saloon.GetCars().Count.ToString();
            ApplicationListBox.Items.Clear();
            var car = (Car)CarsListBox.SelectedItem;
            if (car == null)
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

        private void ChangeAutosaloonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newAvtosaloon = new NewAutosaloonForm();
            newAvtosaloon.ShowDialog();
            if (newAvtosaloon.DialogResult == DialogResult.OK)
            {
                _saloon = newAvtosaloon.Autosaloon;
                CarsListBox.Items.Clear();
                foreach (var car in _saloon.GetCars())
                {
                    CarsListBox.Items.Add(car);
                }
            }
            UpdateWindow();
        }
    }
}
