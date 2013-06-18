using System;
using System.Windows.Forms;

namespace Autosaloon
{
    public partial class CreateApplicationForm : Form
    {
        public Applications Application { get; private set; }
        private readonly Car _car;
        public CreateApplicationForm(Car car)
        {
            _car = car;
            InitializeComponent();
        }

        private void CreateApplicationButton_Click(object sender, System.EventArgs e)
        {
            if (ApplicationInStockRadioButton.Checked)
            {
                Application = new UIApplicationsInStock(NameOfBuyerTextBox.Text, _car);
                    {

                    }
            }
            if (ApplicationOfDeliveryRadioButton.Checked)
            {
                Application = new UIApplicationsForDelayedDelivery(NameOfBuyerTextBox.Text, _car,
                                                                   Convert.ToInt32(PercentTextBox.Text))
                    {
                        CellNumber = CallNumberTextBox.Text
                    };
            }

        }

        private void ApplicationOfDeliveryRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            PercentTextBox.Enabled =true;
        }


        private static void GetNumberValue(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void PercentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetNumberValue(e);
        }
        
    }
}
