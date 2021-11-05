namespace Fractal
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lY = new System.Windows.Forms.Label();
            this.lX = new System.Windows.Forms.Label();
            this.udY = new System.Windows.Forms.NumericUpDown();
            this.udX = new System.Windows.Forms.NumericUpDown();
            this.Lsize = new System.Windows.Forms.Label();
            this.udSize = new System.Windows.Forms.NumericUpDown();
            this.pG = new System.Windows.Forms.Panel();
            this.btTimer = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbCoord = new System.Windows.Forms.GroupBox();
            this.gbZoom = new System.Windows.Forms.GroupBox();
            this.Lzoom = new System.Windows.Forms.Label();
            this.cbZoom = new System.Windows.Forms.ComboBox();
            this.rbPlus = new System.Windows.Forms.RadioButton();
            this.rbMinus = new System.Windows.Forms.RadioButton();
            this.LIter = new System.Windows.Forms.Label();
            this.udIter = new System.Windows.Forms.NumericUpDown();
            this.btRefresh = new System.Windows.Forms.Button();
            this.sfdPic = new System.Windows.Forms.SaveFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.sfdCoord = new System.Windows.Forms.SaveFileDialog();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tsddbImg = new System.Windows.Forms.ToolStripDropDownButton();
            this.btSaveImg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbCoord = new System.Windows.Forms.ToolStripDropDownButton();
            this.btSaveTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.btLoadTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.btSaveBin = new System.Windows.Forms.ToolStripMenuItem();
            this.btLoadBin = new System.Windows.Forms.ToolStripMenuItem();
            this.PB = new System.Windows.Forms.PictureBox();
            this.ofdCoord = new System.Windows.Forms.OpenFileDialog();
            this.sfdCoordTxt = new System.Windows.Forms.SaveFileDialog();
            this.ofdCoordTxt = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.udY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSize)).BeginInit();
            this.pG.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.gbCoord.SuspendLayout();
            this.gbZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udIter)).BeginInit();
            this.ts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // lY
            // 
            this.lY.AutoSize = true;
            this.lY.Location = new System.Drawing.Point(17, 47);
            this.lY.Name = "lY";
            this.lY.Size = new System.Drawing.Size(29, 13);
            this.lY.TabIndex = 4;
            this.lY.Text = "Y   --";
            // 
            // lX
            // 
            this.lX.AutoSize = true;
            this.lX.Location = new System.Drawing.Point(17, 21);
            this.lX.Name = "lX";
            this.lX.Size = new System.Drawing.Size(29, 13);
            this.lX.TabIndex = 3;
            this.lX.Text = "Х   --";
            // 
            // udY
            // 
            this.udY.DecimalPlaces = 15;
            this.udY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.udY.Location = new System.Drawing.Point(55, 45);
            this.udY.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.udY.Minimum = new decimal(new int[] {
            55,
            0,
            0,
            -2147418112});
            this.udY.Name = "udY";
            this.udY.Size = new System.Drawing.Size(123, 20);
            this.udY.TabIndex = 2;
            this.udY.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.udY.ValueChanged += new System.EventHandler(this.udIter_ValueChanged);
            // 
            // udX
            // 
            this.udX.DecimalPlaces = 15;
            this.udX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.udX.Location = new System.Drawing.Point(55, 19);
            this.udX.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.udX.Minimum = new decimal(new int[] {
            55,
            0,
            0,
            -2147418112});
            this.udX.Name = "udX";
            this.udX.Size = new System.Drawing.Size(123, 20);
            this.udX.TabIndex = 1;
            this.udX.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.udX.ValueChanged += new System.EventHandler(this.udIter_ValueChanged);
            // 
            // Lsize
            // 
            this.Lsize.AutoSize = true;
            this.Lsize.Location = new System.Drawing.Point(39, 25);
            this.Lsize.Name = "Lsize";
            this.Lsize.Size = new System.Drawing.Size(95, 13);
            this.Lsize.TabIndex = 3;
            this.Lsize.Text = "Ширина / Высота";
            // 
            // udSize
            // 
            this.udSize.DecimalPlaces = 15;
            this.udSize.Location = new System.Drawing.Point(27, 41);
            this.udSize.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            983040});
            this.udSize.Name = "udSize";
            this.udSize.Size = new System.Drawing.Size(123, 20);
            this.udSize.TabIndex = 2;
            this.udSize.Value = new decimal(new int[] {
            1105788928,
            93132,
            0,
            917504});
            this.udSize.ValueChanged += new System.EventHandler(this.udIter_ValueChanged);
            // 
            // pG
            // 
            this.pG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pG.BackColor = System.Drawing.Color.NavajoWhite;
            this.pG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pG.Controls.Add(this.btTimer);
            this.pG.Controls.Add(this.btReset);
            this.pG.Controls.Add(this.gbSize);
            this.pG.Controls.Add(this.gbCoord);
            this.pG.Controls.Add(this.gbZoom);
            this.pG.Controls.Add(this.LIter);
            this.pG.Controls.Add(this.udIter);
            this.pG.Controls.Add(this.btRefresh);
            this.pG.Location = new System.Drawing.Point(0, 25);
            this.pG.Name = "pG";
            this.pG.Size = new System.Drawing.Size(200, 480);
            this.pG.TabIndex = 3;
            // 
            // btTimer
            // 
            this.btTimer.Location = new System.Drawing.Point(66, 297);
            this.btTimer.Name = "btTimer";
            this.btTimer.Size = new System.Drawing.Size(75, 23);
            this.btTimer.TabIndex = 13;
            this.btTimer.Text = "Старт";
            this.btTimer.UseVisualStyleBackColor = true;
            this.btTimer.Click += new System.EventHandler(this.btTimer_Click);
            // 
            // btReset
            // 
            this.btReset.Image = global::Множество_Мондельброта.Properties.Resources.arrow_rotate_anticlockwise;
            this.btReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReset.Location = new System.Drawing.Point(100, 359);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(80, 23);
            this.btReset.TabIndex = 12;
            this.btReset.Text = "Сброс";
            this.btReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.udSize);
            this.gbSize.Controls.Add(this.Lsize);
            this.gbSize.Location = new System.Drawing.Point(11, 92);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(181, 75);
            this.gbSize.TabIndex = 10;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Размеры рабочего участка";
            // 
            // gbCoord
            // 
            this.gbCoord.Controls.Add(this.lY);
            this.gbCoord.Controls.Add(this.udX);
            this.gbCoord.Controls.Add(this.lX);
            this.gbCoord.Controls.Add(this.udY);
            this.gbCoord.Location = new System.Drawing.Point(11, 11);
            this.gbCoord.Name = "gbCoord";
            this.gbCoord.Size = new System.Drawing.Size(181, 75);
            this.gbCoord.TabIndex = 9;
            this.gbCoord.TabStop = false;
            this.gbCoord.Text = "Координаты якорной точки";
            // 
            // gbZoom
            // 
            this.gbZoom.Controls.Add(this.Lzoom);
            this.gbZoom.Controls.Add(this.cbZoom);
            this.gbZoom.Controls.Add(this.rbPlus);
            this.gbZoom.Controls.Add(this.rbMinus);
            this.gbZoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbZoom.Location = new System.Drawing.Point(11, 173);
            this.gbZoom.Name = "gbZoom";
            this.gbZoom.Size = new System.Drawing.Size(181, 75);
            this.gbZoom.TabIndex = 8;
            this.gbZoom.TabStop = false;
            this.gbZoom.Text = "Зум";
            // 
            // Lzoom
            // 
            this.Lzoom.AutoSize = true;
            this.Lzoom.Location = new System.Drawing.Point(109, 21);
            this.Lzoom.Name = "Lzoom";
            this.Lzoom.Size = new System.Drawing.Size(60, 13);
            this.Lzoom.TabIndex = 4;
            this.Lzoom.Text = "Кратность";
            // 
            // cbZoom
            // 
            this.cbZoom.FormattingEnabled = true;
            this.cbZoom.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32"});
            this.cbZoom.Location = new System.Drawing.Point(112, 41);
            this.cbZoom.Name = "cbZoom";
            this.cbZoom.Size = new System.Drawing.Size(57, 21);
            this.cbZoom.TabIndex = 8;
            // 
            // rbPlus
            // 
            this.rbPlus.AutoSize = true;
            this.rbPlus.Checked = true;
            this.rbPlus.Location = new System.Drawing.Point(6, 21);
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.Size = new System.Drawing.Size(86, 17);
            this.rbPlus.TabIndex = 6;
            this.rbPlus.TabStop = true;
            this.rbPlus.Text = "Увеличение";
            this.rbPlus.UseVisualStyleBackColor = true;
            // 
            // rbMinus
            // 
            this.rbMinus.AutoSize = true;
            this.rbMinus.Location = new System.Drawing.Point(6, 42);
            this.rbMinus.Name = "rbMinus";
            this.rbMinus.Size = new System.Drawing.Size(91, 17);
            this.rbMinus.TabIndex = 7;
            this.rbMinus.Text = "Уменьшение";
            this.rbMinus.UseVisualStyleBackColor = true;
            // 
            // LIter
            // 
            this.LIter.AutoSize = true;
            this.LIter.Location = new System.Drawing.Point(45, 255);
            this.LIter.Name = "LIter";
            this.LIter.Size = new System.Drawing.Size(116, 13);
            this.LIter.TabIndex = 5;
            this.LIter.Text = "Количество итераций";
            // 
            // udIter
            // 
            this.udIter.Location = new System.Drawing.Point(75, 271);
            this.udIter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udIter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udIter.Name = "udIter";
            this.udIter.Size = new System.Drawing.Size(57, 20);
            this.udIter.TabIndex = 4;
            this.udIter.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udIter.ValueChanged += new System.EventHandler(this.udIter_ValueChanged);
            // 
            // btRefresh
            // 
            this.btRefresh.Image = global::Множество_Мондельброта.Properties.Resources.arrow_refresh;
            this.btRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRefresh.Location = new System.Drawing.Point(14, 359);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(80, 23);
            this.btRefresh.TabIndex = 3;
            this.btRefresh.Text = "Обновить";
            this.btRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btDraw_Click);
            // 
            // sfdPic
            // 
            this.sfdPic.DefaultExt = "png";
            this.sfdPic.FileName = "Fractal";
            this.sfdPic.Filter = "png файл|*.png|bmp файл|*.bmp|Все файлы|*.*";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // sfdCoord
            // 
            this.sfdCoord.DefaultExt = "mndlbrt";
            this.sfdCoord.FileName = "Бинарные координаты";
            this.sfdCoord.Filter = "Файл данных|*.dat|Бинарный файл|*.bin";
            // 
            // ts
            // 
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbImg,
            this.toolStripSeparator1,
            this.tsddbCoord});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(679, 25);
            this.ts.TabIndex = 4;
            this.ts.Text = "toolStrip1";
            // 
            // tsddbImg
            // 
            this.tsddbImg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSaveImg});
            this.tsddbImg.Image = ((System.Drawing.Image)(resources.GetObject("tsddbImg.Image")));
            this.tsddbImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbImg.Name = "tsddbImg";
            this.tsddbImg.Size = new System.Drawing.Size(112, 22);
            this.tsddbImg.Text = "Изображение";
            // 
            // btSaveImg
            // 
            this.btSaveImg.Name = "btSaveImg";
            this.btSaveImg.Size = new System.Drawing.Size(133, 22);
            this.btSaveImg.Text = "Сохранить";
            this.btSaveImg.Click += new System.EventHandler(this.btSaveImg_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsddbCoord
            // 
            this.tsddbCoord.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSaveTxt,
            this.btLoadTxt,
            this.btSaveBin,
            this.btLoadBin});
            this.tsddbCoord.Image = global::Множество_Мондельброта.Properties.Resources.chart_line;
            this.tsddbCoord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbCoord.Name = "tsddbCoord";
            this.tsddbCoord.Size = new System.Drawing.Size(104, 22);
            this.tsddbCoord.Text = "Координаты";
            // 
            // btSaveTxt
            // 
            this.btSaveTxt.Name = "btSaveTxt";
            this.btSaveTxt.Size = new System.Drawing.Size(184, 22);
            this.btSaveTxt.Text = "Сохранить .txt";
            this.btSaveTxt.Click += new System.EventHandler(this.btSaveTxt_Click);
            // 
            // btLoadTxt
            // 
            this.btLoadTxt.Name = "btLoadTxt";
            this.btLoadTxt.Size = new System.Drawing.Size(184, 22);
            this.btLoadTxt.Text = "Загрузить .txt";
            this.btLoadTxt.Click += new System.EventHandler(this.btLoadTxt_Click);
            // 
            // btSaveBin
            // 
            this.btSaveBin.Name = "btSaveBin";
            this.btSaveBin.Size = new System.Drawing.Size(184, 22);
            this.btSaveBin.Text = "Сохранить бинарно";
            this.btSaveBin.Click += new System.EventHandler(this.btSaveBin_Click);
            // 
            // btLoadBin
            // 
            this.btLoadBin.Name = "btLoadBin";
            this.btLoadBin.Size = new System.Drawing.Size(184, 22);
            this.btLoadBin.Text = "Загрузить бинарно";
            this.btLoadBin.Click += new System.EventHandler(this.btLoadBin_Click);
            // 
            // PB
            // 
            this.PB.BackColor = System.Drawing.Color.White;
            this.PB.Location = new System.Drawing.Point(199, 25);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(480, 480);
            this.PB.TabIndex = 0;
            this.PB.TabStop = false;
            this.PB.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_Paint);
            this.PB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PB_MouseDoubleClick);
            this.PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_MouseDown);
            this.PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_MouseMove);
            this.PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_MouseUp);
            // 
            // ofdCoord
            // 
            this.ofdCoord.DefaultExt = "dat";
            this.ofdCoord.Filter = "Файл данных|*.dat|Бинарный файл|*.bin|Все файлы|*.*";
            // 
            // sfdCoordTxt
            // 
            this.sfdCoordTxt.DefaultExt = "txt";
            this.sfdCoordTxt.FileName = "Координаты";
            this.sfdCoordTxt.Filter = "Текстовый файл|*.txt";
            // 
            // ofdCoordTxt
            // 
            this.ofdCoordTxt.Filter = "Текстовый файл|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(679, 506);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.pG);
            this.Controls.Add(this.PB);
            this.MinimumSize = new System.Drawing.Size(222, 65);
            this.Name = "MainForm";
            this.Text = "Фракталы";
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.udY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSize)).EndInit();
            this.pG.ResumeLayout(false);
            this.pG.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCoord.ResumeLayout(false);
            this.gbCoord.PerformLayout();
            this.gbZoom.ResumeLayout(false);
            this.gbZoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udIter)).EndInit();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Label lY;
        private System.Windows.Forms.Label lX;
        private System.Windows.Forms.NumericUpDown udY;
        private System.Windows.Forms.NumericUpDown udX;
        private System.Windows.Forms.Label Lsize;
        private System.Windows.Forms.NumericUpDown udSize;
        private System.Windows.Forms.Panel pG;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.NumericUpDown udIter;
        private System.Windows.Forms.GroupBox gbZoom;
        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.RadioButton rbMinus;
        private System.Windows.Forms.Label LIter;
        private System.Windows.Forms.ComboBox cbZoom;
        private System.Windows.Forms.Label Lzoom;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbCoord;
        private System.Windows.Forms.SaveFileDialog sfdPic;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btTimer;
        private System.Windows.Forms.SaveFileDialog sfdCoord;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripDropDownButton tsddbImg;
        private System.Windows.Forms.ToolStripMenuItem btSaveImg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsddbCoord;
        private System.Windows.Forms.ToolStripMenuItem btSaveTxt;
        private System.Windows.Forms.ToolStripMenuItem btLoadTxt;
        private System.Windows.Forms.ToolStripMenuItem btSaveBin;
        private System.Windows.Forms.ToolStripMenuItem btLoadBin;
        private System.Windows.Forms.OpenFileDialog ofdCoord;
        private System.Windows.Forms.SaveFileDialog sfdCoordTxt;
        private System.Windows.Forms.OpenFileDialog ofdCoordTxt;
    }
}

