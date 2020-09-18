namespace WindowsFormsApp5
{
    partial class TechObs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechObs));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.бригадыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.microsoft_Access_Baza_dannykh_2DataSet1 = new WindowsFormsApp5.Microsoft_Access_Baza_dannykh_2DataSet1();
            this.SaveSS = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDoljnost = new System.Windows.Forms.TextBox();
            this.техническоеОбслуживаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddButtonDolj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.самолетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDТОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.результатDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Бригады = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Свмолет = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDБригадыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСамолетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.техническое_обслуживаниеTableAdapter = new WindowsFormsApp5.Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.Техническое_обслуживаниеTableAdapter();
            this.бригадыTableAdapter = new WindowsFormsApp5.Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.БригадыTableAdapter();
            this.самолетыTableAdapter = new WindowsFormsApp5.Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.СамолетыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.бригадыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_Baza_dannykh_2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.техническоеОбслуживаниеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.бригадыBindingSource;
            this.comboBox1.DisplayMember = "Название бригады";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(697, 350);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 97;
            this.comboBox1.ValueMember = "ID_Бригады";
            // 
            // бригадыBindingSource
            // 
            this.бригадыBindingSource.DataMember = "Бригады";
            this.бригадыBindingSource.DataSource = this.microsoft_Access_Baza_dannykh_2DataSet1;
            // 
            // microsoft_Access_Baza_dannykh_2DataSet1
            // 
            this.microsoft_Access_Baza_dannykh_2DataSet1.DataSetName = "Microsoft_Access_Baza_dannykh_2DataSet1";
            this.microsoft_Access_Baza_dannykh_2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaveSS
            // 
            this.SaveSS.Location = new System.Drawing.Point(12, 290);
            this.SaveSS.Name = "SaveSS";
            this.SaveSS.Size = new System.Drawing.Size(75, 23);
            this.SaveSS.TabIndex = 96;
            this.SaveSS.Text = "Save";
            this.SaveSS.UseVisualStyleBackColor = true;
            this.SaveSS.Click += new System.EventHandler(this.SaveSS_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(469, 367);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(73, 65);
            this.DownButton.TabIndex = 95;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(469, 287);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(73, 65);
            this.UpButton.TabIndex = 94;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(548, 313);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 93;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Дата";
            // 
            // AddDoljnost
            // 
            this.AddDoljnost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.техническоеОбслуживаниеBindingSource, "Дата", true));
            this.AddDoljnost.Location = new System.Drawing.Point(697, 287);
            this.AddDoljnost.Name = "AddDoljnost";
            this.AddDoljnost.Size = new System.Drawing.Size(100, 20);
            this.AddDoljnost.TabIndex = 91;
            // 
            // техническоеОбслуживаниеBindingSource
            // 
            this.техническоеОбслуживаниеBindingSource.DataMember = "Техническое обслуживание";
            this.техническоеОбслуживаниеBindingSource.DataSource = this.microsoft_Access_Baza_dannykh_2DataSet1;
            // 
            // AddButtonDolj
            // 
            this.AddButtonDolj.Location = new System.Drawing.Point(548, 287);
            this.AddButtonDolj.Name = "AddButtonDolj";
            this.AddButtonDolj.Size = new System.Drawing.Size(75, 23);
            this.AddButtonDolj.TabIndex = 90;
            this.AddButtonDolj.Text = "Add";
            this.AddButtonDolj.UseVisualStyleBackColor = true;
            this.AddButtonDolj.Click += new System.EventHandler(this.AddButtonDolj_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.техническоеОбслуживаниеBindingSource, "Результат", true));
            this.textBox1.Location = new System.Drawing.Point(697, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Результат";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.самолетыBindingSource;
            this.comboBox2.DisplayMember = "Бортовой номер:";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(697, 377);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 100;
            this.comboBox2.ValueMember = "ID_Самолет";
            // 
            // самолетыBindingSource
            // 
            this.самолетыBindingSource.DataMember = "Самолеты";
            this.самолетыBindingSource.DataSource = this.microsoft_Access_Baza_dannykh_2DataSet1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.техническоеОбслуживаниеBindingSource;
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
            this.bindingNavigator1.TabIndex = 101;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТОDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.результатDataGridViewTextBoxColumn,
            this.Бригады,
            this.Свмолет,
            this.iDБригадыDataGridViewTextBoxColumn,
            this.iDСамолетаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.техническоеОбслуживаниеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 253);
            this.dataGridView1.TabIndex = 102;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDТОDataGridViewTextBoxColumn
            // 
            this.iDТОDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDТОDataGridViewTextBoxColumn.DataPropertyName = "ID_ТО";
            this.iDТОDataGridViewTextBoxColumn.HeaderText = "ID_ТО";
            this.iDТОDataGridViewTextBoxColumn.Name = "iDТОDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // результатDataGridViewTextBoxColumn
            // 
            this.результатDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.результатDataGridViewTextBoxColumn.DataPropertyName = "Результат";
            this.результатDataGridViewTextBoxColumn.HeaderText = "Результат";
            this.результатDataGridViewTextBoxColumn.Name = "результатDataGridViewTextBoxColumn";
            // 
            // Бригады
            // 
            this.Бригады.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Бригады.DataPropertyName = "ID_ТО";
            this.Бригады.DataSource = this.бригадыBindingSource;
            this.Бригады.DisplayMember = "Название бригады";
            this.Бригады.HeaderText = "Бригады";
            this.Бригады.Name = "Бригады";
            this.Бригады.ValueMember = "ID_Бригады";
            // 
            // Свмолет
            // 
            this.Свмолет.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Свмолет.DataPropertyName = "ID_ТО";
            this.Свмолет.DataSource = this.самолетыBindingSource;
            this.Свмолет.DisplayMember = "Бортовой номер:";
            this.Свмолет.HeaderText = "Самолет";
            this.Свмолет.Name = "Свмолет";
            this.Свмолет.ValueMember = "ID_Самолет";
            // 
            // iDБригадыDataGridViewTextBoxColumn
            // 
            this.iDБригадыDataGridViewTextBoxColumn.DataPropertyName = "ID_Бригады";
            this.iDБригадыDataGridViewTextBoxColumn.HeaderText = "ID_Бригады";
            this.iDБригадыDataGridViewTextBoxColumn.Name = "iDБригадыDataGridViewTextBoxColumn";
            this.iDБригадыDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDСамолетаDataGridViewTextBoxColumn
            // 
            this.iDСамолетаDataGridViewTextBoxColumn.DataPropertyName = "ID_Самолета";
            this.iDСамолетаDataGridViewTextBoxColumn.HeaderText = "ID_Самолета";
            this.iDСамолетаDataGridViewTextBoxColumn.Name = "iDСамолетаDataGridViewTextBoxColumn";
            this.iDСамолетаDataGridViewTextBoxColumn.Visible = false;
            // 
            // техническое_обслуживаниеTableAdapter
            // 
            this.техническое_обслуживаниеTableAdapter.ClearBeforeFill = true;
            // 
            // бригадыTableAdapter
            // 
            this.бригадыTableAdapter.ClearBeforeFill = true;
            // 
            // самолетыTableAdapter
            // 
            this.самолетыTableAdapter.ClearBeforeFill = true;
            // 
            // TechObs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SaveSS);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddDoljnost);
            this.Controls.Add(this.AddButtonDolj);
            this.Name = "TechObs";
            this.Text = "TechObs";
            this.Load += new System.EventHandler(this.TechObs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бригадыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_Baza_dannykh_2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.техническоеОбслуживаниеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SaveSS;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddDoljnost;
        private System.Windows.Forms.Button AddButtonDolj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private Microsoft_Access_Baza_dannykh_2DataSet1 microsoft_Access_Baza_dannykh_2DataSet1;
        private System.Windows.Forms.BindingSource техническоеОбслуживаниеBindingSource;
        private Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.Техническое_обслуживаниеTableAdapter техническое_обслуживаниеTableAdapter;
        private System.Windows.Forms.BindingSource бригадыBindingSource;
        private Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.БригадыTableAdapter бригадыTableAdapter;
        private System.Windows.Forms.BindingSource самолетыBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn результатDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Бригады;
        private System.Windows.Forms.DataGridViewComboBoxColumn Свмолет;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDБригадыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСамолетаDataGridViewTextBoxColumn;
        private Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.СамолетыTableAdapter самолетыTableAdapter;
    }
}