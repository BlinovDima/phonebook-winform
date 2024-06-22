namespace PhoneBook
{
    partial class FormPhoneBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhoneBook));
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumberPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClearTextBoxSearchByNumber = new System.Windows.Forms.Button();
            this.btnClearTextBoxByName = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSearchByNumber = new System.Windows.Forms.TextBox();
            this.labelSearchByNumber = new System.Windows.Forms.Label();
            this.buttonSearchByNumber = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.распечататьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсеЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDelete = new System.Windows.Forms.Label();
            this.textBoxDeleteByNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDeleteByNumber = new System.Windows.Forms.Button();
            this.textBoxDeleteByName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDeleteByName = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label6 = new System.Windows.Forms.Label();
            this.lableCount = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.labelHeader);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.textBoxNumberPhone);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.textBoxName);
            this.panelMain.Controls.Add(this.buttonAdd);
            this.panelMain.Location = new System.Drawing.Point(6, 6);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(709, 162);
            this.panelMain.TabIndex = 1;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelHeader.Location = new System.Drawing.Point(135, 5);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(234, 45);
            this.labelHeader.TabIndex = 4;
            this.labelHeader.Text = "Панель ввода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Телефон:";
            // 
            // textBoxNumberPhone
            // 
            this.textBoxNumberPhone.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNumberPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberPhone.Location = new System.Drawing.Point(132, 102);
            this.textBoxNumberPhone.Name = "textBoxNumberPhone";
            this.textBoxNumberPhone.Size = new System.Drawing.Size(334, 31);
            this.textBoxNumberPhone.TabIndex = 2;
            this.textBoxNumberPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNumberPhone.Enter += new System.EventHandler(this.textBoxNumberPhone_Enter);
            this.textBoxNumberPhone.Leave += new System.EventHandler(this.textBoxNumberPhone_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(68, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя:";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(132, 57);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(334, 31);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Image = global::PhoneBook.Properties.Resources.add;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd.Location = new System.Drawing.Point(491, 70);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(199, 45);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить запись";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxMain
            // 
            this.listBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxMain.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.ItemHeight = 29;
            this.listBoxMain.Location = new System.Drawing.Point(12, 287);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(723, 408);
            this.listBoxMain.TabIndex = 6;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(143, 71);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSearch.Size = new System.Drawing.Size(407, 31);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "По имени:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnClearTextBoxSearchByNumber);
            this.panel1.Controls.Add(this.btnClearTextBoxByName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxSearchByNumber);
            this.panel1.Controls.Add(this.labelSearchByNumber);
            this.panel1.Controls.Add(this.buttonSearchByNumber);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 164);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(418, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Показать все записи в базе";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // btnClearTextBoxSearchByNumber
            // 
            this.btnClearTextBoxSearchByNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClearTextBoxSearchByNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearTextBoxSearchByNumber.FlatAppearance.BorderSize = 0;
            this.btnClearTextBoxSearchByNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTextBoxSearchByNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearTextBoxSearchByNumber.ForeColor = System.Drawing.Color.Red;
            this.btnClearTextBoxSearchByNumber.Location = new System.Drawing.Point(647, 110);
            this.btnClearTextBoxSearchByNumber.Name = "btnClearTextBoxSearchByNumber";
            this.btnClearTextBoxSearchByNumber.Size = new System.Drawing.Size(34, 36);
            this.btnClearTextBoxSearchByNumber.TabIndex = 9;
            this.btnClearTextBoxSearchByNumber.Text = "X";
            this.btnClearTextBoxSearchByNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearTextBoxSearchByNumber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearTextBoxSearchByNumber.UseVisualStyleBackColor = false;
            this.btnClearTextBoxSearchByNumber.Click += new System.EventHandler(this.btnClearTextBoxSearchByNumber_Click);
            // 
            // btnClearTextBoxByName
            // 
            this.btnClearTextBoxByName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClearTextBoxByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearTextBoxByName.FlatAppearance.BorderSize = 0;
            this.btnClearTextBoxByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTextBoxByName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearTextBoxByName.ForeColor = System.Drawing.Color.Red;
            this.btnClearTextBoxByName.Location = new System.Drawing.Point(647, 67);
            this.btnClearTextBoxByName.Name = "btnClearTextBoxByName";
            this.btnClearTextBoxByName.Size = new System.Drawing.Size(34, 35);
            this.btnClearTextBoxByName.TabIndex = 8;
            this.btnClearTextBoxByName.Text = "X";
            this.btnClearTextBoxByName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearTextBoxByName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearTextBoxByName.UseVisualStyleBackColor = false;
            this.btnClearTextBoxByName.Click += new System.EventHandler(this.btnClearTextBoxByName_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(144, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 45);
            this.label5.TabIndex = 5;
            this.label5.Text = "Панель поиска";
            // 
            // textBoxSearchByNumber
            // 
            this.textBoxSearchByNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchByNumber.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSearchByNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchByNumber.Location = new System.Drawing.Point(145, 114);
            this.textBoxSearchByNumber.Name = "textBoxSearchByNumber";
            this.textBoxSearchByNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSearchByNumber.Size = new System.Drawing.Size(405, 31);
            this.textBoxSearchByNumber.TabIndex = 7;
            this.textBoxSearchByNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSearchByNumber.Enter += new System.EventHandler(this.textBoxSearchByNumber_Enter);
            this.textBoxSearchByNumber.Leave += new System.EventHandler(this.textBoxSearchByNumber_Leave);
            // 
            // labelSearchByNumber
            // 
            this.labelSearchByNumber.AutoSize = true;
            this.labelSearchByNumber.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchByNumber.Location = new System.Drawing.Point(10, 113);
            this.labelSearchByNumber.Name = "labelSearchByNumber";
            this.labelSearchByNumber.Size = new System.Drawing.Size(124, 27);
            this.labelSearchByNumber.TabIndex = 6;
            this.labelSearchByNumber.Text = "По номеру:";
            // 
            // buttonSearchByNumber
            // 
            this.buttonSearchByNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSearchByNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchByNumber.FlatAppearance.BorderSize = 0;
            this.buttonSearchByNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchByNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchByNumber.Location = new System.Drawing.Point(569, 110);
            this.buttonSearchByNumber.Name = "buttonSearchByNumber";
            this.buttonSearchByNumber.Size = new System.Drawing.Size(72, 36);
            this.buttonSearchByNumber.TabIndex = 5;
            this.buttonSearchByNumber.Text = "Найти";
            this.buttonSearchByNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearchByNumber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearchByNumber.UseVisualStyleBackColor = false;
            this.buttonSearchByNumber.Click += new System.EventHandler(this.buttonSearchByNumber_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(569, 69);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(72, 35);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(258, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "Телефонная книга";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 31);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьТаблицуToolStripMenuItem,
            this.распечататьToolStripMenuItem,
            this.удалитьВсеЗаписиToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // обновитьТаблицуToolStripMenuItem
            // 
            this.обновитьТаблицуToolStripMenuItem.Name = "обновитьТаблицуToolStripMenuItem";
            this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.обновитьТаблицуToolStripMenuItem.Text = "Показать все записи";
            this.обновитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // распечататьToolStripMenuItem
            // 
            this.распечататьToolStripMenuItem.Name = "распечататьToolStripMenuItem";
            this.распечататьToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.распечататьToolStripMenuItem.Text = "Распечатать";
            this.распечататьToolStripMenuItem.Click += new System.EventHandler(this.распечататьToolStripMenuItem_Click);
            // 
            // удалитьВсеЗаписиToolStripMenuItem
            // 
            this.удалитьВсеЗаписиToolStripMenuItem.Name = "удалитьВсеЗаписиToolStripMenuItem";
            this.удалитьВсеЗаписиToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.удалитьВсеЗаписиToolStripMenuItem.Text = "Удалить все записи";
            this.удалитьВсеЗаписиToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсеЗаписиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelDelete);
            this.panel2.Controls.Add(this.textBoxDeleteByNumber);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.buttonDeleteByNumber);
            this.panel2.Controls.Add(this.textBoxDeleteByName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.buttonDeleteByName);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 167);
            this.panel2.TabIndex = 11;
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDelete.Location = new System.Drawing.Point(190, 9);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(293, 45);
            this.labelDelete.TabIndex = 5;
            this.labelDelete.Text = "Панель удаления";
            // 
            // textBoxDeleteByNumber
            // 
            this.textBoxDeleteByNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeleteByNumber.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDeleteByNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDeleteByNumber.Location = new System.Drawing.Point(189, 114);
            this.textBoxDeleteByNumber.Name = "textBoxDeleteByNumber";
            this.textBoxDeleteByNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDeleteByNumber.Size = new System.Drawing.Size(379, 31);
            this.textBoxDeleteByNumber.TabIndex = 7;
            this.textBoxDeleteByNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDeleteByNumber.Enter += new System.EventHandler(this.textBoxDeleteByNumber_Enter);
            this.textBoxDeleteByNumber.Leave += new System.EventHandler(this.textBoxDeleteByNumber_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(58, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "По номеру:";
            // 
            // buttonDeleteByNumber
            // 
            this.buttonDeleteByNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDeleteByNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteByNumber.FlatAppearance.BorderSize = 0;
            this.buttonDeleteByNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteByNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteByNumber.ForeColor = System.Drawing.Color.Red;
            this.buttonDeleteByNumber.Location = new System.Drawing.Point(588, 109);
            this.buttonDeleteByNumber.Name = "buttonDeleteByNumber";
            this.buttonDeleteByNumber.Size = new System.Drawing.Size(88, 36);
            this.buttonDeleteByNumber.TabIndex = 5;
            this.buttonDeleteByNumber.Text = "Удалить";
            this.buttonDeleteByNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteByNumber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteByNumber.UseVisualStyleBackColor = false;
            this.buttonDeleteByNumber.Click += new System.EventHandler(this.buttonDeleteByNumber_Click);
            // 
            // textBoxDeleteByName
            // 
            this.textBoxDeleteByName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeleteByName.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDeleteByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDeleteByName.Location = new System.Drawing.Point(187, 70);
            this.textBoxDeleteByName.Name = "textBoxDeleteByName";
            this.textBoxDeleteByName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDeleteByName.Size = new System.Drawing.Size(381, 31);
            this.textBoxDeleteByName.TabIndex = 4;
            this.textBoxDeleteByName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDeleteByName.Enter += new System.EventHandler(this.textBoxDeleteByName_Enter);
            this.textBoxDeleteByName.Leave += new System.EventHandler(this.textBoxDeleteByName_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(56, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "По имени:";
            // 
            // buttonDeleteByName
            // 
            this.buttonDeleteByName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDeleteByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteByName.FlatAppearance.BorderSize = 0;
            this.buttonDeleteByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteByName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteByName.ForeColor = System.Drawing.Color.Red;
            this.buttonDeleteByName.Location = new System.Drawing.Point(588, 66);
            this.buttonDeleteByName.Name = "buttonDeleteByName";
            this.buttonDeleteByName.Size = new System.Drawing.Size(89, 35);
            this.buttonDeleteByName.TabIndex = 3;
            this.buttonDeleteByName.Text = "Удалить";
            this.buttonDeleteByName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteByName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteByName.UseVisualStyleBackColor = false;
            this.buttonDeleteByName.Click += new System.EventHandler(this.buttonDeleteByName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhoneBook.Properties.Resources.icons8_phone_381;
            this.pictureBox1.Location = new System.Drawing.Point(820, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(755, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Кол-во записей в базе:";
            // 
            // lableCount
            // 
            this.lableCount.AutoSize = true;
            this.lableCount.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableCount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lableCount.Location = new System.Drawing.Point(855, 422);
            this.lableCount.Name = "lableCount";
            this.lableCount.Size = new System.Drawing.Size(45, 52);
            this.lableCount.TabIndex = 16;
            this.lableCount.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 199);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelMain);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 173);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(721, 173);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удаение";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(721, 173);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormPhoneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 711);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lableCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPhoneBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База телефонных номеров";
            this.Load += new System.EventHandler(this.FormPhoneBook_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumberPhone;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearchByNumber;
        private System.Windows.Forms.Label labelSearchByNumber;
        private System.Windows.Forms.Button buttonSearchByNumber;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem распечататьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.TextBox textBoxDeleteByNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDeleteByNumber;
        private System.Windows.Forms.TextBox textBoxDeleteByName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDeleteByName;
        private System.Windows.Forms.Button btnClearTextBoxSearchByNumber;
        private System.Windows.Forms.Button btnClearTextBoxByName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсеЗаписиToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lableCount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

