using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ARM
{
    [Serializable]
    public class Bake : Device
    {
        [DisplayName("Количество зон")]
        [Category("Технические характеристики")]
        public Zone ZoneQuantity { set; get; }

        //private double length;
        //[DisplayName("Длина печи")]
        //[Category("Технические характеристики")]
        //[Description("Длина обрабатываемого участка конвейера (метры)")]
        //public double Length 
        //{ 
        //    get
        //    {
        //        return length;
        //    }
        //    set
        //    {
        //        if (value > 0)
        //            length = value;
        //        else
        //            MessageBox.Show("Длина печи не может быть меньше нуля!");
        //    }
        //}
        private double minSpeed;
        [DisplayName("Минимальная скорость")]
        [Category("Технические характеристики")]
        [Description("Минимальная скорость конвейера (м/мин)")]
        public double MinSpeed
        {
            get
            {
                return minSpeed;
            }
            set
            {
                if (value > 0)
                    if(value < maxSpeed)
                        minSpeed = value;
                    else
                        MessageBox.Show("Минимальная скорость конвейера должна быть меньше максимальной!");
                else
                    MessageBox.Show("Минимальная скорость конвейера должна быть больше нуля!");
            }
        }

        private double maxSpeed;
        [DisplayName("Максимальная скорость")]
        [Category("Технические характеристики")]
        [Description("Максимальная скорость конвейера (м/мин)")]
        public double MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                if (value > 0)
                        if(value > minSpeed)
                            maxSpeed = value;
                        else
                            MessageBox.Show("Максимальная скорость конвейера должна быть больше минимальной!");
                else
                    MessageBox.Show("Максимальная скорость конвейера должна быть больше нуля!");
            }
        }

        public Bake()
        {
            ZoneQuantity = Zone.zon5;
        }
        public Zone ConvertStringToZone(string s)
        {
            switch (s)
            {
                case "zon5":
                    return Zone.zon5;
                case "zon6":
                    return Zone.zon6;
                case "zon12":
                    return Zone.zon12;
            }
            return Zone.zon5;//Значение по умолчанию
        }

        public enum Zone : int
        {
            [Description("Пятизонная печь")]
            zon5 = 5,
            [Description("Шестизонная печь")]
            zon6 = 6,
            [Description("Печь 12 зон")]
            zon12 = 12
        }
    }//Печь
}
