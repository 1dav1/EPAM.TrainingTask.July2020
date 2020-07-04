namespace Clock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hourBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minuteBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secondBox = new System.Windows.Forms.TextBox();
            this.clockPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // hourBox
            // 
            this.hourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourBox.Location = new System.Drawing.Point(447, 176);
            this.hourBox.Name = "hourBox";
            this.hourBox.ReadOnly = true;
            this.hourBox.Size = new System.Drawing.Size(74, 68);
            this.hourBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(527, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // minuteBox
            // 
            this.minuteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minuteBox.Location = new System.Drawing.Point(568, 176);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.ReadOnly = true;
            this.minuteBox.Size = new System.Drawing.Size(74, 68);
            this.minuteBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(648, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 63);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // secondBox
            // 
            this.secondBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondBox.Location = new System.Drawing.Point(689, 176);
            this.secondBox.Name = "secondBox";
            this.secondBox.ReadOnly = true;
            this.secondBox.Size = new System.Drawing.Size(74, 68);
            this.secondBox.TabIndex = 5;
            // 
            // clockPanel
            // 
            this.clockPanel.Location = new System.Drawing.Point(35, 34);
            this.clockPanel.Name = "clockPanel";
            this.clockPanel.Size = new System.Drawing.Size(381, 381);
            this.clockPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clockPanel);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minuteBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondBox;
        private System.Windows.Forms.Panel clockPanel;
    }
}

