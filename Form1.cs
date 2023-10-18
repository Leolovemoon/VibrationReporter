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
            Spectral.InitMainForm(this);
        }

        //Теги для проблем спеткрального анализа
        IDictionary<string, string> myTags = new Dictionary<string, string>();

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
            dw.InitTags(equipment);

            //Включение спектрального анализа в отчет
            if (checkBoxSpectralOn.Checked) 
            {
                myTags.Add(
                    "<SPECTRAL_ENGINE_REV_1>",
                    $"{textBoxSpectralRevFirstA.Text} мм/c ({textBoxSpectralRevFirstB.Text} Гц)");

                //Дисбаланс двигателя
                myTags.Add(
                    "<SPECTRAL_ENGINE_DISBALANCE>",
                    Spectral.GetDisbalanceAnswer(Convert.ToDouble(textBoxSpectralRevFirstA.Text)));

                //Добавляем в анализ выявленные спектральные проблемы
                Spectral.AddProblemTags(myTags,
                    checkBoxSpectralProblem1.Checked);

                //Поулчаем сформированные рекомендации
                myTags.Add(Spectral.GetReqTag());                
            }

            dw.AddTags(myTags);
            dw.InsertItems();

            Spectral.Clear();
            button.Text = "Создать отчет";
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
            groupBoxT2.Enabled = checkBoxCircuit.Checked;
        }
        private void checkBoxSpectralOn_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSpectral.Enabled = checkBoxSpectralOn.Checked;           
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
        }

        private void labelProblem1Even_Click(object sender, EventArgs e)
        {
            labelProblem1Even.Text = labelProblem1Even.Text == "кратных" ?
                "не кратных" :
                "кратных";
        }

        private void label_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
