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
            this.btnStop = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
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
            this.boxDate = new RoundPanel();
            this.tbDate = new WhenToShutDown.CustomControl.CustomToggleButton();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.boxHour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udHours)).BeginInit();
            this.boxMinutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMinNow)).BeginInit();
            this.boxTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHrs)).BeginInit();
            this.boxDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Yellow;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(562, 278);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(203, 39);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "ANNULLA ARRESTO";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.Red;
            this.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutdown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdown.ForeColor = System.Drawing.Color.Black;
            this.btnShutdown.Location = new System.Drawing.Point(120, 278);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(203, 39);
            this.btnShutdown.TabIndex = 8;
            this.btnShutdown.Text = "PIANIFICA ARRESTO";
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // boxHour
            // 
            this.boxHour.BackColor = System.Drawing.Color.White;
            this.boxHour.Controls.Add(this.tbHours);
            this.boxHour.Controls.Add(this.udHours);
            this.boxHour.Controls.Add(this.label3);
            this.boxHour.Location = new System.Drawing.Point(444, 147);
            this.boxHour.Name = "boxHour";
            this.boxHour.Radious = 25;
            this.boxHour.Size = new System.Drawing.Size(411, 111);
            this.boxHour.TabIndex = 15;
            this.boxHour.TabStop = false;
            this.boxHour.Text = "Pianifica arresto in ore";
            this.boxHour.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.boxHour.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.boxHour.TitleForeColor = System.Drawing.Color.White;
            this.boxHour.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // tbHours
            // 
            this.tbHours.AutoSize = true;
            this.tbHours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbHours.Location = new System.Drawing.Point(255, 63);
            this.tbHours.MinimumSize = new System.Drawing.Size(80, 25);
            this.tbHours.Name = "tbHours";
            this.tbHours.OffBackColor = System.Drawing.Color.Gray;
            this.tbHours.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbHours.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbHours.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbHours.Size = new System.Drawing.Size(80, 25);
            this.tbHours.TabIndex = 14;
            this.tbHours.UseVisualStyleBackColor = true;
            this.tbHours.CheckedChanged += new System.EventHandler(this.tbHours_CheckedChanged);
            // 
            // udHours
            // 
            this.udHours.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.udHours.Location = new System.Drawing.Point(46, 63);
            this.udHours.Name = "udHours";
            this.udHours.Size = new System.Drawing.Size(80, 23);
            this.udHours.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "ore";
            // 
            // boxMinutes
            // 
            this.boxMinutes.BackColor = System.Drawing.Color.White;
            this.boxMinutes.Controls.Add(this.tbMinutes);
            this.boxMinutes.Controls.Add(this.udMinNow);
            this.boxMinutes.Controls.Add(this.label4);
            this.boxMinutes.Location = new System.Drawing.Point(12, 147);
            this.boxMinutes.Name = "boxMinutes";
            this.boxMinutes.Radious = 25;
            this.boxMinutes.Size = new System.Drawing.Size(411, 111);
            this.boxMinutes.TabIndex = 13;
            this.boxMinutes.TabStop = false;
            this.boxMinutes.Text = "Pianifica arresto in minuti";
            this.boxMinutes.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.boxMinutes.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.boxMinutes.TitleForeColor = System.Drawing.Color.White;
            this.boxMinutes.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // tbMinutes
            // 
            this.tbMinutes.AutoSize = true;
            this.tbMinutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbMinutes.Location = new System.Drawing.Point(255, 63);
            this.tbMinutes.MinimumSize = new System.Drawing.Size(80, 25);
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.OffBackColor = System.Drawing.Color.Gray;
            this.tbMinutes.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbMinutes.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbMinutes.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbMinutes.Size = new System.Drawing.Size(80, 25);
            this.tbMinutes.TabIndex = 14;
            this.tbMinutes.UseVisualStyleBackColor = true;
            this.tbMinutes.CheckedChanged += new System.EventHandler(this.tbMinutes_CheckedChanged);
            // 
            // udMinNow
            // 
            this.udMinNow.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.udMinNow.Location = new System.Drawing.Point(46, 63);
            this.udMinNow.Name = "udMinNow";
            this.udMinNow.Size = new System.Drawing.Size(80, 23);
            this.udMinNow.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "minuti";
            // 
            // boxTime
            // 
            this.boxTime.BackColor = System.Drawing.Color.White;
            this.boxTime.Controls.Add(this.tbTime);
            this.boxTime.Controls.Add(this.udMin);
            this.boxTime.Controls.Add(this.udHrs);
            this.boxTime.Controls.Add(this.label2);
            this.boxTime.Controls.Add(this.label1);
            this.boxTime.Location = new System.Drawing.Point(444, 12);
            this.boxTime.Name = "boxTime";
            this.boxTime.Radious = 25;
            this.boxTime.Size = new System.Drawing.Size(411, 111);
            this.boxTime.TabIndex = 12;
            this.boxTime.TabStop = false;
            this.boxTime.Text = "Pianifica arresto per orario";
            this.boxTime.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.boxTime.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.boxTime.TitleForeColor = System.Drawing.Color.White;
            this.boxTime.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // tbTime
            // 
            this.tbTime.AutoSize = true;
            this.tbTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbTime.Location = new System.Drawing.Point(344, 56);
            this.tbTime.MinimumSize = new System.Drawing.Size(60, 25);
            this.tbTime.Name = "tbTime";
            this.tbTime.OffBackColor = System.Drawing.Color.Gray;
            this.tbTime.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbTime.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbTime.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbTime.Size = new System.Drawing.Size(60, 25);
            this.tbTime.TabIndex = 12;
            this.tbTime.UseVisualStyleBackColor = true;
            this.tbTime.CheckedChanged += new System.EventHandler(this.tbTime_CheckedChanged);
            // 
            // udMin
            // 
            this.udMin.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udMin.Location = new System.Drawing.Point(176, 58);
            this.udMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.udMin.Name = "udMin";
            this.udMin.Size = new System.Drawing.Size(80, 23);
            this.udMin.TabIndex = 3;
            // 
            // udHrs
            // 
            this.udHrs.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udHrs.Location = new System.Drawing.Point(12, 58);
            this.udHrs.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.udHrs.Name = "udHrs";
            this.udHrs.Size = new System.Drawing.Size(80, 23);
            this.udHrs.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "minuti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ore";
            // 
            // boxDate
            // 
            this.boxDate.BackColor = System.Drawing.Color.White;
            this.boxDate.Controls.Add(this.dtPicker);
            this.boxDate.Controls.Add(this.tbDate);
            this.boxDate.Location = new System.Drawing.Point(12, 12);
            this.boxDate.Name = "boxDate";
            this.boxDate.Radious = 25;
            this.boxDate.Size = new System.Drawing.Size(411, 111);
            this.boxDate.TabIndex = 11;
            this.boxDate.TabStop = false;
            this.boxDate.Text = "Pianifica arresto per data e ore";
            this.boxDate.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.boxDate.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.boxDate.TitleForeColor = System.Drawing.Color.White;
            this.boxDate.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Horizontal;
            // 
            // tbDate
            // 
            this.tbDate.AutoSize = true;
            this.tbDate.BackColor = System.Drawing.Color.MistyRose;
            this.tbDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbDate.Location = new System.Drawing.Point(329, 56);
            this.tbDate.MinimumSize = new System.Drawing.Size(60, 25);
            this.tbDate.Name = "tbDate";
            this.tbDate.OffBackColor = System.Drawing.Color.Gray;
            this.tbDate.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbDate.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbDate.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbDate.Size = new System.Drawing.Size(60, 25);
            this.tbDate.TabIndex = 11;
            this.tbDate.UseVisualStyleBackColor = false;
            this.tbDate.CheckedChanged += new System.EventHandler(this.tbDate_CheckedChanged);
            // 
            // dtPicker
            // 
            this.dtPicker.CalendarFont = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker.Location = new System.Drawing.Point(18, 56);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(293, 25);
            this.dtPicker.TabIndex = 12;
            // 
            // Form_SD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(867, 421);
            this.Controls.Add(this.boxHour);
            this.Controls.Add(this.boxMinutes);
            this.Controls.Add(this.boxTime);
            this.Controls.Add(this.boxDate);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnShutdown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(883, 460);
            this.Name = "Form_SD";
            this.Text = "When to Shut Down";
            this.Load += new System.EventHandler(this.Form_SD_Load);
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
            this.boxDate.ResumeLayout(false);
            this.boxDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udHrs;
        private System.Windows.Forms.NumericUpDown udMin;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnStop;
        public System.Windows.Forms.NumericUpDown udMinNow;
        private RoundPanel boxDate;
        private RoundPanel boxTime;
        private CustomControl.CustomToggleButton tbDate;
        private CustomControl.CustomToggleButton tbTime;
        private RoundPanel boxMinutes;
        private CustomControl.CustomToggleButton tbMinutes;
        private System.Windows.Forms.Label label4;
        private RoundPanel boxHour;
        private CustomControl.CustomToggleButton tbHours;
        public System.Windows.Forms.NumericUpDown udHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtPicker;
    }
}

