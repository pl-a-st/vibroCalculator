namespace Виброкалькулятор2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDispSensFreq = new System.Windows.Forms.RadioButton();
            this.radVelSensFreq = new System.Windows.Forms.RadioButton();
            this.radAccSensFreq = new System.Windows.Forms.RadioButton();
            this.GBDisplacement = new System.Windows.Forms.GroupBox();
            this.radiDisplacementPikPik = new System.Windows.Forms.RadioButton();
            this.radDisplacementPik = new System.Windows.Forms.RadioButton();
            this.radDisplacementRMS = new System.Windows.Forms.RadioButton();
            this.TDisplacement = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.TDisplacement_dB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gBVelocity = new System.Windows.Forms.GroupBox();
            this.radVelocityPikPik = new System.Windows.Forms.RadioButton();
            this.radVelocityPik = new System.Windows.Forms.RadioButton();
            this.radVelocityRMS = new System.Windows.Forms.RadioButton();
            this.TVelocity = new System.Windows.Forms.TextBox();
            this.BVelocity_dBCopy = new System.Windows.Forms.Button();
            this.BVelocityCopy = new System.Windows.Forms.Button();
            this.TVelocity_dB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gBAcceleration = new System.Windows.Forms.GroupBox();
            this.radAccelerationPikPik = new System.Windows.Forms.RadioButton();
            this.radAccelerationPik = new System.Windows.Forms.RadioButton();
            this.radAccelerationRMS = new System.Windows.Forms.RadioButton();
            this.button8 = new System.Windows.Forms.Button();
            this.BAccelerationCopy = new System.Windows.Forms.Button();
            this.TAcceleration = new System.Windows.Forms.TextBox();
            this.TAcceleration_dB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TFrequency = new System.Windows.Forms.TextBox();
            this.TVoltage = new System.Windows.Forms.TextBox();
            this.TVoltage_dB = new System.Windows.Forms.TextBox();
            this.BFrequencyCopy = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radSensitivityMkm = new System.Windows.Forms.RadioButton();
            this.radSensitivityMm = new System.Windows.Forms.RadioButton();
            this.BSensitivityCopy = new System.Windows.Forms.Button();
            this.TSensitivity = new System.Windows.Forms.TextBox();
            this.radSensitivityM = new System.Windows.Forms.RadioButton();
            this.radSensitivityG = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radFrequencyRPM = new System.Windows.Forms.RadioButton();
            this.radFrequencyHw = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radVoltagePikPik = new System.Windows.Forms.RadioButton();
            this.radVoltagePik = new System.Windows.Forms.RadioButton();
            this.radVoltageRMS = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.channelCenter2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.channelCenter1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.channelWidth = new System.Windows.Forms.TextBox();
            this.channelCount = new System.Windows.Forms.TextBox();
            this.boundaryFrequency = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.GBDisplacement.SuspendLayout();
            this.gBVelocity.SuspendLayout();
            this.gBAcceleration.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDispSensFreq);
            this.groupBox1.Controls.Add(this.radVelSensFreq);
            this.groupBox1.Controls.Add(this.radAccSensFreq);
            this.groupBox1.Controls.Add(this.GBDisplacement);
            this.groupBox1.Controls.Add(this.gBVelocity);
            this.groupBox1.Controls.Add(this.gBAcceleration);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры вибрации";
            // 
            // radDispSensFreq
            // 
            this.radDispSensFreq.AutoSize = true;
            this.radDispSensFreq.Location = new System.Drawing.Point(7, 197);
            this.radDispSensFreq.Name = "radDispSensFreq";
            this.radDispSensFreq.Size = new System.Drawing.Size(14, 13);
            this.radDispSensFreq.TabIndex = 15;
            this.radDispSensFreq.UseVisualStyleBackColor = true;
            // 
            // radVelSensFreq
            // 
            this.radVelSensFreq.AutoSize = true;
            this.radVelSensFreq.Location = new System.Drawing.Point(7, 119);
            this.radVelSensFreq.Name = "radVelSensFreq";
            this.radVelSensFreq.Size = new System.Drawing.Size(14, 13);
            this.radVelSensFreq.TabIndex = 14;
            this.radVelSensFreq.UseVisualStyleBackColor = true;
            // 
            // radAccSensFreq
            // 
            this.radAccSensFreq.AutoSize = true;
            this.radAccSensFreq.Checked = true;
            this.radAccSensFreq.Location = new System.Drawing.Point(7, 41);
            this.radAccSensFreq.Name = "radAccSensFreq";
            this.radAccSensFreq.Size = new System.Drawing.Size(14, 13);
            this.radAccSensFreq.TabIndex = 13;
            this.radAccSensFreq.TabStop = true;
            this.radAccSensFreq.UseVisualStyleBackColor = true;
            // 
            // GBDisplacement
            // 
            this.GBDisplacement.Controls.Add(this.radiDisplacementPikPik);
            this.GBDisplacement.Controls.Add(this.radDisplacementPik);
            this.GBDisplacement.Controls.Add(this.radDisplacementRMS);
            this.GBDisplacement.Controls.Add(this.TDisplacement);
            this.GBDisplacement.Controls.Add(this.button5);
            this.GBDisplacement.Controls.Add(this.button6);
            this.GBDisplacement.Controls.Add(this.TDisplacement_dB);
            this.GBDisplacement.Controls.Add(this.label10);
            this.GBDisplacement.Location = new System.Drawing.Point(25, 175);
            this.GBDisplacement.Name = "GBDisplacement";
            this.GBDisplacement.Size = new System.Drawing.Size(398, 72);
            this.GBDisplacement.TabIndex = 12;
            this.GBDisplacement.TabStop = false;
            this.GBDisplacement.Text = "Перемещение, мкм";
            // 
            // radiDisplacementPikPik
            // 
            this.radiDisplacementPikPik.AutoSize = true;
            this.radiDisplacementPikPik.Location = new System.Drawing.Point(92, 45);
            this.radiDisplacementPikPik.Name = "radiDisplacementPikPik";
            this.radiDisplacementPikPik.Size = new System.Drawing.Size(63, 17);
            this.radiDisplacementPikPik.TabIndex = 10;
            this.radiDisplacementPikPik.Text = "Размах";
            this.radiDisplacementPikPik.UseVisualStyleBackColor = true;
            this.radiDisplacementPikPik.CheckedChanged += new System.EventHandler(this.radiDisplacementPikPik_CheckedChanged);
            // 
            // radDisplacementPik
            // 
            this.radDisplacementPik.AutoSize = true;
            this.radDisplacementPik.Location = new System.Drawing.Point(49, 45);
            this.radDisplacementPik.Name = "radDisplacementPik";
            this.radDisplacementPik.Size = new System.Drawing.Size(45, 17);
            this.radDisplacementPik.TabIndex = 10;
            this.radDisplacementPik.Text = "Пик";
            this.radDisplacementPik.UseVisualStyleBackColor = true;
            this.radDisplacementPik.CheckedChanged += new System.EventHandler(this.radDisplacementPik_CheckedChanged);
            // 
            // radDisplacementRMS
            // 
            this.radDisplacementRMS.AutoSize = true;
            this.radDisplacementRMS.Checked = true;
            this.radDisplacementRMS.Location = new System.Drawing.Point(6, 45);
            this.radDisplacementRMS.Name = "radDisplacementRMS";
            this.radDisplacementRMS.Size = new System.Drawing.Size(46, 17);
            this.radDisplacementRMS.TabIndex = 9;
            this.radDisplacementRMS.TabStop = true;
            this.radDisplacementRMS.Text = "СКЗ";
            this.radDisplacementRMS.UseVisualStyleBackColor = true;
            this.radDisplacementRMS.CheckedChanged += new System.EventHandler(this.radDisplacementRMS_CheckedChanged);
            // 
            // TDisplacement
            // 
            this.TDisplacement.Location = new System.Drawing.Point(6, 19);
            this.TDisplacement.Name = "TDisplacement";
            this.TDisplacement.Size = new System.Drawing.Size(86, 20);
            this.TDisplacement.TabIndex = 9;
            this.TDisplacement.Enter += new System.EventHandler(this.TDisplacement_Enter);
            this.TDisplacement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDisplacement_KeyPress);
            this.TDisplacement.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TDisplacement_KeyUp);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(98, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 22);
            this.button5.TabIndex = 8;
            this.button5.Text = "Копировать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(305, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 22);
            this.button6.TabIndex = 8;
            this.button6.Text = "Копировать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TDisplacement_dB
            // 
            this.TDisplacement_dB.Location = new System.Drawing.Point(210, 21);
            this.TDisplacement_dB.Name = "TDisplacement_dB";
            this.TDisplacement_dB.Size = new System.Drawing.Size(89, 20);
            this.TDisplacement_dB.TabIndex = 10;
            this.TDisplacement_dB.Enter += new System.EventHandler(this.TDisplacement_dB_Enter);
            this.TDisplacement_dB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDisplacement_dB_KeyPress);
            this.TDisplacement_dB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TDisplacement_dB_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Перемещение, дБ";
            // 
            // gBVelocity
            // 
            this.gBVelocity.Controls.Add(this.radVelocityPikPik);
            this.gBVelocity.Controls.Add(this.radVelocityPik);
            this.gBVelocity.Controls.Add(this.radVelocityRMS);
            this.gBVelocity.Controls.Add(this.TVelocity);
            this.gBVelocity.Controls.Add(this.BVelocity_dBCopy);
            this.gBVelocity.Controls.Add(this.BVelocityCopy);
            this.gBVelocity.Controls.Add(this.TVelocity_dB);
            this.gBVelocity.Controls.Add(this.label8);
            this.gBVelocity.Location = new System.Drawing.Point(25, 97);
            this.gBVelocity.Name = "gBVelocity";
            this.gBVelocity.Size = new System.Drawing.Size(398, 72);
            this.gBVelocity.TabIndex = 12;
            this.gBVelocity.TabStop = false;
            this.gBVelocity.Text = "Скорость, мм/с";
            // 
            // radVelocityPikPik
            // 
            this.radVelocityPikPik.AutoSize = true;
            this.radVelocityPikPik.Location = new System.Drawing.Point(92, 45);
            this.radVelocityPikPik.Name = "radVelocityPikPik";
            this.radVelocityPikPik.Size = new System.Drawing.Size(63, 17);
            this.radVelocityPikPik.TabIndex = 10;
            this.radVelocityPikPik.Text = "Размах";
            this.radVelocityPikPik.UseVisualStyleBackColor = true;
            this.radVelocityPikPik.CheckedChanged += new System.EventHandler(this.radVelocityPikPik_CheckedChanged);
            // 
            // radVelocityPik
            // 
            this.radVelocityPik.AutoSize = true;
            this.radVelocityPik.Location = new System.Drawing.Point(49, 45);
            this.radVelocityPik.Name = "radVelocityPik";
            this.radVelocityPik.Size = new System.Drawing.Size(45, 17);
            this.radVelocityPik.TabIndex = 10;
            this.radVelocityPik.Text = "Пик";
            this.radVelocityPik.UseVisualStyleBackColor = true;
            this.radVelocityPik.CheckedChanged += new System.EventHandler(this.radVelocityPik_CheckedChanged);
            // 
            // radVelocityRMS
            // 
            this.radVelocityRMS.AutoSize = true;
            this.radVelocityRMS.Checked = true;
            this.radVelocityRMS.Location = new System.Drawing.Point(6, 45);
            this.radVelocityRMS.Name = "radVelocityRMS";
            this.radVelocityRMS.Size = new System.Drawing.Size(46, 17);
            this.radVelocityRMS.TabIndex = 9;
            this.radVelocityRMS.TabStop = true;
            this.radVelocityRMS.Text = "СКЗ";
            this.radVelocityRMS.UseVisualStyleBackColor = true;
            this.radVelocityRMS.CheckedChanged += new System.EventHandler(this.radVelocityRMS_CheckedChanged);
            // 
            // TVelocity
            // 
            this.TVelocity.Location = new System.Drawing.Point(6, 19);
            this.TVelocity.Name = "TVelocity";
            this.TVelocity.Size = new System.Drawing.Size(86, 20);
            this.TVelocity.TabIndex = 7;
            this.TVelocity.Enter += new System.EventHandler(this.Tvelocity_Enter);
            this.TVelocity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tvelocity_KeyPress);
            this.TVelocity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TVelocity_KeyUp);
            // 
            // BVelocity_dBCopy
            // 
            this.BVelocity_dBCopy.Location = new System.Drawing.Point(305, 19);
            this.BVelocity_dBCopy.Name = "BVelocity_dBCopy";
            this.BVelocity_dBCopy.Size = new System.Drawing.Size(76, 22);
            this.BVelocity_dBCopy.TabIndex = 8;
            this.BVelocity_dBCopy.Text = "Копировать";
            this.BVelocity_dBCopy.UseVisualStyleBackColor = true;
            this.BVelocity_dBCopy.Click += new System.EventHandler(this.BVelocity_dBCopy_Click);
            // 
            // BVelocityCopy
            // 
            this.BVelocityCopy.Location = new System.Drawing.Point(98, 17);
            this.BVelocityCopy.Name = "BVelocityCopy";
            this.BVelocityCopy.Size = new System.Drawing.Size(76, 22);
            this.BVelocityCopy.TabIndex = 8;
            this.BVelocityCopy.Text = "Копировать";
            this.BVelocityCopy.UseVisualStyleBackColor = true;
            this.BVelocityCopy.Click += new System.EventHandler(this.BVelocityCopy_Click);
            // 
            // TVelocity_dB
            // 
            this.TVelocity_dB.Location = new System.Drawing.Point(210, 19);
            this.TVelocity_dB.Name = "TVelocity_dB";
            this.TVelocity_dB.Size = new System.Drawing.Size(89, 20);
            this.TVelocity_dB.TabIndex = 8;
            this.TVelocity_dB.Enter += new System.EventHandler(this.Tvelocity_dB_Enter);
            this.TVelocity_dB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tvelocity_dB_KeyPress);
            this.TVelocity_dB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TVelocity_dB_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Скорость,  дБ";
            // 
            // gBAcceleration
            // 
            this.gBAcceleration.Controls.Add(this.radAccelerationPikPik);
            this.gBAcceleration.Controls.Add(this.radAccelerationPik);
            this.gBAcceleration.Controls.Add(this.radAccelerationRMS);
            this.gBAcceleration.Controls.Add(this.button8);
            this.gBAcceleration.Controls.Add(this.BAccelerationCopy);
            this.gBAcceleration.Controls.Add(this.TAcceleration);
            this.gBAcceleration.Controls.Add(this.TAcceleration_dB);
            this.gBAcceleration.Controls.Add(this.label4);
            this.gBAcceleration.Location = new System.Drawing.Point(25, 19);
            this.gBAcceleration.Name = "gBAcceleration";
            this.gBAcceleration.Size = new System.Drawing.Size(398, 72);
            this.gBAcceleration.TabIndex = 12;
            this.gBAcceleration.TabStop = false;
            this.gBAcceleration.Text = "Ускорение, м/с²";
            // 
            // radAccelerationPikPik
            // 
            this.radAccelerationPikPik.AutoSize = true;
            this.radAccelerationPikPik.Location = new System.Drawing.Point(92, 45);
            this.radAccelerationPikPik.Name = "radAccelerationPikPik";
            this.radAccelerationPikPik.Size = new System.Drawing.Size(63, 17);
            this.radAccelerationPikPik.TabIndex = 10;
            this.radAccelerationPikPik.Text = "Размах";
            this.radAccelerationPikPik.UseVisualStyleBackColor = true;
            this.radAccelerationPikPik.CheckedChanged += new System.EventHandler(this.radAccelerationPikPik_CheckedChanged);
            // 
            // radAccelerationPik
            // 
            this.radAccelerationPik.AutoSize = true;
            this.radAccelerationPik.Location = new System.Drawing.Point(49, 45);
            this.radAccelerationPik.Name = "radAccelerationPik";
            this.radAccelerationPik.Size = new System.Drawing.Size(45, 17);
            this.radAccelerationPik.TabIndex = 10;
            this.radAccelerationPik.Text = "Пик";
            this.radAccelerationPik.UseVisualStyleBackColor = true;
            this.radAccelerationPik.CheckedChanged += new System.EventHandler(this.radAccelerationPik_CheckedChanged);
            // 
            // radAccelerationRMS
            // 
            this.radAccelerationRMS.AutoSize = true;
            this.radAccelerationRMS.Checked = true;
            this.radAccelerationRMS.Location = new System.Drawing.Point(6, 45);
            this.radAccelerationRMS.Name = "radAccelerationRMS";
            this.radAccelerationRMS.Size = new System.Drawing.Size(46, 17);
            this.radAccelerationRMS.TabIndex = 9;
            this.radAccelerationRMS.TabStop = true;
            this.radAccelerationRMS.Text = "СКЗ";
            this.radAccelerationRMS.UseVisualStyleBackColor = true;
            this.radAccelerationRMS.CheckedChanged += new System.EventHandler(this.radAccelerationRMS_CheckedChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(305, 17);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 22);
            this.button8.TabIndex = 8;
            this.button8.Text = "Копировать";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // BAccelerationCopy
            // 
            this.BAccelerationCopy.Location = new System.Drawing.Point(98, 17);
            this.BAccelerationCopy.Name = "BAccelerationCopy";
            this.BAccelerationCopy.Size = new System.Drawing.Size(76, 22);
            this.BAccelerationCopy.TabIndex = 8;
            this.BAccelerationCopy.Text = "Копировать";
            this.BAccelerationCopy.UseVisualStyleBackColor = true;
            this.BAccelerationCopy.Click += new System.EventHandler(this.BAccelerationCopy_Click);
            // 
            // TAcceleration
            // 
            this.TAcceleration.Location = new System.Drawing.Point(6, 19);
            this.TAcceleration.Name = "TAcceleration";
            this.TAcceleration.Size = new System.Drawing.Size(86, 20);
            this.TAcceleration.TabIndex = 5;
            this.TAcceleration.TextChanged += new System.EventHandler(this.TAcceleration_TextChanged);
            this.TAcceleration.Enter += new System.EventHandler(this.TAcceleration_Enter);
            this.TAcceleration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TAcceleration_KeyPress);
            this.TAcceleration.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TAcceleration_KeyUp);
            // 
            // TAcceleration_dB
            // 
            this.TAcceleration_dB.Location = new System.Drawing.Point(210, 19);
            this.TAcceleration_dB.Name = "TAcceleration_dB";
            this.TAcceleration_dB.Size = new System.Drawing.Size(89, 20);
            this.TAcceleration_dB.TabIndex = 6;
            this.TAcceleration_dB.TextChanged += new System.EventHandler(this.TAcceleration_dB_TextChanged);
            this.TAcceleration_dB.Enter += new System.EventHandler(this.TAcceleration_dB_Enter);
            this.TAcceleration_dB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TAcceleration_dB_KeyPress);
            this.TAcceleration_dB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TAcceleration_dB_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ускорение,  дБ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Напряжение, дБ";
            // 
            // TFrequency
            // 
            this.TFrequency.Location = new System.Drawing.Point(6, 19);
            this.TFrequency.Name = "TFrequency";
            this.TFrequency.Size = new System.Drawing.Size(89, 20);
            this.TFrequency.TabIndex = 1;
            this.TFrequency.Text = "159,2";
            this.TFrequency.TextChanged += new System.EventHandler(this.TFrequency_TextChanged);
            this.TFrequency.Enter += new System.EventHandler(this.TFrequency_Enter);
            this.TFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TFrequency_KeyPress);
            this.TFrequency.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TFrequency_KeyUp);
            // 
            // TVoltage
            // 
            this.TVoltage.Location = new System.Drawing.Point(6, 19);
            this.TVoltage.Name = "TVoltage";
            this.TVoltage.Size = new System.Drawing.Size(90, 20);
            this.TVoltage.TabIndex = 3;
            this.TVoltage.Text = "100";
            this.TVoltage.Enter += new System.EventHandler(this.TVoltage_Enter);
            this.TVoltage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TVoltage_KeyPress);
            this.TVoltage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TVoltage_KeyUp);
            // 
            // TVoltage_dB
            // 
            this.TVoltage_dB.Location = new System.Drawing.Point(459, 148);
            this.TVoltage_dB.Name = "TVoltage_dB";
            this.TVoltage_dB.Size = new System.Drawing.Size(90, 20);
            this.TVoltage_dB.TabIndex = 4;
            this.TVoltage_dB.Enter += new System.EventHandler(this.TVoltage_dB_Enter);
            this.TVoltage_dB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TVoltage_dB_KeyPress);
            this.TVoltage_dB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TVoltage_dB_KeyUp);
            // 
            // BFrequencyCopy
            // 
            this.BFrequencyCopy.Location = new System.Drawing.Point(101, 19);
            this.BFrequencyCopy.Name = "BFrequencyCopy";
            this.BFrequencyCopy.Size = new System.Drawing.Size(76, 22);
            this.BFrequencyCopy.TabIndex = 8;
            this.BFrequencyCopy.TabStop = false;
            this.BFrequencyCopy.Text = "Копировать";
            this.BFrequencyCopy.UseVisualStyleBackColor = true;
            this.BFrequencyCopy.Click += new System.EventHandler(this.BFrequencyCopy_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(102, 17);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 22);
            this.button9.TabIndex = 8;
            this.button9.Text = "Копировать";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(555, 146);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(76, 22);
            this.button10.TabIndex = 8;
            this.button10.Text = "Копировать";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radSensitivityMkm);
            this.groupBox2.Controls.Add(this.radSensitivityMm);
            this.groupBox2.Controls.Add(this.BSensitivityCopy);
            this.groupBox2.Controls.Add(this.TSensitivity);
            this.groupBox2.Controls.Add(this.radSensitivityM);
            this.groupBox2.Controls.Add(this.radSensitivityG);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "КП датчика";
            // 
            // radSensitivityMkm
            // 
            this.radSensitivityMkm.AutoSize = true;
            this.radSensitivityMkm.Location = new System.Drawing.Point(125, 69);
            this.radSensitivityMkm.Name = "radSensitivityMkm";
            this.radSensitivityMkm.Size = new System.Drawing.Size(67, 17);
            this.radSensitivityMkm.TabIndex = 15;
            this.radSensitivityMkm.Text = "мВ/мкм";
            this.radSensitivityMkm.UseVisualStyleBackColor = true;
            this.radSensitivityMkm.CheckedChanged += new System.EventHandler(this.radSensitivityMkm_CheckedChanged);
            // 
            // radSensitivityMm
            // 
            this.radSensitivityMm.AutoSize = true;
            this.radSensitivityMm.Location = new System.Drawing.Point(125, 46);
            this.radSensitivityMm.Name = "radSensitivityMm";
            this.radSensitivityMm.Size = new System.Drawing.Size(74, 17);
            this.radSensitivityMm.TabIndex = 14;
            this.radSensitivityMm.Text = "мВ/м•с ̄ ¹";
            this.radSensitivityMm.UseVisualStyleBackColor = true;
            this.radSensitivityMm.CheckedChanged += new System.EventHandler(this.radSensitivityMm_CheckedChanged);
            // 
            // BSensitivityCopy
            // 
            this.BSensitivityCopy.Location = new System.Drawing.Point(123, 17);
            this.BSensitivityCopy.Name = "BSensitivityCopy";
            this.BSensitivityCopy.Size = new System.Drawing.Size(76, 22);
            this.BSensitivityCopy.TabIndex = 13;
            this.BSensitivityCopy.TabStop = false;
            this.BSensitivityCopy.Text = "Копировать";
            this.BSensitivityCopy.UseVisualStyleBackColor = true;
            this.BSensitivityCopy.Click += new System.EventHandler(this.BSensitivityCopy_Click);
            // 
            // TSensitivity
            // 
            this.TSensitivity.Location = new System.Drawing.Point(31, 19);
            this.TSensitivity.Name = "TSensitivity";
            this.TSensitivity.Size = new System.Drawing.Size(86, 20);
            this.TSensitivity.TabIndex = 1;
            this.TSensitivity.Text = "100";
            this.TSensitivity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TSensitivity_KeyPress_1);
            this.TSensitivity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TSensitivity_KeyUp);
            // 
            // radSensitivityM
            // 
            this.radSensitivityM.AutoSize = true;
            this.radSensitivityM.Location = new System.Drawing.Point(31, 69);
            this.radSensitivityM.Name = "radSensitivityM";
            this.radSensitivityM.Size = new System.Drawing.Size(74, 17);
            this.radSensitivityM.TabIndex = 11;
            this.radSensitivityM.Text = "мВ/м•с ̄ ²";
            this.radSensitivityM.UseVisualStyleBackColor = true;
            this.radSensitivityM.CheckedChanged += new System.EventHandler(this.radSensitivityM_CheckedChanged);
            // 
            // radSensitivityG
            // 
            this.radSensitivityG.AutoSize = true;
            this.radSensitivityG.Checked = true;
            this.radSensitivityG.Location = new System.Drawing.Point(31, 46);
            this.radSensitivityG.Name = "radSensitivityG";
            this.radSensitivityG.Size = new System.Drawing.Size(51, 17);
            this.radSensitivityG.TabIndex = 10;
            this.radSensitivityG.Text = "мВ/g";
            this.radSensitivityG.UseVisualStyleBackColor = true;
            this.radSensitivityG.CheckedChanged += new System.EventHandler(this.radSensitivityG_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radFrequencyRPM);
            this.groupBox3.Controls.Add(this.radFrequencyHw);
            this.groupBox3.Controls.Add(this.TFrequency);
            this.groupBox3.Controls.Add(this.BFrequencyCopy);
            this.groupBox3.Location = new System.Drawing.Point(247, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Частота, Гц";
            // 
            // radFrequencyRPM
            // 
            this.radFrequencyRPM.AutoSize = true;
            this.radFrequencyRPM.Location = new System.Drawing.Point(50, 46);
            this.radFrequencyRPM.Name = "radFrequencyRPM";
            this.radFrequencyRPM.Size = new System.Drawing.Size(70, 17);
            this.radFrequencyRPM.TabIndex = 10;
            this.radFrequencyRPM.Text = "Об./мин.";
            this.radFrequencyRPM.UseVisualStyleBackColor = true;
            this.radFrequencyRPM.CheckedChanged += new System.EventHandler(this.radFrequencyRPM_CheckedChanged);
            // 
            // radFrequencyHw
            // 
            this.radFrequencyHw.AutoSize = true;
            this.radFrequencyHw.Checked = true;
            this.radFrequencyHw.Location = new System.Drawing.Point(6, 45);
            this.radFrequencyHw.Name = "radFrequencyHw";
            this.radFrequencyHw.Size = new System.Drawing.Size(37, 17);
            this.radFrequencyHw.TabIndex = 9;
            this.radFrequencyHw.Text = "Гц";
            this.radFrequencyHw.UseVisualStyleBackColor = true;
            this.radFrequencyHw.CheckedChanged += new System.EventHandler(this.radFrequencyHw_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radVoltagePikPik);
            this.groupBox4.Controls.Add(this.radVoltagePik);
            this.groupBox4.Controls.Add(this.radVoltageRMS);
            this.groupBox4.Controls.Add(this.TVoltage);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Location = new System.Drawing.Point(453, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 72);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Напряжение, мВ";
            // 
            // radVoltagePikPik
            // 
            this.radVoltagePikPik.AutoSize = true;
            this.radVoltagePikPik.Location = new System.Drawing.Point(92, 45);
            this.radVoltagePikPik.Name = "radVoltagePikPik";
            this.radVoltagePikPik.Size = new System.Drawing.Size(63, 17);
            this.radVoltagePikPik.TabIndex = 10;
            this.radVoltagePikPik.Text = "Размах";
            this.radVoltagePikPik.UseVisualStyleBackColor = true;
            this.radVoltagePikPik.CheckedChanged += new System.EventHandler(this.radVoltagePikPik_CheckedChanged);
            // 
            // radVoltagePik
            // 
            this.radVoltagePik.AutoSize = true;
            this.radVoltagePik.Location = new System.Drawing.Point(49, 45);
            this.radVoltagePik.Name = "radVoltagePik";
            this.radVoltagePik.Size = new System.Drawing.Size(45, 17);
            this.radVoltagePik.TabIndex = 10;
            this.radVoltagePik.Text = "Пик";
            this.radVoltagePik.UseVisualStyleBackColor = true;
            this.radVoltagePik.CheckedChanged += new System.EventHandler(this.radVoltagePik_CheckedChanged);
            // 
            // radVoltageRMS
            // 
            this.radVoltageRMS.AutoSize = true;
            this.radVoltageRMS.Checked = true;
            this.radVoltageRMS.Location = new System.Drawing.Point(6, 45);
            this.radVoltageRMS.Name = "radVoltageRMS";
            this.radVoltageRMS.Size = new System.Drawing.Size(46, 17);
            this.radVoltageRMS.TabIndex = 9;
            this.radVoltageRMS.TabStop = true;
            this.radVoltageRMS.Text = "СКЗ";
            this.radVoltageRMS.UseVisualStyleBackColor = true;
            this.radVoltageRMS.CheckedChanged += new System.EventHandler(this.radVoltageRMS_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.button7);
            this.groupBox8.Controls.Add(this.button4);
            this.groupBox8.Controls.Add(this.button3);
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.button1);
            this.groupBox8.Controls.Add(this.channelCenter2);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.channelCenter1);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.channelWidth);
            this.groupBox8.Controls.Add(this.channelCount);
            this.groupBox8.Controls.Add(this.boundaryFrequency);
            this.groupBox8.Location = new System.Drawing.Point(453, 184);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(210, 195);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Автоспектры";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "F2, Гц";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "F1, Гц";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(121, 150);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 22);
            this.button7.TabIndex = 17;
            this.button7.Text = "Копировать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(121, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 22);
            this.button4.TabIndex = 16;
            this.button4.Text = "Копировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 22);
            this.button3.TabIndex = 15;
            this.button3.Text = "Копировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 22);
            this.button2.TabIndex = 14;
            this.button2.Text = "Копировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 13;
            this.button1.Text = "Копировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // channelCenter2
            // 
            this.channelCenter2.Location = new System.Drawing.Point(52, 150);
            this.channelCenter2.Name = "channelCenter2";
            this.channelCenter2.ReadOnly = true;
            this.channelCenter2.Size = new System.Drawing.Size(63, 20);
            this.channelCenter2.TabIndex = 12;
            this.channelCenter2.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ближайшие центры каналов";
            // 
            // channelCenter1
            // 
            this.channelCenter1.Location = new System.Drawing.Point(52, 124);
            this.channelCenter1.Name = "channelCenter1";
            this.channelCenter1.ReadOnly = true;
            this.channelCenter1.Size = new System.Drawing.Size(63, 20);
            this.channelCenter1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ΔF, Гц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "N, линий";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fгр, Гц";
            // 
            // channelWidth
            // 
            this.channelWidth.Location = new System.Drawing.Point(52, 79);
            this.channelWidth.Name = "channelWidth";
            this.channelWidth.ReadOnly = true;
            this.channelWidth.Size = new System.Drawing.Size(63, 20);
            this.channelWidth.TabIndex = 8;
            // 
            // channelCount
            // 
            this.channelCount.Location = new System.Drawing.Point(52, 53);
            this.channelCount.Name = "channelCount";
            this.channelCount.Size = new System.Drawing.Size(63, 20);
            this.channelCount.TabIndex = 8;
            this.channelCount.Text = "1600";
            this.channelCount.Enter += new System.EventHandler(this.channelCount_Enter);
            this.channelCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.channelCount_KeyPress);
            this.channelCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.channelCount_KeyUp);
            // 
            // boundaryFrequency
            // 
            this.boundaryFrequency.Location = new System.Drawing.Point(52, 27);
            this.boundaryFrequency.Name = "boundaryFrequency";
            this.boundaryFrequency.Size = new System.Drawing.Size(63, 20);
            this.boundaryFrequency.TabIndex = 8;
            this.boundaryFrequency.Text = "1600";
            this.boundaryFrequency.TextChanged += new System.EventHandler(this.boundaryFrequency_TextChanged);
            this.boundaryFrequency.Enter += new System.EventHandler(this.boundaryFrequency_Enter);
            this.boundaryFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boundaryFrequency_KeyPress);
            this.boundaryFrequency.KeyUp += new System.Windows.Forms.KeyEventHandler(this.boundaryFrequency_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 393);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.TVoltage_dB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Пересчет параметров ГАРМОНИЧЕСКОЙ вибрации!!!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBDisplacement.ResumeLayout(false);
            this.GBDisplacement.PerformLayout();
            this.gBVelocity.ResumeLayout(false);
            this.gBVelocity.PerformLayout();
            this.gBAcceleration.ResumeLayout(false);
            this.gBAcceleration.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TDisplacement_dB;
        private System.Windows.Forms.TextBox TVelocity_dB;
        private System.Windows.Forms.TextBox TAcceleration_dB;
        private System.Windows.Forms.TextBox TDisplacement;
        private System.Windows.Forms.TextBox TVelocity;
        private System.Windows.Forms.TextBox TAcceleration;
        private System.Windows.Forms.TextBox TFrequency;
        private System.Windows.Forms.TextBox TVoltage;
        private System.Windows.Forms.TextBox TVoltage_dB;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button BVelocity_dBCopy;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BVelocityCopy;
        private System.Windows.Forms.Button BAccelerationCopy;
        private System.Windows.Forms.Button BFrequencyCopy;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BSensitivityCopy;
        private System.Windows.Forms.TextBox TSensitivity;
        private System.Windows.Forms.RadioButton radSensitivityM;
        private System.Windows.Forms.RadioButton radSensitivityG;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radFrequencyRPM;
        private System.Windows.Forms.RadioButton radFrequencyHw;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radVoltagePikPik;
        private System.Windows.Forms.RadioButton radVoltagePik;
        private System.Windows.Forms.RadioButton radVoltageRMS;
        private System.Windows.Forms.GroupBox GBDisplacement;
        private System.Windows.Forms.RadioButton radiDisplacementPikPik;
        private System.Windows.Forms.RadioButton radDisplacementPik;
        private System.Windows.Forms.RadioButton radDisplacementRMS;
        private System.Windows.Forms.GroupBox gBVelocity;
        private System.Windows.Forms.RadioButton radVelocityPikPik;
        private System.Windows.Forms.RadioButton radVelocityPik;
        private System.Windows.Forms.RadioButton radVelocityRMS;
        private System.Windows.Forms.GroupBox gBAcceleration;
        private System.Windows.Forms.RadioButton radAccelerationPikPik;
        private System.Windows.Forms.RadioButton radAccelerationPik;
        private System.Windows.Forms.RadioButton radAccelerationRMS;
        private System.Windows.Forms.RadioButton radDispSensFreq;
        private System.Windows.Forms.RadioButton radVelSensFreq;
        private System.Windows.Forms.RadioButton radAccSensFreq;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox channelWidth;
        private System.Windows.Forms.TextBox channelCount;
        private System.Windows.Forms.TextBox boundaryFrequency;
        private System.Windows.Forms.TextBox channelCenter2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox channelCenter1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radSensitivityMkm;
        private System.Windows.Forms.RadioButton radSensitivityMm;
    }
}

