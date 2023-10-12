using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VibrationReporter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            var target = (CheckBox)sender;
            if (!target.Checked) return;

            foreach(CheckBox el in groupBoxBoiler.Controls)
            {
                if (el.Name != target.Name)
                    el.Checked = false;
            }
        }

        private void comboBoxEqType_TextUpdate(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            if (!comboBox.Items.Contains(comboBox.Text))
                comboBox.Text = comboBox.Items[0].ToString();
        }

        private void buttonCreateDoc_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.Text = "Идет генерация отчета...";

            var equipment = Equipment.Equipment.InitWithType(
                comboBoxEqType.SelectedIndex,
                (int)numericBlock.Value,
                checkBoxA.Checked ? "A" : checkBoxB.Checked ? "Б" : checkBoxC.Checked ? "В" : String.Empty,
                (int)numericOrder.Value);

            equipment.InitValues(tableLayoutPanel1, tableLayoutPanel2);

            DocWorker dw = new DocWorker(Settings.layoutFileName);
            dw.InitializeTags(equipment);
            dw.InsertItems();

            button.Text = "Создать отчета";
        }

        private void textBoxDouble_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.Text = textBox.Text.Replace('.', ',');
            if (!Double.TryParse(textBox.Text, out double value) && textBox.Text != String.Empty)
            {
                textBox.Text = String.Empty;
                MessageBox.Show("Только числовые значения");
                textBox.Focus();
            }
                
        }

        private void checkBoxCircuit_CheckedChanged(object sender, EventArgs e)
        {
            foreach(var el in tableLayoutPanel2.Controls)
            {
                if(el is TextBox)
                {
                    TextBox container = (TextBox)el;
                    container.ReadOnly = !checkBoxCircuit.Checked;
                    container.Enabled = checkBoxCircuit.Checked;
                }
            }
        }
    }
}
