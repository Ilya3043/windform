
namespace лаба1винда
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
            this.start = new System.Windows.Forms.Button();
            this.label1START = new System.Windows.Forms.Label();
            this.textBox1START = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(167, 181);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(94, 27);
            this.start.TabIndex = 0;
            this.start.Text = "Начать";
            this.start.UseVisualStyleBackColor = false;
            this.start.UseWaitCursor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1START
            // 
            this.label1START.AutoSize = true;
            this.label1START.Location = new System.Drawing.Point(-111, 94);
            this.label1START.Name = "label1START";
            this.label1START.Size = new System.Drawing.Size(0, 15);
            this.label1START.TabIndex = 2;
            this.label1START.UseWaitCursor = true;
            // 
            // textBox1START
            // 
            this.textBox1START.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1START.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1START.Location = new System.Drawing.Point(71, 92);
            this.textBox1START.Multiline = true;
            this.textBox1START.Name = "textBox1START";
            this.textBox1START.ReadOnly = true;
            this.textBox1START.Size = new System.Drawing.Size(280, 84);
            this.textBox1START.TabIndex = 3;
            this.textBox1START.Text = "Данная программа выполняет персональное задание в соответствии с вариантом (вариа" +
    "нт №8)";
            this.textBox1START.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1START.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(432, 262);
            this.Controls.Add(this.textBox1START);
            this.Controls.Add(this.label1START);
            this.Controls.Add(this.start);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1START;
        private System.Windows.Forms.TextBox textBox1START;
    }
}

