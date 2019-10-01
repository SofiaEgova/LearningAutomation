namespace LearningAutomation.Forms
{
    partial class FormTest
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
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTestName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAnswer1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAllQuestions = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxAnswer2 = new System.Windows.Forms.TextBox();
            this.textBoxAnswer3 = new System.Windows.Forms.TextBox();
            this.textBoxAnswer4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Location = new System.Drawing.Point(480, 240);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(140, 23);
            this.buttonAddQuestion.TabIndex = 0;
            this.buttonAddQuestion.Text = "Добавить вопрос";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название теста:";
            // 
            // textBoxTestName
            // 
            this.textBoxTestName.Location = new System.Drawing.Point(230, 3);
            this.textBoxTestName.Name = "textBoxTestName";
            this.textBoxTestName.Size = new System.Drawing.Size(415, 22);
            this.textBoxTestName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вопрос:";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(230, 35);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(415, 67);
            this.textBoxQuestion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Варианты ответов на вопрос:";
            // 
            // textBoxAnswer1
            // 
            this.textBoxAnswer1.Location = new System.Drawing.Point(230, 122);
            this.textBoxAnswer1.Multiline = true;
            this.textBoxAnswer1.Name = "textBoxAnswer1";
            this.textBoxAnswer1.Size = new System.Drawing.Size(241, 23);
            this.textBoxAnswer1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Добавленные вопросы:";
            // 
            // textBoxAllQuestions
            // 
            this.textBoxAllQuestions.Location = new System.Drawing.Point(230, 284);
            this.textBoxAllQuestions.Multiline = true;
            this.textBoxAllQuestions.Name = "textBoxAllQuestions";
            this.textBoxAllQuestions.Size = new System.Drawing.Size(415, 103);
            this.textBoxAllQuestions.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(441, 393);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(545, 393);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxAnswer2
            // 
            this.textBoxAnswer2.Location = new System.Drawing.Point(230, 151);
            this.textBoxAnswer2.Multiline = true;
            this.textBoxAnswer2.Name = "textBoxAnswer2";
            this.textBoxAnswer2.Size = new System.Drawing.Size(241, 23);
            this.textBoxAnswer2.TabIndex = 11;
            // 
            // textBoxAnswer3
            // 
            this.textBoxAnswer3.Location = new System.Drawing.Point(230, 180);
            this.textBoxAnswer3.Multiline = true;
            this.textBoxAnswer3.Name = "textBoxAnswer3";
            this.textBoxAnswer3.Size = new System.Drawing.Size(241, 23);
            this.textBoxAnswer3.TabIndex = 12;
            // 
            // textBoxAnswer4
            // 
            this.textBoxAnswer4.Location = new System.Drawing.Point(230, 209);
            this.textBoxAnswer4.Multiline = true;
            this.textBoxAnswer4.Name = "textBoxAnswer4";
            this.textBoxAnswer4.Size = new System.Drawing.Size(241, 23);
            this.textBoxAnswer4.TabIndex = 13;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 448);
            this.Controls.Add(this.textBoxAnswer4);
            this.Controls.Add(this.textBoxAnswer3);
            this.Controls.Add(this.textBoxAnswer2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxAllQuestions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAnswer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTestName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddQuestion);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTestName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAnswer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAllQuestions;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxAnswer2;
        private System.Windows.Forms.TextBox textBoxAnswer3;
        private System.Windows.Forms.TextBox textBoxAnswer4;
    }
}