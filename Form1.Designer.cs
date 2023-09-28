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
            this.label1 = new System.Windows.Forms.Label();
            this.udHrs = new System.Windows.Forms.NumericUpDown();
            this.udMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.udMinNow = new System.Windows.Forms.NumericUpDown();
            this.btnNowTime = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDateShut = new System.Windows.Forms.Button();
            this.roundPanel1 = new RoundPanel();
            this.roundPanel2 = new RoundPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.udHrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinNow)).BeginInit();
            this.roundPanel1.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "hrs.";
            // 
            // udHrs
            // 
            this.udHrs.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udHrs.Location = new System.Drawing.Point(6, 95);
            this.udHrs.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.udHrs.Name = "udHrs";
            this.udHrs.Size = new System.Drawing.Size(80, 23);
            this.udHrs.TabIndex = 2;
            // 
            // udMin
            // 
            this.udMin.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udMin.Location = new System.Drawing.Point(159, 95);
            this.udMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.udMin.Name = "udMin";
            this.udMin.Size = new System.Drawing.Size(80, 23);
            this.udMin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "mins.";
            // 
            // dtPicker
            // 
            this.dtPicker.CalendarFont = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker.Location = new System.Drawing.Point(6, 218);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(293, 25);
            this.dtPicker.TabIndex = 9;
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTime.Location = new System.Drawing.Point(6, 40);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(92, 25);
            this.cbTime.TabIndex = 8;
            this.cbTime.Text = "Abilita";
            this.cbTime.UseVisualStyleBackColor = true;
            this.cbTime.CheckedChanged += new System.EventHandler(this.cbTime_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(305, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "mins.";
            // 
            // udMinNow
            // 
            this.udMinNow.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.udMinNow.Location = new System.Drawing.Point(256, 153);
            this.udMinNow.Name = "udMinNow";
            this.udMinNow.Size = new System.Drawing.Size(43, 23);
            this.udMinNow.TabIndex = 6;
            // 
            // btnNowTime
            // 
            this.btnNowTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnNowTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNowTime.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNowTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNowTime.Font = new System.Drawing.Font("Cascadia Mono", 12F);
            this.btnNowTime.ForeColor = System.Drawing.Color.White;
            this.btnNowTime.Location = new System.Drawing.Point(6, 149);
            this.btnNowTime.Name = "btnNowTime";
            this.btnNowTime.Size = new System.Drawing.Size(244, 29);
            this.btnNowTime.TabIndex = 5;
            this.btnNowTime.Text = "Usa l\'ora attuale più ➥";
            this.btnNowTime.UseVisualStyleBackColor = false;
            this.btnNowTime.Click += new System.EventHandler(this.btnNowTime_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.Red;
            this.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutdown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdown.ForeColor = System.Drawing.Color.Black;
            this.btnShutdown.Location = new System.Drawing.Point(95, 374);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(203, 39);
            this.btnShutdown.TabIndex = 8;
            this.btnShutdown.Text = "PIANIFICA ARRESTO";
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Yellow;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(95, 374);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(203, 39);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "ANNULLA ARRESTO";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Orario";
            // 
            // btnDateShut
            // 
            this.btnDateShut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnDateShut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDateShut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDateShut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateShut.Font = new System.Drawing.Font("Cascadia Mono", 12F);
            this.btnDateShut.ForeColor = System.Drawing.Color.White;
            this.btnDateShut.Location = new System.Drawing.Point(6, 259);
            this.btnDateShut.Name = "btnDateShut";
            this.btnDateShut.Size = new System.Drawing.Size(244, 29);
            this.btnDateShut.TabIndex = 11;
            this.btnDateShut.Text = "Imposta data d\'arresto";
            this.btnDateShut.UseVisualStyleBackColor = false;
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.White;
            this.roundPanel1.Controls.Add(this.btnDateShut);
            this.roundPanel1.Controls.Add(this.cbTime);
            this.roundPanel1.Controls.Add(this.dtPicker);
            this.roundPanel1.Controls.Add(this.btnShutdown);
            this.roundPanel1.Controls.Add(this.label3);
            this.roundPanel1.Controls.Add(this.label7);
            this.roundPanel1.Controls.Add(this.udMin);
            this.roundPanel1.Controls.Add(this.udMinNow);
            this.roundPanel1.Controls.Add(this.label1);
            this.roundPanel1.Controls.Add(this.btnNowTime);
            this.roundPanel1.Controls.Add(this.label2);
            this.roundPanel1.Controls.Add(this.udHrs);
            this.roundPanel1.Location = new System.Drawing.Point(12, 12);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Radious = 25;
            this.roundPanel1.Size = new System.Drawing.Size(411, 431);
            this.roundPanel1.TabIndex = 11;
            this.roundPanel1.TabStop = false;
            this.roundPanel1.Text = "Data / Orario";
            this.roundPanel1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.roundPanel1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.roundPanel1.TitleForeColor = System.Drawing.Color.White;
            this.roundPanel1.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.White;
            this.roundPanel2.Controls.Add(this.button1);
            this.roundPanel2.Controls.Add(this.checkBox1);
            this.roundPanel2.Controls.Add(this.btnStop);
            this.roundPanel2.Controls.Add(this.dateTimePicker1);
            this.roundPanel2.Controls.Add(this.label4);
            this.roundPanel2.Controls.Add(this.label5);
            this.roundPanel2.Controls.Add(this.numericUpDown1);
            this.roundPanel2.Controls.Add(this.numericUpDown2);
            this.roundPanel2.Controls.Add(this.label6);
            this.roundPanel2.Controls.Add(this.button2);
            this.roundPanel2.Controls.Add(this.label8);
            this.roundPanel2.Controls.Add(this.numericUpDown3);
            this.roundPanel2.Location = new System.Drawing.Point(444, 12);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Radious = 25;
            this.roundPanel2.Size = new System.Drawing.Size(411, 431);
            this.roundPanel2.TabIndex = 12;
            this.roundPanel2.TabStop = false;
            this.roundPanel2.Text = "Data / Orario";
            this.roundPanel2.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.roundPanel2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.roundPanel2.TitleForeColor = System.Drawing.Color.White;
            this.roundPanel2.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cascadia Mono", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Imposta data d\'arresto";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(6, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 25);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Abilita";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 25);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Orario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "mins.";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(159, 95);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 23);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.numericUpDown2.Location = new System.Drawing.Point(256, 153);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(43, 23);
            this.numericUpDown2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "hrs.";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cascadia Mono", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(6, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Usa l\'ora attuale più ➥";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(241, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "mins.";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(6, 95);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(80, 23);
            this.numericUpDown3.TabIndex = 2;
            // 
            // Form_SD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(867, 517);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.roundPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_SD";
            this.Text = "When to Shut Down";
            this.Load += new System.EventHandler(this.Form_SD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udHrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinNow)).EndInit();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udHrs;
        private System.Windows.Forms.NumericUpDown udMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNowTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnStop;
        public System.Windows.Forms.NumericUpDown udMinNow;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button btnDateShut;
        private System.Windows.Forms.Label label3;
        private RoundPanel roundPanel1;
        private RoundPanel roundPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}

