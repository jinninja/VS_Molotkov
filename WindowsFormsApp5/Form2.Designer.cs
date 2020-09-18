namespace WindowsFormsApp5
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.SaveSS = new System.Windows.Forms.Button();
            this.AddStoiButton = new System.Windows.Forms.Button();
            this.AddStoi = new System.Windows.Forms.TextBox();
            this.билетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.microsoft_Access_Baza_dannykh_2DataSet1 = new WindowsFormsApp5.Microsoft_Access_Baza_dannykh_2DataSet1();
            this.AddMesto = new System.Windows.Forms.TextBox();
            this.AddReys = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.рейсыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDБилетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рейсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDРейсыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Рейсы = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.билетTableAdapter = new WindowsFormsApp5.Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.БилетTableAdapter();
            this.рейсыTableAdapter = new WindowsFormsApp5.Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.РейсыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_Baza_dannykh_2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).BeginInit();
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
            this.SaveSS.TabIndex = 1;
            this.SaveSS.Text = "Save";
            this.SaveSS.UseVisualStyleBackColor = true;
            this.SaveSS.Click += new System.EventHandler(this.SaveSS_Click);
            // 
            // AddStoiButton
            // 
            this.AddStoiButton.Location = new System.Drawing.Point(539, 293);
            this.AddStoiButton.Name = "AddStoiButton";
            this.AddStoiButton.Size = new System.Drawing.Size(75, 23);
            this.AddStoiButton.TabIndex = 3;
            this.AddStoiButton.Text = "Add";
            this.AddStoiButton.UseVisualStyleBackColor = true;
            this.AddStoiButton.Click += new System.EventHandler(this.AddStoiButton_Click);
            // 
            // AddStoi
            // 
            this.AddStoi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетBindingSource, "Стоимость", true));
            this.AddStoi.Location = new System.Drawing.Point(688, 293);
            this.AddStoi.Name = "AddStoi";
            this.AddStoi.Size = new System.Drawing.Size(100, 20);
            this.AddStoi.TabIndex = 4;
            // 
            // билетBindingSource
            // 
            this.билетBindingSource.DataMember = "Билет";
            this.билетBindingSource.DataSource = this.microsoft_Access_Baza_dannykh_2DataSet1;
            // 
            // microsoft_Access_Baza_dannykh_2DataSet1
            // 
            this.microsoft_Access_Baza_dannykh_2DataSet1.DataSetName = "Microsoft_Access_Baza_dannykh_2DataSet1";
            this.microsoft_Access_Baza_dannykh_2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddMesto
            // 
            this.AddMesto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетBindingSource, "Место", true));
            this.AddMesto.Location = new System.Drawing.Point(688, 319);
            this.AddMesto.Name = "AddMesto";
            this.AddMesto.Size = new System.Drawing.Size(100, 20);
            this.AddMesto.TabIndex = 5;
            // 
            // AddReys
            // 
            this.AddReys.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетBindingSource, "Рейс", true));
            this.AddReys.Location = new System.Drawing.Point(688, 345);
            this.AddReys.Name = "AddReys";
            this.AddReys.Size = new System.Drawing.Size(100, 20);
            this.AddReys.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Стоимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Место";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Рейс";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(539, 319);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.рейсыBindingSource;
            this.comboBox1.DisplayMember = "Наименование";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(688, 371);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "ID_Рейсы";
            // 
            // рейсыBindingSource
            // 
            this.рейсыBindingSource.DataMember = "Рейсы";
            this.рейсыBindingSource.DataSource = this.microsoft_Access_Baza_dannykh_2DataSet1;
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(460, 293);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(73, 65);
            this.UpButton.TabIndex = 12;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(460, 373);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(73, 65);
            this.DownButton.TabIndex = 13;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDБилетDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.местоDataGridViewTextBoxColumn,
            this.рейсDataGridViewTextBoxColumn,
            this.iDРейсыDataGridViewTextBoxColumn,
            this.Рейсы});
            this.dataGridView1.DataSource = this.билетBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 256);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // iDБилетDataGridViewTextBoxColumn
            // 
            this.iDБилетDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDБилетDataGridViewTextBoxColumn.DataPropertyName = "ID_Билет:";
            this.iDБилетDataGridViewTextBoxColumn.HeaderText = "ID_Билет:";
            this.iDБилетDataGridViewTextBoxColumn.Name = "iDБилетDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // местоDataGridViewTextBoxColumn
            // 
            this.местоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.местоDataGridViewTextBoxColumn.DataPropertyName = "Место";
            this.местоDataGridViewTextBoxColumn.HeaderText = "Место";
            this.местоDataGridViewTextBoxColumn.Name = "местоDataGridViewTextBoxColumn";
            // 
            // рейсDataGridViewTextBoxColumn
            // 
            this.рейсDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.рейсDataGridViewTextBoxColumn.DataPropertyName = "Рейс";
            this.рейсDataGridViewTextBoxColumn.HeaderText = "Рейс";
            this.рейсDataGridViewTextBoxColumn.Name = "рейсDataGridViewTextBoxColumn";
            // 
            // iDРейсыDataGridViewTextBoxColumn
            // 
            this.iDРейсыDataGridViewTextBoxColumn.DataPropertyName = "ID_Рейсы";
            this.iDРейсыDataGridViewTextBoxColumn.HeaderText = "ID_Рейсы";
            this.iDРейсыDataGridViewTextBoxColumn.Name = "iDРейсыDataGridViewTextBoxColumn";
            this.iDРейсыDataGridViewTextBoxColumn.Visible = false;
            // 
            // Рейсы
            // 
            this.Рейсы.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Рейсы.DataPropertyName = "ID_Рейсы";
            this.Рейсы.DataSource = this.рейсыBindingSource;
            this.Рейсы.DisplayMember = "Наименование";
            this.Рейсы.HeaderText = "Рейсы";
            this.Рейсы.Name = "Рейсы";
            this.Рейсы.ValueMember = "ID_Рейсы";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingNavigator1.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator1.BindingSource = this.билетBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(263, 25);
            this.bindingNavigator1.TabIndex = 15;
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
            // билетTableAdapter
            // 
            this.билетTableAdapter.ClearBeforeFill = true;
            // 
            // рейсыTableAdapter
            // 
            this.рейсыTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddReys);
            this.Controls.Add(this.AddMesto);
            this.Controls.Add(this.AddStoi);
            this.Controls.Add(this.AddStoiButton);
            this.Controls.Add(this.SaveSS);
            this.Name = "Form2";
            this.Text = "Bilet";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_Baza_dannykh_2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveSS;
        private System.Windows.Forms.Button AddStoiButton;
        private System.Windows.Forms.TextBox AddStoi;
        private System.Windows.Forms.TextBox AddMesto;
        private System.Windows.Forms.TextBox AddReys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
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
        private System.Windows.Forms.BindingSource билетBindingSource;
        private Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.БилетTableAdapter билетTableAdapter;
        private System.Windows.Forms.BindingSource рейсыBindingSource;
        private Microsoft_Access_Baza_dannykh_2DataSet1TableAdapters.РейсыTableAdapter рейсыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDБилетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рейсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDРейсыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Рейсы;
    }
}