using System.ComponentModel;

namespace ARM
{
    public class Device
    {
        public delegate bool ChangeName(string name);
        public event ChangeName OnChangeName;

        string name;
        [DisplayName("Имя")]
        [Description("Название печатной платы")]
        [Category("Общие сведения")]
        public string Name
        {
            set
            {
                if (OnChangeName != null)
                {
                    if (OnChangeName(value))
                        name = value;
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }//Наименование

        [DisplayName("Комментарий")]
        [Category("Общие сведения")]
        public string Note { set; get; }//Примечание (комментарий)

        public override string ToString()
        {
            return Name;
        }
    }
}
