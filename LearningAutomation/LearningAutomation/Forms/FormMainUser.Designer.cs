namespace LearningAutomation.Forms
{
    partial class FormMainUser
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStatistic = new System.Windows.Forms.TabPage();
            this.tabPageLearning = new System.Windows.Forms.TabPage();
            this.dataGridViewStatistic = new System.Windows.Forms.DataGridView();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.dataGridViewLearning = new System.Windows.Forms.DataGridView();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageStatistic.SuspendLayout();
            this.tabPageLearning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLearning)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageStatistic);
            this.tabControl.Controls.Add(this.tabPageLearning);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(775, 425);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageStatistic
            // 
            this.tabPageStatistic.Controls.Add(this.textBoxResult);
            this.tabPageStatistic.Controls.Add(this.labelResult);
            this.tabPageStatistic.Controls.Add(this.dataGridViewStatistic);
            this.tabPageStatistic.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatistic.Name = "tabPageStatistic";
            this.tabPageStatistic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatistic.Size = new System.Drawing.Size(767, 399);
            this.tabPageStatistic.TabIndex = 0;
            this.tabPageStatistic.Text = "Статистика";
            this.tabPageStatistic.UseVisualStyleBackColor = true;
            // 
            // tabPageLearning
            // 
            this.tabPageLearning.Controls.Add(this.buttonOpen);
            this.tabPageLearning.Controls.Add(this.dataGridViewLearning);
            this.tabPageLearning.Location = new System.Drawing.Point(4, 22);
            this.tabPageLearning.Name = "tabPageLearning";
            this.tabPageLearning.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLearning.Size = new System.Drawing.Size(767, 399);
            this.tabPageLearning.TabIndex = 1;
            this.tabPageLearning.Text = "Обучение";
            this.tabPageLearning.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStatistic
            // 
            this.dataGridViewStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistic.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewStatistic.Name = "dataGridViewStatistic";
            this.dataGridViewStatistic.Size = new System.Drawing.Size(754, 356);
            this.dataGridViewStatistic.TabIndex = 0;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(546, 373);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(80, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Средний балл:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(632, 370);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 2;
            // 
            // dataGridViewLearning
            // 
            this.dataGridViewLearning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLearning.Location = new System.Drawing.Point(7, 30);
            this.dataGridViewLearning.MultiSelect = false;
            this.dataGridViewLearning.Name = "dataGridViewLearning";
            this.dataGridViewLearning.Size = new System.Drawing.Size(754, 363);
            this.dataGridViewLearning.TabIndex = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(7, 7);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // FormMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "FormMainUser";
            this.Text = "FormMainUser";
            this.Load += new System.EventHandler(this.FormMainUser_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageStatistic.ResumeLayout(false);
            this.tabPageStatistic.PerformLayout();
            this.tabPageLearning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLearning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStatistic;
        private System.Windows.Forms.TabPage tabPageLearning;
        private System.Windows.Forms.DataGridView dataGridViewStatistic;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.DataGridView dataGridViewLearning;
    }
}