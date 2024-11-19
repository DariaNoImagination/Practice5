using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class Appliance
    {
        string model; // Модель
        decimal price; //Цена
        int guarantee; //Гарантия
        public Appliance() //Конструктор по умолчанию
        {
            model = "HP";
            price = 10000;
            guarantee = 2;
        }
        public Appliance(string newmodel, decimal newprice, int newguarantee) //Конструктор с параметрами
        {
            if (newmodel != null) model = newmodel;
            else model = "HP";
            if (0 < newprice && newprice < 999999) price = newprice; //Если значение корректно,присваиваем его объекту класса
            else price = 10000; //Иначе устанавливаем значение по умолчанию
            if (0 <= newguarantee && newguarantee <= 10) guarantee = newguarantee;
            else guarantee = 2;
        }
        public override string ToString() //Виртуальный метод для вывода значений
        {

            return $"Модель: {model} Цена: {price} Гарантийный срок: {guarantee}";
        }
        public string Model // Свойство
        {
            get
            {
                return model; //Возвращаем значение 
            }
            set
            {
                if (value != null) model = value;  //Устанавливаем новое значение,если он не равно NULL 
            }

        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (0 < value && value < 999999) price = value; //Если новое значение корректно, присваваем его
            }

        }

        public int Guarantee
        {
            get
            {
                return guarantee;
            }
            set
            {
                if (0 <= value && value <= 10)
                    guarantee = value;
            }
        } }
        public class Printer_c : Appliance //Производный класс Принтер
        {
            int volume_of_paint; //Объем краски
            int print_speed; //Скорость печати
            string print_technology; //Технология печати 
            public Printer_c() : base() //Конструктор по умолчанию
            {

                volume_of_paint = 5;
                print_speed = 20;
                print_technology = "Лазерная";
            }

            public Printer_c(string model, decimal price, int guarantee, int volume, int speed, string tech) : base(model, price, guarantee) //Конструктор с параметрами
            {
                if (volume > 0 && volume < 100) //Проверка новых параметров на корректность 
                    volume_of_paint = volume;
                else volume_of_paint = 5; //Если новые значения некорректны, устанавливаем значение по умолчанию
                if (speed > 0 && speed < 100)
                    print_speed = speed;
                else print_speed = 20;
                if (tech != null) print_technology = tech;
                else print_technology = "Лазерная";
            }

        public override string ToString() //Печать значений
        {
            return base.ToString()+$" Объем краски: {volume_of_paint} Скорость печати: {print_speed} Технология печати: {print_technology}";
            }

            public int Volume
            {
                get
                {
                    return volume_of_paint;
                }
                set
                {
                    if (value > 0 && value < 100) //Если значение корректно
                        volume_of_paint = value; //Присваиваем его объекту
                }
            }

            public int Speed
            {
                get { return print_speed; }
                set
                {
                    if (value > 0 && value < 100) //Если значение корректно 
                        print_speed = value; //Присваиваем его объекту
                }
            }

            public string Tech
            {
                get
                {
                    return print_technology;
                }
                set
                {
                    if (value != null) print_technology = value;

                }
            }
        }

        public class Fax : Appliance //Производный класс - факс
        {
            string phone_number; //Номер
            int transmission_speed; //Скорость передачи
            int memory_capacity; //Объем памяти
            public Fax() : base() //Конструктор по умолчанию
            {
                transmission_speed = 40;
                memory_capacity = 15;
                phone_number = "123456789";
            }

            public Fax(string model, decimal price, int guarantee, int memory, int speed, string number) : base(model, price, guarantee) //Конструктор с параметрами
            {
                if (memory > 0 && memory < 100) memory_capacity = memory; //Если значения корректны,присваиваем их объекту
                else memory_capacity = 15; //Иначе присваиваем значения по умолчанию
                if (speed > 0 && speed < 100) transmission_speed = speed;
                else transmission_speed = 40;
                if (number != null) phone_number = number;
                else phone_number =  "123456789";
            }
            public override string ToString() //Печать значений объекта
            {
                return base.ToString() + $" Объем памяти: {memory_capacity}" + 
                $"Скорость передачи: {transmission_speed} Номер: {phone_number}";
            }

            public int Memory
            {
                get
                {
                    return memory_capacity;
                }
                set
                {
                    if (value > 0 && value < 100)
                        memory_capacity = value;
                }
            }

            public int Speed
            {
                get
                {
                    return transmission_speed;
                }
                set
                {
                    if (value > 0 && value < 100)
                        transmission_speed = value;
                }
            }
            public string Number
            {
                get
                {
                    return phone_number;

                }
                set
                {
                    if (value != null) phone_number = value;
                }

            }
        }
    }

