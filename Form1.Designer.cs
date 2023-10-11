namespace VibrationReporter
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxEqType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericBlock = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_t1_12 = new System.Windows.Forms.Label();
            this.label_t1_11 = new System.Windows.Forms.Label();
            this.label_t1_9 = new System.Windows.Forms.Label();
            this.label_t1_8 = new System.Windows.Forms.Label();
            this.label_t1_7 = new System.Windows.Forms.Label();
            this.label_t1_5 = new System.Windows.Forms.Label();
            this.label_t1_4 = new System.Windows.Forms.Label();
            this.label_t1_3 = new System.Windows.Forms.Label();
            this.label_t1_1 = new System.Windows.Forms.Label();
            this.label_t1_2 = new System.Windows.Forms.Label();
            this.label_t1_6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_t1_10 = new System.Windows.Forms.Label();
            this.T1_00 = new System.Windows.Forms.TextBox();
            this.groupBoxT1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericOrder = new System.Windows.Forms.NumericUpDown();
            this.button_createDoc = new System.Windows.Forms.Button();
            this.groupBoxBoiler = new System.Windows.Forms.GroupBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.T1_01 = new System.Windows.Forms.TextBox();
            this.T1_02 = new System.Windows.Forms.TextBox();
            this.T1_03 = new System.Windows.Forms.TextBox();
            this.T1_04 = new System.Windows.Forms.TextBox();
            this.T1_05 = new System.Windows.Forms.TextBox();
            this.T1_06 = new System.Windows.Forms.TextBox();
            this.T1_07 = new System.Windows.Forms.TextBox();
            this.T1_10 = new System.Windows.Forms.TextBox();
            this.T1_11 = new System.Windows.Forms.TextBox();
            this.T1_12 = new System.Windows.Forms.TextBox();
            this.T1_13 = new System.Windows.Forms.TextBox();
            this.T1_14 = new System.Windows.Forms.TextBox();
            this.T1_15 = new System.Windows.Forms.TextBox();
            this.T1_16 = new System.Windows.Forms.TextBox();
            this.T1_17 = new System.Windows.Forms.TextBox();
            this.T1_20 = new System.Windows.Forms.TextBox();
            this.T1_21 = new System.Windows.Forms.TextBox();
            this.T1_22 = new System.Windows.Forms.TextBox();
            this.T1_23 = new System.Windows.Forms.TextBox();
            this.T1_24 = new System.Windows.Forms.TextBox();
            this.T1_25 = new System.Windows.Forms.TextBox();
            this.T1_26 = new System.Windows.Forms.TextBox();
            this.T1_27 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlock)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxT1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrder)).BeginInit();
            this.groupBoxBoiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxEqType
            // 
            this.comboBoxEqType.FormattingEnabled = true;
            this.comboBoxEqType.Items.AddRange(new object[] {
            "КН (1000 об./мин)",
            "НПНД (1500 об./мин)",
            "ПЭН (3000 об./мин)",
            "НГО (1000 об./мин)"});
            this.comboBoxEqType.Location = new System.Drawing.Point(12, 35);
            this.comboBoxEqType.Name = "comboBoxEqType";
            this.comboBoxEqType.Size = new System.Drawing.Size(272, 24);
            this.comboBoxEqType.TabIndex = 0;
            this.comboBoxEqType.Text = "КН (1000 об./мин)";
            this.comboBoxEqType.TextUpdate += new System.EventHandler(this.comboBoxEqType_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберете тип оборудования";
            // 
            // numericBlock
            // 
            this.numericBlock.Location = new System.Drawing.Point(112, 65);
            this.numericBlock.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericBlock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBlock.Name = "numericBlock";
            this.numericBlock.Size = new System.Drawing.Size(44, 22);
            this.numericBlock.TabIndex = 2;
            this.numericBlock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер блока";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.T1_27, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.T1_22, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.T1_21, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.T1_20, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.T1_17, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.T1_16, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.T1_15, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.T1_14, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.T1_13, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.T1_11, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.T1_06, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.T1_05, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.T1_04, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.T1_03, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.T1_02, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.T1_01, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_t1_12, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_t1_11, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_t1_9, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_t1_8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_t1_7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_t1_5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_t1_4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_t1_3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_t1_1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_t1_2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_t1_6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_t1_10, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.T1_00, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.T1_10, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.T1_23, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.T1_12, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.T1_07, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.T1_24, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.T1_25, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.T1_26, 8, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(713, 212);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(642, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ve, мм/c";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(494, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ve, мм/c";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(346, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ve, мм/c";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(272, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "2A, мкм";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_t1_12
            // 
            this.label_t1_12.AutoSize = true;
            this.label_t1_12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_t1_12.Location = new System.Drawing.Point(198, 103);
            this.label_t1_12.Name = "label_t1_12";
            this.label_t1_12.Size = new System.Drawing.Size(67, 20);
            this.label_t1_12.TabIndex = 14;
            this.label_t1_12.Text = "Ve, мм/c";
            this.label_t1_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_t1_11
            // 
            this.label_t1_11.AutoSize = true;
            this.label_t1_11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_t1_11.Location = new System.Drawing.Point(124, 103);
            this.label_t1_11.Name = "label_t1_11";
            this.label_t1_11.Size = new System.Drawing.Size(67, 20);
            this.label_t1_11.TabIndex = 13;
            this.label_t1_11.Text = "2A, мкм";
            this.label_t1_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_t1_9
            // 
            this.label_t1_9.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_t1_9, 2);
            this.label_t1_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_t1_9.Location = new System.Drawing.Point(420, 52);
            this.label_t1_9.Name = "label_t1_9";
            this.label_t1_9.Size = new System.Drawing.Size(141, 50);
            this.label_t1_9.TabIndex = 11;
            this.label_t1_9.Text = "Подшип. №1";
            this.label_t1_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_t1_8
            // 
            this.label_t1_8.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_t1_8, 2);
            this.label_t1_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_t1_8.Location = new System.Drawing.Point(272, 52);
            this.label_t1_8.Name = "label_t1_8";
            this.label_t1_8.Size = new System.Drawing.Size(141, 50);
            this.label_t1_8.TabIndex = 10;
            this.label_t1_8.Text = "Подшип. №2";
            this.label_t1_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_t1_7
            // 
            this.label_t1_7.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_t1_7, 2);
            this.label_t1_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_t1_7.Location = new System.Drawing.Point(124, 52);
            this.label_t1_7.Name = "label_t1_7";
            this.label_t1_7.Size = new System.Drawing.Size(141, 50);
            this.label_t1_7.TabIndex = 9;
            this.label_t1_7.Text = "Подшип. №1";
            this.label_t1_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_t1_5
            // 
            this.label_t1_5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_t1_5, 4);
            this.label_t1_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_t1_5.Location = new System.Drawing.Point(124, 1);
            this.label_t1_5.Name = "label_t1_5";
            this.label_t1_5.Size = new System.Drawing.Size(289, 50);
            this.label_t1_5.TabIndex = 6;
            this.label_t1_5.Text = "Электродвигатель";
            this.label_t1_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_t1_4
            // 
            this.label_t1_4.AutoSize = true;
            this.label_t1_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_t1_4.Location = new System.Drawing.Point(4, 182);
            this.label_t1_4.Name = "label_t1_4";
            this.label_t1_4.Size = new System.Drawing.Size(113, 29);
            this.label_t1_4.TabIndex = 7;
            this.label_t1_4.Text = "Осевое";
            this.label_t1_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_t1_3
            // 
            this.label_t1_3.AutoSize = true;
            this.label_t1_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_t1_3.Location = new System.Drawing.Point(4, 153);
            this.label_t1_3.Name = "label_t1_3";
            this.label_t1_3.Size = new System.Drawing.Size(113, 28);
            this.label_t1_3.TabIndex = 6;
            this.label_t1_3.Text = "Поперечное";
            this.label_t1_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_t1_1
            // 
            this.label_t1_1.AutoSize = true;
            this.label_t1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_t1_1.Location = new System.Drawing.Point(4, 1);
            this.label_t1_1.Name = "label_t1_1";
            this.tableLayoutPanel1.SetRowSpan(this.label_t1_1, 3);
            this.label_t1_1.Size = new System.Drawing.Size(113, 122);
            this.label_t1_1.TabIndex = 0;
            this.label_t1_1.Text = "Направление";
            this.label_t1_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_t1_2
            // 
            this.label_t1_2.AutoSize = true;
            this.label_t1_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_t1_2.Location = new System.Drawing.Point(4, 124);
            this.label_t1_2.Name = "label_t1_2";
            this.label_t1_2.Size = new System.Drawing.Size(113, 28);
            this.label_t1_2.TabIndex = 1;
            this.label_t1_2.Text = "Вертикальное";
            this.label_t1_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_t1_6
            // 
            this.label_t1_6.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_t1_6, 4);
            this.label_t1_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_t1_6.Location = new System.Drawing.Point(420, 1);
            this.label_t1_6.Name = "label_t1_6";
            this.label_t1_6.Size = new System.Drawing.Size(289, 50);
            this.label_t1_6.TabIndex = 8;
            this.label_t1_6.Text = "Рабочий механизм";
            this.label_t1_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(420, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "2A, мкм";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(568, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "2A, мкм";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_t1_10
            // 
            this.label_t1_10.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_t1_10, 2);
            this.label_t1_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_t1_10.Location = new System.Drawing.Point(568, 52);
            this.label_t1_10.Name = "label_t1_10";
            this.label_t1_10.Size = new System.Drawing.Size(141, 50);
            this.label_t1_10.TabIndex = 12;
            this.label_t1_10.Text = "Подшип. №2";
            this.label_t1_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T1_00
            // 
            this.T1_00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.T1_00.Location = new System.Drawing.Point(124, 127);
            this.T1_00.Name = "T1_00";
            this.T1_00.Size = new System.Drawing.Size(67, 22);
            this.T1_00.TabIndex = 21;
            this.T1_00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_00.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // groupBoxT1
            // 
            this.groupBoxT1.AutoSize = true;
            this.groupBoxT1.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxT1.Location = new System.Drawing.Point(290, 16);
            this.groupBoxT1.Name = "groupBoxT1";
            this.groupBoxT1.Size = new System.Drawing.Size(719, 233);
            this.groupBoxT1.TabIndex = 5;
            this.groupBoxT1.TabStop = false;
            this.groupBoxT1.Text = "Уровень вибрации на подшипниках агрегата";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Порядковый номер";
            // 
            // numericOrder
            // 
            this.numericOrder.Location = new System.Drawing.Point(149, 147);
            this.numericOrder.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericOrder.Name = "numericOrder";
            this.numericOrder.Size = new System.Drawing.Size(44, 22);
            this.numericOrder.TabIndex = 7;
            this.numericOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_createDoc
            // 
            this.button_createDoc.Location = new System.Drawing.Point(12, 204);
            this.button_createDoc.Name = "button_createDoc";
            this.button_createDoc.Size = new System.Drawing.Size(272, 52);
            this.button_createDoc.TabIndex = 8;
            this.button_createDoc.Text = "Создать отчет";
            this.button_createDoc.UseVisualStyleBackColor = true;
            this.button_createDoc.Click += new System.EventHandler(this.buttonCreateDoc_Click);
            // 
            // groupBoxBoiler
            // 
            this.groupBoxBoiler.Controls.Add(this.checkBoxC);
            this.groupBoxBoiler.Controls.Add(this.checkBoxB);
            this.groupBoxBoiler.Controls.Add(this.checkBoxA);
            this.groupBoxBoiler.Location = new System.Drawing.Point(15, 93);
            this.groupBoxBoiler.Name = "groupBoxBoiler";
            this.groupBoxBoiler.Size = new System.Drawing.Size(141, 51);
            this.groupBoxBoiler.TabIndex = 11;
            this.groupBoxBoiler.TabStop = false;
            this.groupBoxBoiler.Text = "Котел";
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Location = new System.Drawing.Point(94, 21);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(38, 20);
            this.checkBoxC.TabIndex = 2;
            this.checkBoxC.Text = "В";
            this.checkBoxC.UseVisualStyleBackColor = true;
            this.checkBoxC.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Location = new System.Drawing.Point(50, 21);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(38, 20);
            this.checkBoxB.TabIndex = 1;
            this.checkBoxB.Text = "Б";
            this.checkBoxB.UseVisualStyleBackColor = true;
            this.checkBoxB.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Checked = true;
            this.checkBoxA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxA.Location = new System.Drawing.Point(6, 21);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(38, 20);
            this.checkBoxA.TabIndex = 0;
            this.checkBoxA.Text = "А";
            this.checkBoxA.UseVisualStyleBackColor = true;
            this.checkBoxA.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // T1_01
            // 
            this.T1_01.Location = new System.Drawing.Point(198, 127);
            this.T1_01.Name = "T1_01";
            this.T1_01.Size = new System.Drawing.Size(67, 22);
            this.T1_01.TabIndex = 22;
            this.T1_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_01.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_02
            // 
            this.T1_02.Location = new System.Drawing.Point(272, 127);
            this.T1_02.Name = "T1_02";
            this.T1_02.Size = new System.Drawing.Size(67, 22);
            this.T1_02.TabIndex = 23;
            this.T1_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_02.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_03
            // 
            this.T1_03.Location = new System.Drawing.Point(346, 127);
            this.T1_03.Name = "T1_03";
            this.T1_03.Size = new System.Drawing.Size(67, 22);
            this.T1_03.TabIndex = 24;
            this.T1_03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_03.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_04
            // 
            this.T1_04.Location = new System.Drawing.Point(420, 127);
            this.T1_04.Name = "T1_04";
            this.T1_04.Size = new System.Drawing.Size(67, 22);
            this.T1_04.TabIndex = 25;
            this.T1_04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_04.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_05
            // 
            this.T1_05.Location = new System.Drawing.Point(494, 127);
            this.T1_05.Name = "T1_05";
            this.T1_05.Size = new System.Drawing.Size(67, 22);
            this.T1_05.TabIndex = 26;
            this.T1_05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_05.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_06
            // 
            this.T1_06.Location = new System.Drawing.Point(568, 127);
            this.T1_06.Name = "T1_06";
            this.T1_06.Size = new System.Drawing.Size(67, 22);
            this.T1_06.TabIndex = 27;
            this.T1_06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_06.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_07
            // 
            this.T1_07.Location = new System.Drawing.Point(420, 185);
            this.T1_07.Name = "T1_07";
            this.T1_07.Size = new System.Drawing.Size(67, 22);
            this.T1_07.TabIndex = 28;
            this.T1_07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_07.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_10
            // 
            this.T1_10.Location = new System.Drawing.Point(346, 185);
            this.T1_10.Name = "T1_10";
            this.T1_10.Size = new System.Drawing.Size(67, 22);
            this.T1_10.TabIndex = 29;
            this.T1_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_10.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_11
            // 
            this.T1_11.Location = new System.Drawing.Point(198, 156);
            this.T1_11.Name = "T1_11";
            this.T1_11.Size = new System.Drawing.Size(67, 22);
            this.T1_11.TabIndex = 30;
            this.T1_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_11.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_12
            // 
            this.T1_12.Location = new System.Drawing.Point(124, 156);
            this.T1_12.Name = "T1_12";
            this.T1_12.Size = new System.Drawing.Size(67, 22);
            this.T1_12.TabIndex = 31;
            this.T1_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_12.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_13
            // 
            this.T1_13.Location = new System.Drawing.Point(346, 156);
            this.T1_13.Name = "T1_13";
            this.T1_13.Size = new System.Drawing.Size(67, 22);
            this.T1_13.TabIndex = 32;
            this.T1_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_13.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_14
            // 
            this.T1_14.Location = new System.Drawing.Point(420, 156);
            this.T1_14.Name = "T1_14";
            this.T1_14.Size = new System.Drawing.Size(67, 22);
            this.T1_14.TabIndex = 33;
            this.T1_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_14.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_15
            // 
            this.T1_15.Location = new System.Drawing.Point(494, 156);
            this.T1_15.Name = "T1_15";
            this.T1_15.Size = new System.Drawing.Size(67, 22);
            this.T1_15.TabIndex = 34;
            this.T1_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_15.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_16
            // 
            this.T1_16.Location = new System.Drawing.Point(568, 156);
            this.T1_16.Name = "T1_16";
            this.T1_16.Size = new System.Drawing.Size(67, 22);
            this.T1_16.TabIndex = 35;
            this.T1_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_16.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_17
            // 
            this.T1_17.Location = new System.Drawing.Point(642, 156);
            this.T1_17.Name = "T1_17";
            this.T1_17.Size = new System.Drawing.Size(67, 22);
            this.T1_17.TabIndex = 36;
            this.T1_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_17.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_20
            // 
            this.T1_20.Location = new System.Drawing.Point(124, 185);
            this.T1_20.Name = "T1_20";
            this.T1_20.Size = new System.Drawing.Size(67, 22);
            this.T1_20.TabIndex = 37;
            this.T1_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_20.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_21
            // 
            this.T1_21.Location = new System.Drawing.Point(198, 185);
            this.T1_21.Name = "T1_21";
            this.T1_21.Size = new System.Drawing.Size(67, 22);
            this.T1_21.TabIndex = 38;
            this.T1_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_21.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_22
            // 
            this.T1_22.Location = new System.Drawing.Point(272, 185);
            this.T1_22.Name = "T1_22";
            this.T1_22.Size = new System.Drawing.Size(67, 22);
            this.T1_22.TabIndex = 39;
            this.T1_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_22.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_23
            // 
            this.T1_23.Location = new System.Drawing.Point(272, 156);
            this.T1_23.Name = "T1_23";
            this.T1_23.Size = new System.Drawing.Size(67, 22);
            this.T1_23.TabIndex = 40;
            this.T1_23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_23.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_24
            // 
            this.T1_24.Location = new System.Drawing.Point(494, 185);
            this.T1_24.Name = "T1_24";
            this.T1_24.Size = new System.Drawing.Size(67, 22);
            this.T1_24.TabIndex = 41;
            this.T1_24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_24.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_25
            // 
            this.T1_25.Location = new System.Drawing.Point(568, 185);
            this.T1_25.Name = "T1_25";
            this.T1_25.Size = new System.Drawing.Size(67, 22);
            this.T1_25.TabIndex = 42;
            this.T1_25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_25.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_26
            // 
            this.T1_26.Location = new System.Drawing.Point(642, 127);
            this.T1_26.Name = "T1_26";
            this.T1_26.Size = new System.Drawing.Size(67, 22);
            this.T1_26.TabIndex = 43;
            this.T1_26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_26.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // T1_27
            // 
            this.T1_27.Location = new System.Drawing.Point(642, 185);
            this.T1_27.Name = "T1_27";
            this.T1_27.Size = new System.Drawing.Size(67, 22);
            this.T1_27.TabIndex = 44;
            this.T1_27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T1_27.Leave += new System.EventHandler(this.textBoxDouble_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1029, 410);
            this.Controls.Add(this.groupBoxBoiler);
            this.Controls.Add(this.button_createDoc);
            this.Controls.Add(this.numericOrder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBoxT1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericBlock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEqType);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericBlock)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxT1.ResumeLayout(false);
            this.groupBoxT1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrder)).EndInit();
            this.groupBoxBoiler.ResumeLayout(false);
            this.groupBoxBoiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEqType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericBlock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxT1;
        private System.Windows.Forms.Label label_t1_1;
        private System.Windows.Forms.Label label_t1_5;
        private System.Windows.Forms.Label label_t1_4;
        private System.Windows.Forms.Label label_t1_3;
        private System.Windows.Forms.Label label_t1_2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_t1_12;
        private System.Windows.Forms.Label label_t1_11;
        private System.Windows.Forms.Label label_t1_9;
        private System.Windows.Forms.Label label_t1_8;
        private System.Windows.Forms.Label label_t1_7;
        private System.Windows.Forms.Label label_t1_6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_t1_10;
        private System.Windows.Forms.TextBox T1_00;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericOrder;
        private System.Windows.Forms.Button button_createDoc;
        private System.Windows.Forms.GroupBox groupBoxBoiler;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.TextBox T1_27;
        private System.Windows.Forms.TextBox T1_26;
        private System.Windows.Forms.TextBox T1_25;
        private System.Windows.Forms.TextBox T1_24;
        private System.Windows.Forms.TextBox T1_23;
        private System.Windows.Forms.TextBox T1_22;
        private System.Windows.Forms.TextBox T1_21;
        private System.Windows.Forms.TextBox T1_20;
        private System.Windows.Forms.TextBox T1_17;
        private System.Windows.Forms.TextBox T1_16;
        private System.Windows.Forms.TextBox T1_15;
        private System.Windows.Forms.TextBox T1_14;
        private System.Windows.Forms.TextBox T1_13;
        private System.Windows.Forms.TextBox T1_12;
        private System.Windows.Forms.TextBox T1_11;
        private System.Windows.Forms.TextBox T1_10;
        private System.Windows.Forms.TextBox T1_07;
        private System.Windows.Forms.TextBox T1_06;
        private System.Windows.Forms.TextBox T1_05;
        private System.Windows.Forms.TextBox T1_04;
        private System.Windows.Forms.TextBox T1_03;
        private System.Windows.Forms.TextBox T1_02;
        private System.Windows.Forms.TextBox T1_01;
    }
}

