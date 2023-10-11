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
        private void InitializeTags(Equipment.Equipment equipment)
        {
            tags = new Dictionary<string, string>()
            {
                {"<EQUIP_FULLNAME>", equipment.FullName()},
                {"<DATE_YEAR>", DateTime.Now.ToString("yyyy")},
                {"<DATE_FULL>", DateTime.Now.ToString("dd.MM.yyyy")},
                {"<EQUIP_FREQ>", equipment.Frequency.ToString()},
                {"<EQUIP_NAME>", equipment.Name},
                {"<BLOCK_NUM>", equipment.BlockNum.ToString()},
                {"<BOILER>", equipment.Boiler},
                {"<ORDER>", equipment.Order.ToString()}
            };
            foreach(var tb in groupBoxT1.Controls)
            {
                if(tb is TextBox)
                {
                   var tbContainer = (TextBox)tb;
                    tags.Add($"<{tbContainer.Name}>", $"<{tbContainer.Name}>");
                }
            }
        }
        private Dictionary<string, string> tags;

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
            var equipment = Equipment.Equipment.InitWithType(
                comboBoxEqType.SelectedIndex,
                (int)numericBlock.Value,
                checkBoxA.Checked ? "A" : checkBoxB.Checked ? "Б" : checkBoxC.Checked ? "В" : "А",
                (int)numericOrder.Value
                );

            InitializeTags(equipment);
            DocWorker dw = new DocWorker(Settings.layoutFileName);
            dw.InsertItems(tags);
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

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
