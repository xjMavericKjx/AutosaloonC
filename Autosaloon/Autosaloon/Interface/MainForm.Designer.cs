namespace Autosaloon.Interface
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CarsPanel = new System.Windows.Forms.Panel();
            this.CarsLabel = new System.Windows.Forms.Label();
            this.CarsListBox = new System.Windows.Forms.ListBox();
            this.NumberOfCarsPanel = new System.Windows.Forms.Panel();
            this.QuantityCarsInSaloonLabel = new System.Windows.Forms.Label();
            this.QuantityCarsLabel = new System.Windows.Forms.Label();
            this.InforationPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.CarInformationTabPage = new System.Windows.Forms.TabPage();
            this.AvailabilityValueLabel = new System.Windows.Forms.Label();
            this.QuantityInStockTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfPassegerTextBox = new System.Windows.Forms.TextBox();
            this.CarNameTextBox = new System.Windows.Forms.TextBox();
            this.AvailabilityLabel = new System.Windows.Forms.Label();
            this.QuantityInStockLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.NumberOfPassegerLabel = new System.Windows.Forms.Label();
            this.CarNameLabel = new System.Windows.Forms.Label();
            this.ApplicatinsTabPage = new System.Windows.Forms.TabPage();
            this.CalculateApplicationButton = new System.Windows.Forms.Button();
            this.ApplicationListBox = new System.Windows.Forms.ListBox();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeAutosaloonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadAutosaloonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAutosaloonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarsPanel.SuspendLayout();
            this.NumberOfCarsPanel.SuspendLayout();
            this.InforationPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.CarInformationTabPage.SuspendLayout();
            this.ApplicatinsTabPage.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarsPanel
            // 
            this.CarsPanel.AutoSize = true;
            this.CarsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CarsPanel.Controls.Add(this.CarsLabel);
            this.CarsPanel.Controls.Add(this.CarsListBox);
            this.CarsPanel.Location = new System.Drawing.Point(12, 27);
            this.CarsPanel.Name = "CarsPanel";
            this.CarsPanel.Size = new System.Drawing.Size(146, 208);
            this.CarsPanel.TabIndex = 0;
            // 
            // CarsLabel
            // 
            this.CarsLabel.AutoSize = true;
            this.CarsLabel.Location = new System.Drawing.Point(4, 10);
            this.CarsLabel.Name = "CarsLabel";
            this.CarsLabel.Size = new System.Drawing.Size(120, 13);
            this.CarsLabel.TabIndex = 1;
            this.CarsLabel.Text = "Автомобили в салоне:";
            // 
            // CarsListBox
            // 
            this.CarsListBox.FormattingEnabled = true;
            this.CarsListBox.Location = new System.Drawing.Point(4, 32);
            this.CarsListBox.Name = "CarsListBox";
            this.CarsListBox.Size = new System.Drawing.Size(139, 173);
            this.CarsListBox.TabIndex = 0;
            this.CarsListBox.SelectedIndexChanged += new System.EventHandler(this.CarsListBox_SelectedIndexChanged);
            this.CarsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CarsListBox_KeyDown);
            // 
            // NumberOfCarsPanel
            // 
            this.NumberOfCarsPanel.AutoSize = true;
            this.NumberOfCarsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NumberOfCarsPanel.Controls.Add(this.QuantityCarsInSaloonLabel);
            this.NumberOfCarsPanel.Controls.Add(this.QuantityCarsLabel);
            this.NumberOfCarsPanel.Location = new System.Drawing.Point(12, 251);
            this.NumberOfCarsPanel.Name = "NumberOfCarsPanel";
            this.NumberOfCarsPanel.Size = new System.Drawing.Size(356, 33);
            this.NumberOfCarsPanel.TabIndex = 1;
            // 
            // QuantityCarsInSaloonLabel
            // 
            this.QuantityCarsInSaloonLabel.AutoSize = true;
            this.QuantityCarsInSaloonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.QuantityCarsInSaloonLabel.Location = new System.Drawing.Point(353, 13);
            this.QuantityCarsInSaloonLabel.Name = "QuantityCarsInSaloonLabel";
            this.QuantityCarsInSaloonLabel.Size = new System.Drawing.Size(0, 20);
            this.QuantityCarsInSaloonLabel.TabIndex = 1;
            // 
            // QuantityCarsLabel
            // 
            this.QuantityCarsLabel.AutoSize = true;
            this.QuantityCarsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.QuantityCarsLabel.Location = new System.Drawing.Point(47, 13);
            this.QuantityCarsLabel.Name = "QuantityCarsLabel";
            this.QuantityCarsLabel.Size = new System.Drawing.Size(291, 20);
            this.QuantityCarsLabel.TabIndex = 0;
            this.QuantityCarsLabel.Text = "Автомобилей доступно в салоне:";
            // 
            // InforationPanel
            // 
            this.InforationPanel.AutoSize = true;
            this.InforationPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InforationPanel.Controls.Add(this.tabControl);
            this.InforationPanel.Location = new System.Drawing.Point(166, 27);
            this.InforationPanel.Name = "InforationPanel";
            this.InforationPanel.Size = new System.Drawing.Size(305, 207);
            this.InforationPanel.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.CarInformationTabPage);
            this.tabControl.Controls.Add(this.ApplicatinsTabPage);
            this.tabControl.Location = new System.Drawing.Point(4, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(298, 194);
            this.tabControl.TabIndex = 0;
            // 
            // CarInformationTabPage
            // 
            this.CarInformationTabPage.Controls.Add(this.AvailabilityValueLabel);
            this.CarInformationTabPage.Controls.Add(this.QuantityInStockTextBox);
            this.CarInformationTabPage.Controls.Add(this.CostTextBox);
            this.CarInformationTabPage.Controls.Add(this.NumberOfPassegerTextBox);
            this.CarInformationTabPage.Controls.Add(this.CarNameTextBox);
            this.CarInformationTabPage.Controls.Add(this.AvailabilityLabel);
            this.CarInformationTabPage.Controls.Add(this.QuantityInStockLabel);
            this.CarInformationTabPage.Controls.Add(this.CostLabel);
            this.CarInformationTabPage.Controls.Add(this.NumberOfPassegerLabel);
            this.CarInformationTabPage.Controls.Add(this.CarNameLabel);
            this.CarInformationTabPage.Location = new System.Drawing.Point(4, 22);
            this.CarInformationTabPage.Name = "CarInformationTabPage";
            this.CarInformationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CarInformationTabPage.Size = new System.Drawing.Size(290, 168);
            this.CarInformationTabPage.TabIndex = 0;
            this.CarInformationTabPage.Text = "Информация об автомобиле";
            this.CarInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // AvailabilityValueLabel
            // 
            this.AvailabilityValueLabel.AutoSize = true;
            this.AvailabilityValueLabel.Location = new System.Drawing.Point(162, 128);
            this.AvailabilityValueLabel.Name = "AvailabilityValueLabel";
            this.AvailabilityValueLabel.Size = new System.Drawing.Size(0, 13);
            this.AvailabilityValueLabel.TabIndex = 9;
            // 
            // QuantityInStockTextBox
            // 
            this.QuantityInStockTextBox.Location = new System.Drawing.Point(148, 84);
            this.QuantityInStockTextBox.Name = "QuantityInStockTextBox";
            this.QuantityInStockTextBox.Size = new System.Drawing.Size(117, 20);
            this.QuantityInStockTextBox.TabIndex = 8;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(9, 84);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(121, 20);
            this.CostTextBox.TabIndex = 7;
            // 
            // NumberOfPassegerTextBox
            // 
            this.NumberOfPassegerTextBox.Location = new System.Drawing.Point(148, 30);
            this.NumberOfPassegerTextBox.Name = "NumberOfPassegerTextBox";
            this.NumberOfPassegerTextBox.Size = new System.Drawing.Size(117, 20);
            this.NumberOfPassegerTextBox.TabIndex = 6;
            // 
            // CarNameTextBox
            // 
            this.CarNameTextBox.Location = new System.Drawing.Point(9, 30);
            this.CarNameTextBox.Name = "CarNameTextBox";
            this.CarNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.CarNameTextBox.TabIndex = 5;
            // 
            // AvailabilityLabel
            // 
            this.AvailabilityLabel.AutoSize = true;
            this.AvailabilityLabel.Location = new System.Drawing.Point(42, 128);
            this.AvailabilityLabel.Name = "AvailabilityLabel";
            this.AvailabilityLabel.Size = new System.Drawing.Size(113, 13);
            this.AvailabilityLabel.TabIndex = 4;
            this.AvailabilityLabel.Text = "Доступен на складе:";
            // 
            // QuantityInStockLabel
            // 
            this.QuantityInStockLabel.AutoSize = true;
            this.QuantityInStockLabel.Location = new System.Drawing.Point(145, 68);
            this.QuantityInStockLabel.Name = "QuantityInStockLabel";
            this.QuantityInStockLabel.Size = new System.Drawing.Size(98, 13);
            this.QuantityInStockLabel.TabIndex = 3;
            this.QuantityInStockLabel.Text = "Кол-во на складе:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(6, 68);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(65, 13);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Стоимость:";
            // 
            // NumberOfPassegerLabel
            // 
            this.NumberOfPassegerLabel.AutoSize = true;
            this.NumberOfPassegerLabel.Location = new System.Drawing.Point(145, 13);
            this.NumberOfPassegerLabel.Name = "NumberOfPassegerLabel";
            this.NumberOfPassegerLabel.Size = new System.Drawing.Size(109, 13);
            this.NumberOfPassegerLabel.TabIndex = 1;
            this.NumberOfPassegerLabel.Text = "Кол-во пассажиров:";
            // 
            // CarNameLabel
            // 
            this.CarNameLabel.AutoSize = true;
            this.CarNameLabel.Location = new System.Drawing.Point(6, 13);
            this.CarNameLabel.Name = "CarNameLabel";
            this.CarNameLabel.Size = new System.Drawing.Size(107, 13);
            this.CarNameLabel.TabIndex = 0;
            this.CarNameLabel.Text = "Марка автомобиля:";
            // 
            // ApplicatinsTabPage
            // 
            this.ApplicatinsTabPage.Controls.Add(this.CalculateApplicationButton);
            this.ApplicatinsTabPage.Controls.Add(this.ApplicationListBox);
            this.ApplicatinsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ApplicatinsTabPage.Name = "ApplicatinsTabPage";
            this.ApplicatinsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicatinsTabPage.Size = new System.Drawing.Size(288, 168);
            this.ApplicatinsTabPage.TabIndex = 1;
            this.ApplicatinsTabPage.Text = "Заявки";
            this.ApplicatinsTabPage.UseVisualStyleBackColor = true;
            // 
            // CalculateApplicationButton
            // 
            this.CalculateApplicationButton.Location = new System.Drawing.Point(46, 133);
            this.CalculateApplicationButton.Name = "CalculateApplicationButton";
            this.CalculateApplicationButton.Size = new System.Drawing.Size(198, 28);
            this.CalculateApplicationButton.TabIndex = 1;
            this.CalculateApplicationButton.Text = "Расчитать споимость заявки";
            this.CalculateApplicationButton.UseVisualStyleBackColor = true;
            this.CalculateApplicationButton.Click += new System.EventHandler(this.CalculateApplicationButton_Click);
            // 
            // ApplicationListBox
            // 
            this.ApplicationListBox.FormattingEnabled = true;
            this.ApplicationListBox.Location = new System.Drawing.Point(6, 6);
            this.ApplicationListBox.Name = "ApplicationListBox";
            this.ApplicationListBox.Size = new System.Drawing.Size(278, 121);
            this.ApplicationListBox.TabIndex = 0;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.CreateToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(480, 24);
            this.MainMenuStrip.TabIndex = 3;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeAutosaloonToolStripMenuItem,
            this.DownloadAutosaloonToolStripMenuItem,
            this.SaveAutosaloonToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // ChangeAutosaloonToolStripMenuItem
            // 
            this.ChangeAutosaloonToolStripMenuItem.Name = "ChangeAutosaloonToolStripMenuItem";
            this.ChangeAutosaloonToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ChangeAutosaloonToolStripMenuItem.Text = "Добавить новый Автосалон";
            this.ChangeAutosaloonToolStripMenuItem.Click += new System.EventHandler(this.ChangeAutosaloonToolStripMenuItem_Click);
            // 
            // DownloadAutosaloonToolStripMenuItem
            // 
            this.DownloadAutosaloonToolStripMenuItem.Name = "DownloadAutosaloonToolStripMenuItem";
            this.DownloadAutosaloonToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.DownloadAutosaloonToolStripMenuItem.Text = "Загрузить Автосалон";
            this.DownloadAutosaloonToolStripMenuItem.Click += new System.EventHandler(this.DownloadAutosaloonToolStripMenuItem_Click);
            // 
            // SaveAutosaloonToolStripMenuItem
            // 
            this.SaveAutosaloonToolStripMenuItem.Name = "SaveAutosaloonToolStripMenuItem";
            this.SaveAutosaloonToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.SaveAutosaloonToolStripMenuItem.Text = "Сохранить Автосалон";
            this.SaveAutosaloonToolStripMenuItem.Click += new System.EventHandler(this.SaveAutosaloonToolStripMenuItem_Click);
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarToolStripMenuItem,
            this.CreateApplicationToolStripMenuItem});
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.CreateToolStripMenuItem.Text = "Создать";
            // 
            // CarToolStripMenuItem
            // 
            this.CarToolStripMenuItem.Name = "CarToolStripMenuItem";
            this.CarToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.CarToolStripMenuItem.Text = "Автомобиль";
            this.CarToolStripMenuItem.Click += new System.EventHandler(this.CarToolStripMenuItem_Click);
            // 
            // CreateApplicationToolStripMenuItem
            // 
            this.CreateApplicationToolStripMenuItem.Name = "CreateApplicationToolStripMenuItem";
            this.CreateApplicationToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.CreateApplicationToolStripMenuItem.Text = "Заявка на автомобиль";
            this.CreateApplicationToolStripMenuItem.Click += new System.EventHandler(this.CreateApplicationToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(480, 310);
            this.Controls.Add(this.InforationPanel);
            this.Controls.Add(this.NumberOfCarsPanel);
            this.Controls.Add(this.CarsPanel);
            this.Controls.Add(this.MainMenuStrip);
            this.MainMenuStrip = this.MainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Выберите автосалон";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CarsPanel.ResumeLayout(false);
            this.CarsPanel.PerformLayout();
            this.NumberOfCarsPanel.ResumeLayout(false);
            this.NumberOfCarsPanel.PerformLayout();
            this.InforationPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.CarInformationTabPage.ResumeLayout(false);
            this.CarInformationTabPage.PerformLayout();
            this.ApplicatinsTabPage.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CarsPanel;
        private System.Windows.Forms.Panel NumberOfCarsPanel;
        private System.Windows.Forms.Panel InforationPanel;
        private System.Windows.Forms.Label CarsLabel;
        private System.Windows.Forms.ListBox CarsListBox;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage CarInformationTabPage;
        private System.Windows.Forms.TabPage ApplicatinsTabPage;
        private System.Windows.Forms.Label AvailabilityLabel;
        private System.Windows.Forms.Label QuantityInStockLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label NumberOfPassegerLabel;
        private System.Windows.Forms.Label CarNameLabel;
        private System.Windows.Forms.TextBox QuantityInStockTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox NumberOfPassegerTextBox;
        private System.Windows.Forms.TextBox CarNameTextBox;
        private System.Windows.Forms.Label AvailabilityValueLabel;
        private System.Windows.Forms.Label QuantityCarsInSaloonLabel;
        private System.Windows.Forms.Label QuantityCarsLabel;
        private System.Windows.Forms.ListBox ApplicationListBox;
        private System.Windows.Forms.ToolStripMenuItem ChangeAutosaloonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DownloadAutosaloonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAutosaloonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateApplicationToolStripMenuItem;
        private System.Windows.Forms.Button CalculateApplicationButton;
    }
}

