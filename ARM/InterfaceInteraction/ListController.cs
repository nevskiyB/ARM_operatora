using System.Collections.Generic;
using System.Windows.Forms;

namespace ARM.InterfaceInteraction
{
    public class ListController
    {
        public List<Device> devices = new List<Device>();
        ListBox lB_devices;

        public ListController(ListBox listBox)
        {
            this.lB_devices = listBox;
        }

        public bool Add(Device item)
        {
            bool flag = true;

            item.OnChangeName += (s) =>
            {
                if (NamesEqualityChecking(s) && NamesLengthChecking(s, 40))
                {
                    flag = true;
                    return true;
                }
                else
                {
                    flag = false;
                    return false;
                }
            };

            if (flag)
            {
                devices.Add(item);
                lB_devices.Items.Add(item.ToString());
                return true;
            }
            else
            {
                return false;
            }

        }//Добавляет item в списки

        public void DeleteSelectedElement()
        {
            if (lB_devices.SelectedIndex > -1)
            {
                devices.RemoveAt(lB_devices.SelectedIndex);
                lB_devices.Items.RemoveAt(lB_devices.SelectedIndex);
            }
        }//Удаляет выделенный элемент

        public void Refresh()
        {
            if (devices == null)
                return;

            lB_devices.Items.Clear();

            foreach (Device item in devices)
            {
                lB_devices.Items.Add(item);
            }
        }//Обновляет listbox по списку boards

        private bool NamesEqualityChecking(string name)
        {
            int maxLength = 40;
            if (name.Length > maxLength)
            {
                MessageBox.Show("Количество символов в имени не может привышать " + maxLength);
                return false;
            }

            foreach (Device item in devices)
            {
                if (name == item.Name)
                {
                    MessageBox.Show("Имя уже зарезервировано!");
                    return false;
                }
            }

            return true;
        }//Проверка имени на совпадение

        private bool NamesLengthChecking(string name, int maxLength)
        {
            if (name.Length > maxLength)
            {
                MessageBox.Show("Количество символов в имени не может привышать " + maxLength);
                return false;
            }
            return true;
        }//Проверка длины имени

    }//Представляет методы для реализации
}
