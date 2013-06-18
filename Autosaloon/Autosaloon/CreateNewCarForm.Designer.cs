namespace Autosaloon
{
    partial class CreateNewCarForm
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
            this.CarNameTextBox = new System.Windows.Forms.TextBox();
            this.CarNameLabel = new System.Windows.Forms.Label();
            this.NumberOfPassegerLabel = new System.Windows.Forms.Label();
            this.NumberOfPassegerTextBox = new System.Windows.Forms.TextBox();
            this.QuantityInStockLabel = new System.Windows.Forms.Label();
            this.QuantityInStockTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CreateCarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarNameTextBox
            // 
            this.CarNameTextBox.Location = new System.Drawing.Point(145, 24);
            this.CarNameTextBox.Name = "CarNameTextBox";
            this.CarNameTextBox.Size = new System.Drawing.Size(127, 20);
            this.CarNameTextBox.TabIndex = 0;
            // 
            // CarNameLabel
            // 
            this.CarNameLabel.AutoSize = true;
            this.CarNameLabel.Location = new System.Drawing.Point(21, 27);
            this.CarNameLabel.Name = "CarNameLabel";
            this.CarNameLabel.Size = new System.Drawing.Size(49, 13);
            this.CarNameLabel.TabIndex = 1;
            this.CarNameLabel.Text = "Модель:";
            // 
            // NumberOfPassegerLabel
            // 
            this.NumberOfPassegerLabel.AutoSize = true;
            this.NumberOfPassegerLabel.Location = new System.Drawing.Point(21, 58);
            this.NumberOfPassegerLabel.Name = "NumberOfPassegerLabel";
            this.NumberOfPassegerLabel.Size = new System.Drawing.Size(109, 13);
            this.NumberOfPassegerLabel.TabIndex = 3;
            this.NumberOfPassegerLabel.Text = "Кол-во пассажиров:";
            // 
            // NumberOfPassegerTextBox
            // 
            this.NumberOfPassegerTextBox.Location = new System.Drawing.Point(145, 55);
            this.NumberOfPassegerTextBox.Name = "NumberOfPassegerTextBox";
            this.NumberOfPassegerTextBox.Size = new System.Drawing.Size(127, 20);
            this.NumberOfPassegerTextBox.TabIndex = 2;
            this.NumberOfPassegerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOfPassegerTextBox_KeyPress);
            // 
            // QuantityInStockLabel
            // 
            this.QuantityInStockLabel.AutoSize = true;
            this.QuantityInStockLabel.Location = new System.Drawing.Point(21, 115);
            this.QuantityInStockLabel.Name = "QuantityInStockLabel";
            this.QuantityInStockLabel.Size = new System.Drawing.Size(98, 13);
            this.QuantityInStockLabel.TabIndex = 7;
            this.QuantityInStockLabel.Text = "Кол-во на складе:";
            // 
            // QuantityInStockTextBox
            // 
            this.QuantityInStockTextBox.Location = new System.Drawing.Point(145, 112);
            this.QuantityInStockTextBox.Name = "QuantityInStockTextBox";
            this.QuantityInStockTextBox.Size = new System.Drawing.Size(127, 20);
            this.QuantityInStockTextBox.TabIndex = 6;
            this.QuantityInStockTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityInStockTextBox_KeyPress);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(21, 84);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(36, 13);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Цена:";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(145, 81);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(127, 20);
            this.CostTextBox.TabIndex = 4;
            this.CostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostTextBox_KeyPress);
            // 
            // CreateCarButton
            // 
            this.CreateCarButton.Location = new System.Drawing.Point(99, 151);
            this.CreateCarButton.Name = "CreateCarButton";
            this.CreateCarButton.Size = new System.Drawing.Size(75, 23);
            this.CreateCarButton.TabIndex = 8;
            this.CreateCarButton.Text = "Создать";
            this.CreateCarButton.UseVisualStyleBackColor = true;
            this.CreateCarButton.Click += new System.EventHandler(this.CreateCarButton_Click);
            // 
            // CreateNewCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 186);
            this.Controls.Add(this.CreateCarButton);
            this.Controls.Add(this.QuantityInStockLabel);
            this.Controls.Add(this.QuantityInStockTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.NumberOfPassegerLabel);
            this.Controls.Add(this.NumberOfPassegerTextBox);
            this.Controls.Add(this.CarNameLabel);
            this.Controls.Add(this.CarNameTextBox);
            this.Name = "CreateNewCarForm";
            this.Text = "Новый автомобиль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CarNameTextBox;
        private System.Windows.Forms.Label CarNameLabel;
        private System.Windows.Forms.Label NumberOfPassegerLabel;
        private System.Windows.Forms.TextBox NumberOfPassegerTextBox;
        private System.Windows.Forms.Label QuantityInStockLabel;
        private System.Windows.Forms.TextBox QuantityInStockTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Button CreateCarButton;
    }
}