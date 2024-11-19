using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Appliance appliance;
        public Form2()
        {
            
            InitializeComponent();
            InitializeControls();
        }
        private enum InputState 
        {
            ModelInput,
            PriceInput,
            GuaranteeInput,
            VolumeInput,
            SpeedInput,
            TechInput,
            MemoryInput,
            NumberInput,
            Completed
        }
       
        private InputState currentState = InputState.ModelInput;

        private void InitializeControls()
        {
            buttonReturn.Hide();
            buttonAdd.Hide();
            textBoxModel.Hide();
            textBoxPrice.Hide();
            textBoxGuarantee.Hide();
            textBoxSpeed.Hide();
            textBoxVolume.Hide();
            textBoxTech.Hide();
            textBoxTransmissionSpeed.Hide();
            textBoxMemory.Hide();
            textBoxNumber.Hide();

            label.Text = "";
            labelError.Text = "" ;
            label1.Text = "";
            labelObjectValue.Text = "";
            comboBoxObject.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxObject.Items.Add("Базовый класс Appliance");
            comboBoxObject.Items.Add("Производный класс Printer_c");
            comboBoxObject.Items.Add("Производный класс Fax");
        }
        
        private void comboBoxObject_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                textBoxModel.Clear();
                textBoxModel.Show();
                labelObjectValue.Text = "Введите значение модели:";
                buttonAdd.Show();
         

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch (comboBoxObject.SelectedIndex)
            {
                case 0: // Базовый класс Appliance
                    switch (currentState)
                    {
                        case InputState.ModelInput:
                            HandleModelInput();
                            break;
                        case InputState.PriceInput:
                            HandlePriceInput();
                            break;
                        case InputState.GuaranteeInput:
                            HandleGuaranteeInput();
                            break;
                    }
                    break;
                case 1: //Производный класс Printer_c
                    switch (currentState)
                    {
                        case InputState.ModelInput:
                            HandleModelInput();
                            break;
                        case InputState.PriceInput:
                            HandlePriceInput();
                            break;
                        case InputState.GuaranteeInput:
                            HandleGuaranteeInput();
                            break;
                        case InputState.SpeedInput:
                            HandleSpeedInput();
                            break;
                        case InputState.VolumeInput:
                            HandleVolumeInput();
                            break;
                        case InputState.TechInput:
                            HandleTechInput();
                            break;
                    }
                    break;
                case 2: //Производный класс Fax
                    switch (currentState)
                    {
                        case InputState.ModelInput:
                            HandleModelInput();
                            break;
                        case InputState.PriceInput:
                            HandlePriceInput();
                            break;
                        case InputState.GuaranteeInput:
                            HandleGuaranteeInput();
                            break;
                        case InputState.SpeedInput:
                            HandleTransmissionSpeedInput();
                            break;
                        case InputState.MemoryInput:
                            HandleMemoryInput();
                            break;
                        case InputState.NumberInput:
                            HandleNumberInput();
                            break;
                    }
                    break;
            }
        }
        private void HandleModelInput() //Ввод модели
        {

            // Проверка ввода модели
            if (string.IsNullOrWhiteSpace(textBoxModel.Text))
            {
                labelError.Text = "Введите значение модели.";
                return;
            }
            buttonAdd.Show();
            labelError.Text = "";
            textBoxModel.Hide();
            labelObjectValue.Text = "Введите значение цены:";
            textBoxPrice.Show();

            // Переход к следующему состоянию
            currentState = InputState.PriceInput;
        }
    
        private void HandlePriceInput() //Ввод цены
        {
            // Проверка ввода цены
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                labelError.Text = "Введите значение цены.";
                return;
            }
            else if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
            {
                labelError.Text = "Введите корректное значение цены.";
                return;
            }
            labelError.Text = "";
            textBoxPrice.Hide();
            labelObjectValue.Text = "Введите значение гарантии:";
            textBoxGuarantee.Show();

            // Переход к следующему состоянию
            currentState = InputState.GuaranteeInput;
        }

        private void HandleGuaranteeInput()//Ввод гарантии
        {
            int guarantee;
            // Проверка ввода гарантии
            if (string.IsNullOrWhiteSpace(textBoxGuarantee.Text))
            {
                labelError.Text = "Введите значение гарантии.";
                return;
            }
            else if (!int.TryParse(textBoxGuarantee.Text, out guarantee))
            {
                labelError.Text = "Введите корректное значение гарантии.";
                return;
            }
            
            switch (comboBoxObject.SelectedIndex) {
                case 0:
                appliance = new Appliance(textBoxModel.Text, Convert.ToDecimal(textBoxPrice.Text), guarantee);

                labelError.Text = "";
                
                labelObjectValue.Text = "Объект успешно создан!";
                textBoxGuarantee.Hide();

                // Завершение процесса ввода
                currentState = InputState.Completed;
                buttonAdd.Hide();
                buttonReturn.Show();
                    break;

                case 1:
                textBoxGuarantee.Hide();
                labelError.Text = "";
                labelObjectValue.Text = "Введите значение скорости ";
                label.Text = "печати:";
                textBoxSpeed.Show();
                currentState = InputState.SpeedInput;
                    break;
                case 2:
                textBoxGuarantee.Hide();
                labelError.Text = "";
                labelObjectValue.Text = "Введите значение скорости ";
                label.Text = "передачи:";
                textBoxTransmissionSpeed.Show();
                currentState = InputState.SpeedInput;
                    break;
                    }        
        }
        private void HandleSpeedInput() //Ввод скорости печати
        {
            if (string.IsNullOrWhiteSpace(textBoxSpeed.Text))
            {
                labelError.Text = "Введите значение скорости печати.";
                return;
            }
            else if (!int.TryParse(textBoxSpeed.Text, out int speed))
            {
                labelError.Text = "Введите корректное значение";
                label1.Text = "скорости печати";
                return;
            }
            labelError.Text = "";
            label1.Text = "";
            textBoxSpeed.Hide();
            labelObjectValue.Text = "Введите значение объема ";
            label.Text = "краски:";

            textBoxVolume.Show();

            // Переход к следующему состоянию
            currentState = InputState.VolumeInput;
           
            }

        private void HandleVolumeInput() //Ввод объема краски
        {
            if (string.IsNullOrWhiteSpace(textBoxVolume.Text))
            {
                labelError.Text = "Введите значение объема краски.";
                return;
            }
            else if (!int.TryParse(textBoxVolume.Text, out int volume))
            {
                labelError.Text = "Введите корректное значение ";
                label1.Text = "объема краски.";
                return;
            }
            labelError.Text = "";
            label1.Text = "";
            textBoxVolume.Hide();
            labelObjectValue.Text = "Введите значение технологии ";
            label.Text = "печати:";
            textBoxTech.Show();
            // Переход к следующему состоянию
            currentState = InputState.TechInput;
        }
        
        private void HandleTechInput() //Ввод технологии печати
        {
            if (string.IsNullOrWhiteSpace(textBoxTech.Text))
            {
                labelError.Text = "Введите значение технологии печати";
                return;
            }
            label.Text = "";
            label1.Text = "";
            labelError.Text = "";
            buttonAdd.Hide();
            textBoxTech.Hide();
            buttonReturn.Show();
            appliance = new Printer_c(textBoxModel.Text, Convert.ToDecimal(textBoxPrice.Text), int.Parse(textBoxGuarantee.Text), int.Parse(textBoxVolume.Text), int.Parse(textBoxSpeed.Text), textBoxTech.Text);

            labelError.Text = "";
            labelObjectValue.Text = "Объект успешно создан!";

            // Завершение процесса ввода
            currentState = InputState.Completed;
        }
        private void HandleTransmissionSpeedInput() //Ввод скорости передачи
        {

            if (string.IsNullOrWhiteSpace(textBoxTransmissionSpeed.Text))
            {
                labelError.Text = "Введите значение скорости передачи.";
                return;
            }
            else if (!int.TryParse(textBoxTransmissionSpeed.Text, out int speed))
            {
                labelError.Text = "Введите корректное значение ";
                label1.Text = "скорости передачи.";
                return;
            }
            textBoxTransmissionSpeed.Hide();
            label1.Text = "";
            labelError.Text = "";
            labelObjectValue.Text = "Введите значение объема ";
            label.Text = "памяти:";
            textBoxMemory.Show();
            // Переход к следующему состоянию
            currentState = InputState.MemoryInput;
        }
        private void HandleMemoryInput() //Ввод объема памяти
        {
            
            if (string.IsNullOrWhiteSpace(textBoxMemory.Text))
            {
                labelError.Text = "Введите значение объема памяти.";
                return;
            }
            else if (!int.TryParse(textBoxMemory.Text, out int memory))
            {
                labelError.Text = "Введите корректное значение ";
                label1.Text = "объема памяти.";
                return;
            }
            textBoxMemory.Hide();
            labelError.Text = "";
            label1.Text = "";
            label.Text = "";
            labelObjectValue.Text = "Введите значение номера";
            textBoxNumber.Show();
            // Переход к следующему состоянию
            currentState = InputState.NumberInput;
        }
        private void HandleNumberInput() //Ввод номера
        {
            string number = textBoxNumber.Text;
            if (string.IsNullOrWhiteSpace(number))
            {
                labelError.Text = "Введите значение номера.";
                return;
            }
            appliance = new Fax(textBoxModel.Text, Convert.ToDecimal(textBoxPrice.Text), int.Parse(textBoxGuarantee.Text), int.Parse(textBoxMemory.Text), int.Parse(textBoxTransmissionSpeed.Text), number);
            buttonAdd.Hide();
            textBoxNumber.Hide();
            buttonReturn.Show();
            labelError.Text = "";
            labelObjectValue.Text = "Объект успешно создан!";

            // Завершение процесса ввода
            currentState = InputState.Completed;
        }
   
        private void buttonReturn_Click(object sender, EventArgs e) //Возврат к выбору действия
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
