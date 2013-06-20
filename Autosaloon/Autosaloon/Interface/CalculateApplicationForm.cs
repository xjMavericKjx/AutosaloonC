using System;
using System.Windows.Forms;
using Autosaloon.Classes;

namespace Autosaloon.Interface
{
    public partial class CalculateApplicationForm : Form
    {
        private readonly Applications _application;
        public CalculateApplicationForm(Applications application)
        {
            _application = application;
            InitializeComponent();
            NameOfBuyerValueLabel.Text = _application.NameOfBuyer;
            CallNumberValueLabel.Text = _application.CellNumber;
            CarInformationLabel.Text = "Модель: " + _application.Car.Name + ";\nЦена: " + _application.СalculateCost();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CanlcelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void CalculateApplicationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateButton.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                CanlcelButton.PerformClick();
            }
        }
    }
}
