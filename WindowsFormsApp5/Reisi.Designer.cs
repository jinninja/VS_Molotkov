namespace WindowsFormsApp5
{
    partial class Reisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reisi));
            this.SaveSS = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDoljnost = new System.Windows.Forms.TextBox();
            this.рейсыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.microsoft_Access_Baza_dannykh_2DataSet1 = new WindowsFormsApp5.Microsoft_Access_Baza_dannykh_2DataSet1();
            this.AddButtonDolj = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.расписанияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.самолетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.бригадыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.маршрутBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDРейсыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПолетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМаршрутаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDРасписаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСамолетыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDБригадыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Расписание = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Самолет = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Бригада = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Маршрут = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.рейсыTableAdapter = new WindowsFormsApp5.Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.РейсыTableAdapter();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.расписанияTableAdapter = new WindowsFormsApp5.Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.РасписанияTableAdapter();
            this.бригадыTableAdapter = new WindowsFormsApp5.Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.БригадыTableAdapter();
            this.маршрутTableAdapter = new WindowsFormsApp5.Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.МаршрутTableAdapter();
            this.самолетыTableAdapter = new WindowsFormsApp5.Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.СамолетыTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_Baza_dannykh_2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписанияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бригадыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveSS
            // 
            this.SaveSS.Location = new System.Drawing.Point(12, 290);
            this.SaveSS.Name = "SaveSS";
            this.SaveSS.Size = new System.Drawing.Size(75, 23);
            this.SaveSS.TabIndex = 77;
            this.SaveSS.Text = "Save";
            this.SaveSS.UseVisualStyleBackColor = true;
            this.SaveSS.Click += new System.EventHandler(this.SaveSS_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(444, 367);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(73, 65);
            this.DownButton.TabIndex = 74;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(444, 287);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(73, 65);
            this.UpButton.TabIndex = 73;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(523, 313);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 72;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Время";
            // 
            // AddDoljnost
            // 
            this.AddDoljnost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Время полета", true));
            this.AddDoljnost.Location = new System.Drawing.Point(697, 287);
            this.AddDoljnost.Name = "AddDoljnost";
            this.AddDoljnost.Size = new System.Drawing.Size(100, 20);
            this.AddDoljnost.TabIndex = 70;
            // 
            // рейсыBindingSource
            // 
            this.рейсыBindingSource.DataMember = "Рейсы";
            this.рейсыBindingSource.DataSource = this.microsoft_Access_Baza_dannykh_2DataSet1;
            // 
            // microsoft_Access_Baza_dannykh_2DataSet1
            // 
            this.microsoft_Access_Baza_dannykh_2DataSet1.DataSetName = "Microsoft_Access_Baza_dannykh_2DataSet1";
            this.microsoft_Access_Baza_dannykh_2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddButtonDolj
            // 
            this.AddButtonDolj.Location = new System.Drawing.Point(523, 287);
            this.AddButtonDolj.Name = "AddButtonDolj";
            this.AddButtonDolj.Size = new System.Drawing.Size(75, 23);
            this.AddButtonDolj.TabIndex = 69;
            this.AddButtonDolj.Text = "Add";
            this.AddButtonDolj.UseVisualStyleBackColor = true;
            this.AddButtonDolj.Click += new System.EventHandler(this.AddButtonDolj_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.расписанияBindingSource;
            this.comboBox1.DisplayMember = "Номер рейса";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(697, 340);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 78;
            this.comboBox1.ValueMember = "ID_Расписание";
            // 
            // расписанияBindingSource
            // 
            this.расписанияBindingSource.DataMember = "Расписания";
            this.расписанияBindingSource.DataSource = this.microsoft_Access_Baza_dannykh_2DataSet1;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.самолетыBindingSource;
            this.comboBox2.DisplayMember = "Бортовой номер:";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(697, 367);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 79;
            this.comboBox2.ValueMember = "ID_Самолет";
            // 
            // самолетыBindingSource
            // 
            this.самолетыBindingSource.DataMember = "Самолеты";
            this.самолетыBindingSource.DataSource = this.microsoft_Access_Baza_dannykh_2DataSet1;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.бригадыBindingSource;
            this.comboBox3.DisplayMember = "Название бригады";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(697, 394);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 80;
            this.comboBox3.ValueMember = "ID_Бригады";
            // 
            // бригадыBindingSource
            // 
            this.бригадыBindingSource.DataMember = "Бригады";
            this.бригадыBindingSource.DataSource = this.microsoft_Access_Baza_dannykh_2DataSet1;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.маршрутBindingSource;
            this.comboBox4.DisplayMember = "Пункт назначения";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(697, 421);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 21);
            this.comboBox4.TabIndex = 81;
            this.comboBox4.ValueMember = "ID_Маршрут";
            // 
            // маршрутBindingSource
            // 
            this.маршрутBindingSource.DataMember = "Маршрут";
            this.маршрутBindingSource.DataSource = this.microsoft_Access_Baza_dannykh_2DataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDРейсыDataGridViewTextBoxColumn,
            this.времяПолетаDataGridViewTextBoxColumn,
            this.iDМаршрутаDataGridViewTextBoxColumn,
            this.iDРасписаниеDataGridViewTextBoxColumn,
            this.iDСамолетыDataGridViewTextBoxColumn,
            this.iDБригадыDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.Расписание,
            this.Самолет,
            this.Бригада,
            this.Маршрут});
            this.dataGridView1.DataSource = this.рейсыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 253);
            this.dataGridView1.TabIndex = 82;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDРейсыDataGridViewTextBoxColumn
            // 
            this.iDРейсыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDРейсыDataGridViewTextBoxColumn.DataPropertyName = "ID_Рейсы";
            this.iDРейсыDataGridViewTextBoxColumn.HeaderText = "ID_Рейсы";
            this.iDРейсыDataGridViewTextBoxColumn.Name = "iDРейсыDataGridViewTextBoxColumn";
            // 
            // времяПолетаDataGridViewTextBoxColumn
            // 
            this.времяПолетаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.времяПолетаDataGridViewTextBoxColumn.DataPropertyName = "Время полета";
            this.времяПолетаDataGridViewTextBoxColumn.HeaderText = "Время полета";
            this.времяПолетаDataGridViewTextBoxColumn.Name = "времяПолетаDataGridViewTextBoxColumn";
            // 
            // iDМаршрутаDataGridViewTextBoxColumn
            // 
            this.iDМаршрутаDataGridViewTextBoxColumn.DataPropertyName = "ID_Маршрута";
            this.iDМаршрутаDataGridViewTextBoxColumn.HeaderText = "ID_Маршрута";
            this.iDМаршрутаDataGridViewTextBoxColumn.Name = "iDМаршрутаDataGridViewTextBoxColumn";
            this.iDМаршрутаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iDМаршрутаDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDРасписаниеDataGridViewTextBoxColumn
            // 
            this.iDРасписаниеDataGridViewTextBoxColumn.DataPropertyName = "ID_Расписание";
            this.iDРасписаниеDataGridViewTextBoxColumn.HeaderText = "ID_Расписание";
            this.iDРасписаниеDataGridViewTextBoxColumn.Name = "iDРасписаниеDataGridViewTextBoxColumn";
            this.iDРасписаниеDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDСамолетыDataGridViewTextBoxColumn
            // 
            this.iDСамолетыDataGridViewTextBoxColumn.DataPropertyName = "ID_Самолеты";
            this.iDСамолетыDataGridViewTextBoxColumn.HeaderText = "ID_Самолеты";
            this.iDСамолетыDataGridViewTextBoxColumn.Name = "iDСамолетыDataGridViewTextBoxColumn";
            this.iDСамолетыDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDБригадыDataGridViewTextBoxColumn
            // 
            this.iDБригадыDataGridViewTextBoxColumn.DataPropertyName = "ID_Бригады";
            this.iDБригадыDataGridViewTextBoxColumn.HeaderText = "ID_Бригады";
            this.iDБригадыDataGridViewTextBoxColumn.Name = "iDБригадыDataGridViewTextBoxColumn";
            this.iDБригадыDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // Расписание
            // 
            this.Расписание.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Расписание.HeaderText = "Расписание";
            this.Расписание.Name = "Расписание";
            // 
            // Самолет
            // 
            this.Самолет.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Самолет.HeaderText = "Самолет";
            this.Самолет.Name = "Самолет";
            // 
            // Бригада
            // 
            this.Бригада.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Бригада.HeaderText = "Бригада";
            this.Бригада.Name = "Бригада";
            // 
            // Маршрут
            // 
            this.Маршрут.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Маршрут.HeaderText = "Маршрут";
            this.Маршрут.Name = "Маршрут";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.рейсыBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 83;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // рейсыTableAdapter
            // 
            this.рейсыTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.маршрутBindingSource;
            this.comboBox5.DisplayMember = "Пункт отправления";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(591, 421);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 21);
            this.comboBox5.TabIndex = 84;
            this.comboBox5.ValueMember = "ID_Маршрут";
            // 
            // расписанияTableAdapter
            // 
            this.расписанияTableAdapter.ClearBeforeFill = true;
            // 
            // бригадыTableAdapter
            // 
            this.бригадыTableAdapter.ClearBeforeFill = true;
            // 
            // маршрутTableAdapter
            // 
            this.маршрутTableAdapter.ClearBeforeFill = true;
            // 
            // самолетыTableAdapter
            // 
            this.самолетыTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Наименование", true));
            this.textBox1.Location = new System.Drawing.Point(697, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Наименование";
            // 
            // Reisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SaveSS);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddDoljnost);
            this.Controls.Add(this.AddButtonDolj);
            this.Name = "Reisi";
            this.Text = "Reisi";
            this.Load += new System.EventHandler(this.Reisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_Baza_dannykh_2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписанияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бригадыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveSS;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddDoljnost;
        private System.Windows.Forms.Button AddButtonDolj;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private Microsoft_Access_Baza_dannykh_2DataSet1 microsoft_Access_Baza_dannykh_2DataSet1;
        private System.Windows.Forms.BindingSource рейсыBindingSource;
        private Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.РейсыTableAdapter рейсыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDРейсыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПолетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМаршрутаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDРасписаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСамолетыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDБригадыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Расписание;
        private System.Windows.Forms.DataGridViewComboBoxColumn Самолет;
        private System.Windows.Forms.DataGridViewComboBoxColumn Бригада;
        private System.Windows.Forms.DataGridViewComboBoxColumn Маршрут;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.BindingSource расписанияBindingSource;
        private Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.РасписанияTableAdapter расписанияTableAdapter;
        private System.Windows.Forms.BindingSource бригадыBindingSource;
        private Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.БригадыTableAdapter бригадыTableAdapter;
        private System.Windows.Forms.BindingSource маршрутBindingSource;
        private Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.МаршрутTableAdapter маршрутTableAdapter;
        private System.Windows.Forms.BindingSource самолетыBindingSource;
        private Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.СамолетыTableAdapter самолетыTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}