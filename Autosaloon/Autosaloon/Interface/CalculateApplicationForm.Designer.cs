namespace Autosaloon.Interface
{
    partial class CalculateApplicationForm
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
            this.NameOfByerLabel = new System.Windows.Forms.Label();
            this.CallNumberLabel = new System.Windows.Forms.Label();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.CanlcelButton = new System.Windows.Forms.Button();
            this.PercentValueLabel = new System.Windows.Forms.Label();
            this.CallNumberValueLabel = new System.Windows.Forms.Label();
            this.NameOfBuyerValueLabel = new System.Windows.Forms.Label();
            this.CarInformationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameOfByerLabel
            // 
            this.NameOfByerLabel.AutoSize = true;
            this.NameOfByerLabel.Location = new System.Drawing.Point(12, 14);
            this.NameOfByerLabel.Name = "NameOfByerLabel";
            this.NameOfByerLabel.Size = new System.Drawing.Size(88, 13);
            this.NameOfByerLabel.TabIndex = 0;
            this.NameOfByerLabel.Text = "Имя заказчика:";
            // 
            // CallNumberLabel
            // 
            this.CallNumberLabel.AutoSize = true;
            this.CallNumberLabel.Location = new System.Drawing.Point(12, 37);
            this.CallNumberLabel.Name = "CallNumberLabel";
            this.CallNumberLabel.Size = new System.Drawing.Size(111, 13);
            this.CallNumberLabel.TabIndex = 1;
            this.CallNumberLabel.Text = "Телефон заказчика:";
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Location = new System.Drawing.Point(12, 61);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(92, 13);
            this.PercentLabel.TabIndex = 2;
            this.PercentLabel.Text = "Процент скидки:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(11, 141);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(115, 23);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Выполнить покупку";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CanlcelButton
            // 
            this.CanlcelButton.Location = new System.Drawing.Point(132, 141);
            this.CanlcelButton.Name = "CanlcelButton";
            this.CanlcelButton.Size = new System.Drawing.Size(115, 23);
            this.CanlcelButton.TabIndex = 4;
            this.CanlcelButton.Text = "Отменить покупку";
            this.CanlcelButton.UseVisualStyleBackColor = true;
            this.CanlcelButton.Click += new System.EventHandler(this.CanlcelButton_Click);
            // 
            // PercentValueLabel
            // 
            this.PercentValueLabel.AutoSize = true;
            this.PercentValueLabel.Location = new System.Drawing.Point(133, 61);
            this.PercentValueLabel.Name = "PercentValueLabel";
            this.PercentValueLabel.Size = new System.Drawing.Size(0, 13);
            this.PercentValueLabel.TabIndex = 7;
            // 
            // CallNumberValueLabel
            // 
            this.CallNumberValueLabel.AutoSize = true;
            this.CallNumberValueLabel.Location = new System.Drawing.Point(133, 37);
            this.CallNumberValueLabel.Name = "CallNumberValueLabel";
            this.CallNumberValueLabel.Size = new System.Drawing.Size(0, 13);
            this.CallNumberValueLabel.TabIndex = 6;
            // 
            // NameOfBuyerValueLabel
            // 
            this.NameOfBuyerValueLabel.AutoSize = true;
            this.NameOfBuyerValueLabel.Location = new System.Drawing.Point(133, 14);
            this.NameOfBuyerValueLabel.Name = "NameOfBuyerValueLabel";
            this.NameOfBuyerValueLabel.Size = new System.Drawing.Size(0, 13);
            this.NameOfBuyerValueLabel.TabIndex = 5;
            // 
            // CarInformationLabel
            // 
            this.CarInformationLabel.AutoSize = true;
            this.CarInformationLabel.Location = new System.Drawing.Point(12, 87);
            this.CarInformationLabel.Name = "CarInformationLabel";
            this.CarInformationLabel.Size = new System.Drawing.Size(0, 13);
            this.CarInformationLabel.TabIndex = 8;
            // 
            // CalculateApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 173);
            this.Controls.Add(this.CarInformationLabel);
            this.Controls.Add(this.PercentValueLabel);
            this.Controls.Add(this.CallNumberValueLabel);
            this.Controls.Add(this.NameOfBuyerValueLabel);
            this.Controls.Add(this.CanlcelButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.CallNumberLabel);
            this.Controls.Add(this.NameOfByerLabel);
            this.Name = "CalculateApplicationForm";
            this.Text = "CalculateApplicationForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalculateApplicationForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameOfByerLabel;
        private System.Windows.Forms.Label CallNumberLabel;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button CanlcelButton;
        private System.Windows.Forms.Label PercentValueLabel;
        private System.Windows.Forms.Label CallNumberValueLabel;
        private System.Windows.Forms.Label NameOfBuyerValueLabel;
        private System.Windows.Forms.Label CarInformationLabel;
    }
}