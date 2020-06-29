namespace ARM
{
    partial class F_mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tC_TechnicalMeans = new System.Windows.Forms.TabControl();
            this.tP_board = new System.Windows.Forms.TabPage();
            this.lB_boards = new System.Windows.Forms.ListBox();
            this.tP_bake = new System.Windows.Forms.TabPage();
            this.lB_bakes = new System.Windows.Forms.ListBox();
            this.pG_ParamProperty = new System.Windows.Forms.PropertyGrid();
            this.p_ParamPanel = new System.Windows.Forms.Panel();
            this.b_Clear = new System.Windows.Forms.Button();
            this.l_dimension = new System.Windows.Forms.Label();
            this.tB_speed = new System.Windows.Forms.TextBox();
            this.l_speed = new System.Windows.Forms.Label();
            this.l_TTable = new System.Windows.Forms.Label();
            this.l_bake = new System.Windows.Forms.Label();
            this.l_board = new System.Windows.Forms.Label();
            this.dGV_TableT = new System.Windows.Forms.DataGridView();
            this.b_calc = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.mS_menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_save = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SaveBoardList = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SaveBakeList = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.chartZone = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tC_TechnicalMeans.SuspendLayout();
            this.tP_board.SuspendLayout();
            this.tP_bake.SuspendLayout();
            this.p_ParamPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TableT)).BeginInit();
            this.mS_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartZone)).BeginInit();
            this.SuspendLayout();
            // 
            // tC_TechnicalMeans
            // 
            this.tC_TechnicalMeans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tC_TechnicalMeans.Controls.Add(this.tP_board);
            this.tC_TechnicalMeans.Controls.Add(this.tP_bake);
            this.tC_TechnicalMeans.Location = new System.Drawing.Point(718, 27);
            this.tC_TechnicalMeans.Name = "tC_TechnicalMeans";
            this.tC_TechnicalMeans.SelectedIndex = 0;
            this.tC_TechnicalMeans.Size = new System.Drawing.Size(237, 421);
            this.tC_TechnicalMeans.TabIndex = 0;
            this.tC_TechnicalMeans.SelectedIndexChanged += new System.EventHandler(this.tC_TechnicalMeans_SelectedIndexChanged);
            // 
            // tP_board
            // 
            this.tP_board.BackColor = System.Drawing.Color.DimGray;
            this.tP_board.Controls.Add(this.lB_boards);
            this.tP_board.Location = new System.Drawing.Point(4, 22);
            this.tP_board.Name = "tP_board";
            this.tP_board.Padding = new System.Windows.Forms.Padding(3);
            this.tP_board.Size = new System.Drawing.Size(229, 395);
            this.tP_board.TabIndex = 0;
            this.tP_board.Text = "Плата";
            // 
            // lB_boards
            // 
            this.lB_boards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lB_boards.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lB_boards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lB_boards.FormattingEnabled = true;
            this.lB_boards.Location = new System.Drawing.Point(6, 8);
            this.lB_boards.Name = "lB_boards";
            this.lB_boards.Size = new System.Drawing.Size(217, 377);
            this.lB_boards.TabIndex = 4;
            this.lB_boards.SelectedIndexChanged += new System.EventHandler(this.lB_boards_SelectedIndexChanged);
            // 
            // tP_bake
            // 
            this.tP_bake.BackColor = System.Drawing.Color.DimGray;
            this.tP_bake.Controls.Add(this.lB_bakes);
            this.tP_bake.Location = new System.Drawing.Point(4, 22);
            this.tP_bake.Name = "tP_bake";
            this.tP_bake.Padding = new System.Windows.Forms.Padding(3);
            this.tP_bake.Size = new System.Drawing.Size(229, 395);
            this.tP_bake.TabIndex = 1;
            this.tP_bake.Text = "Печь";
            // 
            // lB_bakes
            // 
            this.lB_bakes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lB_bakes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lB_bakes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lB_bakes.FormattingEnabled = true;
            this.lB_bakes.Location = new System.Drawing.Point(6, 8);
            this.lB_bakes.Name = "lB_bakes";
            this.lB_bakes.Size = new System.Drawing.Size(217, 377);
            this.lB_bakes.TabIndex = 5;
            this.lB_bakes.SelectedIndexChanged += new System.EventHandler(this.lB_bakes_SelectedIndexChanged);
            // 
            // pG_ParamProperty
            // 
            this.pG_ParamProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pG_ParamProperty.Location = new System.Drawing.Point(718, 483);
            this.pG_ParamProperty.Name = "pG_ParamProperty";
            this.pG_ParamProperty.Size = new System.Drawing.Size(237, 167);
            this.pG_ParamProperty.TabIndex = 3;
            this.pG_ParamProperty.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pG_ParamProperty_PropertyValueChanged);
            // 
            // p_ParamPanel
            // 
            this.p_ParamPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_ParamPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.p_ParamPanel.Controls.Add(this.b_Clear);
            this.p_ParamPanel.Controls.Add(this.l_dimension);
            this.p_ParamPanel.Controls.Add(this.tB_speed);
            this.p_ParamPanel.Controls.Add(this.l_speed);
            this.p_ParamPanel.Controls.Add(this.l_TTable);
            this.p_ParamPanel.Controls.Add(this.l_bake);
            this.p_ParamPanel.Controls.Add(this.l_board);
            this.p_ParamPanel.Controls.Add(this.dGV_TableT);
            this.p_ParamPanel.Location = new System.Drawing.Point(12, 483);
            this.p_ParamPanel.Name = "p_ParamPanel";
            this.p_ParamPanel.Size = new System.Drawing.Size(700, 167);
            this.p_ParamPanel.TabIndex = 1;
            // 
            // b_Clear
            // 
            this.b_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Clear.BackColor = System.Drawing.SystemColors.Control;
            this.b_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Clear.Location = new System.Drawing.Point(537, 31);
            this.b_Clear.Name = "b_Clear";
            this.b_Clear.Size = new System.Drawing.Size(157, 23);
            this.b_Clear.TabIndex = 11;
            this.b_Clear.Text = "Отчистить поля";
            this.b_Clear.UseVisualStyleBackColor = false;
            this.b_Clear.Click += new System.EventHandler(this.b_Clear_Click);
            // 
            // l_dimension
            // 
            this.l_dimension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l_dimension.AutoSize = true;
            this.l_dimension.BackColor = System.Drawing.SystemColors.Control;
            this.l_dimension.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.l_dimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_dimension.Location = new System.Drawing.Point(648, 6);
            this.l_dimension.Name = "l_dimension";
            this.l_dimension.Size = new System.Drawing.Size(46, 16);
            this.l_dimension.TabIndex = 11;
            this.l_dimension.Text = "м/мин";
            // 
            // tB_speed
            // 
            this.tB_speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_speed.BackColor = System.Drawing.SystemColors.Control;
            this.tB_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_speed.Location = new System.Drawing.Point(537, 3);
            this.tB_speed.Name = "tB_speed";
            this.tB_speed.ReadOnly = true;
            this.tB_speed.Size = new System.Drawing.Size(105, 22);
            this.tB_speed.TabIndex = 10;
            // 
            // l_speed
            // 
            this.l_speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l_speed.AutoSize = true;
            this.l_speed.BackColor = System.Drawing.SystemColors.Control;
            this.l_speed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.l_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_speed.Location = new System.Drawing.Point(385, 6);
            this.l_speed.Name = "l_speed";
            this.l_speed.Size = new System.Drawing.Size(146, 16);
            this.l_speed.TabIndex = 9;
            this.l_speed.Text = "Скорость конвейера:";
            // 
            // l_TTable
            // 
            this.l_TTable.AutoSize = true;
            this.l_TTable.BackColor = System.Drawing.SystemColors.Control;
            this.l_TTable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.l_TTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_TTable.Location = new System.Drawing.Point(3, 63);
            this.l_TTable.Name = "l_TTable";
            this.l_TTable.Size = new System.Drawing.Size(177, 16);
            this.l_TTable.TabIndex = 8;
            this.l_TTable.Text = "Таблица температур зон:";
            // 
            // l_bake
            // 
            this.l_bake.AutoSize = true;
            this.l_bake.BackColor = System.Drawing.SystemColors.Control;
            this.l_bake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_bake.Location = new System.Drawing.Point(3, 23);
            this.l_bake.Name = "l_bake";
            this.l_bake.Size = new System.Drawing.Size(47, 16);
            this.l_bake.TabIndex = 7;
            this.l_bake.Text = "Печь: ";
            // 
            // l_board
            // 
            this.l_board.AutoSize = true;
            this.l_board.BackColor = System.Drawing.SystemColors.Control;
            this.l_board.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_board.Location = new System.Drawing.Point(3, 6);
            this.l_board.Name = "l_board";
            this.l_board.Size = new System.Drawing.Size(55, 16);
            this.l_board.TabIndex = 6;
            this.l_board.Text = "Плата: ";
            // 
            // dGV_TableT
            // 
            this.dGV_TableT.AllowUserToAddRows = false;
            this.dGV_TableT.AllowUserToDeleteRows = false;
            this.dGV_TableT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_TableT.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGV_TableT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_TableT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dGV_TableT.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dGV_TableT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_TableT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_TableT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_TableT.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_TableT.Location = new System.Drawing.Point(3, 82);
            this.dGV_TableT.Name = "dGV_TableT";
            this.dGV_TableT.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_TableT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_TableT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dGV_TableT.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_TableT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGV_TableT.Size = new System.Drawing.Size(691, 82);
            this.dGV_TableT.TabIndex = 5;
            // 
            // b_calc
            // 
            this.b_calc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_calc.BackColor = System.Drawing.Color.Silver;
            this.b_calc.Enabled = false;
            this.b_calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_calc.Location = new System.Drawing.Point(718, 454);
            this.b_calc.Name = "b_calc";
            this.b_calc.Size = new System.Drawing.Size(75, 23);
            this.b_calc.TabIndex = 7;
            this.b_calc.Text = "Расчёт";
            this.b_calc.UseVisualStyleBackColor = false;
            this.b_calc.Click += new System.EventHandler(this.b_calc_Click);
            // 
            // b_delete
            // 
            this.b_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_delete.BackColor = System.Drawing.SystemColors.Control;
            this.b_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_delete.Location = new System.Drawing.Point(880, 454);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(75, 23);
            this.b_delete.TabIndex = 5;
            this.b_delete.Text = "Удалить";
            this.b_delete.UseVisualStyleBackColor = false;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_add
            // 
            this.b_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_add.BackColor = System.Drawing.SystemColors.Control;
            this.b_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_add.Location = new System.Drawing.Point(799, 454);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(75, 23);
            this.b_add.TabIndex = 6;
            this.b_add.Text = "Добавить";
            this.b_add.UseVisualStyleBackColor = false;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // mS_menu
            // 
            this.mS_menu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mS_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.mS_menu.Location = new System.Drawing.Point(0, 0);
            this.mS_menu.Name = "mS_menu";
            this.mS_menu.Size = new System.Drawing.Size(968, 24);
            this.mS_menu.TabIndex = 10;
            this.mS_menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_save,
            this.TSMI_Load});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // TSMI_save
            // 
            this.TSMI_save.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_SaveBoardList,
            this.TSMI_SaveBakeList});
            this.TSMI_save.Name = "TSMI_save";
            this.TSMI_save.Size = new System.Drawing.Size(180, 22);
            this.TSMI_save.Text = "Сохранить";
            // 
            // TSMI_SaveBoardList
            // 
            this.TSMI_SaveBoardList.Name = "TSMI_SaveBoardList";
            this.TSMI_SaveBoardList.Size = new System.Drawing.Size(180, 22);
            this.TSMI_SaveBoardList.Text = "Список плат";
            this.TSMI_SaveBoardList.Click += new System.EventHandler(this.TSMI_SaveBoardList_Click);
            // 
            // TSMI_SaveBakeList
            // 
            this.TSMI_SaveBakeList.Name = "TSMI_SaveBakeList";
            this.TSMI_SaveBakeList.Size = new System.Drawing.Size(180, 22);
            this.TSMI_SaveBakeList.Text = "Список печей";
            this.TSMI_SaveBakeList.Click += new System.EventHandler(this.TSMI_SaveBakeList_Click);
            // 
            // TSMI_Load
            // 
            this.TSMI_Load.Name = "TSMI_Load";
            this.TSMI_Load.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Load.Text = "Загрузить";
            this.TSMI_Load.Click += new System.EventHandler(this.TSMI_Load_Click);
            // 
            // chartZone
            // 
            this.chartZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chartZone.BorderlineColor = System.Drawing.Color.DimGray;
            this.chartZone.BorderlineWidth = 0;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.Title = "Зоны";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.Title = "Температуры,°C";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartZone.ChartAreas.Add(chartArea1);
            this.chartZone.Location = new System.Drawing.Point(12, 27);
            this.chartZone.Name = "chartZone";
            this.chartZone.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartZone.Series.Add(series1);
            this.chartZone.Size = new System.Drawing.Size(700, 450);
            this.chartZone.TabIndex = 5;
            this.chartZone.Text = "chartZones";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "TitleChart";
            title1.Text = "Температуры в зонах печи";
            this.chartZone.Titles.Add(title1);
            // 
            // F_mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(968, 662);
            this.Controls.Add(this.chartZone);
            this.Controls.Add(this.b_calc);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.pG_ParamProperty);
            this.Controls.Add(this.p_ParamPanel);
            this.Controls.Add(this.tC_TechnicalMeans);
            this.Controls.Add(this.mS_menu);
            this.MainMenuStrip = this.mS_menu;
            this.Name = "F_mainForm";
            this.Text = "АРМ оператора";
            this.Load += new System.EventHandler(this.F_mainForm_Load);
            this.tC_TechnicalMeans.ResumeLayout(false);
            this.tP_board.ResumeLayout(false);
            this.tP_bake.ResumeLayout(false);
            this.p_ParamPanel.ResumeLayout(false);
            this.p_ParamPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TableT)).EndInit();
            this.mS_menu.ResumeLayout(false);
            this.mS_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tC_TechnicalMeans;
        private System.Windows.Forms.TabPage tP_board;
        private System.Windows.Forms.ListBox lB_boards;
        private System.Windows.Forms.PropertyGrid pG_ParamProperty;
        private System.Windows.Forms.TabPage tP_bake;
        private System.Windows.Forms.Panel p_ParamPanel;
        private System.Windows.Forms.DataGridView dGV_TableT;
        private System.Windows.Forms.Label l_TTable;
        private System.Windows.Forms.Label l_bake;
        private System.Windows.Forms.Label l_board;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_calc;
        private System.Windows.Forms.ListBox lB_bakes;
        private System.Windows.Forms.MenuStrip mS_menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_save;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SaveBoardList;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SaveBakeList;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Load;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZone;
        private System.Windows.Forms.TextBox tB_speed;
        private System.Windows.Forms.Label l_speed;
        private System.Windows.Forms.Label l_dimension;
        private System.Windows.Forms.Button b_Clear;
    }
}

