﻿using System;
using System.Windows.Forms;
using Autosaloon.Classes;

namespace Autosaloon.Interface
{
    public partial class NewAutosaloonForm : Form
    {
        public NewAutosaloonForm()
        {
            InitializeComponent();
        }

        public Avtosaloon Autosaloon { get; set; }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Autosaloon = new Avtosaloon(InputAutosaloonNameTextBox.Text.Trim());
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
