namespace CursTP
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
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1Speed = new System.Windows.Forms.TrackBar();
            this.trackBar2Value = new System.Windows.Forms.TrackBar();
            this.trackBar3TP = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3TP)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(847, 331);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer_tick1);
            // 
            // trackBar1Speed
            // 
            this.trackBar1Speed.Location = new System.Drawing.Point(11, 375);
            this.trackBar1Speed.Maximum = 15;
            this.trackBar1Speed.Minimum = 5;
            this.trackBar1Speed.Name = "trackBar1Speed";
            this.trackBar1Speed.Size = new System.Drawing.Size(207, 45);
            this.trackBar1Speed.TabIndex = 1;
            this.trackBar1Speed.Value = 10;
            this.trackBar1Speed.Scroll += new System.EventHandler(this.trackBar1Speed_Scroll);
            // 
            // trackBar2Value
            // 
            this.trackBar2Value.Location = new System.Drawing.Point(224, 375);
            this.trackBar2Value.Maximum = 500;
            this.trackBar2Value.Minimum = 50;
            this.trackBar2Value.Name = "trackBar2Value";
            this.trackBar2Value.Size = new System.Drawing.Size(207, 45);
            this.trackBar2Value.TabIndex = 2;
            this.trackBar2Value.TickFrequency = 50;
            this.trackBar2Value.Value = 100;
            this.trackBar2Value.Scroll += new System.EventHandler(this.trackBar2Value_Scroll);
            // 
            // trackBar3TP
            // 
            this.trackBar3TP.Location = new System.Drawing.Point(618, 372);
            this.trackBar3TP.Maximum = 180;
            this.trackBar3TP.Name = "trackBar3TP";
            this.trackBar3TP.Size = new System.Drawing.Size(207, 45);
            this.trackBar3TP.TabIndex = 3;
            this.trackBar3TP.TickFrequency = 30;
            this.trackBar3TP.Scroll += new System.EventHandler(this.trackBar3TP_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Для изменения радиуса телепортов покрутить колесо мыши:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Для увелечения скрол вверх";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Для уменьшения скрол вниз";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Панель изменения параметров частиц";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Панель изменения параметров телепорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Скорость";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Количество частиц";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(619, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Направления телепорта";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 510);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Для отдающего ЛКМ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 497);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Для принимающего ПКМ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(309, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Для изменения местонахождения телепортов нажмите:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Палитра цветов для фона";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar3TP);
            this.Controls.Add(this.trackBar2Value);
            this.Controls.Add(this.trackBar1Speed);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3TP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1Speed;
        private System.Windows.Forms.TrackBar trackBar2Value;
        private System.Windows.Forms.TrackBar trackBar3TP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
    }
}

