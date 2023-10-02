namespace WhenToShutDown
{
    partial class Form_SD
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SD));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cBtnAnnulla = new WhenToShutDown.CustomControl.CustomButton();
            this.cBtnArresto = new WhenToShutDown.CustomControl.CustomButton();
            this.boxDate = new RoundPanel();
            this.tbDate = new WhenToShutDown.CustomControl.CustomToggleButton();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.boxHour = new RoundPanel();
            this.tbHours = new WhenToShutDown.CustomControl.CustomToggleButton();
            this.udHours = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.boxMinutes = new RoundPanel();
            this.tbMinutes = new WhenToShutDown.CustomControl.CustomToggleButton();
            this.udMinNow = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.boxTime = new RoundPanel();
            this.tbTime = new WhenToShutDown.CustomControl.CustomToggleButton();
            this.udMin = new System.Windows.Forms.NumericUpDown();
            this.udHrs = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxDate.SuspendLayout();
            this.boxHour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udHours)).BeginInit();
            this.boxMinutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMinNow)).BeginInit();
            this.boxTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHrs)).BeginInit();
            this.SuspendLayout();
            // 
            // cBtnAnnulla
            // 
            this.cBtnAnnulla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cBtnAnnulla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cBtnAnnulla.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(249)))));
            this.cBtnAnnulla.BorderRadius = 1;
            this.cBtnAnnulla.BorderSize = 2;
            this.cBtnAnnulla.FlatAppearance.BorderSize = 0;
            this.cBtnAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBtnAnnulla.Font = new System.Drawing.Font("VCR OSD Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnAnnulla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(5)))), ((int)(((byte)(212)))));
            this.cBtnAnnulla.Location = new System.Drawing.Point(535, 274);
            this.cBtnAnnulla.Name = "cBtnAnnulla";
            this.cBtnAnnulla.Size = new System.Drawing.Size(204, 40);
            this.cBtnAnnulla.TabIndex = 19;
            this.cBtnAnnulla.Text = "ANNULLA ARRESTO";
            this.cBtnAnnulla.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(5)))), ((int)(((byte)(212)))));
            this.cBtnAnnulla.UseVisualStyleBackColor = false;
            this.cBtnAnnulla.Click += new System.EventHandler(this.cBtnAnnulla_Click);
            // 
            // cBtnArresto
            // 
            this.cBtnArresto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cBtnArresto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cBtnArresto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(1)))), ((int)(((byte)(206)))));
            this.cBtnArresto.BorderRadius = 1;
            this.cBtnArresto.BorderSize = 2;
            this.cBtnArresto.FlatAppearance.BorderSize = 0;
            this.cBtnArresto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBtnArresto.Font = new System.Drawing.Font("VCR OSD Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnArresto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(5)))), ((int)(((byte)(212)))));
            this.cBtnArresto.Location = new System.Drawing.Point(119, 274);
            this.cBtnArresto.Name = "cBtnArresto";
            this.cBtnArresto.Size = new System.Drawing.Size(204, 40);
            this.cBtnArresto.TabIndex = 18;
            this.cBtnArresto.Text = "PIANIFICA ARRESTO";
            this.cBtnArresto.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(5)))), ((int)(((byte)(212)))));
            this.cBtnArresto.UseVisualStyleBackColor = false;
            this.cBtnArresto.Click += new System.EventHandler(this.cBtnArresto_Click);
            // 
            // boxDate
            // 
            this.boxDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.boxDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(21)))), ((int)(((byte)(255)))));
            this.boxDate.BorderSize = 3F;
            this.boxDate.BorderVisibile = true;
            this.boxDate.Controls.Add(this.tbDate);
            this.boxDate.Controls.Add(this.dtPicker);
            this.boxDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxDate.Location = new System.Drawing.Point(12, 12);
            this.boxDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxDate.Name = "boxDate";
            this.boxDate.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxDate.Radious = 1;
            this.boxDate.Size = new System.Drawing.Size(412, 111);
            this.boxDate.TabIndex = 17;
            this.boxDate.TabStop = false;
            this.boxDate.Text = "PIANIFICA ARRESTO PER DATA";
            this.boxDate.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.boxDate.TitleFont = new System.Drawing.Font("VCR OSD Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDate.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(18)))), ((int)(((byte)(254)))));
            this.boxDate.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent05;
            this.boxDate.UseCompatibleTextRendering = true;
            // 
            // tbDate
            // 
            this.tbDate.AutoSize = true;
            this.tbDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbDate.Location = new System.Drawing.Point(328, 54);
            this.tbDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDate.MinimumSize = new System.Drawing.Size(60, 25);
            this.tbDate.Name = "tbDate";
            this.tbDate.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.tbDate.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(254)))));
            this.tbDate.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(65)))), ((int)(((byte)(231)))));
            this.tbDate.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.tbDate.Size = new System.Drawing.Size(60, 25);
            this.tbDate.TabIndex = 13;
            this.tbDate.UseVisualStyleBackColor = true;
            this.tbDate.CheckedChanged += new System.EventHandler(this.tbDate_CheckedChanged);
            // 
            // dtPicker
            // 
            this.dtPicker.CalendarFont = new System.Drawing.Font("VCR OSD Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.CalendarForeColor = System.Drawing.Color.Black;
            this.dtPicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.dtPicker.Font = new System.Drawing.Font("VCR OSD Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker.Location = new System.Drawing.Point(18, 56);
            this.dtPicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(293, 22);
            this.dtPicker.TabIndex = 12;
            // 
            // boxHour
            // 
            this.boxHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.boxHour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(21)))), ((int)(((byte)(255)))));
            this.boxHour.BorderSize = 3F;
            this.boxHour.BorderVisibile = true;
            this.boxHour.Controls.Add(this.tbHours);
            this.boxHour.Controls.Add(this.udHours);
            this.boxHour.Controls.Add(this.label3);
            this.boxHour.Location = new System.Drawing.Point(444, 147);
            this.boxHour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxHour.Name = "boxHour";
            this.boxHour.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxHour.Radious = 1;
            this.boxHour.Size = new System.Drawing.Size(412, 111);
            this.boxHour.TabIndex = 15;
            this.boxHour.TabStop = false;
            this.boxHour.Text = "PIANIFICA ARRESTO IN ORE";
            this.boxHour.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.boxHour.TitleFont = new System.Drawing.Font("VCR OSD Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.boxHour.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(18)))), ((int)(((byte)(254)))));
            this.boxHour.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent05;
            // 
            // tbHours
            // 
            this.tbHours.AutoSize = true;
            this.tbHours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbHours.Location = new System.Drawing.Point(244, 59);
            this.tbHours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbHours.MinimumSize = new System.Drawing.Size(80, 25);
            this.tbHours.Name = "tbHours";
            this.tbHours.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.tbHours.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(254)))));
            this.tbHours.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(65)))), ((int)(((byte)(231)))));
            this.tbHours.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.tbHours.Size = new System.Drawing.Size(80, 25);
            this.tbHours.TabIndex = 14;
            this.tbHours.UseVisualStyleBackColor = true;
            this.tbHours.CheckedChanged += new System.EventHandler(this.tbHours_CheckedChanged);
            // 
            // udHours
            // 
            this.udHours.Font = new System.Drawing.Font("VCR OSD Mono", 11.25F);
            this.udHours.Location = new System.Drawing.Point(46, 63);
            this.udHours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udHours.Name = "udHours";
            this.udHours.Size = new System.Drawing.Size(80, 22);
            this.udHours.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("VCR OSD Mono", 11.25F);
            this.label3.Location = new System.Drawing.Point(133, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ore";
            // 
            // boxMinutes
            // 
            this.boxMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.boxMinutes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(21)))), ((int)(((byte)(255)))));
            this.boxMinutes.BorderSize = 3F;
            this.boxMinutes.BorderVisibile = true;
            this.boxMinutes.Controls.Add(this.tbMinutes);
            this.boxMinutes.Controls.Add(this.udMinNow);
            this.boxMinutes.Controls.Add(this.label4);
            this.boxMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxMinutes.Location = new System.Drawing.Point(12, 147);
            this.boxMinutes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxMinutes.Name = "boxMinutes";
            this.boxMinutes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxMinutes.Radious = 1;
            this.boxMinutes.Size = new System.Drawing.Size(412, 111);
            this.boxMinutes.TabIndex = 13;
            this.boxMinutes.TabStop = false;
            this.boxMinutes.Text = "PIANIFICA ARRESTO IN MINUTI";
            this.boxMinutes.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.boxMinutes.TitleFont = new System.Drawing.Font("VCR OSD Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.boxMinutes.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(18)))), ((int)(((byte)(254)))));
            this.boxMinutes.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent05;
            // 
            // tbMinutes
            // 
            this.tbMinutes.AutoSize = true;
            this.tbMinutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbMinutes.Location = new System.Drawing.Point(232, 59);
            this.tbMinutes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbMinutes.MinimumSize = new System.Drawing.Size(80, 25);
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.tbMinutes.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(254)))));
            this.tbMinutes.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(65)))), ((int)(((byte)(231)))));
            this.tbMinutes.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.tbMinutes.Size = new System.Drawing.Size(80, 25);
            this.tbMinutes.TabIndex = 14;
            this.tbMinutes.UseVisualStyleBackColor = true;
            this.tbMinutes.CheckedChanged += new System.EventHandler(this.tbMinutes_CheckedChanged);
            // 
            // udMinNow
            // 
            this.udMinNow.Font = new System.Drawing.Font("VCR OSD Mono", 11.25F);
            this.udMinNow.Location = new System.Drawing.Point(46, 63);
            this.udMinNow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udMinNow.Name = "udMinNow";
            this.udMinNow.Size = new System.Drawing.Size(80, 22);
            this.udMinNow.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("VCR OSD Mono", 11.25F);
            this.label4.Location = new System.Drawing.Point(137, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "minuti";
            // 
            // boxTime
            // 
            this.boxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.boxTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(21)))), ((int)(((byte)(255)))));
            this.boxTime.BorderSize = 3F;
            this.boxTime.BorderVisibile = true;
            this.boxTime.Controls.Add(this.tbTime);
            this.boxTime.Controls.Add(this.udMin);
            this.boxTime.Controls.Add(this.udHrs);
            this.boxTime.Controls.Add(this.label2);
            this.boxTime.Controls.Add(this.label1);
            this.boxTime.Location = new System.Drawing.Point(444, 12);
            this.boxTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxTime.Name = "boxTime";
            this.boxTime.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxTime.Radious = 1;
            this.boxTime.Size = new System.Drawing.Size(412, 111);
            this.boxTime.TabIndex = 12;
            this.boxTime.TabStop = false;
            this.boxTime.Text = "PIANIFICA ARRESTO PER ORARIO";
            this.boxTime.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.boxTime.TitleFont = new System.Drawing.Font("VCR OSD Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.boxTime.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(18)))), ((int)(((byte)(254)))));
            this.boxTime.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent05;
            // 
            // tbTime
            // 
            this.tbTime.AutoSize = true;
            this.tbTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbTime.Location = new System.Drawing.Point(329, 55);
            this.tbTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTime.MinimumSize = new System.Drawing.Size(60, 25);
            this.tbTime.Name = "tbTime";
            this.tbTime.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.tbTime.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(254)))));
            this.tbTime.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(65)))), ((int)(((byte)(231)))));
            this.tbTime.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.tbTime.Size = new System.Drawing.Size(60, 25);
            this.tbTime.TabIndex = 12;
            this.tbTime.UseVisualStyleBackColor = true;
            this.tbTime.CheckedChanged += new System.EventHandler(this.tbTime_CheckedChanged);
            // 
            // udMin
            // 
            this.udMin.Font = new System.Drawing.Font("VCR OSD Mono", 11.25F);
            this.udMin.Location = new System.Drawing.Point(176, 58);
            this.udMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.udMin.Name = "udMin";
            this.udMin.Size = new System.Drawing.Size(80, 22);
            this.udMin.TabIndex = 3;
            // 
            // udHrs
            // 
            this.udHrs.Font = new System.Drawing.Font("VCR OSD Mono", 11.25F);
            this.udHrs.Location = new System.Drawing.Point(12, 58);
            this.udHrs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udHrs.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.udHrs.Name = "udHrs";
            this.udHrs.Size = new System.Drawing.Size(80, 22);
            this.udHrs.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("VCR OSD Mono", 11.25F);
            this.label2.Location = new System.Drawing.Point(262, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "minuti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VCR OSD Mono", 11.25F);
            this.label1.Location = new System.Drawing.Point(98, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ore";
            // 
            // Form_SD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(868, 326);
            this.Controls.Add(this.cBtnAnnulla);
            this.Controls.Add(this.cBtnArresto);
            this.Controls.Add(this.boxDate);
            this.Controls.Add(this.boxHour);
            this.Controls.Add(this.boxMinutes);
            this.Controls.Add(this.boxTime);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(884, 365);
            this.Name = "Form_SD";
            this.Text = "When to Shut Down";
            this.Load += new System.EventHandler(this.Form_SD_Load);
            this.boxDate.ResumeLayout(false);
            this.boxDate.PerformLayout();
            this.boxHour.ResumeLayout(false);
            this.boxHour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udHours)).EndInit();
            this.boxMinutes.ResumeLayout(false);
            this.boxMinutes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMinNow)).EndInit();
            this.boxTime.ResumeLayout(false);
            this.boxTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHrs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udHrs;
        private System.Windows.Forms.NumericUpDown udMin;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RoundPanel boxTime;
        private CustomControl.CustomToggleButton tbTime;
        private RoundPanel boxHour;
        private CustomControl.CustomToggleButton tbHours;
        public System.Windows.Forms.NumericUpDown udHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown udMinNow;
        private CustomControl.CustomToggleButton tbMinutes;
        private RoundPanel boxMinutes;
        private RoundPanel boxDate;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private CustomControl.CustomToggleButton tbDate;
        private CustomControl.CustomButton cBtnArresto;
        private CustomControl.CustomButton cBtnAnnulla;
    }
}

