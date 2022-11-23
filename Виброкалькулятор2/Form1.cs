using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; // для работы NumberFormatInfo.

namespace Виброкалькулятор2
{

    public partial class Form1 : Form
    {
        public static string Symbol1=""; //переменная для хранения символа
        public static string String1 = ""; //переменная для хранения строки
        public static string strFlagType = "";
        public static bool EKeyChar = false, Point1 = false, Minus1 = false; // подтверждение необходимости отмены ввода, флаг постановки запятой, флаг постановки минуса
        public static bool bSensitivity = false, bFrequency = false, bAcceleration = false, bAcceleration_dB = false,
            bVoltage = false, bVoltage_dB = false, bVelocity = false, bVelocity_dB =false, bDisplacement=false, 
            bDisplacement_dB=false;
        public static int backspase1 = 0, backspase2 = 0, EKey=0, vRound =0;// счетчик введенных символов, порядковый номер на котором поставили разделитель
        public static double sensitivity, frequency, acceleration, acceleration_dB, voltage, voltage_db,
           velocity, velocity_dB, displacement, displacement_dB, vaError,chError, permVError=0.1;
         public Form1()
        {
            InitializeComponent();
        }
        public string FlagType()// расставляем флаги выбора
        {
            bSensitivity = false;
            bFrequency = false;
            bAcceleration = false;
            bAcceleration_dB = false;
            bVoltage = false;
            bVoltage_dB = false;
            bVelocity = false;
            bVelocity_dB = false;
            bDisplacement = false;
            bDisplacement_dB = false;

            switch (strFlagType)
            {

                case "Sensitivity":
                    bSensitivity = true;
                    break;
                case "Frequency":
                    bFrequency = true;
                    break;
                case "Acceleration":
                    bAcceleration = true;
                    break;
                case "Acceleration_dB":
                    bAcceleration_dB = true;
                    break;
                case "Voltage":
                    bVoltage = true;
                    break;
                case "Voltage_dB":
                    bVoltage_dB = true;
                    break;
                case "Velocity":
                    bVelocity = true;
                    break;
                case "Velocity_dB":
                    bVelocity_dB = true;
                    break;
                case "Displacement":
                    bDisplacement = true;
                    break;
                case "Displacement_dB":
                    bDisplacement_dB = true;
                    break;
            }

            return strFlagType;

        }
        public string Сalculate()// все переводим в изначальные единицы, все считаем и заносим в соответствующие поля
        {
            try
            {
                if (radSensitivityG.Checked)
                {
                    sensitivity = Convert.ToDouble(TSensitivity.Text);
                }
                else
                {
                    sensitivity = Convert.ToDouble(TSensitivity.Text) * 9.807;
                }
            }
            catch
            { }
            try
            {
                if (radFrequencyHw.Checked)
                {
                    frequency = Convert.ToDouble(TFrequency.Text);
                }
                else
                {
                    frequency = Convert.ToDouble(TFrequency.Text) / 60;
                }
            }
            catch
            { }
            try
            {
                if (radVoltageRMS.Checked)
                {
                    voltage = Convert.ToDouble(TVoltage.Text);
                }
                else
                {
                    if (radVoltagePik.Checked)
                    {
                        voltage = Convert.ToDouble(TVoltage.Text) / Math.Sqrt(2);
                    }
                    else
                    {
                        voltage = Convert.ToDouble(TVoltage.Text) / 2 / Math.Sqrt(2);
                    }
                }
            }
            catch
            { }
            try
            {voltage_db = Convert.ToDouble(TVoltage_dB.Text); }
            catch
            { }

            try
            {acceleration_dB = Convert.ToDouble(TAcceleration_dB.Text); }
            catch
            { }
            try
            {//velocity = Convert.ToDouble(TVelocity.Text); }
                if (radVelocityRMS.Checked)
                {
                    velocity = Convert.ToDouble(TVelocity.Text);
                }
                else
                {
                    if (radVelocityPik.Checked)
                    {
                        velocity = Convert.ToDouble(TVelocity.Text) / Math.Sqrt(2);
                    }
                    else
                    {
                        velocity = Convert.ToDouble(TVelocity.Text) / 2 / Math.Sqrt(2);
                    }
                }
            }
            catch
            { }
            try
            {velocity_dB = Convert.ToDouble(TVelocity_dB.Text); }
            catch
            { }
            try
            {//displacement = Convert.ToDouble(TDisplacement.Text); }
                if (radDisplacementRMS.Checked)
                {
                    displacement = Convert.ToDouble(TDisplacement.Text);
                }
                else
                {
                    if (radDisplacementPik.Checked)
                    {
                        displacement = Convert.ToDouble(TDisplacement.Text) / Math.Sqrt(2);
                    }
                    else
                    {
                        displacement = Convert.ToDouble(TDisplacement.Text) / 2 / Math.Sqrt(2);
                    }
                }
            }
            catch
            { }
            try
            {displacement_dB = Convert.ToDouble(TDisplacement_dB.Text); }
            catch
            { }
            try
            {//acceleration = Convert.ToDouble(TAcceleration.Text);}
                if (radAccelerationRMS.Checked)
                {
                    acceleration = Convert.ToDouble(TAcceleration.Text);
                }
                else
                {
                    if (radAccelerationPik.Checked)
                    {
                        acceleration = Convert.ToDouble(TAcceleration.Text) / Math.Sqrt(2);
                    }
                    else
                    {
                        acceleration = Convert.ToDouble(TAcceleration.Text) / 2 / Math.Sqrt(2);
                    }
                }
            }
            catch
            { }

            switch (strFlagType)
            {
                case "Sensitivity":
                    if (radVelSensFreq.Checked)
                    {
                        try
                        { voltage = velocity * 2 * Math.PI * frequency / Math.Pow(10, 3) * sensitivity / 9.807; }
                        catch
                        { }
                    }
                    else
                    {
                        if(radDispSensFreq.Checked)
                        {
                            try
                            {
                                voltage = displacement * 4 * Math.PI * frequency * Math.PI * frequency / Math.Pow(10, 6) *
                                          sensitivity / 9.807;
                            }
                            catch
                            { }
                        }
                    }
                    break;
                case "Frequency":
                    if (radVelSensFreq.Checked)
                    {
                        try
                        { voltage = velocity * 2 * Math.PI * frequency / Math.Pow(10, 3) * sensitivity / 9.807; }
                        catch
                        { }
                    }
                    else
                    {
                        if (radDispSensFreq.Checked)
                        {
                            try
                            {
                                voltage = displacement * 4 * Math.PI * frequency * Math.PI * frequency / Math.Pow(10, 6) *
                                          sensitivity / 9.807;
                            }
                            catch
                            { }
                        }
                    }
                    break;
                case "Acceleration":
                    try
                    { voltage = acceleration * sensitivity / 9.807; }
                    catch
                    { }
                    break;
                case "Acceleration_dB":
                    try
                    { voltage =  Math.Pow(10, (acceleration_dB / 20))*Math.Pow(10, -6)*sensitivity/9.807; }
                    catch
                    { voltage = 123; }
                    break;
                case "Voltage":

                    break;
                case "Voltage_dB":
                    try
                    { voltage = Math.Pow(10, voltage_db / 20) * Math.Pow(10, -6)*1000; }
                    catch
                    { }
                    break;
                case "Velocity":
                    try
                    { voltage = velocity * 2 * Math.PI * frequency / Math.Pow(10, 3) * sensitivity / 9.807; }
                    catch
                    { }
                    break;
                case "Velocity_dB":
                    try
                    {
                        voltage = Math.Pow(10, velocity_dB / 20) * Math.Pow(10, -6) * 2 * Math.PI * frequency /
                                  Math.Pow(10, 3) * sensitivity / 9.807;
                    }
                    catch
                    { }
                    break;
                case "Displacement":
                    try
                    {
                        voltage = displacement * 4 * Math.PI * frequency * Math.PI * frequency / Math.Pow(10, 6) *
                                  sensitivity / 9.807;
                    }
                    catch
                    { }
                    break;
                case "Displacement_dB":
                    try
                    {
                        voltage = Math.Pow(10, displacement_dB / 20) * Math.Pow(10, -6) * 4 * Math.PI *
                                   frequency * Math.PI * frequency / Math.Pow(10, 6) * sensitivity / 9.807;
                    }
                    catch
                    { }
                    break;
            }
       
            if (strFlagType != "Voltage")
            {
                try
                {
                    if(radVoltageRMS.Checked)
                    {
                        chError = voltage;
                        TVoltage.Text = Convert.ToString(Math.Round(voltage, checkRound()));
                    }
                    else
                    {
                        if(radVoltagePik.Checked)
                        {
                            chError = voltage*Math.Sqrt(2);
                            TVoltage.Text = Convert.ToString(Math.Round(voltage * Math.Sqrt(2), checkRound()));
                        }
                        else
                        {
                            chError = voltage * 2*Math.Sqrt(2);
                            TVoltage.Text = Convert.ToString(Math.Round(voltage * 2 * Math.Sqrt(2), checkRound()));
                        }

                    }
                   
                }
                catch
                { TVoltage.Text = "нет данных"; }
            }
            if (strFlagType != "Voltage_dB")
            {
                try
                {
                    voltage_db = 20 * Math.Log10(voltage/1000 / Math.Pow(10, -6));
                    chError = voltage_db;
                    //voltage_db = ;
                    TVoltage_dB.Text = Convert.ToString(Math.Round(voltage_db, checkRound()));
                }
                catch
                { TVoltage_dB.Text = "нет данных"; }
            }
            if (strFlagType != "Acceleration")
            {
                try
                {
                    acceleration = voltage * 9.807 / sensitivity;
                    //chError = acceleration;
                    //acceleration = Math.Round(acceleration, checkRound());
                    //TAcceleration.Text = Convert.ToString(acceleration);
                    if (radAccelerationRMS.Checked)
                    {
                        chError = acceleration;
                        //acceleration = ;
                        TAcceleration.Text = Convert.ToString(Math.Round(acceleration, checkRound()));
                    }
                    else
                    {
                        if (radAccelerationPik.Checked)
                        {
                            chError = acceleration * Math.Sqrt(2);
                            TAcceleration.Text = Convert.ToString(Math.Round(acceleration * Math.Sqrt(2), checkRound()));
                        }
                        else
                        {
                            chError = acceleration * 2 * Math.Sqrt(2);
                            TAcceleration.Text = Convert.ToString(Math.Round(acceleration * 2 * Math.Sqrt(2), checkRound()));
                        }

                    }
                }
                catch
                { TAcceleration.Text = "нет данных"; }
            }
            if (strFlagType != "Acceleration_dB")
            {
                try
                {
                    acceleration_dB = 20 * Math.Log10(voltage * 9.807 / sensitivity / Math.Pow(10, -6));
                    chError = acceleration_dB;
                    //acceleration_dB = ;
                    TAcceleration_dB.Text = Convert.ToString(Math.Round(acceleration_dB, checkRound()));
                }
                catch
                { TAcceleration_dB.Text = "нет данных"; }
            }
            if (strFlagType != "Velocity")
            {

                if (strFlagType == "Velocity_dB" || !radVelSensFreq.Checked) // если изменяются Дб виброскорости или установлен радбатон отсчитывать отностиельно виброскорости 
                {
                    try
                    {
                        velocity = voltage * 9.807 / sensitivity / 2 / Math.PI / frequency * Math.Pow(10, 3);
                        //chError = velocity;
                        //velocity = Math.Round(velocity, checkRound());
                        //TVelocity.Text = Convert.ToString(velocity);
                        if (radVelocityRMS.Checked)
                        {
                            chError = velocity;
                            TVelocity.Text = Convert.ToString(Math.Round(velocity, checkRound()));
                        }
                        else
                        {
                            if (radVelocityPik.Checked)
                            {
                                chError = velocity * Math.Sqrt(2);
                                TVelocity.Text = Convert.ToString(Math.Round(velocity * Math.Sqrt(2), checkRound()));
                            }
                            else
                            {
                                chError = velocity * 2 * Math.Sqrt(2);
                                TVelocity.Text = Convert.ToString(Math.Round(velocity * 2 * Math.Sqrt(2), checkRound()));
                            }

                        }
                    }
                    catch
                    { TVelocity.Text = "нет данных"; }
                }
            }
            if (strFlagType != "Velocity_dB")
            {
                try
                {
                    velocity_dB = 20 * Math.Log10(voltage * 9.807 / sensitivity / 2 / Math.PI / frequency *
                Math.Pow(10, 3) / Math.Pow(10, -6));
                    chError = velocity_dB;
                    //velocity_dB = ;
                    TVelocity_dB.Text = Convert.ToString(Math.Round(velocity_dB, checkRound()));
                }
                catch
                { TVelocity_dB.Text = "нет данных"; }
            }
            if (strFlagType != "Displacement")
            {
                try
                {
                    displacement = voltage * 9.807 / sensitivity / 4 / Math.PI / frequency / Math.PI / frequency
                * Math.Pow(10, 6);
                    //chError = displacement;
                    //displacement = Math.Round(displacement, checkRound());
                    //TDisplacement.Text = Convert.ToString(displacement);
                    if (radDisplacementRMS.Checked)
                    {
                        chError = displacement;
                        TDisplacement.Text = Convert.ToString(Math.Round(displacement, checkRound()));
                    }
                    else
                    {
                        if (radDisplacementPik.Checked)
                        {
                            chError = displacement * Math.Sqrt(2);
                            TDisplacement.Text = Convert.ToString(Math.Round(displacement * Math.Sqrt(2), checkRound()));
                        }
                        else
                        {
                            chError = displacement * 2 * Math.Sqrt(2);
                            TDisplacement.Text = Convert.ToString(Math.Round(displacement * 2 * Math.Sqrt(2), checkRound()));
                        }

                    }
                }
                catch
                { TDisplacement.Text = "нет данных"; }
            }
            if (strFlagType != "Displacement_dB")
            {
                try
                {
                    displacement_dB = 20 * Math.Log10(voltage * 9.807 / sensitivity / 4 / Math.PI / frequency
                / Math.PI / frequency * Math.Pow(10, 6) / Math.Pow(10, -6));
                    chError = displacement_dB;
                    //displacement_dB = ;
                    TDisplacement_dB.Text = Convert.ToString(Math.Round(displacement_dB, checkRound()));
                }
                catch
                { TDisplacement_dB.Text = "нет данных"; }
            }
            try
            {
                //считаем ширину канала
                chError = Convert.ToDouble(boundaryFrequency.Text) / Convert.ToDouble(channelCount.Text);

                channelWidth.Text = Convert.ToString(Math.Round(Convert.ToDouble(boundaryFrequency.Text) / Convert.ToDouble(channelCount.Text), checkRound()));
            }
            catch
            {


            }
            try
            {
                //рассчитываем центры каналов
                channelCenter1.Text = Convert.ToString(Convert.ToDouble(boundaryFrequency.Text) / Convert.ToDouble(channelCount.Text) * Math.Floor(frequency / (Convert.ToDouble(boundaryFrequency.Text) / Convert.ToDouble(channelCount.Text))));
                channelCenter2.Text = Convert.ToString(Convert.ToDouble(boundaryFrequency.Text) / Convert.ToDouble(channelCount.Text) * Math.Ceiling(frequency / (Convert.ToDouble(boundaryFrequency.Text) / Convert.ToDouble(channelCount.Text))));
            }
            catch
            {

            }
            return strFlagType;
        }
        // проверка на разделитель
        public int EKeyCheck()
        {
            if (EKey == 46 || EKey == 44)
            {
                EKey = Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator);
            }
            return EKey;

        }
       //проверять на сколько округлять
        public int checkRound()
        {
           try
            {
                vRound = 0;
                while (chError <= 1000 && vRound <= 5) 
                {
                    chError = chError * 10;
                    vRound++;
                }
                
                return vRound;
            }
            catch
            {
                return 0;
            }
        }
        //проверка на числа
        public bool EKeyCharCheck()
        {
            if ((EKey >= 47 && EKey <= 58) || EKey == 8 || EKey == 46 || EKey == 44)
            {
                EKeyChar = false;
            }
            else
            {
                
                EKeyChar = true;
            }
            return EKeyChar;

        }

