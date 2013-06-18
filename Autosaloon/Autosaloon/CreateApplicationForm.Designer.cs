namespace Autosaloon
{
    partial class CreateApplicationForm
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
            this.CreateApplicationButton = new System.Windows.Forms.Button();
            this.CallNumberLabel = new System.Windows.Forms.Label();
            this.CallNumberTextBox = new System.Windows.Forms.TextBox();
            this.NameOfBuyerLabel = new System.Windows.Forms.Label();
            this.NameOfBuyerTextBox = new System.Windows.Forms.TextBox();
            this.ApplicationInStockRadioButton = new System.Windows.Forms.RadioButton();
            this.ApplicationOfDeliveryRadioButton = new System.Windows.Forms.RadioButton();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.PercentTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateApplicationButton
            // 
            this.CreateApplicationButton.Location = new System.Drawing.Point(99, 151);
            this.CreateApplicationButton.Name = "CreateApplicationButton";
            this.CreateApplicationButton.Size = new System.Drawing.Size(75, 23);
            this.CreateApplicationButton.TabIndex = 0;
            this.CreateApplicationButton.Text = "Создать";
            this.CreateApplicationButton.UseVisualStyleBackColor = true;
            this.CreateApplicationButton.Click += new System.EventHandler(this.CreateApplicationButton_Click);
            // 
            // CallNumberLabel
            // 
            this.CallNumberLabel.AutoSize = true;
            this.CallNumberLabel.Location = new System.Drawing.Point(12, 56);
            this.CallNumberLabel.Name = "CallNumberLabel";
            this.CallNumberLabel.Size = new System.Drawing.Size(96, 13);
            this.CallNumberLabel.TabIndex = 7;
            this.CallNumberLabel.Text = "Номер телефона:";
            // 
            // CallNumberTextBox
            // 
            this.CallNumberTextBox.Location = new System.Drawing.Point(136, 53);
            this.CallNumberTextBox.Name = "CallNumberTextBox";
            this.CallNumberTextBox.Size = new System.Drawing.Size(127, 20);
            this.CallNumberTextBox.TabIndex = 6;
            // 
            // NameOfBuyerLabel
            // 
            this.NameOfBuyerLabel.AutoSize = true;
            this.NameOfBuyerLabel.Location = new System.Drawing.Point(12, 25);
            this.NameOfBuyerLabel.Name = "NameOfBuyerLabel";
            this.NameOfBuyerLabel.Size = new System.Drawing.Size(88, 13);
            this.NameOfBuyerLabel.TabIndex = 5;
            this.NameOfBuyerLabel.Text = "Имя заказчика:";
            // 
            // NameOfBuyerTextBox
            // 
            this.NameOfBuyerTextBox.Location = new System.Drawing.Point(136, 22);
            this.NameOfBuyerTextBox.Name = "NameOfBuyerTextBox";
            this.NameOfBuyerTextBox.Size = new System.Drawing.Size(127, 20);
            this.NameOfBuyerTextBox.TabIndex = 4;
            // 
            // ApplicationInStockRadioButton
            // 
            this.ApplicationInStockRadioButton.AutoSize = true;
            this.ApplicationInStockRadioButton.Location = new System.Drawing.Point(15, 79);
            this.ApplicationInStockRadioButton.Name = "ApplicationInStockRadioButton";
            this.ApplicationInStockRadioButton.Size = new System.Drawing.Size(173, 17);
            this.ApplicationInStockRadioButton.TabIndex = 8;
            this.ApplicationInStockRadioButton.TabStop = true;
            this.ApplicationInStockRadioButton.Text = "Заявка на покупку со стенда";
            this.ApplicationInStockRadioButton.UseVisualStyleBackColor = true;
            // 
            // ApplicationOfDeliveryRadioButton
            // 
            this.ApplicationOfDeliveryRadioButton.AutoSize = true;
            this.ApplicationOfDeliveryRadioButton.Location = new System.Drawing.Point(15, 102);
            this.ApplicationOfDeliveryRadioButton.Name = "ApplicationOfDeliveryRadioButton";
            this.ApplicationOfDeliveryRadioButton.Size = new System.Drawing.Size(185, 17);
            this.ApplicationOfDeliveryRadioButton.TabIndex = 9;
            this.ApplicationOfDeliveryRadioButton.TabStop = true;
            this.ApplicationOfDeliveryRadioButton.Text = "Заявка на отложенную покупку";
            this.ApplicationOfDeliveryRadioButton.UseVisualStyleBackColor = true;
            this.ApplicationOfDeliveryRadioButton.CheckedChanged += new System.EventHandler(this.ApplicationOfDeliveryRadioButton_CheckedChanged);
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Location = new System.Drawing.Point(12, 128);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(92, 13);
            this.PercentLabel.TabIndex = 11;
            this.PercentLabel.Text = "Процент скидки:";
            // 
            // PercentTextBox
            // 
            this.PercentTextBox.Location = new System.Drawing.Point(136, 125);
            this.PercentTextBox.Name = "PercentTextBox";
            this.PercentTextBox.Size = new System.Drawing.Size(127, 20);
            this.PercentTextBox.TabIndex = 10;
            this.PercentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PercentTextBox_KeyPress);
            // 
            // CreateApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.PercentTextBox);
            this.Controls.Add(this.ApplicationOfDeliveryRadioButton);
            this.Controls.Add(this.ApplicationInStockRadioButton);
            this.Controls.Add(this.CallNumberLabel);
            this.Controls.Add(this.CallNumberTextBox);
            this.Controls.Add(this.NameOfBuyerLabel);
            this.Controls.Add(this.NameOfBuyerTextBox);
            this.Controls.Add(this.CreateApplicationButton);
            this.Name = "CreateApplicationForm";
            this.Text = "CreateApplicationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateApplicationButton;
        private System.Windows.Forms.Label CallNumberLabel;
        private System.Windows.Forms.TextBox CallNumberTextBox;
        private System.Windows.Forms.Label NameOfBuyerLabel;
        private System.Windows.Forms.TextBox NameOfBuyerTextBox;
        private System.Windows.Forms.RadioButton ApplicationInStockRadioButton;
        private System.Windows.Forms.RadioButton ApplicationOfDeliveryRadioButton;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.TextBox PercentTextBox;
    }
}