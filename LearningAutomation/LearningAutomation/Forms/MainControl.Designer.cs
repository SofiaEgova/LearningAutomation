namespace LearningAutomation
{
    partial class MainControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBeginLearning = new System.Windows.Forms.Button();
            this.listBoxStatistic = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonBeginLearning
            // 
            this.buttonBeginLearning.Location = new System.Drawing.Point(18, 19);
            this.buttonBeginLearning.Name = "buttonBeginLearning";
            this.buttonBeginLearning.Size = new System.Drawing.Size(180, 24);
            this.buttonBeginLearning.TabIndex = 0;
            this.buttonBeginLearning.Text = "Перейти к обучению";
            this.buttonBeginLearning.UseVisualStyleBackColor = true;
            // 
            // listBoxStatistic
            // 
            this.listBoxStatistic.FormattingEnabled = true;
            this.listBoxStatistic.ItemHeight = 16;
            this.listBoxStatistic.Location = new System.Drawing.Point(18, 49);
            this.listBoxStatistic.Name = "listBoxStatistic";
            this.listBoxStatistic.Size = new System.Drawing.Size(807, 244);
            this.listBoxStatistic.TabIndex = 1;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxStatistic);
            this.Controls.Add(this.buttonBeginLearning);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(854, 489);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBeginLearning;
        private System.Windows.Forms.ListBox listBoxStatistic;
    }
}
