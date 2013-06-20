using System;
using System.Windows.Forms;
using Autosaloon.Classes;

namespace Autosaloon.Interface
{
    public partial class CreateNewCarForm : Form
    {
        private readonly Avtosaloon _saloon;
        public Car Car { get; private set; }
        public CreateNewCarForm(Avtosaloon saloon)
        {
            _saloon = saloon;
            InitializeComponent();
        }

        private void CreateCarButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CarNameTextBox.Text)
                && !String.IsNullOrEmpty(CostTextBox.Text)
                && !String.IsNullOrEmpty(NumberOfPassegerTextBox.Text))
            {
                Car = new Car(_saloon, Convert.ToInt32(QuantityInStockTextBox.Text))
                    {
                        Name = CarNameTextBox.Text,
                        MaximumNumberOfPassengers = Convert.ToInt32(NumberOfPassegerTextBox.Text),
                        Cost = Convert.ToInt32(CostTextBox.Text)
                    };
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Неуказаны необходимые поля.");
            }
        }

        private void NumberOfPassegerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetNumberValue(e);
        }

        private void CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetNumberValue(e);
        }

        private void QuantityInStockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetNumberValue(e);
        }

        private static void GetNumberValue(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
