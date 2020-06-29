using System.ComponentModel;
using System.Windows.Forms;

namespace ARM
{
    public class Board : Device
    {
        double transientProcessTime;
        [DisplayName("Время переходного процесса")]
        [Category("Технические характеристики")]
        [Description("Длительность переходного процесса при тестовом разогреве платы (секунды)")]
        public double TransientProcessTime
        {
            set
            {
                if (value < 60 || value > 180)
                {
                    MessageBox.Show("Значения температуры и скорости конвейера могут быть некорректными при данных значениях времени переходного процесса");
                }

                transientProcessTime = value;
                timeConst = transientProcessTime / 3;
            }
            get
            {
                return transientProcessTime;
            }
        }//Время переходного процесса

        double timeConst;
        [DisplayName("Постоянная времени")]
        [Category("Технические характеристики")]
        [Description("Постоянная времени платы.")]
        [ReadOnly(true)]
        public double TimeConst
        {
            set
            {
                timeConst = value;
                transientProcessTime = timeConst * 3;
            }
            get
            {
                return timeConst;
            }
        }//Постоянная времени
    }//Плата
}
