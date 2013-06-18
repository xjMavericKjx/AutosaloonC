namespace Autosaloon
{
    partial class NewAutosaloonForm
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.InputAutosaloonNameLabel = new System.Windows.Forms.Label();
            this.InputAutosaloonNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 74);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(260, 23);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // InputAutosaloonNameLabel
            // 
            this.InputAutosaloonNameLabel.AutoSize = true;
            this.InputAutosaloonNameLabel.Location = new System.Drawing.Point(9, 19);
            this.InputAutosaloonNameLabel.Name = "InputAutosaloonNameLabel";
            this.InputAutosaloonNameLabel.Size = new System.Drawing.Size(165, 13);
            this.InputAutosaloonNameLabel.TabIndex = 1;
            this.InputAutosaloonNameLabel.Text = "Введите название автосалона:";
            // 
            // InputAutosaloonNameTextBox
            // 
            this.InputAutosaloonNameTextBox.Location = new System.Drawing.Point(60, 41);
            this.InputAutosaloonNameTextBox.Name = "InputAutosaloonNameTextBox";
            this.InputAutosaloonNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.InputAutosaloonNameTextBox.TabIndex = 2;
            // 
            // NewAutosaloonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.InputAutosaloonNameTextBox);
            this.Controls.Add(this.InputAutosaloonNameLabel);
            this.Controls.Add(this.CreateButton);
            this.Name = "NewAutosaloonForm";
            this.Text = "NewAutosaloonForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewAutosaloonForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label InputAutosaloonNameLabel;
        private System.Windows.Forms.TextBox InputAutosaloonNameTextBox;
    }
}