        private void TSensitivity_KeyPress(object sender, KeyPressEventArgs e)
        {
            EKey = e.KeyChar;// код символа
            e.KeyChar = Convert.ToChar(EKeyCheck());// проверяем на разделитель 
            e.Handled = EKeyCharCheck();// проверяем на соответствие числа
            
        }

        private void TFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            EKey = e.KeyChar;// код символа
            e.KeyChar = Convert.ToChar(EKeyCheck());// проверяем на разделитель 
            e.Handled = EKeyCharCheck();// проверяем на соответствие числа
        }

        private void TVoltage_KeyPress(object sender, KeyPressEventArgs e)
        {
            EKey = e.KeyChar;// код символа
            e.KeyChar = Convert.ToChar(EKeyCheck());// проверяем на разделитель 
            e.Handled = EKeyCharCheck();// проверяем на соответствие числа
            
        }

        private void Tvelocity_KeyPress(object sender, KeyPressEventArgs e)
        {
            EKey = e.KeyChar;// код символа
            e.KeyChar = Convert.ToChar(EKeyCheck());// проверяем на разделитель 
            e.Handled = EKeyCharCheck();// проверяем на соответствие числа
        }

        private void Tvelocity_dB_KeyPress(object sender, KeyPressEventArgs e)
        {
            EKey = e.KeyChar;// код символа
            e.KeyChar = Convert.ToChar(EKeyCheck());// проверяем на разделитель 
            e.Handled = EKeyCharCheck();// проверяем на соответствие числа
        }

        private void TDisplacement_KeyPress(object sender, KeyPressEventArgs e)
        {
            EKey = e.KeyChar;// код символа
            e.KeyChar = Convert.ToChar(EKeyCheck());// проверяем на разделитель 
            e.Handled = EKeyCharCheck();// проверяем на соответствие числа
        }

        private void TSensitivity_Enter(object sender, EventArgs e)
        {//обнуляем счетчики присваеваем счетчикам значения числа введеных символов и порядка разделителя
            strFlagType = "Sensitivity";
            strFlagType = FlagType();
            
            backspase1 = TSensitivity.Text.Length;
            String1 = TSensitivity.Text;
            backspase2 = String1.IndexOf(Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator))+1;
            EKey = 0;
            EKeyChar = false;
            if (backspase2 > 0)
            {
                Point1 = true;
            }
            else
            {
                Point1 = false;
            }
        }

        private void TVoltage_Enter(object sender, EventArgs e)
        {//обнуляем счетчики присваеваем счетчикам значения числа введеных символов и порядка разделителя
            strFlagType = "Voltage";
            strFlagType = FlagType();
            backspase1 = TVoltage.Text.Length;
            String1 = TVoltage.Text;
            backspase2 = String1.IndexOf(Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)) + 1;
            EKey = 0;
            EKeyChar = false;
            if (backspase2 > 0)
            {
                Point1 = true;
            }
            else
            {
                Point1 = false;
            }
        }

        private void TVoltage_dB_Enter(object sender, EventArgs e)
        {//обнуляем счетчики присваеваем счетчикам значения числа введеных символов и порядка разделителя
            strFlagType = "Voltage_dB";
            strFlagType = FlagType();
            backspase1 = TVoltage.Text.Length;
            String1 = TVoltage.Text;
            backspase2 = String1.IndexOf(Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)) + 1;
            EKey = 0;
            EKeyChar = false;
            if (backspase2 > 0)
            {
                Point1 = true;
            }
            else
            {
                Point1 = false;
            }
        }

        private void TAcceleration_Enter(object sender, EventArgs e)
        {//обнуляем счетчики присваеваем счетчикам значения числа введеных символов и порядка разделителя
            strFlagType = "Acceleration";
            strFlagType = FlagType();
            backspase1 = TAcceleration.Text.Length;
            String1 = TAcceleration.Text;
            backspase2 = String1.IndexOf(Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)) + 1;
            EKey = 0;
            EKeyChar = false;
            if (backspase2 > 0)
            {
                Point1 = true;
            }
            else
            {
                Point1 = false;
            }
        }

        private void TAcceleration_dB_Enter(object sender, EventArgs e)
        {//обнуляем счетчики присваеваем счетчикам значения числа введеных символов и порядка разделителя
            strFlagType = "Acceleration_dB";
            strFlagType = FlagType();
            backspase1 = TAcceleration_dB.Text.Length;
            String1 = TAcceleration_dB.Text;
            backspase2 = String1.IndexOf(Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)) + 1;
            EKey = 0;
            EKeyChar = false;
            if (backspase2 > 0)
            {
                Point1 = true;
            }
            else
            {
                Point1 = false;
            }
        }
        private void Tvelocity_Enter(object sender, EventArgs e)
        {//обнуляем счетчики присваеваем счетчикам значения числа введеных символов и порядка разделителя
            strFlagType = "Velocity";
            strFlagType = FlagType();
            backspase1 = TVelocity.Text.Length;
            String1 = TVelocity.Text;
            backspase2 = String1.IndexOf(Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)) + 1;
            EKey = 0;
            EKeyChar = false;
            if (backspase2 > 0)
            {
                Point1 = true;
            }
            else
            {
                Point1 = false;
            }
        }

        private void Tvelocity_dB_Enter(object sender, EventArgs e)
        {//обнуляем счетчики присваеваем счетчикам значения числа введеных символов и порядка разделителя
            strFlagType = "Velocity_dB";
            strFlagType = FlagType();
            backspase1 = TVelocity_dB.Text.Length;
            String1 = TVelocity_dB.Text;
            backspase2 = String1.IndexOf(Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)) + 1;
            EKey = 0;
            EKeyChar = false;
            if (backspase2 > 0)
            {
                Point1 = true;
            }
            else
            {
                Point1 = false;
            }
        }

        private void TDisplacement_Enter(object sender, EventArgs e)
        {//обнуляем счетчики присваеваем счетчикам значения числа введеных символов и порядка разделителя
            strFlagType = "Displacement";
            strFlagType = FlagType();
            backspase1 = TDisplacement.Text.Length;
            String1 = TDisplacement.Text;
            backspase2 = String1.IndexOf(Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)) + 1;
            EKey = 0;
            EKeyChar = false;
            if (backspase2 > 0)
            {
                Point1 = true;
            }
            else
            {
                Point1 = false;
            }
        }


        private void TDisplacement_dB_Enter(object sender, EventArgs e)
        {//обнуляем счетчики присваеваем счетчикам значения числа введеных символов и порядка разделителя
            strFlagType = "Displacement_dB";
            strFlagType = FlagType();
            backspase1 = TDisplacement_dB.Text.Length;
            String1 = TDisplacement_dB.Text;
            backspase2 = String1.IndexOf(Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)) + 1;
            EKey = 0;
            EKeyChar = false;
            if (backspase2 > 0)
            {
                Point1 = true;
            }
            else
            {
                Point1 = false;
            }
        }

        private void TDisplacement_dB_KeyPress(object sender, KeyPressEventArgs e)
        {
            EKey = e.KeyChar;// код символа
            e.KeyChar = Convert.ToChar(EKeyCheck());// проверяем на разделитель 
            e.Handled = EKeyCharCheck();// проверяем на соответствие числа
        }

        private void TVoltage_dB_KeyPress(object sender, KeyPressEventArgs e)
        {
            EKey = e.KeyChar;// код символа
            e.KeyChar = Convert.ToChar(EKeyCheck());// проверяем на разделитель 
            e.Handled = EKeyCharCheck();// проверяем на соответствие числа
        }

        private void TSensitivity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.Handled = true;
            }
        }

        private void TSensitivity_MouseMove(object sender, MouseEventArgs e)
        {
          (sender as TextBox).SelectionLength = 0;
            TSensitivity.Select(TSensitivity.Text.Length, 0);
        }

        private void TSensitivity_MouseDown(object sender, MouseEventArgs e)
        {
            TSensitivity.Select(TSensitivity.Text.Length, 0);
        }

        private void TVoltage_dB_KeyUp(object sender, KeyEventArgs e)
        {
            strFlagType = Сalculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strFlagType = "Voltage";
            strFlagType = Сalculate();
        }

        private void radSensitivityM_CheckedChanged(object sender, EventArgs e)
        {
            if(radSensitivityM.Checked)
            {
                chError = sensitivity / 9.807;
                TSensitivity.Text = Convert.ToString(Math.Round(sensitivity / 9.807,checkRound()));
                GBDisplacement.Visible = true;
                gBVelocity.Visible = true;
                
                radDispSensFreq.Visible = true;
                radVelSensFreq.Visible = true;
                gBVelocity.Text = "Скорость, мм/с";
                gBAcceleration.Text = "Ускорение, м/с²";
            }
        }

        private void TSensitivity_KeyUp(object sender, KeyEventArgs e)
        {
            strFlagType = Сalculate();
        }

        private void TSensitivity_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            EKey = e.KeyChar;// код символа
            e.KeyChar = Convert.ToChar(EKeyCheck());// проверяем на разделитель 
            e.Handled = EKeyCharCheck();// проверяем на соответствие числа
        }

        private void radSensitivityG_CheckedChanged(object sender, EventArgs e)
        {
            if (radSensitivityG.Checked)
            {
                chError = sensitivity;
                TSensitivity.Text = Convert.ToString(Math.Round(sensitivity, checkRound()));
                GBDisplacement.Visible = true;
                gBVelocity.Visible = true;

                radDispSensFreq.Visible = true;
                radVelSensFreq.Visible = true;
                gBVelocity.Text = "Скорость, мм/с";
                gBAcceleration.Text = "Ускорение, м/с²";
            }
        }

        private void radFrequencyRPM_CheckedChanged(object sender, EventArgs e)
        {
            if (radFrequencyRPM.Checked)
            {
                chError = frequency * 60;
                TFrequency.Text = Convert.ToString(Math.Round(frequency * 60, checkRound()));
            }
        }

        private void radFrequencyHw_CheckedChanged(object sender, EventArgs e)
        {
            if (radFrequencyHw.Checked)
            {
                chError = frequency;
                TFrequency.Text = Convert.ToString(Math.Round(frequency, checkRound()));
            }
        }

        private void radVoltagePik_CheckedChanged(object sender, EventArgs e)
        {
            if (radVoltagePik.Checked)
            {
                chError = voltage * Math.Sqrt(2);
                TVoltage.Text = Convert.ToString(Math.Round(voltage * Math.Sqrt(2), checkRound()));
            }
        }

        private void radVoltagePikPik_CheckedChanged(object sender, EventArgs e)
        {
            
                if (radVoltagePikPik.Checked)
                {
                    chError = voltage * 2* Math.Sqrt(2);
                    TVoltage.Text = Convert.ToString(Math.Round(voltage * 2 * Math.Sqrt(2), checkRound()));
                }
            
        }

        private void radVoltageRMS_CheckedChanged(object sender, EventArgs e)
        {
            if (radVoltageRMS.Checked)
            {
                chError = voltage ;
                TVoltage.Text = Convert.ToString(Math.Round(voltage, checkRound()));
            }
        }

        private void radAccelerationRMS_CheckedChanged(object sender, EventArgs e)
        {
            if (radAccelerationRMS.Checked)
            {
                chError = acceleration;
                TAcceleration.Text = Convert.ToString(Math.Round(acceleration, checkRound()));
            }
           
        }

        private void radAccelerationPik_CheckedChanged(object sender, EventArgs e)
        {
            if (radAccelerationPik.Checked)
            {
                chError = acceleration * Math.Sqrt(2);
                TAcceleration.Text = Convert.ToString(Math.Round(acceleration * Math.Sqrt(2), checkRound()));
            }
        }

        private void radAccelerationPikPik_CheckedChanged(object sender, EventArgs e)
            {
                chError = acceleration * 2 * Math.Sqrt(2);
                TAcceleration.Text = Convert.ToString(Math.Round(acceleration * 2 * Math.Sqrt(2), checkRound()));
            }

        private void radVelocityRMS_CheckedChanged(object sender, EventArgs e)
        {
            if (radVelocityRMS.Checked)
            {
                chError = velocity;
                TVelocity.Text = Convert.ToString(Math.Round(velocity, checkRound()));
            }
        }

        private void radDisplacementRMS_CheckedChanged(object sender, EventArgs e)
        {
            if (radDisplacementRMS.Checked)
            {
                chError = displacement;
                TDisplacement.Text = Convert.ToString(Math.Round(displacement, checkRound()));
            }
        }

        private void radVelocityPik_CheckedChanged(object sender, EventArgs e)
        {
            if (radVelocityPik.Checked)
            {
                chError = velocity * Math.Sqrt(2);
                TVelocity.Text = Convert.ToString(Math.Round(velocity * Math.Sqrt(2), checkRound()));
            }
        }

        private void radDisplacementPik_CheckedChanged(object sender, EventArgs e)
        {
            if (radDisplacementPik.Checked)
            {
                chError = displacement * Math.Sqrt(2);
                TDisplacement.Text = Convert.ToString(Math.Round(displacement * Math.Sqrt(2), checkRound()));
            }
        }

        private void radVelocityPikPik_CheckedChanged(object sender, EventArgs e)
        {
            chError = velocity * 2 * Math.Sqrt(2);
            TVelocity.Text = Convert.ToString(Math.Round(velocity * 2 * Math.Sqrt(2), checkRound()));

        }

        private void TVelocity_KeyUp(object sender, KeyEventArgs e)
        {
            strFlagType = Сalculate();
        }

        private void TAcceleration_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDisplacement_KeyUp(object sender, KeyEventArgs e)
        {
            strFlagType = Сalculate();
        }

        private void radiDisplacementPikPik_CheckedChanged(object sender, EventArgs e)
        {
            chError = displacement * 2 * Math.Sqrt(2);
            TDisplacement.Text = Convert.ToString(Math.Round(displacement * 2 * Math.Sqrt(2), checkRound()));
        }

        private void BSensitivityCopy_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(TSensitivity.Text);

        }

        private void BFrequencyCopy_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(TFrequency.Text);

        }

        private void BAccelerationCopy_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(TAcceleration.Text);

        }

        private void button8_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(TAcceleration_dB.Text);

        }

        private void button9_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(TVoltage.Text);

        }

        private void button10_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(TVoltage_dB.Text);
        }

        private void BVelocityCopy_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(TVelocity.Text);
        }

        private void BVelocity_dBCopy_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(TVelocity_dB.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(TDisplacement.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(TDisplacement_dB.Text);
        }

        private void TVelocity_dB_KeyUp(object sender, KeyEventArgs e)
        {
            strFlagType = Сalculate();
        }

        private void TAcceleration_dB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDisplacement_dB_KeyUp(object sender, KeyEventArgs e)
        {
            strFlagType = Сalculate();
        }

        private void TFrequency_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void boundaryFrequency_KeyUp(object sender, KeyEventArgs e)
        {
            strFlagType = Сalculate();
        }

        private void channelCount_KeyUp(object sender, KeyEventArgs e)
        {
            strFlagType = Сalculate();
        }

        private void boundaryFrequency_Enter(object sender, EventArgs e)
        {
            backspase1 = boundaryFrequency.Text.Length;
            String1 = boundaryFrequency.Text;
            backspase2 = String1.IndexOf(Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)) + 1;
            EKey = 0;
            EKeyChar = false;
            if (backspase2 > 0)
            {
                Point1 = true;
            }
            else
            {
                Point1 = false;
            }
        }

        private void channelCount_Enter(object sender, EventArgs e)
        {
            backspase1 = channelCount.Text.Length;
            String1 = channelCount.Text;
            backspase2 = String1.IndexOf(Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)) + 1;
            EKey = 0;
            EKeyChar = false;
            if (backspase2 > 0)
            {
                Point1 = true;
            }
            else
            {
                Point1 = false;
            }
        }

        private void boundaryFrequency_TextChanged(object sender, EventArgs e)
        {

        }

        private void boundaryFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            EKey = e.KeyChar;// код символа
            e.KeyChar = Convert.ToChar(EKeyCheck());// проверяем на разделитель 
            e.Handled = EKeyCharCheck();// проверяем на соответствие числа
        }

        private void channelCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            EKey = e.KeyChar;// код символа
            e.KeyChar = Convert.ToChar(EKeyCheck());// проверяем на разделитель 
            e.Handled = EKeyCharCheck();// проверяем на соответствие числа
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(boundaryFrequency.Text, TextDataFormat.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(channelCount.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(channelWidth.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(channelCenter1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();  Clipboard.SetText(channelCenter2.Text);
        }

        private void radSensitivityMm_CheckedChanged(object sender, EventArgs e)
        {
            if (radSensitivityMm.Checked)
            {
                chError = sensitivity / 9.807;
                TSensitivity.Text = Convert.ToString(Math.Round(sensitivity / 9.807, checkRound()));
                GBDisplacement.Visible = false;
                if (radDispSensFreq.Checked)
                {
                    radVelSensFreq.Checked = true;
                }
                radDispSensFreq.Visible = false;
                gBVelocity.Text = "Перемещение, мкм";
                gBAcceleration.Text = "Скорость, мм/с";
                gBVelocity.Visible = true;
                radVelSensFreq.Visible = true;
            }
        }

        private void radSensitivityMkm_CheckedChanged(object sender, EventArgs e)
        {
            if (radSensitivityMkm.Checked)
            {
                chError = sensitivity / 9.807;
                TSensitivity.Text = Convert.ToString(Math.Round(sensitivity / 9.807, checkRound()));

                GBDisplacement.Visible = false;
                gBVelocity.Visible = false;
                if (radDispSensFreq.Checked || radVelSensFreq.Checked)
                {
                    radAccSensFreq.Checked = true;
                }
                radDispSensFreq.Visible = false;
                radVelSensFreq.Visible = false;
                gBAcceleration.Text = "Перемещение, мкм";

            }
        }

        private void TDisplacement_TextChanged(object sender, EventArgs e) {

        }

        private void TFrequency_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    e.Handled = true;
                }
            }
        }

        private void TVoltage_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    e.Handled = true;
                }
            }
            
            
        }

        private void TAcceleration_dB_KeyUp(object sender, KeyEventArgs e)
        {
            strFlagType = Сalculate();
        }

        private void TFrequency_KeyUp(object sender, KeyEventArgs e)
        {
            strFlagType = Сalculate();
        }

        private void TAcceleration_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    e.Handled = true;
                }
            }
        }

        private void TAcceleration_dB_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    e.Handled = true;
                }
            }
        }

        private void TVoltage_dB_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    e.Handled = true;
                }
            }
        }

        private void TVelocity_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    e.Handled = true;
                }
            }
        }

        private void TVoltage_KeyUp(object sender, KeyEventArgs e)
        {
            strFlagType = Сalculate();
        }

        private void TAcceleration_KeyUp(object sender, KeyEventArgs e)
        {
            strFlagType = Сalculate();
            (sender as TextBox).SelectionLength = 0;
            TAcceleration.Select(TAcceleration.Text.Length, 0);
        }

        private void TVelocity_dB_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    e.Handled = true;
                }
            }
        }

        private void TDisplacement_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    e.Handled = true;
                }
            }
        }

        private void TDisplacement_dB_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    e.Handled = true;
                }
            }
        }

        private void TFrequency_MouseMove(object sender, MouseEventArgs e)

        {
            (sender as TextBox).SelectionLength = 0;
            TFrequency.Select(TFrequency.Text.Length, 0);
        }

        private void TVoltage_MouseMove(object sender, MouseEventArgs e)
        {
            
                (sender as TextBox).SelectionLength = 0;
                TVoltage.Select(TVoltage.Text.Length, 0);
            
        }

        private void TAcceleration_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as TextBox).SelectionLength = 0;
            TAcceleration.Select(TAcceleration.Text.Length, 0);
        }

        private void TDisplacement_dB_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as TextBox).SelectionLength = 0;
            TDisplacement_dB.Select(TDisplacement_dB.Text.Length, 0);
        }

        private void TAcceleration_dB_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as TextBox).SelectionLength = 0;
            TAcceleration_dB.Select(TAcceleration_dB.Text.Length, 0);
        }

        private void TVoltage_dB_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as TextBox).SelectionLength = 0;
            TVoltage_dB.Select(TVoltage_dB.Text.Length, 0);
        }

        private void TVelocity_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as TextBox).SelectionLength = 0;
            TVelocity.Select(TVelocity.Text.Length, 0);
        }

        private void TVelocity_dB_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as TextBox).SelectionLength = 0;
            TVelocity_dB.Select(TVelocity_dB.Text.Length, 0);
        }

        private void TDisplacement_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as TextBox).SelectionLength = 0;
            TDisplacement.Select(TDisplacement.Text.Length, 0);
        }

        private void TFrequency_Enter(object sender, EventArgs e)
        {//обнуляем счетчики присваеваем счетчикам значения числа введеных символов и порядка разделителя
            strFlagType = "Frequency";
            strFlagType = FlagType();
            backspase1 = TFrequency.Text.Length;
            String1 = TFrequency.Text;
            backspase2 = String1.IndexOf(Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)) + 1;
            EKey = 0;
            EKeyChar = false;
            if (backspase2 > 0)
            {
                Point1 = true;
            }
            else
            {
                Point1 = false;
            }
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void TAcceleration_KeyPress(object sender, KeyPressEventArgs e)
        {
            EKey = e.KeyChar;// код символа
            e.KeyChar = Convert.ToChar(EKeyCheck());// проверяем на разделитель 
            e.Handled = EKeyCharCheck();// проверяем на соответствие числа
            
        }

        private void TAcceleration_dB_KeyPress(object sender, KeyPressEventArgs e)
        {
            EKey = e.KeyChar;// код символа
            e.KeyChar = Convert.ToChar(EKeyCheck());// проверяем на разделитель 
            e.Handled = EKeyCharCheck();// проверяем на соответствие числа
        }

    }
}
