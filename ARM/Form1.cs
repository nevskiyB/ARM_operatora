using ARM.InterfaceInteraction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ARM
{
    public partial class F_mainForm : Form
    {
        public ListController boardController;
        public ListController bakeController;
        public Formatter formatter;
        ARM.Forms.F_board broadConfig;
        ARM.Forms.F_bake bakeConfig;

        public F_mainForm()
        {
            InitializeComponent();
            chartZone.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            boardController = new ListController(lB_boards);
            bakeController = new ListController(lB_bakes);
            formatter = new Formatter();
            broadConfig = new Forms.F_board(boardController, this);
            bakeConfig = new Forms.F_bake(bakeController, this);
        }

        private void F_mainForm_Load(object sender, EventArgs e)
        {
            //Перечисленны платы и печи для примера работы программы
            Board testBoard = new Board();
            testBoard.Name = "Тестовая плата";
            testBoard.Note = "Плата используется для демонстрации работы программы";
            testBoard.TransientProcessTime = 90;
            boardController.Add(testBoard);

            Bake Raduga21 = new Bake();
            Raduga21.Name = "Радуга-21";
            Raduga21.Note = "Пятизонная печь оплавления фирмы НПП<<Радуга>>.\n Сайт изготовителя: https://www.raduga-npp.ru/";
            Raduga21.MaxSpeed = 0.75;
            Raduga21.MinSpeed = 0.15;
            Raduga21.ZoneQuantity = Bake.Zone.zon5;
            bakeController.Add(Raduga21);

            Bake Raduga23 = new Bake();
            Raduga23.Name = "Радуга-23";
            Raduga23.Note = "Печь оплавления с 12 зонами фирмы НПП<<Радуга>>.\n Сайт изготовителя: https://www.raduga-npp.ru/";
            Raduga23.MaxSpeed = 1.5;
            Raduga23.MinSpeed = 0.1;
            Raduga23.ZoneQuantity = Bake.Zone.zon12;
            bakeController.Add(Raduga23);

            Bake Raduga12 = new Bake();
            Raduga12.Name = "Радуга-12";
            Raduga12.Note = "Шестизонная печь оплавления фирмы НПП<<Радуга>>.\n Сайт изготовителя: https://www.raduga-npp.ru/";
            Raduga12.MaxSpeed = 0.75;
            Raduga12.MinSpeed = 0.15;
            Raduga12.ZoneQuantity = Bake.Zone.zon6;
            bakeController.Add(Raduga12);
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            if (tC_TechnicalMeans.SelectedIndex == 0)
            {
                ARM.Forms.F_board broadConfig = new Forms.F_board(boardController, this);
                broadConfig.Show();

                this.Enabled = false;
            }

            if (tC_TechnicalMeans.SelectedIndex == 1)
            {
                ARM.Forms.F_bake bakeConfig = new Forms.F_bake(bakeController, this);
                bakeConfig.Show();

                this.Enabled = false;
            }
        }//Добавление элемента в список

        private void b_delete_Click(object sender, EventArgs e)
        {
            if (tC_TechnicalMeans.SelectedIndex == 0)
                boardController.DeleteSelectedElement();
            if (tC_TechnicalMeans.SelectedIndex == 1)
                bakeController.DeleteSelectedElement();
        }//Удаление элемента из списка

        private void b_calc_Click(object sender, EventArgs e)
        {
            Board board_tmp = (Board)boardController.devices[lB_boards.SelectedIndex];
            Bake bake_tmp = (Bake)bakeController.devices[lB_bakes.SelectedIndex];
            Polynomial poly = new Polynomial(bake_tmp.ZoneQuantity);

            double speed = poly.GetFromPoly(poly.PolyV, board_tmp.TimeConst);
            speed = speed * 60;//Перевод в м/мин

            double[] ZoneT = poly.GetZoneTemperature(board_tmp.TimeConst);

            DisplaySpeed(speed, bake_tmp.MaxSpeed, bake_tmp.MinSpeed);
            DrawChart(ZoneT);
            FillTable(ZoneT);
        }//Расчёт параметров
        private void DisplaySpeed(double speed, double maxSpeed, double minSpeed)
        {
            tB_speed.Text = Convert.ToString(Math.Round(speed, 2));

            if (maxSpeed >= speed && minSpeed <= speed)
            {
                tB_speed.ForeColor = Color.Black;
            }
            else
            {
                tB_speed.ForeColor = Color.Red;
                MessageBox.Show("Скорость конвейера не соответствует техническим характеристикам печи!");
            }
        }//Вывод скорости конвейера

        private void FillTable(double[] ZoneT)
        {
            dGV_TableT.RowCount = 1;
            dGV_TableT.ColumnCount = ZoneT.Length;
            for (int i = 0; i < dGV_TableT.ColumnCount; i++)
            {
                dGV_TableT.Columns[i].HeaderText = "T зона: " + (i + 1);
                dGV_TableT.Rows[0].Cells[i].Value = Math.Round(ZoneT[i], 0);
            }
        }//Метод для заполнение таблицы(Параметр: массив температур зон)

        private void DrawChart(double[] ZoneT)
        {
            chartZone.Series[0].Points.Clear();

            for (int i = 0; i < ZoneT.Length; i++)
            {
                chartZone.Series[0].Points.AddXY(i + 1, ZoneT[i]);
            }
        }//Метод создание гистограммы(Параметр: массив температур зон)

        private void pG_ParamProperty_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            int tmpIndex;

            if (tC_TechnicalMeans.SelectedIndex == 0)
            {
                tmpIndex = lB_boards.SelectedIndex;
                boardController.Refresh();
                lB_boards.SetSelected(tmpIndex, true);
            }
            if (tC_TechnicalMeans.SelectedIndex == 1)
            {
                tmpIndex = lB_bakes.SelectedIndex;
                bakeController.Refresh();
                lB_bakes.SetSelected(tmpIndex, true);
            }
        }//Обработчик события изменения свойства

        private void lB_boards_SelectedIndexChanged(object sender, EventArgs e)    {
            if (lB_boards.SelectedIndex > -1)
                l_board.Text = "Плата: " + lB_boards.SelectedItem.ToString();
            else
                l_board.Text = "Плата: ";

            CalcButtonControlling();
            SwichPropertyGrid();
        }//Обработчик события изменения выбранного индекса в lB_boards

        private void lB_bakes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lB_bakes.SelectedIndex > -1)
                l_bake.Text = "Печь: " + lB_bakes.SelectedItem.ToString();
            else
                l_bake.Text = "Печь: ";

            CalcButtonControlling();
            SwichPropertyGrid();
        }//Обработчик события изменения выбранного индекса в lB_bakes

        private void tC_TechnicalMeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwichPropertyGrid();
        }//Обработчик события изменения индекса открытой вкладки C_TechnicalMeans

        private void SwichPropertyGrid()
        {
            if (tC_TechnicalMeans.SelectedIndex == 0)
            {
                if (lB_boards.SelectedIndex > -1)
                    pG_ParamProperty.SelectedObject = boardController.devices[lB_boards.SelectedIndex];
                else
                    pG_ParamProperty.SelectedObject = null;
            }
            if (tC_TechnicalMeans.SelectedIndex == 1)
            {
                if (lB_bakes.SelectedIndex > -1)
                    pG_ParamProperty.SelectedObject = bakeController.devices[lB_bakes.SelectedIndex];
                else
                    pG_ParamProperty.SelectedObject = null;
            }
        }//Метод переключает отображаемые свойства в pG_ParamProperty и зависимости от выбранной вкладки C_TechnicalMeans

        private void TSMI_SaveBoardList_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Платы";
            saveFileDialog.ShowDialog();
            formatter.WriteBoardList(boardController.devices, saveFileDialog.FileName + ".boards");
        }//Обработчик события сихраняет список плат

        private void TSMI_SaveBakeList_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Печи";
            saveFileDialog.ShowDialog();
            formatter.WriteBakeList(bakeController.devices, saveFileDialog.FileName + ".bakes");
        }//Обработчик события сохраняет список печей

        private void TSMI_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName.Contains(".bakes"))
            {
                List<Bake> bakes = formatter.ReadBakeList(openFileDialog.FileName);
                if (bakes != null)
                {
                    bakeController.devices = new List<Device>(bakes);
                    bakeController.Refresh();
                }
                return;
            }
            if (openFileDialog.FileName.Contains(".boards"))
            {
                List<Board> boards = formatter.ReadBoardList(openFileDialog.FileName);
                if (boards != null)
                {
                    boardController.devices = new List<Device>(boards);
                    boardController.Refresh();
                }  
            }
        }//Обработчик события загружает список с учётом расширения

        private void CalcButtonControlling()
        {
            if (lB_boards.SelectedIndex > -1 && lB_bakes.SelectedIndex > -1)
            {
                b_calc.Enabled = true;
                b_calc.BackColor = Color.DarkSeaGreen;
            }
            else
            {
                b_calc.Enabled = false;
                b_calc.BackColor = Color.Silver;
            }
        }//Метод активации и дезактивации кнопки b_calc

        private void b_Clear_Click(object sender, EventArgs e)
        {
            dGV_TableT.Rows.Clear();
            dGV_TableT.Columns.Clear();
            tB_speed.Text = "";
        }//Обработчик события отчищает данные, полученные в результате расчёта
    }
}
