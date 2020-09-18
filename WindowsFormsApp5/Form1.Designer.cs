namespace WindowsFormsApp5
{
    partial class Form1
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
            this.BiletB = new System.Windows.Forms.Button();
            this.BrigB = new System.Windows.Forms.Button();
            this.DoljB = new System.Windows.Forms.Button();
            this.MarshB = new System.Windows.Forms.Button();
            this.ModelSB = new System.Windows.Forms.Button();
            this.PersonalB = new System.Windows.Forms.Button();
            this.TechObsB = new System.Windows.Forms.Button();
            this.RaspB = new System.Windows.Forms.Button();
            this.ReisiB = new System.Windows.Forms.Button();
            this.PlanesB = new System.Windows.Forms.Button();
            this.typeB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BiletB
            // 
            this.BiletB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BiletB.Location = new System.Drawing.Point(52, 12);
            this.BiletB.Name = "BiletB";
            this.BiletB.Size = new System.Drawing.Size(146, 48);
            this.BiletB.TabIndex = 0;
            this.BiletB.Text = "Билет";
            this.BiletB.UseVisualStyleBackColor = false;
            this.BiletB.Click += new System.EventHandler(this.Reys_Click);
            // 
            // BrigB
            // 
            this.BrigB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BrigB.Location = new System.Drawing.Point(52, 66);
            this.BrigB.Name = "BrigB";
            this.BrigB.Size = new System.Drawing.Size(146, 48);
            this.BrigB.TabIndex = 2;
            this.BrigB.Text = "Бригады";
            this.BrigB.UseVisualStyleBackColor = false;
            this.BrigB.Click += new System.EventHandler(this.button2_Click);
            // 
            // DoljB
            // 
            this.DoljB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DoljB.Location = new System.Drawing.Point(52, 120);
            this.DoljB.Name = "DoljB";
            this.DoljB.Size = new System.Drawing.Size(146, 48);
            this.DoljB.TabIndex = 3;
            this.DoljB.Text = "Должности";
            this.DoljB.UseVisualStyleBackColor = false;
            this.DoljB.Click += new System.EventHandler(this.button3_Click);
            // 
            // MarshB
            // 
            this.MarshB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MarshB.Location = new System.Drawing.Point(52, 174);
            this.MarshB.Name = "MarshB";
            this.MarshB.Size = new System.Drawing.Size(146, 48);
            this.MarshB.TabIndex = 4;
            this.MarshB.Text = "Маршрут";
            this.MarshB.UseVisualStyleBackColor = false;
            this.MarshB.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModelSB
            // 
            this.ModelSB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelSB.Location = new System.Drawing.Point(52, 228);
            this.ModelSB.Name = "ModelSB";
            this.ModelSB.Size = new System.Drawing.Size(146, 48);
            this.ModelSB.TabIndex = 5;
            this.ModelSB.Text = "Модель Самолета";
            this.ModelSB.UseVisualStyleBackColor = false;
            this.ModelSB.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PersonalB
            // 
            this.PersonalB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PersonalB.Location = new System.Drawing.Point(52, 283);
            this.PersonalB.Name = "PersonalB";
            this.PersonalB.Size = new System.Drawing.Size(146, 48);
            this.PersonalB.TabIndex = 6;
            this.PersonalB.Text = "Персонал";
            this.PersonalB.UseVisualStyleBackColor = false;
            this.PersonalB.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // TechObsB
            // 
            this.TechObsB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TechObsB.Location = new System.Drawing.Point(52, 498);
            this.TechObsB.Name = "TechObsB";
            this.TechObsB.Size = new System.Drawing.Size(146, 48);
            this.TechObsB.TabIndex = 7;
            this.TechObsB.Text = "Тех.Обслуживание";
            this.TechObsB.UseVisualStyleBackColor = false;
            this.TechObsB.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // RaspB
            // 
            this.RaspB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RaspB.Location = new System.Drawing.Point(52, 337);
            this.RaspB.Name = "RaspB";
            this.RaspB.Size = new System.Drawing.Size(146, 48);
            this.RaspB.TabIndex = 8;
            this.RaspB.Text = "Расписания";
            this.RaspB.UseVisualStyleBackColor = false;
            this.RaspB.Click += new System.EventHandler(this.button4_Click);
            // 
            // ReisiB
            // 
            this.ReisiB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReisiB.Location = new System.Drawing.Point(52, 391);
            this.ReisiB.Name = "ReisiB";
            this.ReisiB.Size = new System.Drawing.Size(146, 48);
            this.ReisiB.TabIndex = 9;
            this.ReisiB.Text = "Рейсы";
            this.ReisiB.UseVisualStyleBackColor = false;
            this.ReisiB.Click += new System.EventHandler(this.button5_Click);
            // 
            // PlanesB
            // 
            this.PlanesB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlanesB.Location = new System.Drawing.Point(52, 445);
            this.PlanesB.Name = "PlanesB";
            this.PlanesB.Size = new System.Drawing.Size(146, 48);
            this.PlanesB.TabIndex = 10;
            this.PlanesB.Text = "Самолеты";
            this.PlanesB.UseVisualStyleBackColor = false;
            this.PlanesB.Click += new System.EventHandler(this.button6_Click);
            // 
            // typeB
            // 
            this.typeB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.typeB.Location = new System.Drawing.Point(52, 552);
            this.typeB.Name = "typeB";
            this.typeB.Size = new System.Drawing.Size(146, 48);
            this.typeB.TabIndex = 11;
            this.typeB.Text = "Тип";
            this.typeB.UseVisualStyleBackColor = false;
            this.typeB.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.abstrakciya_cvet_ugol_fon_1087;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(242, 615);
            this.Controls.Add(this.typeB);
            this.Controls.Add(this.PlanesB);
            this.Controls.Add(this.ReisiB);
            this.Controls.Add(this.RaspB);
            this.Controls.Add(this.TechObsB);
            this.Controls.Add(this.PersonalB);
            this.Controls.Add(this.ModelSB);
            this.Controls.Add(this.MarshB);
            this.Controls.Add(this.DoljB);
            this.Controls.Add(this.BrigB);
            this.Controls.Add(this.BiletB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BiletB;
        private System.Windows.Forms.Button BrigB;
        private System.Windows.Forms.Button DoljB;
        private System.Windows.Forms.Button MarshB;
        private System.Windows.Forms.Button ModelSB;
        private System.Windows.Forms.Button PersonalB;
        private System.Windows.Forms.Button TechObsB;
        private System.Windows.Forms.Button RaspB;
        private System.Windows.Forms.Button ReisiB;
        private System.Windows.Forms.Button PlanesB;
        private System.Windows.Forms.Button typeB;
    }
}

