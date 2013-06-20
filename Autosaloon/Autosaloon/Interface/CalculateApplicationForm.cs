using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosaloon
{
    public partial class CalculateApplicationForm : Form
    {
        private Applications _application;
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
    }
}
