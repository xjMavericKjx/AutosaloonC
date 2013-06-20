using System;
using System.Windows.Forms;
using Autosaloon.Classes;

namespace Autosaloon.Interface
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
                Application = new UIApplicationsInStock(NameOfBuyerTextBox.Text, _car)
                    {
                        CellNumber = CallNumberTextBox.Text
                    };
            }
            if (ApplicationOfDeliveryRadioButton.Checked)
            {
                Application = new UIApplicationsForDelayedDelivery(NameOfBuyerTextBox.Text, _car,
                                                                   Convert.ToInt32(PercentTextBox.Text))
                    {
                        CellNumber = CallNumberTextBox.Text
                    };
            }
            DialogResult = DialogResult.OK;
            Close();
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

        private void ApplicationInStockRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PercentTextBox.Enabled = false;
        }
        
    }
}
