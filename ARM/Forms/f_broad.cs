using ARM.InterfaceInteraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARM.Forms
{
    public partial class F_board : Form
    {
        ListController boardsController;
        Board board = new Board();
        Form formParent;
        public F_board(ListController boardsController, Form formParent)
        {
            InitializeComponent();

            this.boardsController = boardsController;
            this.formParent = formParent;

            pG_BoardProperty.SelectedObject = board;  
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (board.Name == null)
            {
                MessageBox.Show("Свойство <Имя> не заполнено!");
                return;
            }
            if (board.TransientProcessTime <= 0)
            {
                MessageBox.Show("Свойство <Время переходного процесса> должно быть больше нуля!");
                return;
            }
            foreach (Board item in boardsController.devices)
            {
                if (board.Name == item.Name)
                {
                    MessageBox.Show("Такое имя уже существует!");
                    return;
                }
            }

            if (boardsController.Add(board))
                this.Close();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_board_FormClosed(object sender, FormClosedEventArgs e)
        {
            formParent.Enabled = true;
            this.Hide();
            this.Dispose();
        }
    }
}