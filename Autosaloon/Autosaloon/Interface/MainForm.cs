using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Autosaloon.Classes;

namespace Autosaloon.Interface
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
            
            var car = (Car)CarsListBox.SelectedItem;
            if (car == null)
            {
                ClearCarPanel();
                return;
            }
            CarNameTextBox.Text = car.Name;
            NumberOfPassegerTextBox.Text = car.MaximumNumberOfPassengers.ToString();
            CostTextBox.Text = car.Cost.ToString();
            QuantityInStockTextBox.Text = car.QuantityInStock.ToString();
            AvailabilityValueLabel.Text = car.Availability ? "ДА" : "НЕТ";
            UpdateApplicationListBox(car);
        }

        private void ClearCarPanel()
        {
            CarNameTextBox.Text = "";
            NumberOfPassegerTextBox.Text = "";
            CostTextBox.Text = "";
            QuantityInStockTextBox.Text = "";
            AvailabilityValueLabel.Text = "Выберите автомобиль.";
        }

        private void ChangeAutosaloonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newAvtosaloon = new NewAutosaloonForm();
            newAvtosaloon.ShowDialog();
            if (newAvtosaloon.DialogResult == DialogResult.OK)
            {
                _saloon = newAvtosaloon.Autosaloon;
                UpdateCarsListBox();
                UpdateWindow();
            }
        }

        private void CarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_saloon == null)
            {
                MessageBox.Show("Сначала необходимо создать автосалон");
                return;
            }
            var carDialog = new CreateNewCarForm(_saloon);
            carDialog.ShowDialog();
            if (carDialog.DialogResult == DialogResult.OK)
            {
                UpdateCarsListBox();
                UpdateWindow();
            }
        }

        private void UpdateCarsListBox()
        {
            CarsListBox.Items.Clear();
            foreach (var car in _saloon.GetCars())
            {
                CarsListBox.Items.Add(car);
            }
        }

        private void UpdateApplicationListBox(Car car)
        {
            ApplicationListBox.Items.Clear();
            foreach (var application in car.GetApplications())
            {
                ApplicationListBox.Items.Add(application);
            }
        }

        private void CreateApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CarsListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите автомобиль из списка!");
                return;
            }
            var application = new CreateApplicationForm((Car)CarsListBox.SelectedItem);
            application.ShowDialog();
            if (application.DialogResult == DialogResult.OK)
            {
                UpdateApplicationListBox((Car)CarsListBox.SelectedItem);
            }
        }

        private void CalculateApplicationButton_Click(object sender, EventArgs e)
        {
            if (ApplicationListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите заявку из списка.");
                return;
            }
            var application = (Applications)ApplicationListBox.SelectedItem;
            var calculateApplication = new CalculateApplicationForm(application);
            calculateApplication.ShowDialog();
            if (calculateApplication.DialogResult == DialogResult.OK)
            {
                application.Car.RemoveApplication(application);
                UpdateApplicationListBox(application.Car);
            }
        }

        private void SaveAutosaloonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_saloon == null)
            {
                MessageBox.Show("Для сохранения необходимо наличие хоть однго автосалона!");
                return;
            }
            var saveAutosaloonFileDialog = new SaveFileDialog
                {
                    Title = "Сохранение Автосалона"
                };
            saveAutosaloonFileDialog.ShowDialog();

            if (saveAutosaloonFileDialog.FileName != "")
            {
                var formatter = new BinaryFormatter();
                using (
                    var fStream = new FileStream(saveAutosaloonFileDialog.FileName, FileMode.Create, FileAccess.Write,
                                                 FileShare.None))
                {
                    formatter.Serialize(fStream, _saloon);
                }
            }
            else
            {
                MessageBox.Show("Не указано имя файла.");
            }
        }

        private void DownloadAutosaloonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openAutosaloonFileDialog = new OpenFileDialog
                {
                    Title = "Выберите файл с Автосалоном"
                };
            openAutosaloonFileDialog.ShowDialog();
            if (openAutosaloonFileDialog.FileName != "")
            {
                var formatter = new BinaryFormatter();
                using (var fStream = File.OpenRead(openAutosaloonFileDialog.FileName))
                {
                    _saloon = (Avtosaloon) formatter.Deserialize(fStream);
                }
                UpdateCarsListBox();
                UpdateWindow();
            }
            else
            {
                MessageBox.Show("Не указано имя файла.");
            }
        }

        private void CarsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (CarsListBox.SelectedItem == null)
            {
                return;
            }
            if (e.KeyCode == Keys.Delete)
            {
                var car = (Car)CarsListBox.SelectedItem;
                _saloon.RemoveCar(car);
                UpdateCarsListBox();
                UpdateWindow();
            }
        }

    }
}
