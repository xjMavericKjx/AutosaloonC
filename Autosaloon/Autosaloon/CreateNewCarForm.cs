using System;
using System.Windows.Forms;

namespace Autosaloon
{
    public partial class CreateNewCarForm : Form
    {
        private Avtosaloon _saloon;
        public Car Car { get; private set; }
        public CreateNewCarForm(Avtosaloon saloon)
        {
            _saloon = saloon;
            InitializeComponent();
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

        private void CreateCarButton_Click(object sender, EventArgs e)
        {
            Car = new Car(_saloon,Convert.ToInt32(QuantityInStockTextBox.Text));
            Car.Name = CarNameTextBox.Text;
            Car.MaximumNumberOfPassengers = Convert.ToInt32(NumberOfPassegerTextBox.Text);
            Car.Cost = Convert.ToInt32(CostTextBox.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
