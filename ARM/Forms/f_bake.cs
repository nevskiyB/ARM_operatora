using ARM.InterfaceInteraction;
using System;
using System.Windows.Forms;

namespace ARM.Forms
{
    public partial class F_bake : Form
    {
        ListController bakeController;
        Bake bake = new Bake();
        Form formParent;
        public F_bake(ListController bakeController, Form formParent)
        {
            InitializeComponent();

            this.bakeController = bakeController;
            pG_BakeProperty.SelectedObject = bake;
            this.formParent = formParent;
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (bake.Name == null)
            {
                MessageBox.Show("Поле <Имя> не заполнено!");
                return;
            }

            if (bake.MaxSpeed <= 0)
            {
                MessageBox.Show("Максимальная скорость конвейера должна быть больше нуля!");
                return;
            }

            if (bake.MinSpeed <= 0)
            {
                MessageBox.Show("Минимальная скорость конвейера должна быть больше нуля!");
                return;
            }

            if (bake.MaxSpeed <= bake.MinSpeed)
            {
                MessageBox.Show("Минимальная скорость конвейера не может быть больше максимальной!");
                return;
            }

            foreach (Bake item in bakeController.devices)
            {
                if (bake.Name == item.Name)
                {
                    MessageBox.Show("Такое имя уже существует!");
                    return;
                }
            }

            bakeController.Add(bake);

            this.Close();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_bake_FormClosed(object sender, FormClosedEventArgs e)
        {
            formParent.Enabled = true;
            this.Hide();
            this.Dispose();
        }
    }
}
